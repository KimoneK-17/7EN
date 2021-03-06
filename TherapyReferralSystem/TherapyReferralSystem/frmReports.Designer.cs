﻿namespace TherapyReferralSystem
{
    partial class frmReports
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
            this.mnuReports = new System.Windows.Forms.MenuStrip();
            this.mnuReportsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReportsReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsPrintRep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsTherRef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cboxReport = new System.Windows.Forms.ComboBox();
            this.lblReportSelect = new System.Windows.Forms.Label();
            this.DGVReport = new System.Windows.Forms.DataGridView();
            this.lblTherID = new System.Windows.Forms.Label();
            this.lblChildID = new System.Windows.Forms.Label();
            this.lblCluster = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cboxTherapyType = new System.Windows.Forms.ComboBox();
            this.lblTherapyType = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTherapistID = new System.Windows.Forms.TextBox();
            this.txtChildID = new System.Windows.Forms.TextBox();
            this.txtCluster = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.DTPYear = new System.Windows.Forms.DateTimePicker();
            this.DTPMonth = new System.Windows.Forms.DateTimePicker();
            this.DTPDay = new System.Windows.Forms.DateTimePicker();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.mnuReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuReports
            // 
            this.mnuReports.BackColor = System.Drawing.Color.Teal;
            this.mnuReports.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReports.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsFile,
            this.mnuReportsPrintRep,
            this.mnuReportsForm});
            this.mnuReports.Location = new System.Drawing.Point(0, 0);
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(1274, 28);
            this.mnuReports.TabIndex = 0;
            this.mnuReports.Text = "Menu";
            // 
            // mnuReportsFile
            // 
            this.mnuReportsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuReportsReturn});
            this.mnuReportsFile.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsFile.ForeColor = System.Drawing.Color.White;
            this.mnuReportsFile.Name = "mnuReportsFile";
            this.mnuReportsFile.Size = new System.Drawing.Size(61, 24);
            this.mnuReportsFile.Text = "File";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // mnuReportsReturn
            // 
            this.mnuReportsReturn.Name = "mnuReportsReturn";
            this.mnuReportsReturn.Size = new System.Drawing.Size(144, 26);
            this.mnuReportsReturn.Text = "Logout";
            this.mnuReportsReturn.Click += new System.EventHandler(this.ezitToolStripMenuItem_Click);
            // 
            // mnuReportsPrintRep
            // 
            this.mnuReportsPrintRep.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsPrintRep.ForeColor = System.Drawing.Color.White;
            this.mnuReportsPrintRep.Name = "mnuReportsPrintRep";
            this.mnuReportsPrintRep.Size = new System.Drawing.Size(141, 24);
            this.mnuReportsPrintRep.Text = "Print Report";
            this.mnuReportsPrintRep.Click += new System.EventHandler(this.mnuReportsPrintRep_Click);
            // 
            // mnuReportsForm
            // 
            this.mnuReportsForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsTherRef,
            this.mnuReportsRegChild,
            this.mnuReportsRegUser});
            this.mnuReportsForm.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsForm.ForeColor = System.Drawing.Color.White;
            this.mnuReportsForm.Name = "mnuReportsForm";
            this.mnuReportsForm.Size = new System.Drawing.Size(61, 24);
            this.mnuReportsForm.Text = "Form";
            // 
            // mnuReportsTherRef
            // 
            this.mnuReportsTherRef.Name = "mnuReportsTherRef";
            this.mnuReportsTherRef.Size = new System.Drawing.Size(244, 26);
            this.mnuReportsTherRef.Text = "Therapy Referral";
            this.mnuReportsTherRef.Click += new System.EventHandler(this.mnuReportsTherRef_Click);
            // 
            // mnuReportsRegChild
            // 
            this.mnuReportsRegChild.Name = "mnuReportsRegChild";
            this.mnuReportsRegChild.Size = new System.Drawing.Size(244, 26);
            this.mnuReportsRegChild.Text = "Register Child";
            this.mnuReportsRegChild.Click += new System.EventHandler(this.mnuReportsRegChild_Click);
            // 
            // mnuReportsRegUser
            // 
            this.mnuReportsRegUser.Name = "mnuReportsRegUser";
            this.mnuReportsRegUser.Size = new System.Drawing.Size(244, 26);
            this.mnuReportsRegUser.Text = "Register User";
            this.mnuReportsRegUser.Click += new System.EventHandler(this.mnuReportsRegUser_Click);
            // 
            // cboxReport
            // 
            this.cboxReport.Font = new System.Drawing.Font("Verily Serif Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxReport.FormattingEnabled = true;
            this.cboxReport.Items.AddRange(new object[] {
            "Therapy",
            "ADD & ADHD Therapy",
            "Child Information",
            "Therapist Information",
            "Waiting on outside resource"});
            this.cboxReport.Location = new System.Drawing.Point(370, 45);
            this.cboxReport.Name = "cboxReport";
            this.cboxReport.Size = new System.Drawing.Size(468, 31);
            this.cboxReport.TabIndex = 2;
            this.cboxReport.SelectedIndexChanged += new System.EventHandler(this.cboxReport_SelectedIndexChanged);
            // 
            // lblReportSelect
            // 
            this.lblReportSelect.AutoSize = true;
            this.lblReportSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblReportSelect.Font = new System.Drawing.Font("Verily Serif Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSelect.Location = new System.Drawing.Point(17, 48);
            this.lblReportSelect.Name = "lblReportSelect";
            this.lblReportSelect.Size = new System.Drawing.Size(322, 23);
            this.lblReportSelect.TabIndex = 3;
            this.lblReportSelect.Text = "SELECT YOUR REPORT TO VIEW";
            // 
            // DGVReport
            // 
            this.DGVReport.BackgroundColor = System.Drawing.Color.White;
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.Location = new System.Drawing.Point(21, 96);
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.Size = new System.Drawing.Size(817, 479);
            this.DGVReport.TabIndex = 4;
            // 
            // lblTherID
            // 
            this.lblTherID.AutoSize = true;
            this.lblTherID.BackColor = System.Drawing.Color.Transparent;
            this.lblTherID.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherID.Location = new System.Drawing.Point(844, 333);
            this.lblTherID.Name = "lblTherID";
            this.lblTherID.Size = new System.Drawing.Size(152, 20);
            this.lblTherID.TabIndex = 12;
            this.lblTherID.Text = "THERAPIST ID:";
            this.lblTherID.Visible = false;
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.BackColor = System.Drawing.Color.Transparent;
            this.lblChildID.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildID.Location = new System.Drawing.Point(844, 370);
            this.lblChildID.Name = "lblChildID";
            this.lblChildID.Size = new System.Drawing.Size(152, 20);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "CHILD NUMBER:";
            this.lblChildID.Visible = false;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.BackColor = System.Drawing.Color.Transparent;
            this.lblCluster.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCluster.Location = new System.Drawing.Point(844, 112);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(86, 20);
            this.lblCluster.TabIndex = 22;
            this.lblCluster.Text = "CLUSTER";
            this.lblCluster.Visible = false;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(844, 148);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(64, 20);
            this.lblHouse.TabIndex = 25;
            this.lblHouse.Text = "HOUSE";
            this.lblHouse.Visible = false;
            // 
            // cboxTherapyType
            // 
            this.cboxTherapyType.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTherapyType.FormattingEnabled = true;
            this.cboxTherapyType.Items.AddRange(new object[] {
            "OT",
            "Clinical Psych/Psychiatry",
            "Educational Psych",
            "Medical Assess",
            "ADD",
            "Play",
            "Physiotherapy",
            "Academic",
            "SALT",
            "Mentor",
            "Optometry",
            "Audiology",
            "Social Background Summary",
            "SNAP"});
            this.cboxTherapyType.Location = new System.Drawing.Point(994, 294);
            this.cboxTherapyType.Name = "cboxTherapyType";
            this.cboxTherapyType.Size = new System.Drawing.Size(263, 28);
            this.cboxTherapyType.TabIndex = 28;
            this.cboxTherapyType.Visible = false;
            // 
            // lblTherapyType
            // 
            this.lblTherapyType.AutoSize = true;
            this.lblTherapyType.BackColor = System.Drawing.Color.Transparent;
            this.lblTherapyType.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherapyType.Location = new System.Drawing.Point(844, 295);
            this.lblTherapyType.Name = "lblTherapyType";
            this.lblTherapyType.Size = new System.Drawing.Size(141, 20);
            this.lblTherapyType.TabIndex = 27;
            this.lblTherapyType.Text = "THERAPY TYPE";
            this.lblTherapyType.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(846, 259);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(42, 20);
            this.lblDay.TabIndex = 34;
            this.lblDay.Text = "DAY";
            this.lblDay.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(844, 221);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(64, 20);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "MONTH";
            this.lblMonth.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(844, 186);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 20);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "YEAR";
            this.lblYear.Visible = false;
            // 
            // txtTherapistID
            // 
            this.txtTherapistID.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTherapistID.Location = new System.Drawing.Point(994, 332);
            this.txtTherapistID.Name = "txtTherapistID";
            this.txtTherapistID.Size = new System.Drawing.Size(263, 29);
            this.txtTherapistID.TabIndex = 37;
            this.txtTherapistID.Visible = false;
            // 
            // txtChildID
            // 
            this.txtChildID.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildID.Location = new System.Drawing.Point(994, 366);
            this.txtChildID.Name = "txtChildID";
            this.txtChildID.Size = new System.Drawing.Size(263, 29);
            this.txtChildID.TabIndex = 38;
            this.txtChildID.Visible = false;
            // 
            // txtCluster
            // 
            this.txtCluster.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCluster.Location = new System.Drawing.Point(994, 111);
            this.txtCluster.Name = "txtCluster";
            this.txtCluster.Size = new System.Drawing.Size(263, 29);
            this.txtCluster.TabIndex = 40;
            this.txtCluster.Visible = false;
            // 
            // txtHouse
            // 
            this.txtHouse.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouse.Location = new System.Drawing.Point(994, 147);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(263, 29);
            this.txtHouse.TabIndex = 41;
            this.txtHouse.Visible = false;
            // 
            // DTPYear
            // 
            this.DTPYear.Checked = false;
            this.DTPYear.CustomFormat = "yyyy";
            this.DTPYear.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPYear.Location = new System.Drawing.Point(994, 182);
            this.DTPYear.Name = "DTPYear";
            this.DTPYear.ShowCheckBox = true;
            this.DTPYear.ShowUpDown = true;
            this.DTPYear.Size = new System.Drawing.Size(263, 29);
            this.DTPYear.TabIndex = 42;
            this.DTPYear.Visible = false;
            // 
            // DTPMonth
            // 
            this.DTPMonth.Checked = false;
            this.DTPMonth.CustomFormat = "MM";
            this.DTPMonth.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPMonth.Location = new System.Drawing.Point(994, 217);
            this.DTPMonth.Name = "DTPMonth";
            this.DTPMonth.ShowCheckBox = true;
            this.DTPMonth.ShowUpDown = true;
            this.DTPMonth.Size = new System.Drawing.Size(263, 29);
            this.DTPMonth.TabIndex = 43;
            this.DTPMonth.Visible = false;
            // 
            // DTPDay
            // 
            this.DTPDay.Checked = false;
            this.DTPDay.CustomFormat = "dd";
            this.DTPDay.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDay.Location = new System.Drawing.Point(994, 255);
            this.DTPDay.Name = "DTPDay";
            this.DTPDay.ShowCheckBox = true;
            this.DTPDay.ShowUpDown = true;
            this.DTPDay.Size = new System.Drawing.Size(263, 29);
            this.DTPDay.TabIndex = 44;
            this.DTPDay.Visible = false;
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowReport.Font = new System.Drawing.Font("Verily Serif Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(934, 418);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(280, 40);
            this.btnShowReport.TabIndex = 45;
            this.btnShowReport.Text = "Display Report";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Visible = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Verily Serif Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(966, 53);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 23);
            this.lblSearch.TabIndex = 46;
            this.lblSearch.Text = "SEARCH BY :";
            this.lblSearch.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmReports
            // 
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Reports;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 601);
            this.ControlBox = false;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCluster);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.DGVReport);
            this.Controls.Add(this.DTPDay);
            this.Controls.Add(this.cboxReport);
            this.Controls.Add(this.txtCluster);
            this.Controls.Add(this.lblReportSelect);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtChildID);
            this.Controls.Add(this.DTPYear);
            this.Controls.Add(this.lblChildID);
            this.Controls.Add(this.DTPMonth);
            this.Controls.Add(this.lblTherID);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.txtTherapistID);
            this.Controls.Add(this.mnuReports);
            this.Controls.Add(this.lblTherapyType);
            this.Controls.Add(this.cboxTherapyType);
            this.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuReports;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.mnuReports.ResumeLayout(false);
            this.mnuReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
#endregion
        
        private System.Windows.Forms.MenuStrip mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsFile;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsPrintRep;
        private System.Windows.Forms.ComboBox cboxReport;
        private System.Windows.Forms.Label lblReportSelect;
        private System.Windows.Forms.DataGridView DGVReport;
        private System.Windows.Forms.Label lblTherID;
        private System.Windows.Forms.Label lblChildID;
        private System.Windows.Forms.Label lblCluster;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cboxTherapyType;
        private System.Windows.Forms.Label lblTherapyType;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTherapistID;
        private System.Windows.Forms.TextBox txtChildID;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsForm;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsTherRef;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsRegChild;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsRegUser;
 

        private System.Windows.Forms.TextBox txtCluster;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.DateTimePicker DTPYear;
        private System.Windows.Forms.DateTimePicker DTPMonth;
        private System.Windows.Forms.DateTimePicker DTPDay;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}