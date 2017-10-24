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
            this.mnuPassRecovHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRequestReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnGetQuestion = new System.Windows.Forms.Button();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.mnuPassRecov.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(237, 64);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(333, 22);
            this.txtEmailAddress.TabIndex = 26;
            // 
            // lblEmailUsername
            // 
            this.lblEmailUsername.AutoSize = true;
            this.lblEmailUsername.BackColor = System.Drawing.Color.White;
            this.lblEmailUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailUsername.Location = new System.Drawing.Point(79, 65);
            this.lblEmailUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailUsername.Name = "lblEmailUsername";
            this.lblEmailUsername.Size = new System.Drawing.Size(134, 22);
            this.lblEmailUsername.TabIndex = 25;
            this.lblEmailUsername.Text = "Email Address";
            // 
            // mnuPassRecov
            // 
            this.mnuPassRecov.BackColor = System.Drawing.Color.LightSlateGray;
            this.mnuPassRecov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPassRecov.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPassRecov.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovFile,
            this.mnuPassRecovHelp});
            this.mnuPassRecov.Location = new System.Drawing.Point(0, 0);
            this.mnuPassRecov.Name = "mnuPassRecov";
            this.mnuPassRecov.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuPassRecov.Size = new System.Drawing.Size(691, 32);
            this.mnuPassRecov.TabIndex = 27;
            this.mnuPassRecov.Text = "MENU";
            // 
            // mnuPassRecovFile
            // 
            this.mnuPassRecovFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovReturn});
            this.mnuPassRecovFile.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovFile.Name = "mnuPassRecovFile";
            this.mnuPassRecovFile.Size = new System.Drawing.Size(57, 28);
            this.mnuPassRecovFile.Text = "File";
            // 
            // mnuPassRecovReturn
            // 
            this.mnuPassRecovReturn.Name = "mnuPassRecovReturn";
            this.mnuPassRecovReturn.Size = new System.Drawing.Size(148, 28);
            this.mnuPassRecovReturn.Text = "Return";
            this.mnuPassRecovReturn.Click += new System.EventHandler(this.mnuPassRecovReturn_Click);
            // 
            // mnuPassRecovHelp
            // 
            this.mnuPassRecovHelp.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovHelp.Name = "mnuPassRecovHelp";
            this.mnuPassRecovHelp.Size = new System.Drawing.Size(66, 28);
            this.mnuPassRecovHelp.Text = "Help";
            this.mnuPassRecovHelp.Click += new System.EventHandler(this.mnuPassRecovHelp_Click);
            // 
            // btnRequestReset
            // 
            this.btnRequestReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnRequestReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestReset.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestReset.Location = new System.Drawing.Point(237, 454);
            this.btnRequestReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequestReset.Name = "btnRequestReset";
            this.btnRequestReset.Size = new System.Drawing.Size(199, 55);
            this.btnRequestReset.TabIndex = 35;
            this.btnRequestReset.Text = "REQUEST RESET";
<<<<<<< HEAD
            this.btnRequestReset.UseVisualStyleBackColor = false;
=======
            this.btnRequestReset.UseVisualStyleBackColor = true;
            this.btnRequestReset.Click += new System.EventHandler(this.btnRequestReset_Click);
>>>>>>> 14bb39d17ea2337d0586df1db6f7413fb5a931fb
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(23, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Don\'t have a security question or can\'t remember your answer?";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmitAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(237, 320);
            this.btnSubmitAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(199, 55);
            this.btnSubmitAnswer.TabIndex = 33;
            this.btnSubmitAnswer.Text = "SUBMIT ANSWER";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(237, 263);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(333, 22);
            this.txtAnswer.TabIndex = 32;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnswer.Location = new System.Drawing.Point(135, 266);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(74, 22);
            this.lblAnswer.TabIndex = 31;
            this.lblAnswer.Text = "Answer";
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuestion.Location = new System.Drawing.Point(237, 162);
            this.btnGetQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.Size = new System.Drawing.Size(199, 55);
            this.btnGetQuestion.TabIndex = 30;
            this.btnGetQuestion.Text = "GET QUESTION";
            this.btnGetQuestion.UseVisualStyleBackColor = false;
            this.btnGetQuestion.Click += new System.EventHandler(this.btnGetQuestion_Click);
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Location = new System.Drawing.Point(237, 107);
            this.txtSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(333, 22);
            this.txtSecurityQuestion.TabIndex = 29;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(41, 107);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(164, 22);
            this.lblSecurityQuestion.TabIndex = 28;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.FormTexture;
            this.ClientSize = new System.Drawing.Size(518, 445);
=======
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Form_Texture;
            this.ClientSize = new System.Drawing.Size(691, 548);
>>>>>>> 14bb39d17ea2337d0586df1db6f7413fb5a931fb
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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