namespace TherapyReferralSystem
{
    partial class frmUserPasswordReset
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
            this.lblOTP = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.lblNewPword = new System.Windows.Forms.Label();
            this.txtNPword = new System.Windows.Forms.TextBox();
            this.btnChangePword = new System.Windows.Forms.Button();
            this.lblConPWord = new System.Windows.Forms.Label();
            this.txtConPword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblREmail = new System.Windows.Forms.Label();
            this.lblROTP = new System.Windows.Forms.Label();
            this.lblRNPword = new System.Windows.Forms.Label();
            this.lblRCPword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.Location = new System.Drawing.Point(28, 64);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(45, 17);
            this.lblOTP.TabIndex = 0;
            this.lblOTP.Text = "OTP: ";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(163, 64);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(197, 22);
            this.txtOTP.TabIndex = 1;
            // 
            // lblNewPword
            // 
            this.lblNewPword.AutoSize = true;
            this.lblNewPword.Location = new System.Drawing.Point(28, 104);
            this.lblNewPword.Name = "lblNewPword";
            this.lblNewPword.Size = new System.Drawing.Size(108, 17);
            this.lblNewPword.TabIndex = 2;
            this.lblNewPword.Text = "New Password: ";
            // 
            // txtNPword
            // 
            this.txtNPword.Location = new System.Drawing.Point(163, 104);
            this.txtNPword.Name = "txtNPword";
            this.txtNPword.Size = new System.Drawing.Size(197, 22);
            this.txtNPword.TabIndex = 3;
            // 
            // btnChangePword
            // 
            this.btnChangePword.Location = new System.Drawing.Point(85, 197);
            this.btnChangePword.Name = "btnChangePword";
            this.btnChangePword.Size = new System.Drawing.Size(87, 28);
            this.btnChangePword.TabIndex = 4;
            this.btnChangePword.Text = "Change Password";
            this.btnChangePword.UseVisualStyleBackColor = true;
            this.btnChangePword.Click += new System.EventHandler(this.btnChangePword_Click);
            // 
            // lblConPWord
            // 
            this.lblConPWord.AutoSize = true;
            this.lblConPWord.Location = new System.Drawing.Point(28, 147);
            this.lblConPWord.Name = "lblConPWord";
            this.lblConPWord.Size = new System.Drawing.Size(129, 17);
            this.lblConPWord.TabIndex = 5;
            this.lblConPWord.Text = "Confirm Password: ";
            // 
            // txtConPword
            // 
            this.txtConPword.Location = new System.Drawing.Point(163, 147);
            this.txtConPword.Name = "txtConPword";
            this.txtConPword.Size = new System.Drawing.Size(197, 22);
            this.txtConPword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.ForeColor = System.Drawing.Color.Red;
            this.lblREmail.Location = new System.Drawing.Point(366, 40);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(13, 17);
            this.lblREmail.TabIndex = 9;
            this.lblREmail.Text = "*";
            // 
            // lblROTP
            // 
            this.lblROTP.AutoSize = true;
            this.lblROTP.ForeColor = System.Drawing.Color.Red;
            this.lblROTP.Location = new System.Drawing.Point(366, 76);
            this.lblROTP.Name = "lblROTP";
            this.lblROTP.Size = new System.Drawing.Size(13, 17);
            this.lblROTP.TabIndex = 10;
            this.lblROTP.Text = "*";
            // 
            // lblRNPword
            // 
            this.lblRNPword.AutoSize = true;
            this.lblRNPword.ForeColor = System.Drawing.Color.Red;
            this.lblRNPword.Location = new System.Drawing.Point(366, 114);
            this.lblRNPword.Name = "lblRNPword";
            this.lblRNPword.Size = new System.Drawing.Size(13, 17);
            this.lblRNPword.TabIndex = 11;
            this.lblRNPword.Text = "*";
            // 
            // lblRCPword
            // 
            this.lblRCPword.AutoSize = true;
            this.lblRCPword.ForeColor = System.Drawing.Color.Red;
            this.lblRCPword.Location = new System.Drawing.Point(366, 149);
            this.lblRCPword.Name = "lblRCPword";
            this.lblRCPword.Size = new System.Drawing.Size(13, 17);
            this.lblRCPword.TabIndex = 12;
            this.lblRCPword.Text = "*";
            // 
            // frmUserPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 253);
            this.Controls.Add(this.lblRCPword);
            this.Controls.Add(this.lblRNPword);
            this.Controls.Add(this.lblROTP);
            this.Controls.Add(this.lblREmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtConPword);
            this.Controls.Add(this.lblConPWord);
            this.Controls.Add(this.btnChangePword);
            this.Controls.Add(this.txtNPword);
            this.Controls.Add(this.lblNewPword);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lblOTP);
            this.Name = "frmUserPasswordReset";
            this.Text = "frmUserPasswordReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lblNewPword;
        private System.Windows.Forms.TextBox txtNPword;
        private System.Windows.Forms.Button btnChangePword;
        private System.Windows.Forms.Label lblConPWord;
        private System.Windows.Forms.TextBox txtConPword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblREmail;
        private System.Windows.Forms.Label lblROTP;
        private System.Windows.Forms.Label lblRNPword;
        private System.Windows.Forms.Label lblRCPword;
    }
}