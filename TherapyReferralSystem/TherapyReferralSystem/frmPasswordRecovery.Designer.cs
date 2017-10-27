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
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(225, 64);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(333, 27);
            this.txtEmailAddress.TabIndex = 26;
            // 
            // lblEmailUsername
            // 
            this.lblEmailUsername.AutoSize = true;
            this.lblEmailUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsername.ForeColor = System.Drawing.Color.Black;
            this.lblEmailUsername.Location = new System.Drawing.Point(16, 65);
            this.lblEmailUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailUsername.Name = "lblEmailUsername";
            this.lblEmailUsername.Size = new System.Drawing.Size(151, 20);
            this.lblEmailUsername.TabIndex = 25;
            this.lblEmailUsername.Text = "EMAIL ADDRESS:";
            // 
            // mnuPassRecov
            // 
            this.mnuPassRecov.BackColor = System.Drawing.Color.Teal;
            this.mnuPassRecov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPassRecov.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPassRecov.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovFile,
            this.mnuPassRecovHelp});
            this.mnuPassRecov.Location = new System.Drawing.Point(0, 0);
            this.mnuPassRecov.Name = "mnuPassRecov";
            this.mnuPassRecov.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuPassRecov.Size = new System.Drawing.Size(741, 28);
            this.mnuPassRecov.TabIndex = 27;
            this.mnuPassRecov.Text = "MENU";
            // 
            // mnuPassRecovFile
            // 
            this.mnuPassRecovFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPassRecovReturn});
            this.mnuPassRecovFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPassRecovFile.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovFile.Name = "mnuPassRecovFile";
            this.mnuPassRecovFile.Size = new System.Drawing.Size(48, 24);
            this.mnuPassRecovFile.Text = "File";
            // 
            // mnuPassRecovReturn
            // 
            this.mnuPassRecovReturn.Name = "mnuPassRecovReturn";
            this.mnuPassRecovReturn.Size = new System.Drawing.Size(134, 26);
            this.mnuPassRecovReturn.Text = "Return";
            this.mnuPassRecovReturn.Click += new System.EventHandler(this.mnuPassRecovReturn_Click);
            // 
            // mnuPassRecovHelp
            // 
            this.mnuPassRecovHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPassRecovHelp.ForeColor = System.Drawing.Color.White;
            this.mnuPassRecovHelp.Name = "mnuPassRecovHelp";
            this.mnuPassRecovHelp.Size = new System.Drawing.Size(56, 24);
            this.mnuPassRecovHelp.Text = "Help";
            this.mnuPassRecovHelp.Click += new System.EventHandler(this.mnuPassRecovHelp_Click);
            // 
            // btnRequestReset
            // 
            this.btnRequestReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnRequestReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestReset.Location = new System.Drawing.Point(300, 241);
            this.btnRequestReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequestReset.Name = "btnRequestReset";
            this.btnRequestReset.Size = new System.Drawing.Size(151, 31);
            this.btnRequestReset.TabIndex = 35;
            this.btnRequestReset.Text = "REQUEST RESET";
            this.btnRequestReset.UseVisualStyleBackColor = true;
            this.btnRequestReset.Click += new System.EventHandler(this.btnRequestReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Don\'t have a security question or can\'t remember your answer?";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmitAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(575, 142);
            this.btnSubmitAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(151, 27);
            this.btnSubmitAnswer.TabIndex = 33;
            this.btnSubmitAnswer.Text = "SUBMIT ANSWER";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(225, 142);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(333, 27);
            this.txtAnswer.TabIndex = 32;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(16, 149);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(87, 20);
            this.lblAnswer.TabIndex = 31;
            this.lblAnswer.Text = "ANSWER:";
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuestion.Location = new System.Drawing.Point(575, 107);
            this.btnGetQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.Size = new System.Drawing.Size(151, 27);
            this.btnGetQuestion.TabIndex = 30;
            this.btnGetQuestion.Text = "GET QUESTION";
            this.btnGetQuestion.UseVisualStyleBackColor = false;
            this.btnGetQuestion.Click += new System.EventHandler(this.btnGetQuestion_Click);
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQuestion.Location = new System.Drawing.Point(225, 103);
            this.txtSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(333, 27);
            this.txtSecurityQuestion.TabIndex = 29;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(16, 107);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(187, 20);
            this.lblSecurityQuestion.TabIndex = 28;
            this.lblSecurityQuestion.Text = "SECURITY QUESTION:";
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.PasswordRec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 294);
            this.ControlBox = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPasswordRecovery";
            this.Load += new System.EventHandler(this.frmPasswordRecovery_Load);
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