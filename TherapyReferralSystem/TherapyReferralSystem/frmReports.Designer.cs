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
<<<<<<< HEAD
            this.txtCluster = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.DTPYear = new System.Windows.Forms.DateTimePicker();
            this.DTPMonth = new System.Windows.Forms.DateTimePicker();
            this.DTPDay = new System.Windows.Forms.DateTimePicker();
=======
            this.cboxRefine = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
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
            this.mnuReportsFile.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsFile.ForeColor = System.Drawing.Color.White;
            this.mnuReportsFile.Name = "mnuReportsFile";
            this.mnuReportsFile.Size = new System.Drawing.Size(51, 20);
            this.mnuReportsFile.Text = "File";
            // 
            // mnuReportsReturn
            // 
            this.mnuReportsReturn.Name = "mnuReportsReturn";
            this.mnuReportsReturn.Size = new System.Drawing.Size(122, 22);
            this.mnuReportsReturn.Text = "Return";
            this.mnuReportsReturn.Click += new System.EventHandler(this.ezitToolStripMenuItem_Click);
            // 
            // mnuReportsPrintRep
            // 
            this.mnuReportsPrintRep.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsPrintRep.ForeColor = System.Drawing.Color.White;
            this.mnuReportsPrintRep.Name = "mnuReportsPrintRep";
            this.mnuReportsPrintRep.Size = new System.Drawing.Size(115, 20);
            this.mnuReportsPrintRep.Text = "Print Report";
            this.mnuReportsPrintRep.Click += new System.EventHandler(this.mnuReportsPrintRep_Click);
            // 
            // mnuReportsHelp
            // 
            this.mnuReportsHelp.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsHelp.ForeColor = System.Drawing.Color.White;
            this.mnuReportsHelp.Name = "mnuReportsHelp";
            this.mnuReportsHelp.Size = new System.Drawing.Size(51, 20);
            this.mnuReportsHelp.Text = "Help";
            this.mnuReportsHelp.Click += new System.EventHandler(this.mnuReportsHelp_Click);
            // 
            // mnuReportsForm
            // 
            this.mnuReportsForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportsTherRef,
            this.mnuReportsRegChild,
            this.mnuReportsRegUser});
            this.mnuReportsForm.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReportsForm.ForeColor = System.Drawing.Color.White;
            this.mnuReportsForm.Name = "mnuReportsForm";
            this.mnuReportsForm.Size = new System.Drawing.Size(51, 20);
            this.mnuReportsForm.Text = "Form";
            // 
            // mnuReportsTherRef
            // 
            this.mnuReportsTherRef.Name = "mnuReportsTherRef";
            this.mnuReportsTherRef.Size = new System.Drawing.Size(202, 22);
            this.mnuReportsTherRef.Text = "Therapy Referral";
            this.mnuReportsTherRef.Click += new System.EventHandler(this.mnuReportsTherRef_Click);
            // 
            // mnuReportsRegChild
            // 
            this.mnuReportsRegChild.Name = "mnuReportsRegChild";
            this.mnuReportsRegChild.Size = new System.Drawing.Size(202, 22);
            this.mnuReportsRegChild.Text = "Register Child";
            this.mnuReportsRegChild.Click += new System.EventHandler(this.mnuReportsRegChild_Click);
            // 
            // mnuReportsRegUser
            // 
            this.mnuReportsRegUser.Name = "mnuReportsRegUser";
            this.mnuReportsRegUser.Size = new System.Drawing.Size(202, 22);
            this.mnuReportsRegUser.Text = "Register User";
            this.mnuReportsRegUser.Click += new System.EventHandler(this.mnuReportsRegUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verily Serif Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
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
            "Interventions",
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
            this.lblReportSelect.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSelect.Location = new System.Drawing.Point(5, 19);
            this.lblReportSelect.Name = "lblReportSelect";
            this.lblReportSelect.Size = new System.Drawing.Size(215, 15);
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
            this.lblTherID.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherID.Location = new System.Drawing.Point(236, 127);
            this.lblTherID.Name = "lblTherID";
            this.lblTherID.Size = new System.Drawing.Size(191, 15);
            this.lblTherID.TabIndex = 12;
            this.lblTherID.Text = "SEARCH BY THERAPIST ID:";
            this.lblTherID.Visible = false;
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.BackColor = System.Drawing.Color.Transparent;
            this.lblChildID.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildID.Location = new System.Drawing.Point(236, 157);
            this.lblChildID.Name = "lblChildID";
<<<<<<< HEAD
            this.lblChildID.Size = new System.Drawing.Size(117, 13);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "Search by child Nr:";
=======
            this.lblChildID.Size = new System.Drawing.Size(159, 15);
            this.lblChildID.TabIndex = 11;
            this.lblChildID.Text = "SEARCH BY CHILD ID:";
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            this.lblChildID.Visible = false;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.BackColor = System.Drawing.Color.Transparent;
            this.lblCluster.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCluster.Location = new System.Drawing.Point(236, 19);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(119, 15);
            this.lblCluster.TabIndex = 22;
            this.lblCluster.Text = "SELECT CLUSTER";
            this.lblCluster.Visible = false;
            // 
<<<<<<< HEAD
=======
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
            this.cboxCluster.Location = new System.Drawing.Point(239, 41);
            this.cboxCluster.Name = "cboxCluster";
            this.cboxCluster.Size = new System.Drawing.Size(121, 21);
            this.cboxCluster.TabIndex = 24;
            this.cboxCluster.Visible = false;
            this.cboxCluster.SelectedIndexChanged += new System.EventHandler(this.cboxCluster_SelectedIndexChanged);
            // 
            // cboxHouse
            // 
            this.cboxHouse.FormattingEnabled = true;
            this.cboxHouse.Location = new System.Drawing.Point(425, 41);
            this.cboxHouse.Name = "cboxHouse";
            this.cboxHouse.Size = new System.Drawing.Size(121, 21);
            this.cboxHouse.TabIndex = 26;
            this.cboxHouse.Visible = false;
            // 
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(423, 20);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(103, 15);
            this.lblHouse.TabIndex = 25;
            this.lblHouse.Text = "SELECT HOUSE";
            this.lblHouse.Visible = false;
            // 
            // cboxTherapyType
            // 
            this.cboxTherapyType.FormattingEnabled = true;
            this.cboxTherapyType.Location = new System.Drawing.Point(606, 41);
            this.cboxTherapyType.Name = "cboxTherapyType";
            this.cboxTherapyType.Size = new System.Drawing.Size(121, 21);
            this.cboxTherapyType.TabIndex = 28;
            this.cboxTherapyType.Visible = false;
            // 
            // lblTherapyType
            // 
            this.lblTherapyType.AutoSize = true;
            this.lblTherapyType.BackColor = System.Drawing.Color.Transparent;
            this.lblTherapyType.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherapyType.Location = new System.Drawing.Point(603, 20);
            this.lblTherapyType.Name = "lblTherapyType";
            this.lblTherapyType.Size = new System.Drawing.Size(159, 15);
            this.lblTherapyType.TabIndex = 27;
            this.lblTherapyType.Text = "SELECT THERAPY TYPE";
            this.lblTherapyType.Visible = false;
            // 
<<<<<<< HEAD
=======
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Location = new System.Drawing.Point(606, 93);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 21);
            this.cboxDay.TabIndex = 35;
            this.cboxDay.Visible = false;
            // 
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.lblDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(602, 138);
=======
            this.lblDay.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(603, 72);
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(87, 15);
            this.lblDay.TabIndex = 34;
            this.lblDay.Text = "SELECT DAY";
            this.lblDay.Visible = false;
            // 
