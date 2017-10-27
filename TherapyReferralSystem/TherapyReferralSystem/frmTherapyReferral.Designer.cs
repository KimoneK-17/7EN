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
            this.mnuTherapyRefReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTherapyRefRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearFields = new System.Windows.Forms.Button();
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
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Select Date Referred:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(683, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Referred By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter Childs Diagnosis/Condition:";
            // 
            // lblChildNumber
            // 
            this.lblChildNumber.AutoSize = true;
            this.lblChildNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblChildNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildNumber.Location = new System.Drawing.Point(16, 54);
            this.lblChildNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildNumber.Name = "lblChildNumber";
            this.lblChildNumber.Size = new System.Drawing.Size(195, 20);
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
            this.panel1.Location = new System.Drawing.Point(323, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 190);
            this.panel1.TabIndex = 32;
            // 
            // cmbCNum
            // 
            this.cmbCNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCNum.FormattingEnabled = true;
            this.cmbCNum.Location = new System.Drawing.Point(16, 11);
            this.cmbCNum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCNum.Name = "cmbCNum";
            this.cmbCNum.Size = new System.Drawing.Size(263, 24);
            this.cmbCNum.TabIndex = 0;
            // 
            // lblDsplyName
            // 
            this.lblDsplyName.AutoSize = true;
            this.lblDsplyName.Location = new System.Drawing.Point(185, 21);
            this.lblDsplyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDsplyName.Name = "lblDsplyName";
            this.lblDsplyName.Size = new System.Drawing.Size(0, 17);
            this.lblDsplyName.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(16, 44);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(263, 22);
            this.txtCondition.TabIndex = 3;
            // 
            // cmbReason
            // 
            this.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(15, 76);
            this.cmbReason.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(264, 24);
            this.cmbReason.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(16, 110);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(263, 24);
            this.cmbStatus.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(16, 143);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(263, 24);
            this.cmbType.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chkWaitingList);
            this.panel2.Controls.Add(this.cmbRefBy);
            this.panel2.Controls.Add(this.dtpDateRef);
            this.panel2.Controls.Add(this.dtpDateStart);
            this.panel2.Controls.Add(this.dtpDateEnd);
            this.panel2.Location = new System.Drawing.Point(893, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 190);
            this.panel2.TabIndex = 33;
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
            // 
            // cmbRefBy
            // 
            this.cmbRefBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefBy.FormattingEnabled = true;
            this.cmbRefBy.Location = new System.Drawing.Point(16, 11);
            this.cmbRefBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRefBy.Name = "cmbRefBy";
            this.cmbRefBy.Size = new System.Drawing.Size(265, 24);
            this.cmbRefBy.TabIndex = 12;
            // 
            // dtpDateRef
            // 
            this.dtpDateRef.Location = new System.Drawing.Point(16, 44);
            this.dtpDateRef.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateRef.Name = "dtpDateRef";
            this.dtpDateRef.Size = new System.Drawing.Size(265, 22);
            this.dtpDateRef.TabIndex = 13;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(16, 111);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(265, 22);
            this.dtpDateStart.TabIndex = 15;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(16, 149);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpDateEnd.TabIndex = 16;
            // 
            // nudSess
            // 
            this.nudSess.Location = new System.Drawing.Point(16, 11);
            this.nudSess.Margin = new System.Windows.Forms.Padding(4);
            this.nudSess.Name = "nudSess";
            this.nudSess.Size = new System.Drawing.Size(264, 22);
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
            this.panel3.Location = new System.Drawing.Point(323, 268);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 329);
            this.panel3.TabIndex = 34;
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.Location = new System.Drawing.Point(16, 58);
            this.rtxtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.Size = new System.Drawing.Size(263, 69);
            this.rtxtDetails.TabIndex = 43;
            this.rtxtDetails.Text = "";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(16, 246);
            this.rtxtResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(249, 64);
            this.rtxtResult.TabIndex = 42;
            this.rtxtResult.Text = "";
            // 
            // cmbReport
            // 
            this.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Location = new System.Drawing.Point(16, 198);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(263, 24);
            this.cmbReport.TabIndex = 20;
            // 
            // cmbTherapist
            // 
            this.cmbTherapist.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTherapist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTherapist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTherapist.FormattingEnabled = true;
            this.cmbTherapist.Location = new System.Drawing.Point(16, 150);
            this.cmbTherapist.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTherapist.Name = "cmbTherapist";
            this.cmbTherapist.Size = new System.Drawing.Size(263, 24);
            this.cmbTherapist.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(683, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 284);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Select Number of Sessions:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Enter Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 428);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Select Therapist:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 471);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Select Report:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 516);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Enter Result:";
            // 
            // btnAddRef
            // 
            this.btnAddRef.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRef.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRef.Location = new System.Drawing.Point(771, 302);
            this.btnAddRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRef.Name = "btnAddRef";
            this.btnAddRef.Size = new System.Drawing.Size(191, 43);
            this.btnAddRef.TabIndex = 42;
            this.btnAddRef.Text = "CAPTURE REFERAL";
            this.btnAddRef.UseVisualStyleBackColor = false;
            this.btnAddRef.Click += new System.EventHandler(this.btnAddRef_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.Location = new System.Drawing.Point(683, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Waiting List:";
            // 
            // mnuTherapyRef
            // 
            this.mnuTherapyRef.BackColor = System.Drawing.Color.LightSlateGray;
            this.mnuTherapyRef.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTherapyRef.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTherapyRef.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefFile,
            this.mnuTherapyRefView,
            this.mnuTherapyRefHelp,
            this.mnuTherapyRefForm});
            this.mnuTherapyRef.Location = new System.Drawing.Point(0, 0);
            this.mnuTherapyRef.Name = "mnuTherapyRef";
            this.mnuTherapyRef.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuTherapyRef.Size = new System.Drawing.Size(1216, 31);
            this.mnuTherapyRef.TabIndex = 54;
            this.mnuTherapyRef.Text = "menuStrip1";
            // 
            // mnuTherapyRefFile
            // 
            this.mnuTherapyRefFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefReturn});
            this.mnuTherapyRefFile.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefFile.Name = "mnuTherapyRefFile";
            this.mnuTherapyRefFile.Size = new System.Drawing.Size(56, 27);
            this.mnuTherapyRefFile.Text = "File";
            // 
            // mnuTherapyRefReturn
            // 
            this.mnuTherapyRefReturn.Name = "mnuTherapyRefReturn";
            this.mnuTherapyRefReturn.Size = new System.Drawing.Size(149, 28);
            this.mnuTherapyRefReturn.Text = "Return";
            this.mnuTherapyRefReturn.Click += new System.EventHandler(this.mnuTherapyRefReturn_Click);
            // 
            // mnuTherapyRefView
            // 
            this.mnuTherapyRefView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefReports});
            this.mnuTherapyRefView.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefView.Name = "mnuTherapyRefView";
            this.mnuTherapyRefView.Size = new System.Drawing.Size(68, 27);
            this.mnuTherapyRefView.Text = "View";
            // 
            // mnuTherapyRefReports
            // 
            this.mnuTherapyRefReports.Name = "mnuTherapyRefReports";
            this.mnuTherapyRefReports.Size = new System.Drawing.Size(159, 28);
            this.mnuTherapyRefReports.Text = "Reports";
            this.mnuTherapyRefReports.Click += new System.EventHandler(this.mnuTherapyRefReports_Click);
            // 
            // mnuTherapyRefHelp
            // 
            this.mnuTherapyRefHelp.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefHelp.Name = "mnuTherapyRefHelp";
            this.mnuTherapyRefHelp.Size = new System.Drawing.Size(65, 27);
            this.mnuTherapyRefHelp.Text = "Help";
            this.mnuTherapyRefHelp.Click += new System.EventHandler(this.mnuTherapyRefHelp_Click);
            // 
            // mnuTherapyRefForm
            // 
            this.mnuTherapyRefForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTherapyRefRegChild,
            this.mnuTherapyRefRegUser});
            this.mnuTherapyRefForm.ForeColor = System.Drawing.Color.White;
            this.mnuTherapyRefForm.Name = "mnuTherapyRefForm";
            this.mnuTherapyRefForm.Size = new System.Drawing.Size(71, 27);
            this.mnuTherapyRefForm.Text = "Form";
            // 
            // mnuTherapyRefRegChild
            // 
            this.mnuTherapyRefRegChild.Name = "mnuTherapyRefRegChild";
            this.mnuTherapyRefRegChild.Size = new System.Drawing.Size(220, 28);
            this.mnuTherapyRefRegChild.Text = "Register Child";
            this.mnuTherapyRefRegChild.Click += new System.EventHandler(this.mnuTherapyRefRegChild_Click);
            // 
            // mnuTherapyRefRegUser
            // 
            this.mnuTherapyRefRegUser.Name = "mnuTherapyRefRegUser";
            this.mnuTherapyRefRegUser.Size = new System.Drawing.Size(220, 28);
            this.mnuTherapyRefRegUser.Text = "Register User";
            this.mnuTherapyRefRegUser.Click += new System.EventHandler(this.mnuTherapyRefRegUser_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(771, 368);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(191, 43);
            this.btnClearFields.TabIndex = 55;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            // 
            // frmTherapyReferral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.therapyback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 649);
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
            this.Text = "Therapy Referral";
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
    }
}