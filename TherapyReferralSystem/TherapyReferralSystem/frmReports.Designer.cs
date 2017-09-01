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
            this.mnuReportsReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsPrintRep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxReport = new System.Windows.Forms.ComboBox();
            this.lblReportSelect = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTherID = new System.Windows.Forms.Label();
            this.lblChildID = new System.Windows.Forms.Label();
            this.lblCluster = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboxCluster = new System.Windows.Forms.ComboBox();
            this.cboxHouse = new System.Windows.Forms.ComboBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cboxTherapyType = new System.Windows.Forms.ComboBox();
            this.lblTherapyType = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTherapistID = new System.Windows.Forms.TextBox();
            this.txtChildID = new System.Windows.Forms.TextBox();
            this.cboxRefine = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mnuReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuReports
            // 
            this.mnuReports.BackColor = System.Drawing.Color.DimGray;
            this.mnuReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsFile,
            this.mnuReportsPrintRep,
            this.mnuReportsHelp});
            this.mnuReports.Location = new System.Drawing.Point(0, 0);
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(861, 26);
            this.mnuReports.TabIndex = 0;
            this.mnuReports.Text = "Menu";
            // 
            // mnuReportsFile
            // 
            this.mnuReportsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsReturn,
            this.mnuReportsLogout});
            this.mnuReportsFile.ForeColor = System.Drawing.Color.White;
            this.mnuReportsFile.Name = "mnuReportsFile";
            this.mnuReportsFile.Size = new System.Drawing.Size(47, 22);
            this.mnuReportsFile.Text = "File";
            // 
            // mnuReportsReturn
            // 
            this.mnuReportsReturn.Name = "mnuReportsReturn";
            this.mnuReportsReturn.Size = new System.Drawing.Size(128, 22);
            this.mnuReportsReturn.Text = "Return";
            this.mnuReportsReturn.Click += new System.EventHandler(this.ezitToolStripMenuItem_Click);
            // 
            // mnuReportsLogout
            // 
            this.mnuReportsLogout.Name = "mnuReportsLogout";
            this.mnuReportsLogout.Size = new System.Drawing.Size(128, 22);
            this.mnuReportsLogout.Text = "Logout";
            this.mnuReportsLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mnuReportsPrintRep
            // 
            this.mnuReportsPrintRep.ForeColor = System.Drawing.Color.White;
            this.mnuReportsPrintRep.Name = "mnuReportsPrintRep";
            this.mnuReportsPrintRep.Size = new System.Drawing.Size(111, 22);
            this.mnuReportsPrintRep.Text = "Print Report";
            // 
            // mnuReportsHelp
            // 
            this.mnuReportsHelp.ForeColor = System.Drawing.Color.White;
            this.mnuReportsHelp.Name = "mnuReportsHelp";
            this.mnuReportsHelp.Size = new System.Drawing.Size(54, 22);
            this.mnuReportsHelp.Text = "Help";
            this.mnuReportsHelp.Click += new System.EventHandler(this.mnuReportsHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reports";
            // 
            // cboxReport
            // 
            this.cboxReport.FormattingEnabled = true;
            this.cboxReport.Items.AddRange(new object[] {
            "Theraphy",
            "ADD & ADHD Theraphy",
            "Child Information",
            "Therapist Information",
            "Referals",
            "Interventions",
            "Waiting on outside resource"});
            this.cboxReport.Location = new System.Drawing.Point(48, 100);
            this.cboxReport.Name = "cboxReport";
            this.cboxReport.Size = new System.Drawing.Size(184, 21);
            this.cboxReport.TabIndex = 2;
            // 
            // lblReportSelect
            // 
            this.lblReportSelect.AutoSize = true;
            this.lblReportSelect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSelect.Location = new System.Drawing.Point(49, 78);
            this.lblReportSelect.Name = "lblReportSelect";
            this.lblReportSelect.Size = new System.Drawing.Size(183, 19);
            this.lblReportSelect.TabIndex = 3;
            this.lblReportSelect.Text = "Select your report to view";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 314);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblTherID
            // 
            this.lblTherID.AutoSize = true;
            this.lblTherID.Location = new System.Drawing.Point(307, 188);
            this.lblTherID.Name = "lblTherID";
            this.lblTherID.Size = new System.Drawing.Size(115, 13);
            this.lblTherID.TabIndex = 12;
            this.lblTherID.Text = "Search by therapist ID:";
            this.lblTherID.Visible = false;
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.Location = new System.Drawing.Point(307, 214);
            this.lblChildID.Name = "lblChildID";
            this.lblChildID.Size = new System.Drawing.Size(97, 13);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "Search by child ID:";
            this.lblChildID.Visible = false;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.Location = new System.Drawing.Point(307, 83);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(72, 13);
            this.lblCluster.TabIndex = 22;
            this.lblCluster.Text = "Select Cluster";
            this.lblCluster.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(317, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(206, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "(pop up house only when cluster selected)";
            // 
            // cboxCluster
            // 
            this.cboxCluster.FormattingEnabled = true;
            this.cboxCluster.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboxCluster.Location = new System.Drawing.Point(309, 100);
            this.cboxCluster.Name = "cboxCluster";
            this.cboxCluster.Size = new System.Drawing.Size(121, 21);
            this.cboxCluster.TabIndex = 24;
            this.cboxCluster.Visible = false;
            this.cboxCluster.SelectedIndexChanged += new System.EventHandler(this.cboxCluster_SelectedIndexChanged);
            // 
            // cboxHouse
            // 
            this.cboxHouse.FormattingEnabled = true;
            this.cboxHouse.Location = new System.Drawing.Point(455, 100);
            this.cboxHouse.Name = "cboxHouse";
            this.cboxHouse.Size = new System.Drawing.Size(121, 21);
            this.cboxHouse.TabIndex = 26;
            this.cboxHouse.Visible = false;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(453, 83);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(71, 13);
            this.lblHouse.TabIndex = 25;
            this.lblHouse.Text = "Select House";
            this.lblHouse.Visible = false;
            // 
            // cboxTherapyType
            // 
            this.cboxTherapyType.FormattingEnabled = true;
            this.cboxTherapyType.Location = new System.Drawing.Point(605, 100);
            this.cboxTherapyType.Name = "cboxTherapyType";
            this.cboxTherapyType.Size = new System.Drawing.Size(121, 21);
            this.cboxTherapyType.TabIndex = 28;
            this.cboxTherapyType.Visible = false;
            // 
            // lblTherapyType
            // 
            this.lblTherapyType.AutoSize = true;
            this.lblTherapyType.Location = new System.Drawing.Point(603, 83);
            this.lblTherapyType.Name = "lblTherapyType";
            this.lblTherapyType.Size = new System.Drawing.Size(106, 13);
            this.lblTherapyType.TabIndex = 27;
            this.lblTherapyType.Text = "Select Therapy Type";
            this.lblTherapyType.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(585, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "(pop up only where applicable)";
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Location = new System.Drawing.Point(606, 155);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 21);
            this.cboxDay.TabIndex = 35;
            this.cboxDay.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(604, 138);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(59, 13);
            this.lblDay.TabIndex = 34;
            this.lblDay.Text = "Select Day";
            this.lblDay.Visible = false;
            // 
            // cboxMonth
            // 
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "Desember"});
            this.cboxMonth.Location = new System.Drawing.Point(455, 155);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(121, 21);
            this.cboxMonth.TabIndex = 33;
            this.cboxMonth.Visible = false;
            this.cboxMonth.SelectedIndexChanged += new System.EventHandler(this.cboxMonth_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(453, 138);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(70, 13);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "Select Month";
            this.lblMonth.Visible = false;
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005"});
            this.cboxYear.Location = new System.Drawing.Point(309, 155);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(121, 21);
            this.cboxYear.TabIndex = 31;
            this.cboxYear.Visible = false;
            this.cboxYear.SelectedIndexChanged += new System.EventHandler(this.cboxYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(307, 138);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 13);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Select Year";
            this.lblYear.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(661, 179);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(133, 13);
            this.label28.TabIndex = 36;
            this.label28.Text = "Look at date picker maybe";
            // 
            // txtTherapistID
            // 
            this.txtTherapistID.Location = new System.Drawing.Point(454, 185);
            this.txtTherapistID.Name = "txtTherapistID";
            this.txtTherapistID.Size = new System.Drawing.Size(100, 20);
            this.txtTherapistID.TabIndex = 37;
            this.txtTherapistID.Visible = false;
            this.txtTherapistID.TextChanged += new System.EventHandler(this.txtTherapistID_TextChanged);
            // 
            // txtChildID
            // 
            this.txtChildID.Location = new System.Drawing.Point(454, 211);
            this.txtChildID.Name = "txtChildID";
            this.txtChildID.Size = new System.Drawing.Size(100, 20);
            this.txtChildID.TabIndex = 38;
            this.txtChildID.Visible = false;
            this.txtChildID.TextChanged += new System.EventHandler(this.txtChildID_TextChanged);
            // 
            // cboxRefine
            // 
            this.cboxRefine.AutoSize = true;
            this.cboxRefine.Location = new System.Drawing.Point(48, 134);
            this.cboxRefine.Name = "cboxRefine";
            this.cboxRefine.Size = new System.Drawing.Size(94, 17);
            this.cboxRefine.TabIndex = 39;
            this.cboxRefine.Text = "Refine Search";
            this.cboxRefine.UseVisualStyleBackColor = true;
            this.cboxRefine.CheckedChanged += new System.EventHandler(this.cboxRefine_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "(hide all to right untill refine search selected)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "(pop up month only when year selected)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "(pop up day only when month selected)";
            // 
            // frmReports
            // 
            this.ClientSize = new System.Drawing.Size(861, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxRefine);
            this.Controls.Add(this.txtChildID);
            this.Controls.Add(this.txtTherapistID);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cboxMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cboxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cboxTherapyType);
            this.Controls.Add(this.lblTherapyType);
            this.Controls.Add(this.cboxHouse);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.cboxCluster);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblCluster);
            this.Controls.Add(this.lblTherID);
            this.Controls.Add(this.lblChildID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblReportSelect);
            this.Controls.Add(this.cboxReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuReports);
            this.MainMenuStrip = this.mnuReports;
            this.Name = "frmReports";
            this.Text = "Reports";
            this.mnuReports.ResumeLayout(false);
            this.mnuReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsFile;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsPrintRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxReport;
        private System.Windows.Forms.Label lblReportSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsHelp;
        private System.Windows.Forms.Label lblTherID;
        private System.Windows.Forms.Label lblChildID;
        private System.Windows.Forms.Label lblCluster;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboxCluster;
        private System.Windows.Forms.ComboBox cboxHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cboxTherapyType;
        private System.Windows.Forms.Label lblTherapyType;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtTherapistID;
        private System.Windows.Forms.TextBox txtChildID;
        private System.Windows.Forms.CheckBox cboxRefine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsLogout;
    }
}