<<<<<<< HEAD
=======
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
            this.cboxMonth.Location = new System.Drawing.Point(425, 93);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(121, 21);
            this.cboxMonth.TabIndex = 33;
            this.cboxMonth.Visible = false;
            this.cboxMonth.SelectedIndexChanged += new System.EventHandler(this.cboxMonth_SelectedIndexChanged);
            // 
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.lblMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(451, 140);
=======
            this.lblMonth.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(424, 72);
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(103, 15);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "SELECT MONTH";
            this.lblMonth.Visible = false;
            // 
<<<<<<< HEAD
=======
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005"});
            this.cboxYear.Location = new System.Drawing.Point(239, 93);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(121, 21);
            this.cboxYear.TabIndex = 31;
            this.cboxYear.Visible = false;
            this.cboxYear.SelectedIndexChanged += new System.EventHandler(this.cboxYear_SelectedIndexChanged);
            // 
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.lblYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(307, 140);
=======
            this.lblYear.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(236, 72);
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(95, 15);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "SELECT YEAR";
            this.lblYear.Visible = false;
            // 
            // txtTherapistID
            // 
            this.txtTherapistID.Location = new System.Drawing.Point(425, 123);
            this.txtTherapistID.Name = "txtTherapistID";
            this.txtTherapistID.Size = new System.Drawing.Size(121, 20);
            this.txtTherapistID.TabIndex = 37;
            this.txtTherapistID.Visible = false;
            this.txtTherapistID.TextChanged += new System.EventHandler(this.txtTherapistID_TextChanged);
            // 
            // txtChildID
            // 
            this.txtChildID.Location = new System.Drawing.Point(425, 153);
            this.txtChildID.Name = "txtChildID";
            this.txtChildID.Size = new System.Drawing.Size(121, 20);
            this.txtChildID.TabIndex = 38;
            this.txtChildID.Visible = false;
            this.txtChildID.TextChanged += new System.EventHandler(this.txtChildID_TextChanged);
            // 
