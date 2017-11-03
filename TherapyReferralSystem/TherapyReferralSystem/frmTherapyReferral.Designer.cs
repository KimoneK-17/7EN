namespace TherapyReferralSystem
{
    partial class frmTherapyReferral
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChildNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCNum = new System.Windows.Forms.ComboBox();
            this.lblDsplyName = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbEnd = new System.Windows.Forms.CheckBox();
            this.chkWaitingList = new System.Windows.Forms.CheckBox();
            this.cmbRefBy = new System.Windows.Forms.ComboBox();
            this.dtpDateRef = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.nudSess = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtxtDetails = new System.Windows.Forms.RichTextBox();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.cmbTherapist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddRef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuTherapyRef = new System.Windows.Forms.MenuStrip();
            this.mnuTherapyRefFile = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.lblRCNum = new System.Windows.Forms.Label();
            this.lblRDiagnosis = new System.Windows.Forms.Label();
            this.lblRReason = new System.Windows.Forms.Label();
            this.lblRStatus = new System.Windows.Forms.Label();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblRNumSes = new System.Windows.Forms.Label();
            this.lblRTherapist = new System.Windows.Forms.Label();
            this.lblRReport = new System.Windows.Forms.Label();
            this.lblRRefBy = new System.Windows.Forms.Label();
            this.lblRDateRef = new System.Windows.Forms.Label();
            this.lblRStartDate = new System.Windows.Forms.Label();
            this.lblRDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSess)).BeginInit();
            this.panel3.SuspendLayout();
            this.mnuTherapyRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Select Date Referred:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 553);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Referred By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter Childs Diagnosis/Condition:";
            // 
            // lblChildNumber
            // 
            this.lblChildNumber.AutoSize = true;
            this.lblChildNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblChildNumber.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildNumber.Location = new System.Drawing.Point(16, 54);
            this.lblChildNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildNumber.Name = "lblChildNumber";
            this.lblChildNumber.Size = new System.Drawing.Size(209, 20);
            this.lblChildNumber.TabIndex = 25;
            this.lblChildNumber.Text = "Select Child Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbCNum);
            this.panel1.Controls.Add(this.lblDsplyName);
            this.panel1.Controls.Add(this.txtCondition);
            this.panel1.Controls.Add(this.cmbReason);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(379, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 190);
            this.panel1.TabIndex = 32;
            // 
            // cmbCNum
            // 
            this.cmbCNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCNum.FormattingEnabled = true;
            this.cmbCNum.Location = new System.Drawing.Point(16, 11);
            this.cmbCNum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCNum.Name = "cmbCNum";
            this.cmbCNum.Size = new System.Drawing.Size(325, 28);
            this.cmbCNum.TabIndex = 0;
            // 
            // lblDsplyName
            // 
            this.lblDsplyName.AutoSize = true;
            this.lblDsplyName.Location = new System.Drawing.Point(185, 21);
            this.lblDsplyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDsplyName.Name = "lblDsplyName";
            this.lblDsplyName.Size = new System.Drawing.Size(0, 20);
            this.lblDsplyName.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(16, 44);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(325, 29);
            this.txtCondition.TabIndex = 3;
            // 
            // cmbReason
            // 
            this.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Items.AddRange(new object[] {
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
            "SNAP",
            "NCBT",
            "Art",
            "Abbbas Lounge"});
            this.cmbReason.Location = new System.Drawing.Point(15, 76);
            this.cmbReason.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(327, 28);
            this.cmbReason.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "open",
            "closed",
            "assessment",
            "waiting list"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 110);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(325, 28);
            this.cmbStatus.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Assessment",
            "Treatment",
            "Intervention"});
            this.cmbType.Location = new System.Drawing.Point(16, 143);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(325, 28);
            this.cmbType.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chbEnd);
            this.panel2.Controls.Add(this.chkWaitingList);
            this.panel2.Controls.Add(this.cmbRefBy);
            this.panel2.Controls.Add(this.dtpDateRef);
            this.panel2.Controls.Add(this.dtpDateStart);
            this.panel2.Controls.Add(this.dtpDateEnd);
            this.panel2.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(379, 534);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 216);
            this.panel2.TabIndex = 33;
            // 
            // chbEnd
            // 
            this.chbEnd.AutoSize = true;
            this.chbEnd.Location = new System.Drawing.Point(16, 150);
            this.chbEnd.Name = "chbEnd";
            this.chbEnd.Size = new System.Drawing.Size(81, 24);
            this.chbEnd.TabIndex = 18;
            this.chbEnd.Text = "Ended";
            this.chbEnd.UseVisualStyleBackColor = true;
            this.chbEnd.CheckedChanged += new System.EventHandler(this.chbEnd_CheckedChanged);
            // 
            // chkWaitingList
            // 
            this.chkWaitingList.AutoSize = true;
            this.chkWaitingList.Location = new System.Drawing.Point(16, 80);
            this.chkWaitingList.Margin = new System.Windows.Forms.Padding(4);
            this.chkWaitingList.Name = "chkWaitingList";
            this.chkWaitingList.Size = new System.Drawing.Size(18, 17);
            this.chkWaitingList.TabIndex = 17;
            this.chkWaitingList.UseVisualStyleBackColor = true;
            this.chkWaitingList.CheckedChanged += new System.EventHandler(this.chkWaitingList_CheckedChanged);
            // 
            // cmbRefBy
            // 
            this.cmbRefBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefBy.FormattingEnabled = true;
            this.cmbRefBy.Items.AddRange(new object[] {
            "School",
            "Social",
            "Medical",
            "Therapy",
            "Mum"});
            this.cmbRefBy.Location = new System.Drawing.Point(16, 11);
            this.cmbRefBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRefBy.Name = "cmbRefBy";
            this.cmbRefBy.Size = new System.Drawing.Size(328, 28);
            this.cmbRefBy.TabIndex = 12;
            // 
            // dtpDateRef
            // 
            this.dtpDateRef.Location = new System.Drawing.Point(16, 44);
            this.dtpDateRef.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateRef.MaxDate = new System.DateTime(2017, 10, 30, 0, 0, 0, 0);
            this.dtpDateRef.Name = "dtpDateRef";
            this.dtpDateRef.Size = new System.Drawing.Size(328, 29);
            this.dtpDateRef.TabIndex = 13;
            this.dtpDateRef.Value = new System.DateTime(2017, 10, 30, 0, 0, 0, 0);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(16, 111);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(328, 29);
            this.dtpDateStart.TabIndex = 15;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(13, 183);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(328, 29);
            this.dtpDateEnd.TabIndex = 16;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // nudSess
            // 
            this.nudSess.Location = new System.Drawing.Point(16, 11);
            this.nudSess.Margin = new System.Windows.Forms.Padding(4);
            this.nudSess.Name = "nudSess";
            this.nudSess.Size = new System.Drawing.Size(327, 29);
            this.nudSess.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rtxtDetails);
            this.panel3.Controls.Add(this.rtxtResult);
            this.panel3.Controls.Add(this.cmbReport);
            this.panel3.Controls.Add(this.cmbTherapist);
            this.panel3.Controls.Add(this.nudSess);
            this.panel3.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(379, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 268);
            this.panel3.TabIndex = 34;
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.Location = new System.Drawing.Point(16, 44);
            this.rtxtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.Size = new System.Drawing.Size(325, 51);
            this.rtxtDetails.TabIndex = 43;
            this.rtxtDetails.Text = "";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(16, 186);
            this.rtxtResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(325, 58);
            this.rtxtResult.TabIndex = 42;
            this.rtxtResult.Text = "";
            // 
            // cmbReport
            // 
            this.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbReport.Location = new System.Drawing.Point(16, 146);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(325, 28);
            this.cmbReport.TabIndex = 20;
            // 
            // cmbTherapist
            // 
            this.cmbTherapist.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTherapist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTherapist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTherapist.FormattingEnabled = true;
            this.cmbTherapist.Location = new System.Drawing.Point(16, 108);
            this.cmbTherapist.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTherapist.Name = "cmbTherapist";
            this.cmbTherapist.Size = new System.Drawing.Size(325, 28);
            this.cmbTherapist.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 717);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 651);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Select Number of Sessions:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 298);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Enter Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 357);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Select Therapist:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 398);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Select Report:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 441);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Enter Result:";
            // 
            // btnAddRef
            // 
            this.btnAddRef.BackColor = System.Drawing.Color.Snow;
            this.btnAddRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRef.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRef.Location = new System.Drawing.Point(20, 787);
            this.btnAddRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRef.Name = "btnAddRef";
            this.btnAddRef.Size = new System.Drawing.Size(191, 33);
            this.btnAddRef.TabIndex = 42;
            this.btnAddRef.Text = "CAPTURE REFERAL";
            this.btnAddRef.UseVisualStyleBackColor = false;
            this.btnAddRef.Click += new System.EventHandler(this.btnAddRef_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 618);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Waiting List:";
            // 
            // mnuTherapyRef
            // 
            this.mnuTherapyRef.BackColor = System.Drawing.Color.Teal;
            this.mnuTherapyRef.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRef.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTherapyRef.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefFile,
            this.mnuTherapyRefView,
            this.mnuTherapyRefHelp,
            this.mnuTherapyRefForm});
            this.mnuTherapyRef.Location = new System.Drawing.Point(0, 0);
            this.mnuTherapyRef.Name = "mnuTherapyRef";
            this.mnuTherapyRef.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuTherapyRef.Size = new System.Drawing.Size(1031, 28);
            this.mnuTherapyRef.TabIndex = 54;
            this.mnuTherapyRef.Text = "menuStrip1";
            // 
            // mnuTherapyRefFile
            // 
            this.mnuTherapyRefFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.myProfileToolStripMenuItem,
            this.mnuTherapyRefReturn});
            this.mnuTherapyRefFile.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRefFile.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefFile.Name = "mnuTherapyRefFile";
            this.mnuTherapyRefFile.Size = new System.Drawing.Size(61, 24);
            this.mnuTherapyRefFile.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // mnuTherapyRefReturn
            // 
            this.mnuTherapyRefReturn.Name = "mnuTherapyRefReturn";
            this.mnuTherapyRefReturn.Size = new System.Drawing.Size(181, 26);
            this.mnuTherapyRefReturn.Text = "Logout";
            this.mnuTherapyRefReturn.Click += new System.EventHandler(this.mnuTherapyRefReturn_Click);
            // 
            // mnuTherapyRefView
            // 
            this.mnuTherapyRefView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefReports});
            this.mnuTherapyRefView.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRefView.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefView.Name = "mnuTherapyRefView";
            this.mnuTherapyRefView.Size = new System.Drawing.Size(61, 24);
            this.mnuTherapyRefView.Text = "View";
            // 
            // mnuTherapyRefReports
            // 
            this.mnuTherapyRefReports.Name = "mnuTherapyRefReports";
            this.mnuTherapyRefReports.Size = new System.Drawing.Size(154, 26);
            this.mnuTherapyRefReports.Text = "Reports";
            this.mnuTherapyRefReports.Click += new System.EventHandler(this.mnuTherapyRefReports_Click);
            // 
            // mnuTherapyRefHelp
            // 
            this.mnuTherapyRefHelp.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRefHelp.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefHelp.Name = "mnuTherapyRefHelp";
            this.mnuTherapyRefHelp.Size = new System.Drawing.Size(61, 24);
            this.mnuTherapyRefHelp.Text = "Help";
            this.mnuTherapyRefHelp.Click += new System.EventHandler(this.mnuTherapyRefHelp_Click);
            // 
            // mnuTherapyRefForm
            // 
            this.mnuTherapyRefForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefRegChild,
            this.mnuTherapyRefRegUser});
            this.mnuTherapyRefForm.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRefForm.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefForm.Name = "mnuTherapyRefForm";
            this.mnuTherapyRefForm.Size = new System.Drawing.Size(61, 24);
            this.mnuTherapyRefForm.Text = "Form";
            // 
            // mnuTherapyRefRegChild
            // 
            this.mnuTherapyRefRegChild.Name = "mnuTherapyRefRegChild";
            this.mnuTherapyRefRegChild.Size = new System.Drawing.Size(224, 26);
            this.mnuTherapyRefRegChild.Text = "Register Child";
            this.mnuTherapyRefRegChild.Click += new System.EventHandler(this.mnuTherapyRefRegChild_Click);
            // 
            // mnuTherapyRefRegUser
            // 
            this.mnuTherapyRefRegUser.Name = "mnuTherapyRefRegUser";
            this.mnuTherapyRefRegUser.Size = new System.Drawing.Size(224, 26);
            this.mnuTherapyRefRegUser.Text = "Register User";
            this.mnuTherapyRefRegUser.Click += new System.EventHandler(this.mnuTherapyRefRegUser_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.Snow;
            this.btnClearFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearFields.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(20, 828);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(191, 33);
            this.btnClearFields.TabIndex = 55;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            // 
            // lblRCNum
            // 
            this.lblRCNum.AutoSize = true;
            this.lblRCNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRCNum.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRCNum.ForeColor = System.Drawing.Color.Red;
            this.lblRCNum.Location = new System.Drawing.Point(750, 48);
            this.lblRCNum.Name = "lblRCNum";
            this.lblRCNum.Size = new System.Drawing.Size(16, 16);
            this.lblRCNum.TabIndex = 56;
            this.lblRCNum.Text = "*";
            // 
            // lblRDiagnosis
            // 
            this.lblRDiagnosis.AutoSize = true;
            this.lblRDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.lblRDiagnosis.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDiagnosis.ForeColor = System.Drawing.Color.Red;
            this.lblRDiagnosis.Location = new System.Drawing.Point(750, 79);
            this.lblRDiagnosis.Name = "lblRDiagnosis";
            this.lblRDiagnosis.Size = new System.Drawing.Size(16, 16);
            this.lblRDiagnosis.TabIndex = 60;
            this.lblRDiagnosis.Text = "*";
            // 
            // lblRReason
            // 
            this.lblRReason.AutoSize = true;
            this.lblRReason.BackColor = System.Drawing.Color.Transparent;
            this.lblRReason.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRReason.ForeColor = System.Drawing.Color.Red;
            this.lblRReason.Location = new System.Drawing.Point(750, 115);
            this.lblRReason.Name = "lblRReason";
            this.lblRReason.Size = new System.Drawing.Size(16, 16);
            this.lblRReason.TabIndex = 61;
            this.lblRReason.Text = "*";
            // 
            // lblRStatus
            // 
            this.lblRStatus.AutoSize = true;
            this.lblRStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblRStatus.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRStatus.ForeColor = System.Drawing.Color.Red;
            this.lblRStatus.Location = new System.Drawing.Point(750, 156);
            this.lblRStatus.Name = "lblRStatus";
            this.lblRStatus.Size = new System.Drawing.Size(16, 16);
            this.lblRStatus.TabIndex = 62;
            this.lblRStatus.Text = "*";
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.BackColor = System.Drawing.Color.Transparent;
            this.lblRType.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRType.ForeColor = System.Drawing.Color.Red;
            this.lblRType.Location = new System.Drawing.Point(750, 189);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(16, 16);
            this.lblRType.TabIndex = 63;
            this.lblRType.Text = "*";
            // 
            // lblRNumSes
            // 
            this.lblRNumSes.AutoSize = true;
            this.lblRNumSes.BackColor = System.Drawing.Color.Transparent;
            this.lblRNumSes.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNumSes.ForeColor = System.Drawing.Color.Red;
            this.lblRNumSes.Location = new System.Drawing.Point(750, 261);
            this.lblRNumSes.Name = "lblRNumSes";
            this.lblRNumSes.Size = new System.Drawing.Size(16, 16);
            this.lblRNumSes.TabIndex = 64;
            this.lblRNumSes.Text = "*";
            // 
            // lblRTherapist
            // 
            this.lblRTherapist.AutoSize = true;
            this.lblRTherapist.BackColor = System.Drawing.Color.Transparent;
            this.lblRTherapist.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTherapist.ForeColor = System.Drawing.Color.Red;
            this.lblRTherapist.Location = new System.Drawing.Point(750, 360);
            this.lblRTherapist.Name = "lblRTherapist";
            this.lblRTherapist.Size = new System.Drawing.Size(16, 16);
            this.lblRTherapist.TabIndex = 65;
            this.lblRTherapist.Text = "*";
            // 
            // lblRReport
            // 
            this.lblRReport.AutoSize = true;
            this.lblRReport.BackColor = System.Drawing.Color.Transparent;
            this.lblRReport.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRReport.ForeColor = System.Drawing.Color.Red;
            this.lblRReport.Location = new System.Drawing.Point(750, 398);
            this.lblRReport.Name = "lblRReport";
            this.lblRReport.Size = new System.Drawing.Size(16, 16);
            this.lblRReport.TabIndex = 66;
            this.lblRReport.Text = "*";
            // 
            // lblRRefBy
            // 
            this.lblRRefBy.AutoSize = true;
            this.lblRRefBy.BackColor = System.Drawing.Color.Transparent;
            this.lblRRefBy.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRefBy.ForeColor = System.Drawing.Color.Red;
            this.lblRRefBy.Location = new System.Drawing.Point(750, 548);
            this.lblRRefBy.Name = "lblRRefBy";
            this.lblRRefBy.Size = new System.Drawing.Size(16, 16);
            this.lblRRefBy.TabIndex = 67;
            this.lblRRefBy.Text = "*";
            // 
            // lblRDateRef
            // 
            this.lblRDateRef.AutoSize = true;
            this.lblRDateRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRDateRef.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDateRef.ForeColor = System.Drawing.Color.Red;
            this.lblRDateRef.Location = new System.Drawing.Point(750, 583);
            this.lblRDateRef.Name = "lblRDateRef";
            this.lblRDateRef.Size = new System.Drawing.Size(16, 16);
            this.lblRDateRef.TabIndex = 68;
            this.lblRDateRef.Text = "*";
            // 
            // lblRStartDate
            // 
            this.lblRStartDate.AutoSize = true;
            this.lblRStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRStartDate.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRStartDate.ForeColor = System.Drawing.Color.Red;
            this.lblRStartDate.Location = new System.Drawing.Point(750, 650);
            this.lblRStartDate.Name = "lblRStartDate";
            this.lblRStartDate.Size = new System.Drawing.Size(16, 16);
            this.lblRStartDate.TabIndex = 70;
            this.lblRStartDate.Text = "*";
            // 
            // lblRDetails
            // 
            this.lblRDetails.AutoSize = true;
            this.lblRDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblRDetails.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDetails.ForeColor = System.Drawing.Color.Red;
            this.lblRDetails.Location = new System.Drawing.Point(750, 298);
            this.lblRDetails.Name = "lblRDetails";
            this.lblRDetails.Size = new System.Drawing.Size(16, 16);
            this.lblRDetails.TabIndex = 71;
            this.lblRDetails.Text = "*";
            // 
            // frmTherapyReferral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.TherapyReferral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 878);
            this.ControlBox = false;
            this.Controls.Add(this.lblRDetails);
            this.Controls.Add(this.lblRStartDate);
            this.Controls.Add(this.lblRDateRef);
            this.Controls.Add(this.lblRRefBy);
            this.Controls.Add(this.lblRReport);
            this.Controls.Add(this.lblRTherapist);
            this.Controls.Add(this.lblRNumSes);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.lblRStatus);
            this.Controls.Add(this.lblRReason);
            this.Controls.Add(this.lblRDiagnosis);
            this.Controls.Add(this.lblRCNum);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.mnuTherapyRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddRef);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChildNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTherapyReferral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Therapy Referral";
            this.Load += new System.EventHandler(this.frmTherapyReferral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSess)).EndInit();
            this.panel3.ResumeLayout(false);
            this.mnuTherapyRef.ResumeLayout(false);
            this.mnuTherapyRef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChildNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCNum;
        private System.Windows.Forms.Label lblDsplyName;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbRefBy;
        private System.Windows.Forms.DateTimePicker dtpDateRef;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.NumericUpDown nudSess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.ComboBox cmbTherapist;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddRef;
        private System.Windows.Forms.RichTextBox rtxtDetails;
        private System.Windows.Forms.CheckBox chkWaitingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnuTherapyRef;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefView;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefReports;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefForm;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefRegChild;
        private System.Windows.Forms.ToolStripMenuItem mnuTherapyRefRegUser;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Label lblRCNum;
        private System.Windows.Forms.Label lblRDiagnosis;
        private System.Windows.Forms.Label lblRReason;
        private System.Windows.Forms.Label lblRStatus;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblRNumSes;
        private System.Windows.Forms.Label lblRTherapist;
        private System.Windows.Forms.Label lblRReport;
        private System.Windows.Forms.Label lblRRefBy;
        private System.Windows.Forms.Label lblRDateRef;
        private System.Windows.Forms.Label lblRStartDate;
        private System.Windows.Forms.Label lblRDetails;
        private System.Windows.Forms.CheckBox chbEnd;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
    }
}