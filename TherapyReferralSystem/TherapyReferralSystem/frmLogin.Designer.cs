﻿namespace TherapyReferralSystem
{
    partial class frmLogin1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.mnuLogin = new System.Windows.Forms.MenuStrip();
            this.mnuLoginFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoginLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoginHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewPword = new System.Windows.Forms.Button();
            this.mnuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Location = new System.Drawing.Point(80, 79);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(159, 29);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(75, 133);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(164, 29);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(263, 82);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(275, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(263, 138);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(275, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(328, 201);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.Location = new System.Drawing.Point(531, 207);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(179, 23);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Forgot Password?";
            // 
            // mnuLogin
            // 
            this.mnuLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.mnuLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoginFile,
            this.mnuLoginHelp});
            this.mnuLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuLogin.Size = new System.Drawing.Size(743, 32);
            this.mnuLogin.TabIndex = 28;
            this.mnuLogin.Text = "MENU";
            // 
            // mnuLoginFile
            // 
            this.mnuLoginFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoginLogout});
            this.mnuLoginFile.ForeColor = System.Drawing.Color.White;
            this.mnuLoginFile.Name = "mnuLoginFile";
            this.mnuLoginFile.Size = new System.Drawing.Size(57, 28);
            this.mnuLoginFile.Text = "File";
            // 
            // mnuLoginLogout
            // 
            this.mnuLoginLogout.Name = "mnuLoginLogout";
            this.mnuLoginLogout.Size = new System.Drawing.Size(181, 28);
            this.mnuLoginLogout.Text = "Logout";
            this.mnuLoginLogout.Click += new System.EventHandler(this.mnuLoginLogout_Click);
            // 
            // mnuLoginHelp
            // 
            this.mnuLoginHelp.ForeColor = System.Drawing.Color.White;
            this.mnuLoginHelp.Name = "mnuLoginHelp";
            this.mnuLoginHelp.Size = new System.Drawing.Size(66, 28);
            this.mnuLoginHelp.Text = "Help";
            this.mnuLoginHelp.Click += new System.EventHandler(this.mnuLoginHelp_Click);
            // 
            // btnViewPword
            // 
            this.btnViewPword.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.eye;
            this.btnViewPword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPword.Location = new System.Drawing.Point(545, 136);
            this.btnViewPword.Name = "btnViewPword";
            this.btnViewPword.Size = new System.Drawing.Size(29, 27);
            this.btnViewPword.TabIndex = 29;
            this.btnViewPword.UseVisualStyleBackColor = true;
            this.btnViewPword.Click += new System.EventHandler(this.btnViewPword_Click);
            // 
            // frmLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.FormTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(743, 297);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewPword);
            this.Controls.Add(this.mnuLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin1_Load);
            this.mnuLogin.ResumeLayout(false);
            this.mnuLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.MenuStrip mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLoginFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLoginLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuLoginHelp;
        private System.Windows.Forms.Button btnViewPword;
    }
}