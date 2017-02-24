namespace XLS2XML
{
    partial class Excel2CSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenExcelButton = new System.Windows.Forms.Button();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SheetIndexNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectPathButton = new System.Windows.Forms.Button();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.xmlProgressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ColUPCNum = new System.Windows.Forms.NumericUpDown();
            this.ColUPC16Num = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ColStartRFIDNONum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UPC711Num = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ColQuantityNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheetIndexNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColUPCNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColUPC16Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColStartRFIDNONum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPC711Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColQuantityNum)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenExcelButton
            // 
            this.OpenExcelButton.Location = new System.Drawing.Point(25, 19);
            this.OpenExcelButton.Name = "OpenExcelButton";
            this.OpenExcelButton.Size = new System.Drawing.Size(75, 47);
            this.OpenExcelButton.TabIndex = 0;
            this.OpenExcelButton.Text = "打开 Excel";
            this.OpenExcelButton.UseVisualStyleBackColor = true;
            this.OpenExcelButton.Click += new System.EventHandler(this.OpenExcelButton_Click);
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SheetIndexNum);
            this.groupBox1.Controls.Add(this.OpenExcelButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sheet";
            // 
            // SheetIndexNum
            // 
            this.SheetIndexNum.Location = new System.Drawing.Point(191, 34);
            this.SheetIndexNum.Name = "SheetIndexNum";
            this.SheetIndexNum.Size = new System.Drawing.Size(44, 20);
            this.SheetIndexNum.TabIndex = 1;
            this.SheetIndexNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SheetIndexNum.ValueChanged += new System.EventHandler(this.SheetIndexNum_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ProductNameText);
            this.groupBox2.Controls.Add(this.outputPathLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SelectPathButton);
            this.groupBox2.Location = new System.Drawing.Point(42, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "一般设置";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Product";
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(84, 71);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(100, 20);
            this.ProductNameText.TabIndex = 13;
            this.ProductNameText.Text = "Aeroprint";
            this.ProductNameText.TextChanged += new System.EventHandler(this.ProductNameText_TextChanged);
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Location = new System.Drawing.Point(144, 50);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(35, 13);
            this.outputPathLabel.TabIndex = 2;
            this.outputPathLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CSV文件保存路径";
            // 
            // SelectPathButton
            // 
            this.SelectPathButton.Location = new System.Drawing.Point(25, 20);
            this.SelectPathButton.Name = "SelectPathButton";
            this.SelectPathButton.Size = new System.Drawing.Size(93, 23);
            this.SelectPathButton.TabIndex = 0;
            this.SelectPathButton.Text = "选择保存路径";
            this.SelectPathButton.UseVisualStyleBackColor = true;
            this.SelectPathButton.Click += new System.EventHandler(this.SelectPathButton_Click);
            // 
            // openCsvFileDialog
            // 
            this.openCsvFileDialog.FileName = "openFileDialog1";
            // 
            // xmlProgressBar
            // 
            this.xmlProgressBar.Location = new System.Drawing.Point(24, 493);
            this.xmlProgressBar.Name = "xmlProgressBar";
            this.xmlProgressBar.Size = new System.Drawing.Size(546, 23);
            this.xmlProgressBar.Step = 1;
            this.xmlProgressBar.TabIndex = 5;
            this.xmlProgressBar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Column UPC_NO_Space";
            // 
            // ColUPCNum
            // 
            this.ColUPCNum.Location = new System.Drawing.Point(200, 39);
            this.ColUPCNum.Name = "ColUPCNum";
            this.ColUPCNum.Size = new System.Drawing.Size(44, 20);
            this.ColUPCNum.TabIndex = 1;
            this.ColUPCNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColUPCNum.ValueChanged += new System.EventHandler(this.ColUPCNum_ValueChanged);
            // 
            // ColUPC16Num
            // 
            this.ColUPC16Num.Location = new System.Drawing.Point(200, 66);
            this.ColUPC16Num.Name = "ColUPC16Num";
            this.ColUPC16Num.Size = new System.Drawing.Size(44, 20);
            this.ColUPC16Num.TabIndex = 1;
            this.ColUPC16Num.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ColUPC16Num.ValueChanged += new System.EventHandler(this.ColUPC16Num_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Column UPC_1-6";
            // 
            // ColStartRFIDNONum
            // 
            this.ColStartRFIDNONum.Location = new System.Drawing.Point(200, 120);
            this.ColStartRFIDNONum.Name = "ColStartRFIDNONum";
            this.ColStartRFIDNONum.Size = new System.Drawing.Size(44, 20);
            this.ColStartRFIDNONum.TabIndex = 1;
            this.ColStartRFIDNONum.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.ColStartRFIDNONum.ValueChanged += new System.EventHandler(this.ColStartRFIDNONum_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Column Start RFID Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "*";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.ColUPCNum);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.UPC711Num);
            this.groupBox4.Controls.Add(this.ColUPC16Num);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.ColQuantityNum);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ColStartRFIDNONum);
            this.groupBox4.Location = new System.Drawing.Point(42, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 195);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Column Setting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "*";
            // 
            // UPC711Num
            // 
            this.UPC711Num.Location = new System.Drawing.Point(200, 93);
            this.UPC711Num.Name = "UPC711Num";
            this.UPC711Num.Size = new System.Drawing.Size(44, 20);
            this.UPC711Num.TabIndex = 1;
            this.UPC711Num.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.UPC711Num.ValueChanged += new System.EventHandler(this.UPC711Num_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Column Start RFID Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Column UPC_7-11";
            // 
            // ColQuantityNum
            // 
            this.ColQuantityNum.Location = new System.Drawing.Point(200, 147);
            this.ColQuantityNum.Name = "ColQuantityNum";
            this.ColQuantityNum.Size = new System.Drawing.Size(44, 20);
            this.ColQuantityNum.TabIndex = 1;
            this.ColQuantityNum.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ColQuantityNum.ValueChanged += new System.EventHandler(this.ColQuantityNum_ValueChanged);
            // 
            // Excel2CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.xmlProgressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Excel2CSV";
            this.Text = "Excel2CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheetIndexNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColUPCNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColUPC16Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColStartRFIDNONum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPC711Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColQuantityNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenExcelButton;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SheetIndexNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectPathButton;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.OpenFileDialog openCsvFileDialog;
        private System.Windows.Forms.ProgressBar xmlProgressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ColUPCNum;
        private System.Windows.Forms.NumericUpDown ColUPC16Num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ColStartRFIDNONum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown UPC711Num;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ColQuantityNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ProductNameText;
    }
}

