namespace TherapyReferralSystem
{
    partial class frmPasswordRecovery
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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailUsername = new System.Windows.Forms.Label();
            this.mnuPassRecov = new System.Windows.Forms.MenuStrip();
            this.mnuPassRecovFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassRecovReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRequestReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnGetQuestion = new System.Windows.Forms.Button();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.mnuPassRecovHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassRecov.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(178, 52);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(251, 20);
            this.txtEmailAddress.TabIndex = 26;
            // 
            // lblEmailUsername
            // 
            this.lblEmailUsername.AutoSize = true;
            this.lblEmailUsername.BackColor = System.Drawing.Color.White;
            this.lblEmailUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailUsername.Location = new System.Drawing.Point(59, 53);
            this.lblEmailUsername.Name = "lblEmailUsername";
            this.lblEmailUsername.Size = new System.Drawing.Size(100, 18);
            this.lblEmailUsername.TabIndex = 25;
            this.lblEmailUsername.Text = "Email Address";
            // 
            // mnuPassRecov
            // 
            this.mnuPassRecov.BackColor = System.Drawing.Color.DimGray;
            this.mnuPassRecov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPassRecov.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPassRecov.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovFile,
            this.mnuPassRecovHelp});
            this.mnuPassRecov.Location = new System.Drawing.Point(0, 0);
            this.mnuPassRecov.Name = "mnuPassRecov";
            this.mnuPassRecov.Size = new System.Drawing.Size(518, 26);
            this.mnuPassRecov.TabIndex = 27;
            this.mnuPassRecov.Text = "MENU";
            // 
            // mnuPassRecovFile
            // 
            this.mnuPassRecovFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovReturn});
            this.mnuPassRecovFile.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovFile.Name = "mnuPassRecovFile";
            this.mnuPassRecovFile.Size = new System.Drawing.Size(47, 22);
            this.mnuPassRecovFile.Text = "File";
            // 
            // mnuPassRecovReturn
            // 
            this.mnuPassRecovReturn.Name = "mnuPassRecovReturn";
            this.mnuPassRecovReturn.Size = new System.Drawing.Size(152, 22);
            this.mnuPassRecovReturn.Text = "Return";
            this.mnuPassRecovReturn.Click += new System.EventHandler(this.mnuPassRecovReturn_Click);
            // 
            // btnRequestReset
            // 
            this.btnRequestReset.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Request_Reset_Button;
            this.btnRequestReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestReset.Location = new System.Drawing.Point(178, 369);
            this.btnRequestReset.Name = "btnRequestReset";
            this.btnRequestReset.Size = new System.Drawing.Size(92, 45);
            this.btnRequestReset.TabIndex = 35;
            this.btnRequestReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(17, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Don\'t have a security question or can\'t remember your answer?";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Submit_Answer_Button;
            this.btnSubmitAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswer.Location = new System.Drawing.Point(178, 260);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(92, 45);
            this.btnSubmitAnswer.TabIndex = 33;
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(178, 214);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(251, 20);
            this.txtAnswer.TabIndex = 32;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnswer.Location = new System.Drawing.Point(101, 216);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(58, 18);
            this.lblAnswer.TabIndex = 31;
            this.lblAnswer.Text = "Answer";
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Get_Question_Button;
            this.btnGetQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuestion.Location = new System.Drawing.Point(178, 132);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.Size = new System.Drawing.Size(92, 45);
            this.btnGetQuestion.TabIndex = 30;
            this.btnGetQuestion.UseVisualStyleBackColor = true;
            this.btnGetQuestion.Click += new System.EventHandler(this.btnGetQuestion_Click);
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Location = new System.Drawing.Point(178, 87);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(251, 20);
            this.txtSecurityQuestion.TabIndex = 29;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(31, 87);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(128, 18);
            this.lblSecurityQuestion.TabIndex = 28;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // mnuPassRecovHelp
            // 
            this.mnuPassRecovHelp.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovHelp.Name = "mnuPassRecovHelp";
            this.mnuPassRecovHelp.Size = new System.Drawing.Size(54, 22);
            this.mnuPassRecovHelp.Text = "Help";
            this.mnuPassRecovHelp.Click += new System.EventHandler(this.mnuPassRecovHelp_Click);
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Form_Texture;
            this.ClientSize = new System.Drawing.Size(518, 445);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailUsername);
            this.Controls.Add(this.mnuPassRecov);
            this.Controls.Add(this.btnRequestReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnGetQuestion);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPasswordRecovery";
            this.Text = "frmPasswordRecovery";
            this.mnuPassRecov.ResumeLayout(false);
            this.mnuPassRecov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailUsername;
        private System.Windows.Forms.MenuStrip mnuPassRecov;
        private System.Windows.Forms.ToolStripMenuItem mnuPassRecovFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPassRecovReturn;
        private System.Windows.Forms.Button btnRequestReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnGetQuestion;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.ToolStripMenuItem mnuPassRecovHelp;
    }
}