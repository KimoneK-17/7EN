namespace TherapyReferralSystem
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
            this.mnuReportsPrintRep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxReport = new System.Windows.Forms.ComboBox();
            this.lblReportSelect = new System.Windows.Forms.Label();
            this.lblTherID = new System.Windows.Forms.Label();
            this.lblChildID = new System.Windows.Forms.Label();
            this.lblCluster = new System.Windows.Forms.Label();
            this.cboxCluster = new System.Windows.Forms.ComboBox();
            this.cboxHouse = new System.Windows.Forms.ComboBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cboxTherapyType = new System.Windows.Forms.ComboBox();
            this.lblTherapyType = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTherapistID = new System.Windows.Forms.TextBox();
            this.txtChildID = new System.Windows.Forms.TextBox();
            this.cboxRefine = new System.Windows.Forms.CheckBox();
<<<<<<< HEAD
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnuReportsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsTherRef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegUser = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
=======
            this.DGVReport = new System.Windows.Forms.DataGridView();
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
>>>>>>> f66427b45e206b20d4191a06d93ccaaaf2f680b8
            this.mnuReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuReports
            // 
            this.mnuReports.BackColor = System.Drawing.Color.DimGray;
            this.mnuReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsFile,
            this.mnuReportsPrintRep,
            this.mnuReportsHelp,
            this.mnuReportsForm});
            this.mnuReports.Location = new System.Drawing.Point(0, 0);
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(968, 26);
            this.mnuReports.TabIndex = 0;
            this.mnuReports.Text = "Menu";
            // 
            // mnuReportsFile
            // 
            this.mnuReportsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsReturn});
            this.mnuReportsFile.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsFile.ForeColor = System.Drawing.Color.White;
            this.mnuReportsFile.Name = "mnuReportsFile";
            this.mnuReportsFile.Size = new System.Drawing.Size(44, 22);
            this.mnuReportsFile.Text = "File";
            // 
            // mnuReportsReturn
            // 
            this.mnuReportsReturn.Name = "mnuReportsReturn";
            this.mnuReportsReturn.Size = new System.Drawing.Size(152, 22);
            this.mnuReportsReturn.Text = "Return";
            this.mnuReportsReturn.Click += new System.EventHandler(this.ezitToolStripMenuItem_Click);
            // 
            // mnuReportsPrintRep
            // 
            this.mnuReportsPrintRep.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuReportsPrintRep.ForeColor = System.Drawing.Color.White;
            this.mnuReportsPrintRep.Name = "mnuReportsPrintRep";
            this.mnuReportsPrintRep.Size = new System.Drawing.Size(108, 22);
            this.mnuReportsPrintRep.Text = "Print Report";
            this.mnuReportsPrintRep.Click += new System.EventHandler(this.mnuReportsPrintRep_Click);
            // 
            // mnuReportsHelp
            // 
            this.mnuReportsHelp.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuReportsHelp.ForeColor = System.Drawing.Color.White;
            this.mnuReportsHelp.Name = "mnuReportsHelp";
            this.mnuReportsHelp.Size = new System.Drawing.Size(52, 22);
            this.mnuReportsHelp.Text = "Help";
            this.mnuReportsHelp.Click += new System.EventHandler(this.mnuReportsHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reports";
            // 
            // cboxReport
            // 
            this.cboxReport.FormattingEnabled = true;
            this.cboxReport.Items.AddRange(new object[] {
            "Theraphies",
            "ADD & ADHD Theraphy",
            "Child Information",
            "Therapist Information",
            "Interventions",
            "Waiting on outside resource"});
            this.cboxReport.Location = new System.Drawing.Point(48, 100);
            this.cboxReport.Name = "cboxReport";
            this.cboxReport.Size = new System.Drawing.Size(184, 21);
            this.cboxReport.TabIndex = 2;
            this.cboxReport.SelectedIndexChanged += new System.EventHandler(this.cboxReport_SelectedIndexChanged);
            // 
            // lblReportSelect
            // 
            this.lblReportSelect.AutoSize = true;
            this.lblReportSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblReportSelect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSelect.Location = new System.Drawing.Point(49, 78);
            this.lblReportSelect.Name = "lblReportSelect";
            this.lblReportSelect.Size = new System.Drawing.Size(156, 13);
            this.lblReportSelect.TabIndex = 3;
            this.lblReportSelect.Text = "Select your report to view";
            // 
            // lblTherID
            // 
            this.lblTherID.AutoSize = true;
            this.lblTherID.BackColor = System.Drawing.Color.Transparent;
            this.lblTherID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherID.Location = new System.Drawing.Point(307, 188);
            this.lblTherID.Name = "lblTherID";
            this.lblTherID.Size = new System.Drawing.Size(142, 13);
            this.lblTherID.TabIndex = 12;
            this.lblTherID.Text = "Search by therapist ID:";
            this.lblTherID.Visible = false;
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.BackColor = System.Drawing.Color.Transparent;
            this.lblChildID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildID.Location = new System.Drawing.Point(307, 214);
            this.lblChildID.Name = "lblChildID";
            this.lblChildID.Size = new System.Drawing.Size(118, 13);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "Search by child ID:";
            this.lblChildID.Visible = false;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.BackColor = System.Drawing.Color.Transparent;
            this.lblCluster.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCluster.Location = new System.Drawing.Point(307, 83);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(87, 13);
            this.lblCluster.TabIndex = 22;
            this.lblCluster.Text = "Select Cluster";
            this.lblCluster.Visible = false;
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
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(453, 83);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(81, 13);
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
            this.lblTherapyType.BackColor = System.Drawing.Color.Transparent;
            this.lblTherapyType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherapyType.Location = new System.Drawing.Point(603, 83);
            this.lblTherapyType.Name = "lblTherapyType";
            this.lblTherapyType.Size = new System.Drawing.Size(124, 13);
            this.lblTherapyType.TabIndex = 27;
            this.lblTherapyType.Text = "Select Therapy Type";
            this.lblTherapyType.Visible = false;
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
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(604, 138);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(69, 13);
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
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(453, 138);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(80, 13);
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
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(307, 138);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(71, 13);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Select Year";
            this.lblYear.Visible = false;
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
            this.cboxRefine.BackColor = System.Drawing.Color.Transparent;
            this.cboxRefine.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRefine.Location = new System.Drawing.Point(48, 134);
            this.cboxRefine.Name = "cboxRefine";
            this.cboxRefine.Size = new System.Drawing.Size(106, 17);
            this.cboxRefine.TabIndex = 39;
            this.cboxRefine.Text = "Refine Search";
            this.cboxRefine.UseVisualStyleBackColor = false;
            this.cboxRefine.CheckedChanged += new System.EventHandler(this.cboxRefine_CheckedChanged);
            // 
            // DGVReport
            // 
            this.DGVReport.AllowUserToAddRows = false;
            this.DGVReport.AllowUserToDeleteRows = false;
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.Location = new System.Drawing.Point(48, 274);
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.ReadOnly = true;
            this.DGVReport.Size = new System.Drawing.Size(870, 268);
            this.DGVReport.TabIndex = 41;
            // 
            // mnuReportsForm
            // 
            this.mnuReportsForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsTherRef,
            this.mnuReportsRegChild,
            this.mnuReportsRegUser});
            this.mnuReportsForm.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuReportsForm.ForeColor = System.Drawing.Color.White;
            this.mnuReportsForm.Name = "mnuReportsForm";
            this.mnuReportsForm.Size = new System.Drawing.Size(60, 22);
            this.mnuReportsForm.Text = "Form";
            // 
            // mnuReportsTherRef
            // 
            this.mnuReportsTherRef.Name = "mnuReportsTherRef";
            this.mnuReportsTherRef.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsTherRef.Text = "Therapy Referral";
            this.mnuReportsTherRef.Click += new System.EventHandler(this.mnuReportsTherRef_Click);
            // 
            // mnuReportsRegChild
            // 
            this.mnuReportsRegChild.Name = "mnuReportsRegChild";
            this.mnuReportsRegChild.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsRegChild.Text = "Register Child";
            this.mnuReportsRegChild.Click += new System.EventHandler(this.mnuReportsRegChild_Click);
            // 
            // mnuReportsRegUser
            // 
            this.mnuReportsRegUser.Name = "mnuReportsRegUser";
            this.mnuReportsRegUser.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsRegUser.Text = "Register User";
            this.mnuReportsRegUser.Click += new System.EventHandler(this.mnuReportsRegUser_Click);
            // 
            // mnuReportsForm
            // 
            this.mnuReportsForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsTherRef,
            this.mnuReportsRegChild,
            this.mnuReportsRegUser});
            this.mnuReportsForm.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuReportsForm.ForeColor = System.Drawing.Color.White;
            this.mnuReportsForm.Name = "mnuReportsForm";
            this.mnuReportsForm.Size = new System.Drawing.Size(60, 22);
            this.mnuReportsForm.Text = "Form";
            // 
            // mnuReportsTherRef
            // 
            this.mnuReportsTherRef.Name = "mnuReportsTherRef";
            this.mnuReportsTherRef.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsTherRef.Text = "Therapy Referral";
            this.mnuReportsTherRef.Click += new System.EventHandler(this.mnuReportsTherRef_Click);
            // 
            // mnuReportsRegChild
            // 
            this.mnuReportsRegChild.Name = "mnuReportsRegChild";
            this.mnuReportsRegChild.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsRegChild.Text = "Register Child";
            this.mnuReportsRegChild.Click += new System.EventHandler(this.mnuReportsRegChild_Click);
            // 
            // mnuReportsRegUser
            // 
            this.mnuReportsRegUser.Name = "mnuReportsRegUser";
            this.mnuReportsRegUser.Size = new System.Drawing.Size(198, 22);
            this.mnuReportsRegUser.Text = "Register User";
            this.mnuReportsRegUser.Click += new System.EventHandler(this.mnuReportsRegUser_Click);
            // 
            // frmReports
            // 
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Form_Texture;
            this.ClientSize = new System.Drawing.Size(968, 558);
            this.Controls.Add(this.DGVReport);
            this.Controls.Add(this.cboxRefine);
            this.Controls.Add(this.txtChildID);
            this.Controls.Add(this.txtTherapistID);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cboxMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cboxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboxTherapyType);
            this.Controls.Add(this.lblTherapyType);
            this.Controls.Add(this.cboxHouse);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.cboxCluster);
            this.Controls.Add(this.lblCluster);
            this.Controls.Add(this.lblTherID);
            this.Controls.Add(this.lblChildID);
            this.Controls.Add(this.lblReportSelect);
            this.Controls.Add(this.cboxReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuReports);
            this.MainMenuStrip = this.mnuReports;
            this.Name = "frmReports";
            this.Text = "Reports";
            this.mnuReports.ResumeLayout(false);
            this.mnuReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mnuReportsHelp;
        private System.Windows.Forms.Label lblTherID;
        private System.Windows.Forms.Label lblChildID;
        private System.Windows.Forms.Label lblCluster;
        private System.Windows.Forms.ComboBox cboxCluster;
        private System.Windows.Forms.ComboBox cboxHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cboxTherapyType;
        private System.Windows.Forms.Label lblTherapyType;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTherapistID;
        private System.Windows.Forms.TextBox txtChildID;
        private System.Windows.Forms.CheckBox cboxRefine;
<<<<<<< HEAD
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsForm;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsTherRef;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsRegChild;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsRegUser;
<<<<<<< HEAD
=======
=======
        private System.Windows.Forms.DataGridView DGVReport;
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
>>>>>>> f66427b45e206b20d4191a06d93ccaaaf2f680b8
    }
}