<<<<<<< HEAD
            // txtCluster
            // 
            this.txtCluster.Location = new System.Drawing.Point(309, 100);
            this.txtCluster.Name = "txtCluster";
            this.txtCluster.Size = new System.Drawing.Size(85, 20);
            this.txtCluster.TabIndex = 40;
            this.txtCluster.TextChanged += new System.EventHandler(this.txtCluster_TextChanged);
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(454, 101);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(85, 20);
            this.txtHouse.TabIndex = 41;
            this.txtHouse.TextChanged += new System.EventHandler(this.txtHouse_TextChanged);
            // 
            // DTPYear
            // 
            this.DTPYear.CustomFormat = "yyyy";
            this.DTPYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPYear.Location = new System.Drawing.Point(309, 156);
            this.DTPYear.Name = "DTPYear";
            this.DTPYear.ShowUpDown = true;
            this.DTPYear.Size = new System.Drawing.Size(80, 20);
            this.DTPYear.TabIndex = 42;
            this.DTPYear.ValueChanged += new System.EventHandler(this.DTPYear_ValueChanged);
            // 
            // DTPMonth
            // 
            this.DTPMonth.CustomFormat = "MMMM";
            this.DTPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPMonth.Location = new System.Drawing.Point(454, 156);
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
            this.DTPDay.Location = new System.Drawing.Point(605, 156);
            this.DTPDay.Name = "DTPDay";
            this.DTPDay.ShowUpDown = true;
            this.DTPDay.Size = new System.Drawing.Size(79, 20);
            this.DTPDay.TabIndex = 44;
=======
            // cboxRefine
            // 
            this.cboxRefine.AutoSize = true;
            this.cboxRefine.BackColor = System.Drawing.Color.Transparent;
            this.cboxRefine.Font = new System.Drawing.Font("Verily Serif Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRefine.Location = new System.Drawing.Point(8, 77);
            this.cboxRefine.Name = "cboxRefine";
            this.cboxRefine.Size = new System.Drawing.Size(130, 19);
            this.cboxRefine.TabIndex = 39;
            this.cboxRefine.Text = "REFINE SEARCH";
            this.cboxRefine.UseVisualStyleBackColor = false;
            this.cboxRefine.CheckedChanged += new System.EventHandler(this.cboxRefine_CheckedChanged);
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboxRefine);
            this.panel1.Controls.Add(this.cboxCluster);
            this.panel1.Controls.Add(this.txtChildID);
            this.panel1.Controls.Add(this.cboxReport);
            this.panel1.Controls.Add(this.txtTherapistID);
            this.panel1.Controls.Add(this.lblReportSelect);
            this.panel1.Controls.Add(this.lblChildID);
            this.panel1.Controls.Add(this.cboxDay);
            this.panel1.Controls.Add(this.lblTherID);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblCluster);
            this.panel1.Controls.Add(this.cboxMonth);
            this.panel1.Controls.Add(this.lblHouse);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.cboxHouse);
            this.panel1.Controls.Add(this.cboxYear);
            this.panel1.Controls.Add(this.lblTherapyType);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.cboxTherapyType);
            this.panel1.Location = new System.Drawing.Point(48, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 196);
            this.panel1.TabIndex = 40;
            // 
            // frmReports
            // 
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Reports;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 619);
<<<<<<< HEAD
            this.Controls.Add(this.DTPDay);
            this.Controls.Add(this.DTPMonth);
            this.Controls.Add(this.DTPYear);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.txtCluster);
            this.Controls.Add(this.txtChildID);
            this.Controls.Add(this.txtTherapistID);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboxTherapyType);
            this.Controls.Add(this.lblTherapyType);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.lblCluster);
            this.Controls.Add(this.lblTherID);
            this.Controls.Add(this.lblChildID);
=======
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
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
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtCluster;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.DateTimePicker DTPYear;
        private System.Windows.Forms.DateTimePicker DTPMonth;
        private System.Windows.Forms.DateTimePicker DTPDay;
=======
        private System.Windows.Forms.Panel panel1;
>>>>>>> 1411f22bfbd3edd3b68017bb200d1ace9b1c7c32
    }
}