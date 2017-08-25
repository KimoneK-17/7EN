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
            this.lblEmailUsername = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnGetQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRequestReset = new System.Windows.Forms.Button();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmailUsername
            // 
            this.lblEmailUsername.AutoSize = true;
            this.lblEmailUsername.BackColor = System.Drawing.Color.White;
            this.lblEmailUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailUsername.Location = new System.Drawing.Point(59, 52);
            this.lblEmailUsername.Name = "lblEmailUsername";
            this.lblEmailUsername.Size = new System.Drawing.Size(100, 18);
            this.lblEmailUsername.TabIndex = 10;
            this.lblEmailUsername.Text = "Email Address";
            this.lblEmailUsername.Click += new System.EventHandler(this.lblEmailUsername_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(178, 51);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(251, 20);
            this.txtEmailAddress.TabIndex = 11;
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.DimGray;
            this.MENU.Font = new System.Drawing.Font("Myriad Pro Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(465, 26);
            this.MENU.TabIndex = 16;
            this.MENU.Text = "MENU";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(31, 86);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(128, 18);
            this.lblSecurityQuestion.TabIndex = 17;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Location = new System.Drawing.Point(178, 86);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(251, 20);
            this.txtSecurityQuestion.TabIndex = 18;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnswer.Location = new System.Drawing.Point(101, 215);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(58, 18);
            this.lblAnswer.TabIndex = 20;
            this.lblAnswer.Text = "Answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(178, 214);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(251, 20);
            this.txtAnswer.TabIndex = 21;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Submit_Answer_Button;
            this.btnSubmitAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswer.Location = new System.Drawing.Point(178, 259);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(92, 45);
            this.btnSubmitAnswer.TabIndex = 22;
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Get_Question_Button;
            this.btnGetQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuestion.Location = new System.Drawing.Point(178, 132);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.Size = new System.Drawing.Size(92, 45);
            this.btnGetQuestion.TabIndex = 19;
            this.btnGetQuestion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(17, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Don\'t have a security question or can\'t remember your answer?";
            // 
            // btnRequestReset
            // 
            this.btnRequestReset.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Request_Reset_Button;
            this.btnRequestReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestReset.Location = new System.Drawing.Point(178, 368);
            this.btnRequestReset.Name = "btnRequestReset";
            this.btnRequestReset.Size = new System.Drawing.Size(92, 45);
            this.btnRequestReset.TabIndex = 24;
            this.btnRequestReset.UseVisualStyleBackColor = true;
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(465, 438);
            this.Controls.Add(this.btnRequestReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnGetQuestion);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailUsername);
            this.Controls.Add(this.MENU);
            this.MainMenuStrip = this.MENU;
            this.Name = "frmPasswordRecovery";
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.frmPasswordRecovery_Load);
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmailUsername;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Button btnGetQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequestReset;
    }
}