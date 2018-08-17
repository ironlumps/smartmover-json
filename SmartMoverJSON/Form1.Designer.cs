namespace SmartMoverJSON
{
    partial class Form1
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMonthsRequested = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudMailingFrequency = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProcessingType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProcessList = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_grpParsed = new System.Windows.Forms.CheckBox();
            this.cb_grpName = new System.Windows.Forms.CheckBox();
            this.cb_grpOriginal = new System.Windows.Forms.CheckBox();
            this.cb_grpStandardized = new System.Windows.Forms.CheckBox();
            this.cb_suite = new System.Windows.Forms.CheckBox();
            this.cb_dpv = new System.Windows.Forms.CheckBox();
            this.cb_moveCode = new System.Windows.Forms.CheckBox();
            this.cb_plus4 = new System.Windows.Forms.CheckBox();
            this.cb_pmb = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rb_NCOA = new System.Windows.Forms.RadioButton();
            this.rb_CCOA = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthsRequested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailingFrequency)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(25, 31);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(188, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.Tag = "";
            this.txtCustomerID.Text = "Enter Customer ID Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "I. Customer ID";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(384, 50);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(530, 531);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "II. Customize Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 406);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.nudMonthsRequested);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nudMailingFrequency);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtListName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbProcessingType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtJobID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(10, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "*Set your options first before running NCOA Smart Mover.\r\n\r\n";
            // 
            // nudMonthsRequested
            // 
            this.nudMonthsRequested.Location = new System.Drawing.Point(13, 294);
            this.nudMonthsRequested.Name = "nudMonthsRequested";
            this.nudMonthsRequested.Size = new System.Drawing.Size(137, 20);
            this.nudMonthsRequested.TabIndex = 10;
            this.nudMonthsRequested.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Months Requested";
            // 
            // nudMailingFrequency
            // 
            this.nudMailingFrequency.Location = new System.Drawing.Point(13, 246);
            this.nudMailingFrequency.Name = "nudMailingFrequency";
            this.nudMailingFrequency.Size = new System.Drawing.Size(137, 20);
            this.nudMailingFrequency.TabIndex = 8;
            this.nudMailingFrequency.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mailing Frequency";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(13, 197);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(209, 20);
            this.txtListName.TabIndex = 6;
            this.txtListName.Text = "Text List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "List Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Processing Type";
            // 
            // cmbProcessingType
            // 
            this.cmbProcessingType.FormattingEnabled = true;
            this.cmbProcessingType.Items.AddRange(new object[] {
            "Business Only",
            "Individuals Only",
            "Business and Individuals",
            "Standard",
            "Residential"});
            this.cmbProcessingType.Location = new System.Drawing.Point(13, 146);
            this.cmbProcessingType.Name = "cmbProcessingType";
            this.cmbProcessingType.Size = new System.Drawing.Size(209, 21);
            this.cmbProcessingType.TabIndex = 3;
            this.cmbProcessingType.Text = "Standard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 65);
            this.label4.TabIndex = 2;
            this.label4.Text = "The Job ID is used to identify the current\r\nlist processed. Use a unique Job ID f" +
    "or \r\nyour entire list for this Smart Mover \r\nProcessing Period. Each unique Job " +
    "ID\r\nwill have 1 Smart Mover Report.\r\n";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(13, 24);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(251, 20);
            this.txtJobID.TabIndex = 1;
            this.txtJobID.Text = "Enter Job ID Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "JobID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_pmb);
            this.tabPage2.Controls.Add(this.cb_plus4);
            this.tabPage2.Controls.Add(this.cb_moveCode);
            this.tabPage2.Controls.Add(this.cb_dpv);
            this.tabPage2.Controls.Add(this.cb_suite);
            this.tabPage2.Controls.Add(this.cb_grpStandardized);
            this.tabPage2.Controls.Add(this.cb_grpOriginal);
            this.tabPage2.Controls.Add(this.cb_grpName);
            this.tabPage2.Controls.Add(this.cb_grpParsed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columns";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "III. Select File to Process";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(25, 526);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(327, 20);
            this.txtFilePath.TabIndex = 6;
            this.txtFilePath.Text = "...\\...\\Name and Address.csv";
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(25, 552);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(107, 23);
            this.btnBrowseFiles.TabIndex = 7;
            this.btnBrowseFiles.Text = "Browse Files";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "IV. Process Smart Mover";
            // 
            // btnProcessList
            // 
            this.btnProcessList.Location = new System.Drawing.Point(25, 601);
            this.btnProcessList.Name = "btnProcessList";
            this.btnProcessList.Size = new System.Drawing.Size(147, 34);
            this.btnProcessList.TabIndex = 9;
            this.btnProcessList.Text = "Process List";
            this.btnProcessList.UseVisualStyleBackColor = true;
            this.btnProcessList.Click += new System.EventHandler(this.btnProcessList_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Output";
            // 
            // cb_grpParsed
            // 
            this.cb_grpParsed.AutoSize = true;
            this.cb_grpParsed.Location = new System.Drawing.Point(7, 7);
            this.cb_grpParsed.Name = "cb_grpParsed";
            this.cb_grpParsed.Size = new System.Drawing.Size(74, 17);
            this.cb_grpParsed.TabIndex = 0;
            this.cb_grpParsed.Text = "grpParsed";
            this.cb_grpParsed.UseVisualStyleBackColor = true;
            // 
            // cb_grpName
            // 
            this.cb_grpName.AutoSize = true;
            this.cb_grpName.Location = new System.Drawing.Point(7, 31);
            this.cb_grpName.Name = "cb_grpName";
            this.cb_grpName.Size = new System.Drawing.Size(69, 17);
            this.cb_grpName.TabIndex = 1;
            this.cb_grpName.Text = "grpName";
            this.cb_grpName.UseVisualStyleBackColor = true;
            // 
            // cb_grpOriginal
            // 
            this.cb_grpOriginal.AutoSize = true;
            this.cb_grpOriginal.Location = new System.Drawing.Point(7, 55);
            this.cb_grpOriginal.Name = "cb_grpOriginal";
            this.cb_grpOriginal.Size = new System.Drawing.Size(76, 17);
            this.cb_grpOriginal.TabIndex = 2;
            this.cb_grpOriginal.Text = "grpOriginal";
            this.cb_grpOriginal.UseVisualStyleBackColor = true;
            // 
            // cb_grpStandardized
            // 
            this.cb_grpStandardized.AutoSize = true;
            this.cb_grpStandardized.Location = new System.Drawing.Point(7, 79);
            this.cb_grpStandardized.Name = "cb_grpStandardized";
            this.cb_grpStandardized.Size = new System.Drawing.Size(103, 17);
            this.cb_grpStandardized.TabIndex = 3;
            this.cb_grpStandardized.Text = "grpStandardized";
            this.cb_grpStandardized.UseVisualStyleBackColor = true;
            // 
            // cb_suite
            // 
            this.cb_suite.AutoSize = true;
            this.cb_suite.Location = new System.Drawing.Point(7, 103);
            this.cb_suite.Name = "cb_suite";
            this.cb_suite.Size = new System.Drawing.Size(50, 17);
            this.cb_suite.TabIndex = 4;
            this.cb_suite.Text = "Suite";
            this.cb_suite.UseVisualStyleBackColor = true;
            // 
            // cb_dpv
            // 
            this.cb_dpv.AutoSize = true;
            this.cb_dpv.Location = new System.Drawing.Point(7, 127);
            this.cb_dpv.Name = "cb_dpv";
            this.cb_dpv.Size = new System.Drawing.Size(97, 17);
            this.cb_dpv.TabIndex = 5;
            this.cb_dpv.Text = "DPVFootNotes";
            this.cb_dpv.UseVisualStyleBackColor = true;
            // 
            // cb_moveCode
            // 
            this.cb_moveCode.AutoSize = true;
            this.cb_moveCode.Location = new System.Drawing.Point(7, 151);
            this.cb_moveCode.Name = "cb_moveCode";
            this.cb_moveCode.Size = new System.Drawing.Size(110, 17);
            this.cb_moveCode.TabIndex = 6;
            this.cb_moveCode.Text = "MoveReturnCode";
            this.cb_moveCode.UseVisualStyleBackColor = true;
            // 
            // cb_plus4
            // 
            this.cb_plus4.AutoSize = true;
            this.cb_plus4.Location = new System.Drawing.Point(7, 175);
            this.cb_plus4.Name = "cb_plus4";
            this.cb_plus4.Size = new System.Drawing.Size(52, 17);
            this.cb_plus4.TabIndex = 7;
            this.cb_plus4.Text = "Plus4";
            this.cb_plus4.UseVisualStyleBackColor = true;
            // 
            // cb_pmb
            // 
            this.cb_pmb.AutoSize = true;
            this.cb_pmb.Location = new System.Drawing.Point(7, 199);
            this.cb_pmb.Name = "cb_pmb";
            this.cb_pmb.Size = new System.Drawing.Size(95, 17);
            this.cb_pmb.TabIndex = 8;
            this.cb_pmb.Text = "PrivateMailbox";
            this.cb_pmb.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rb_CCOA);
            this.tabPage3.Controls.Add(this.rb_NCOA);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(327, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rb_NCOA
            // 
            this.rb_NCOA.AutoSize = true;
            this.rb_NCOA.Location = new System.Drawing.Point(26, 21);
            this.rb_NCOA.Name = "rb_NCOA";
            this.rb_NCOA.Size = new System.Drawing.Size(55, 17);
            this.rb_NCOA.TabIndex = 0;
            this.rb_NCOA.TabStop = true;
            this.rb_NCOA.Text = "NCOA";
            this.rb_NCOA.UseVisualStyleBackColor = true;
            // 
            // rb_CCOA
            // 
            this.rb_CCOA.AutoSize = true;
            this.rb_CCOA.Location = new System.Drawing.Point(26, 54);
            this.rb_CCOA.Name = "rb_CCOA";
            this.rb_CCOA.Size = new System.Drawing.Size(54, 17);
            this.rb_CCOA.TabIndex = 1;
            this.rb_CCOA.TabStop = true;
            this.rb_CCOA.Text = "CCOA";
            this.rb_CCOA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 647);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnProcessList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthsRequested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailingFrequency)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMonthsRequested;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudMailingFrequency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProcessingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProcessList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_pmb;
        private System.Windows.Forms.CheckBox cb_plus4;
        private System.Windows.Forms.CheckBox cb_moveCode;
        private System.Windows.Forms.CheckBox cb_dpv;
        private System.Windows.Forms.CheckBox cb_suite;
        private System.Windows.Forms.CheckBox cb_grpStandardized;
        private System.Windows.Forms.CheckBox cb_grpOriginal;
        private System.Windows.Forms.CheckBox cb_grpName;
        private System.Windows.Forms.CheckBox cb_grpParsed;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rb_CCOA;
        private System.Windows.Forms.RadioButton rb_NCOA;
    }
}

