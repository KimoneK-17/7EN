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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTherapyReferral));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChildNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmCNum = new System.Windows.Forms.ComboBox();
            this.lblDsplyName = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cbmSess = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSess)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Select Date Referred:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Referred By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Session";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select Reason:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter Childs Diagnosis/Condition:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblChildNumber
            // 
            this.lblChildNumber.AutoSize = true;
            this.lblChildNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblChildNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildNumber.Location = new System.Drawing.Point(8, 29);
            this.lblChildNumber.Name = "lblChildNumber";
            this.lblChildNumber.Size = new System.Drawing.Size(146, 16);
            this.lblChildNumber.TabIndex = 25;
            this.lblChildNumber.Text = "Select Child Number:";
            this.lblChildNumber.Click += new System.EventHandler(this.lblChildNumber_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbmCNum);
            this.panel1.Controls.Add(this.lblDsplyName);
            this.panel1.Controls.Add(this.txtCondition);
            this.panel1.Controls.Add(this.cmbReason);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cbmSess);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 226);
            this.panel1.TabIndex = 32;
            // 
            // cbmCNum
            // 
            this.cbmCNum.FormattingEnabled = true;
            this.cbmCNum.Location = new System.Drawing.Point(12, 9);
            this.cbmCNum.Name = "cbmCNum";
            this.cbmCNum.Size = new System.Drawing.Size(121, 21);
            this.cbmCNum.TabIndex = 0;
            // 
            // lblDsplyName
            // 
            this.lblDsplyName.AutoSize = true;
            this.lblDsplyName.Location = new System.Drawing.Point(139, 17);
            this.lblDsplyName.Name = "lblDsplyName";
            this.lblDsplyName.Size = new System.Drawing.Size(0, 13);
            this.lblDsplyName.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(12, 54);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(121, 20);
            this.txtCondition.TabIndex = 3;
            // 
            // cmbReason
            // 
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(12, 100);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(121, 21);
            this.cmbReason.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(12, 148);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 8;
            // 
            // cbmSess
            // 
            this.cbmSess.FormattingEnabled = true;
            this.cbmSess.Location = new System.Drawing.Point(12, 198);
            this.cbmSess.Name = "cbmSess";
            this.cbmSess.Size = new System.Drawing.Size(121, 21);
            this.cbmSess.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbRefBy);
            this.panel2.Controls.Add(this.dtpDateRef);
            this.panel2.Controls.Add(this.dtpDateStart);
            this.panel2.Controls.Add(this.dtpDateEnd);
            this.panel2.Controls.Add(this.nudSess);
            this.panel2.Location = new System.Drawing.Point(667, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 226);
            this.panel2.TabIndex = 33;
            // 
            // cmbRefBy
            // 
            this.cmbRefBy.FormattingEnabled = true;
            this.cmbRefBy.Location = new System.Drawing.Point(12, 9);
            this.cmbRefBy.Name = "cmbRefBy";
            this.cmbRefBy.Size = new System.Drawing.Size(121, 21);
            this.cmbRefBy.TabIndex = 12;
            // 
            // dtpDateRef
            // 
            this.dtpDateRef.Location = new System.Drawing.Point(12, 55);
            this.dtpDateRef.Name = "dtpDateRef";
            this.dtpDateRef.Size = new System.Drawing.Size(200, 20);
            this.dtpDateRef.TabIndex = 13;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(12, 102);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(200, 20);
            this.dtpDateStart.TabIndex = 15;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(12, 150);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEnd.TabIndex = 16;
            // 
            // nudSess
            // 
            this.nudSess.Location = new System.Drawing.Point(12, 199);
            this.nudSess.Name = "nudSess";
            this.nudSess.Size = new System.Drawing.Size(120, 20);
            this.nudSess.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtxtDetails);
            this.panel3.Controls.Add(this.rtxtResult);
            this.panel3.Controls.Add(this.cmbReport);
            this.panel3.Controls.Add(this.cmbTherapist);
            this.panel3.Location = new System.Drawing.Point(239, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 226);
            this.panel3.TabIndex = 34;
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.Location = new System.Drawing.Point(15, 17);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.Size = new System.Drawing.Size(188, 57);
            this.rtxtDetails.TabIndex = 43;
            this.rtxtDetails.Text = "";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(15, 166);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(188, 53);
            this.rtxtResult.TabIndex = 42;
            this.rtxtResult.Text = "";
            // 
            // cmbReport
            // 
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Location = new System.Drawing.Point(15, 125);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(121, 21);
            this.cmbReport.TabIndex = 20;
            // 
            // cmbTherapist
            // 
            this.cmbTherapist.FormattingEnabled = true;
            this.cmbTherapist.Location = new System.Drawing.Point(15, 90);
            this.cmbTherapist.Name = "cmbTherapist";
            this.cmbTherapist.Size = new System.Drawing.Size(121, 21);
            this.cmbTherapist.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Select Number of Sessions:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Enter Details:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Select Therapist:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Select Report:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Enter Result:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnAddRef
            // 
            this.btnAddRef.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRef.BackgroundImage")));
            this.btnAddRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRef.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRef.Location = new System.Drawing.Point(10, 500);
            this.btnAddRef.Name = "btnAddRef";
            this.btnAddRef.Size = new System.Drawing.Size(75, 35);
            this.btnAddRef.TabIndex = 42;
            this.btnAddRef.UseVisualStyleBackColor = false;
            this.btnAddRef.Click += new System.EventHandler(this.btnAddRef_Click);
            // 
            // frmTherapyReferral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 543);
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
            this.Name = "frmTherapyReferral";
            this.Text = "Therapy Referral";
            this.Load += new System.EventHandler(this.frmTherapyReferral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSess)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbmCNum;
        private System.Windows.Forms.Label lblDsplyName;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cbmSess;
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
    }
}