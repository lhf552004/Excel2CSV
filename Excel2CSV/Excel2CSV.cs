using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Xml;
using System.Runtime.InteropServices;

namespace XLS2XML
{
    public enum delimiterEnum
    {
        semicolon = ';',
        tab = '\t',
        comma = ',',
        whiteSpace = ' '
    }
      

    public partial class Excel2CSV : Form
    {
        public Excel2CSV()
        {
            InitializeComponent();
        }
       
        private string outputFolderPath = System.Windows.Forms.Application.StartupPath;

        private XmlDocument targetDoc;
        private string[,] units;
        private ulong fileID = 0;
        private int sheetIndex = 1;
        public char[] delimiters = new char[] {';','\t', ',' ,' '};
        private char delimiter;

        private string productName = "";
        private int header = 48;
        private int filter = 1;
        private int partition = 5;
        private int indicator = 0;

        private string[] headers;
        private string[] values;
        private int _colUPC = 0;
        private int _colUPC16 = 0;
        private int _colUPC711 = 0;
        private int _colStartRFIDNO = 0;
        private int _colQuantity = 0;
        private int _colEPC = 0;
        private int quantity = 0;
        string UPC = "";
        string UPCCompanyPrefix = "";
        string ItemReferenceNumber = "";
        string serialNumber = "";

        
        private void OpenExcelButton_Click(object sender, EventArgs e)
        {
            if (_colUPC <= 0 || _colStartRFIDNO <= 0 || _colQuantity <=0)
            {
                MessageBox.Show("Please set UPC column or Start RFID number column or quantity column");
                return;
            }

            if (this.openExcelFileDialog.ShowDialog() == DialogResult.OK)
            {
                int rowCount = 0;
                int colCount = 0;
                xmlProgressBar.Visible = true;
                string fullFileName = openExcelFileDialog.FileName;
                string fileName = fullFileName.Substring(fullFileName.LastIndexOf("\\") + 1);
                string outputfileName = "";
                string filePath = "";
                string folderPath = "";

                fileName = fileName.Substring(0, fileName.LastIndexOf("."));
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;
                int rCnt = 0;
                int cCnt = 0;
                string EPC = "";
                FileIDHandler handler = new FileIDHandler();
                fileID = handler.getFileID(fullFileName);


                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(fullFileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(sheetIndex);
                try
                {
                    
                    range = xlWorkSheet.UsedRange;

                    rowCount = range.Rows.Count;
                    colCount = range.Columns.Count;
                    xmlProgressBar.Maximum = rowCount;
                    headers = new string[colCount+1];
                    values = new string[colCount+1]; 
                    for (cCnt = 1; cCnt <= colCount; cCnt++)
                    {
                        headers[cCnt-1] = (range.Cells[1, cCnt] as Excel.Range).Value2.ToString();
                    }
                    headers[colCount] = "EPC";
                    

                    for (rCnt = 2; rCnt <= rowCount; rCnt++)
                    {
                        //progessValue = ((rCnt - 1) / count) * 100;
                        //Console.Write("progessValue: " + progessValue + Environment.NewLine);
                        xmlProgressBar.Value = (rCnt - 1);
                        
                        for (cCnt = 1; cCnt <= colCount; cCnt++)
                        {
                            var value = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                            values[cCnt-1] = value;
                        }
                        

                        UPC = values[_colUPC-1];
                        serialNumber = values[_colStartRFIDNO-1];
                        quantity = int.Parse(values[_colQuantity - 1]);
                        outputfileName = productName + "_Job_" + (rCnt - 1).ToString().PadLeft(2, '0') + "_" + quantity;
                        if (quantity <= 0) {
                            MessageBox.Show("quantity is zero from excel file. it shouldn't happen");
                            return;
                        }
                        if (_colUPC16 > 0)
                        {

                            UPCCompanyPrefix = values[_colUPC16-1];
                        }
                        else
                        {
                            UPCCompanyPrefix = UPC.ToString().Substring(0, 6);
                        }
                        if (_colUPC711 > 0)
                        {

                            ItemReferenceNumber= values[_colUPC711-1];
                        }
                        else
                        {
                            ItemReferenceNumber = UPC.ToString().Substring(6, 5);
                        }

                        if (UPCCompanyPrefix.Length!=6 || ItemReferenceNumber.Length != 5)
                        {
                            MessageBox.Show("UPCCompanyPrefix or ItemReferenceNumber is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        EPC = convertToEPC(UPCCompanyPrefix, ItemReferenceNumber, serialNumber);
                        if (String.IsNullOrWhiteSpace(EPC))
                        {
                            MessageBox.Show("EPC length is 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        values[colCount] = EPC;
                        folderPath = outputFolderPath + "\\CSV";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        filePath = folderPath + "\\" + outputfileName + ".csv";
                        createAndSaveToCSV(filePath, values, quantity, headers);
                    }

                    MessageBox.Show("读写完成!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                finally
                {
                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                    xmlProgressBar.Value = 0;
                    xmlProgressBar.Visible = false;
                }

            }

        }

        private string convertToEPC(string UPCCompanyPrefix, string ItemReferenceNumber, string serialNumber)
        {
            string EPC = "";
            string EPCBin = "";
            string headerBin = Convert.ToString(header, 2);
            headerBin = headerBin.PadLeft(8, '0');
            string filterBin = Convert.ToString(filter, 2);
            filterBin = filterBin.PadLeft(3, '0');
            string partitionBin = Convert.ToString(partition, 2);
            partitionBin = partitionBin.PadLeft(3, '0');
            EPCBin = headerBin + filterBin + partitionBin;
            string GS1CompanyPrefix = Convert.ToString(int.Parse(UPCCompanyPrefix), 2);
            GS1CompanyPrefix = GS1CompanyPrefix.PadLeft(24, '0');
            //GS1CompanyPrefix = "0000" + GS1CompanyPrefix;
            //InfoText.AppendText("GS1CompanyPrefix: " + GS1CompanyPrefix + Environment.NewLine);
            //InfoText.AppendText("The length of GS1CompanyPrefix: " + GS1CompanyPrefix.Length + Environment.NewLine);
            EPCBin = EPCBin + GS1CompanyPrefix;

            string indicatorBin = Convert.ToString(indicator, 2);
            indicatorBin = indicatorBin.PadLeft(4, '0');

            string ItemReferenceNumberBin = Convert.ToString(int.Parse(ItemReferenceNumber), 2);
            ItemReferenceNumberBin = ItemReferenceNumberBin.PadLeft(16, '0');
            ItemReferenceNumberBin = indicatorBin + ItemReferenceNumberBin;
            //InfoText.AppendText("ItemReferenceNumber: " + ItemReferenceNumber + Environment.NewLine);
            //InfoText.AppendText("The length of ItemReferenceNumber: " + ItemReferenceNumber.Length + Environment.NewLine);

            EPCBin = EPCBin + ItemReferenceNumberBin;
            string serialNumberBin = Convert.ToString(int.Parse(serialNumber), 2);
            serialNumberBin = serialNumberBin.PadLeft(38, '0');
            EPCBin = EPCBin + serialNumberBin;
            if (EPCBin.Length == 96)
            {
                int theNum = -1;
                int index = -1;
                string theNumBin = "";
                string theNumHex = "";
                for (int i = 0; i < 24; i++)
                {
                    index = i * 4;
                    theNumBin = EPCBin.Substring(index, 4);
                    theNum = Convert.ToInt32(theNumBin, 2);
                    theNumHex = Convert.ToString(theNum, 16);
                    EPC = EPC + theNumHex;
                }
            }
            EPC = EPC.ToUpper();
            //InfoText.AppendText("EPC: " + EPC + Environment.NewLine);
            return EPC;
        }

        private void writeToFile(string filePath, string text)
        {
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.Unicode);
            sw.Write(text);
            sw.Flush();
            sw.Close();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.openExcelFileDialog.FileName = "*.xls";
            this.openCsvFileDialog.FileName = "*.csv";
            outputPathLabel.Text = outputFolderPath;
            
            delimiter = (char)delimiterEnum.tab;
            ProductNameText_TextChanged(null, null);
            ColUPCNum_ValueChanged(null, null);
            ColUPC16Num_ValueChanged(null, null);
            UPC711Num_ValueChanged(null, null);
            ColStartRFIDNONum_ValueChanged(null, null);
            ColQuantityNum_ValueChanged(null, null);
        }

        private void SheetIndexNum_ValueChanged(object sender, EventArgs e)
        {
            sheetIndex = (int)SheetIndexNum.Value;
        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            if (this.targetFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = targetFolderBrowserDialog.SelectedPath;
                
            }

        }

        private void createAndSaveToCSV(string filePath, string[] values, int quantity, string[] headers)
        {
            //string outputText = "EPC;Print1;Print2;Print3;Print4" + Environment.NewLine;
            string EPC = values[values.Length - 1];
            string EPCFront = EPC.Substring(0, 14);
            long index = Convert.ToInt64(EPC.Substring(14), 16);
            string indexStr = "";
            StringBuilder outputText = new StringBuilder(128);
            outputText.AppendLine(String.Join(",", headers)); 

            for (int j = 0; j < quantity; j++)
            {
                indexStr = Convert.ToString(index, 16);
                indexStr = indexStr.PadLeft(10, '0');
                indexStr = indexStr.ToUpper();
                string newEPC = EPCFront + indexStr;
                if (!checkEPCValided(indexStr, true) || !checkEPCValided(newEPC, false))
                {
                    //InfoText.AppendText("EPC length is not correct: " + newEPC + Environment.NewLine);
                    MessageBox.Show("EPC length is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                values[values.Length - 1] = newEPC;
                outputText.AppendLine(String.Join(",", values));
                index++;
                
            }
            writeToFile(filePath, outputText.ToString());
        }
        private bool checkEPCValided(string toCheck, bool isPart)
        {
            bool result = false;
            if (isPart)
            {
                if (toCheck.Length == 10)
                {
                    result = true;
                }
            }
            else
            {
                if (toCheck.Length == 24)
                {
                    result = true;
                }

            }
            return result;
        }

      
        private void ColUPCNum_ValueChanged(object sender, EventArgs e)
        {
            _colUPC = (int)ColUPCNum.Value;
       
        }

        private void ColUPC16Num_ValueChanged(object sender, EventArgs e)
        {
            _colUPC16 = (int)ColUPC16Num.Value;
       
        }
        private void UPC711Num_ValueChanged(object sender, EventArgs e)
        {
            _colUPC711 = (int)UPC711Num.Value;
        }
        private void ColStartRFIDNONum_ValueChanged(object sender, EventArgs e)
        {
            _colStartRFIDNO = (int)ColStartRFIDNONum.Value;
        }

        private void ColQuantityNum_ValueChanged(object sender, EventArgs e)
        {
            _colQuantity = (int)ColQuantityNum.Value;
        }

        private void ProductNameText_TextChanged(object sender, EventArgs e)
        {
            productName = ProductNameText.Text;
            productName = productName.Trim();
        }

      
    }
}
