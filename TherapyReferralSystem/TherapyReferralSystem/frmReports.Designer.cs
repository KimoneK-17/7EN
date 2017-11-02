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
            this.mnuReportsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsTherRef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportsRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.mnuReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuReports
            // 
            this.mnuReports.BackColor = System.Drawing.Color.Teal;
            this.mnuReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsFile,
            this.mnuReportsPrintRep,
            this.mnuReportsHelp,
            this.mnuReportsForm});
            this.mnuReports.Location = new System.Drawing.Point(0, 0);
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(861, 24);
            this.mnuReports.TabIndex = 0;
            this.mnuReports.Text = "Menu";
            // 
            // mnuReportsFile
            // 
            this.mnuReportsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsReturn});
            this.mnuReportsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsFile.ForeColor = System.Drawing.Color.White;
            this.mnuReportsFile.Name = "mnuReportsFile";
            this.mnuReportsFile.Size = new System.Drawing.Size(42, 20);
            this.mnuReportsFile.Text = "File";
            // 
            // mnuReportsReturn
            // 
            this.mnuReportsReturn.Name = "mnuReportsReturn";
            this.mnuReportsReturn.Size = new System.Drawing.Size(115, 22);
            this.mnuReportsReturn.Text = "Return";
            this.mnuReportsReturn.Click += new System.EventHandler(this.ezitToolStripMenuItem_Click);
            // 
            // mnuReportsPrintRep
            // 
            this.mnuReportsPrintRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsPrintRep.ForeColor = System.Drawing.Color.White;
            this.mnuReportsPrintRep.Name = "mnuReportsPrintRep";
            this.mnuReportsPrintRep.Size = new System.Drawing.Size(90, 20);
            this.mnuReportsPrintRep.Text = "Print Report";
            this.mnuReportsPrintRep.Click += new System.EventHandler(this.mnuReportsPrintRep_Click);
            // 
            // mnuReportsHelp
            // 
            this.mnuReportsHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsHelp.ForeColor = System.Drawing.Color.White;
            this.mnuReportsHelp.Name = "mnuReportsHelp";
            this.mnuReportsHelp.Size = new System.Drawing.Size(49, 20);
            this.mnuReportsHelp.Text = "Help";
            this.mnuReportsHelp.Click += new System.EventHandler(this.mnuReportsHelp_Click);
            // 
            // mnuReportsForm
            // 
            this.mnuReportsForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsTherRef,
            this.mnuReportsRegChild,
            this.mnuReportsRegUser});
            this.mnuReportsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsForm.ForeColor = System.Drawing.Color.White;
            this.mnuReportsForm.Name = "mnuReportsForm";
            this.mnuReportsForm.Size = new System.Drawing.Size(51, 20);
            this.mnuReportsForm.Text = "Form";
            // 
            // mnuReportsTherRef
            // 
            this.mnuReportsTherRef.Name = "mnuReportsTherRef";
            this.mnuReportsTherRef.Size = new System.Drawing.Size(178, 22);
            this.mnuReportsTherRef.Text = "Therapy Referral";
            this.mnuReportsTherRef.Click += new System.EventHandler(this.mnuReportsTherRef_Click);
            // 
            // mnuReportsRegChild
            // 
            this.mnuReportsRegChild.Name = "mnuReportsRegChild";
            this.mnuReportsRegChild.Size = new System.Drawing.Size(178, 22);
            this.mnuReportsRegChild.Text = "Register Child";
            this.mnuReportsRegChild.Click += new System.EventHandler(this.mnuReportsRegChild_Click);
            // 
            // mnuReportsRegUser
            // 
            this.mnuReportsRegUser.Name = "mnuReportsRegUser";
            this.mnuReportsRegUser.Size = new System.Drawing.Size(178, 22);
            this.mnuReportsRegUser.Text = "Register User";
            this.mnuReportsRegUser.Click += new System.EventHandler(this.mnuReportsRegUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPORTS";
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
            "Waiting on outside resource"});
            this.cboxReport.Location = new System.Drawing.Point(8, 41);
            this.cboxReport.Name = "cboxReport";
            this.cboxReport.Size = new System.Drawing.Size(184, 21);
            this.cboxReport.TabIndex = 2;
            this.cboxReport.SelectedIndexChanged += new System.EventHandler(this.cboxReport_SelectedIndexChanged);
            // 
            // lblReportSelect
            // 
            this.lblReportSelect.AutoSize = true;
            this.lblReportSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblReportSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSelect.Location = new System.Drawing.Point(5, 19);
            this.lblReportSelect.Name = "lblReportSelect";
            this.lblReportSelect.Size = new System.Drawing.Size(221, 16);
            this.lblReportSelect.TabIndex = 3;
            this.lblReportSelect.Text = "SELECT YOUR REPORT TO VIEW";
            // 
            // DGVReport
            // 
            this.DGVReport.BackgroundColor = System.Drawing.Color.White;
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.Location = new System.Drawing.Point(48, 268);
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.Size = new System.Drawing.Size(768, 305);
            this.DGVReport.TabIndex = 4;
            // 
            // lblTherID
            // 
            this.lblTherID.AutoSize = true;
            this.lblTherID.BackColor = System.Drawing.Color.Transparent;
            this.lblTherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherID.Location = new System.Drawing.Point(228, 115);
            this.lblTherID.Name = "lblTherID";
            this.lblTherID.Size = new System.Drawing.Size(184, 16);
            this.lblTherID.TabIndex = 12;
            this.lblTherID.Text = "SEARCH BY THERAPIST ID:";
            this.lblTherID.Visible = false;
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.BackColor = System.Drawing.Color.Transparent;
            this.lblChildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildID.Location = new System.Drawing.Point(228, 145);
            this.lblChildID.Name = "lblChildID";
            this.lblChildID.Size = new System.Drawing.Size(146, 16);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "SEARCH BY CHILD ID:";
            this.lblChildID.Visible = false;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.BackColor = System.Drawing.Color.Transparent;
            this.lblCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCluster.Location = new System.Drawing.Point(228, 12);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(126, 16);
            this.lblCluster.TabIndex = 22;
            this.lblCluster.Text = "SELECT CLUSTER";
            this.lblCluster.Visible = false;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(414, 12);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(111, 16);
            this.lblHouse.TabIndex = 25;
            this.lblHouse.Text = "SELECT HOUSE";
            this.lblHouse.Visible = false;
            // 
            // cboxTherapyType
            // 
            this.cboxTherapyType.FormattingEnabled = true;
            this.cboxTherapyType.Location = new System.Drawing.Point(598, 31);
            this.cboxTherapyType.Name = "cboxTherapyType";
            this.cboxTherapyType.Size = new System.Drawing.Size(121, 21);
            this.cboxTherapyType.TabIndex = 28;
            this.cboxTherapyType.Visible = false;
            // 
            // lblTherapyType
            // 
            this.lblTherapyType.AutoSize = true;
            this.lblTherapyType.BackColor = System.Drawing.Color.Transparent;
            this.lblTherapyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherapyType.Location = new System.Drawing.Point(595, 12);
            this.lblTherapyType.Name = "lblTherapyType";
            this.lblTherapyType.Size = new System.Drawing.Size(167, 16);
            this.lblTherapyType.TabIndex = 27;
            this.lblTherapyType.Text = "SELECT THERAPY TYPE";
            this.lblTherapyType.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(595, 60);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(91, 16);
            this.lblDay.TabIndex = 34;
            this.lblDay.Text = "SELECT DAY";
            this.lblDay.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(416, 60);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(113, 16);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "SELECT MONTH";
            this.lblMonth.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(228, 60);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 16);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "SELECT YEAR";
            this.lblYear.Visible = false;
            // 
            // txtTherapistID
            // 
            this.txtTherapistID.Location = new System.Drawing.Point(417, 114);
            this.txtTherapistID.Name = "txtTherapistID";
            this.txtTherapistID.Size = new System.Drawing.Size(121, 20);
            this.txtTherapistID.TabIndex = 37;
            this.txtTherapistID.Visible = false;
            this.txtTherapistID.TextChanged += new System.EventHandler(this.txtTherapistID_TextChanged);
            // 
            // txtChildID
            // 
            this.txtChildID.Location = new System.Drawing.Point(417, 144);
            this.txtChildID.Name = "txtChildID";
            this.txtChildID.Size = new System.Drawing.Size(121, 20);
            this.txtChildID.TabIndex = 38;
            this.txtChildID.Visible = false;
            this.txtChildID.TextChanged += new System.EventHandler(this.txtChildID_TextChanged);
            // 
            // txtCluster
            // 
            this.txtCluster.Location = new System.Drawing.Point(231, 32);
            this.txtCluster.Name = "txtCluster";
            this.txtCluster.Size = new System.Drawing.Size(85, 20);
            this.txtCluster.TabIndex = 40;
            this.txtCluster.TextChanged += new System.EventHandler(this.txtCluster_TextChanged);
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(417, 31);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(85, 20);
            this.txtHouse.TabIndex = 41;
            this.txtHouse.TextChanged += new System.EventHandler(this.txtHouse_TextChanged);
            // 
            // DTPYear
            // 
            this.DTPYear.CustomFormat = "yyyy";
            this.DTPYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPYear.Location = new System.Drawing.Point(231, 79);
            this.DTPYear.Name = "DTPYear";
            this.DTPYear.ShowUpDown = true;
            this.DTPYear.Size = new System.Drawing.Size(80, 20);
            this.DTPYear.TabIndex = 42;
            this.DTPYear.ValueChanged += new System.EventHandler(this.DTPYear_ValueChanged);
            // 
            // DTPMonth
            // 
            this.DTPMonth.CustomFormat = "MM";
            this.DTPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPMonth.Location = new System.Drawing.Point(419, 79);
            this.DTPMonth.Name = "DTPMonth";
            this.DTPMonth.ShowUpDown = true;
            this.DTPMonth.Size = new System.Drawing.Size(79, 20);
            this.DTPMonth.TabIndex = 43;
            this.DTPMonth.ValueChanged += new System.EventHandler(this.DTPMonth_ValueChanged);
            // 
            // DTPDay
            // 
            this.DTPDay.CustomFormat = "dd";
            this.DTPDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDay.Location = new System.Drawing.Point(598, 79);
            this.DTPDay.Name = "DTPDay";
            this.DTPDay.ShowUpDown = true;
            this.DTPDay.Size = new System.Drawing.Size(79, 20);
            this.DTPDay.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShowReport);
            this.panel1.Controls.Add(this.DTPDay);
            this.panel1.Controls.Add(this.DTPMonth);
            this.panel1.Controls.Add(this.cboxReport);
            this.panel1.Controls.Add(this.DTPYear);
            this.panel1.Controls.Add(this.lblReportSelect);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.txtHouse);
            this.panel1.Controls.Add(this.lblChildID);
            this.panel1.Controls.Add(this.txtCluster);
            this.panel1.Controls.Add(this.lblTherID);
            this.panel1.Controls.Add(this.txtChildID);
            this.panel1.Controls.Add(this.lblCluster);
            this.panel1.Controls.Add(this.txtTherapistID);
            this.panel1.Controls.Add(this.lblHouse);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblTherapyType);
            this.panel1.Controls.Add(this.cboxTherapyType);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Location = new System.Drawing.Point(48, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 196);
            this.panel1.TabIndex = 40;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(53, 91);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(97, 23);
            this.btnShowReport.TabIndex = 45;
            this.btnShowReport.Text = "Display Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // frmReports
            // 
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Reports;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 619);
            this.Controls.Add(this.DGVReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuReports);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mnuReports;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.mnuReports.ResumeLayout(false);
            this.mnuReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView DGVReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportsHelp;
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
 
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowReport;
    }
}