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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblOTP.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTP.Location = new System.Drawing.Point(12, 125);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(189, 20);
            this.lblOTP.TabIndex = 0;
            this.lblOTP.Text = "OTP/Old Password: ";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(190, 116);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(307, 29);
            this.txtOTP.TabIndex = 1;
            // 
            // lblNewPword
            // 
            this.lblNewPword.AutoSize = true;
            this.lblNewPword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPword.Location = new System.Drawing.Point(12, 162);
            this.lblNewPword.Name = "lblNewPword";
            this.lblNewPword.Size = new System.Drawing.Size(149, 20);
            this.lblNewPword.TabIndex = 2;
            this.lblNewPword.Text = "New Password: ";
            // 
            // txtNPword
            // 
            this.txtNPword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPword.Location = new System.Drawing.Point(190, 153);
            this.txtNPword.Name = "txtNPword";
            this.txtNPword.Size = new System.Drawing.Size(307, 29);
            this.txtNPword.TabIndex = 3;
            // 
            // btnChangePword
            // 
            this.btnChangePword.BackColor = System.Drawing.Color.Snow;
            this.btnChangePword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePword.Location = new System.Drawing.Point(304, 238);
            this.btnChangePword.Name = "btnChangePword";
            this.btnChangePword.Size = new System.Drawing.Size(192, 28);
            this.btnChangePword.TabIndex = 4;
            this.btnChangePword.Text = "Change Password";
            this.btnChangePword.UseVisualStyleBackColor = false;
            this.btnChangePword.Click += new System.EventHandler(this.btnChangePword_Click);
            // 
            // lblConPWord
            // 
            this.lblConPWord.AutoSize = true;
            this.lblConPWord.BackColor = System.Drawing.Color.Transparent;
            this.lblConPWord.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPWord.Location = new System.Drawing.Point(12, 199);
            this.lblConPWord.Name = "lblConPWord";
            this.lblConPWord.Size = new System.Drawing.Size(179, 20);
            this.lblConPWord.TabIndex = 5;
            this.lblConPWord.Text = "Confirm Password: ";
            // 
            // txtConPword
            // 
            this.txtConPword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPword.Location = new System.Drawing.Point(190, 190);
            this.txtConPword.Name = "txtConPword";
            this.txtConPword.Size = new System.Drawing.Size(307, 29);
            this.txtConPword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(159, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(190, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.BackColor = System.Drawing.Color.Transparent;
            this.lblREmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREmail.ForeColor = System.Drawing.Color.Red;
            this.lblREmail.Location = new System.Drawing.Point(503, 82);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(19, 20);
            this.lblREmail.TabIndex = 9;
            this.lblREmail.Text = "*";
            // 
            // lblROTP
            // 
            this.lblROTP.AutoSize = true;
            this.lblROTP.BackColor = System.Drawing.Color.Transparent;
            this.lblROTP.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROTP.ForeColor = System.Drawing.Color.Red;
            this.lblROTP.Location = new System.Drawing.Point(503, 118);
            this.lblROTP.Name = "lblROTP";
            this.lblROTP.Size = new System.Drawing.Size(19, 20);
            this.lblROTP.TabIndex = 10;
            this.lblROTP.Text = "*";
            // 
            // lblRNPword
            // 
            this.lblRNPword.AutoSize = true;
            this.lblRNPword.BackColor = System.Drawing.Color.Transparent;
            this.lblRNPword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNPword.ForeColor = System.Drawing.Color.Red;
            this.lblRNPword.Location = new System.Drawing.Point(503, 154);
            this.lblRNPword.Name = "lblRNPword";
            this.lblRNPword.Size = new System.Drawing.Size(19, 20);
            this.lblRNPword.TabIndex = 11;
            this.lblRNPword.Text = "*";
            // 
            // lblRCPword
            // 
            this.lblRCPword.AutoSize = true;
            this.lblRCPword.BackColor = System.Drawing.Color.Transparent;
            this.lblRCPword.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRCPword.ForeColor = System.Drawing.Color.Red;
            this.lblRCPword.Location = new System.Drawing.Point(503, 190);
            this.lblRCPword.Name = "lblRCPword";
            this.lblRCPword.Size = new System.Drawing.Size(19, 20);
            this.lblRCPword.TabIndex = 12;
            this.lblRCPword.Text = "*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToLoginToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToLoginToolStripMenuItem
            // 
            this.backToLoginToolStripMenuItem.Name = "backToLoginToolStripMenuItem";
            this.backToLoginToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.backToLoginToolStripMenuItem.Text = "Back To Login";
            this.backToLoginToolStripMenuItem.Click += new System.EventHandler(this.backToLoginToolStripMenuItem_Click);
            // 
            // frmUserPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.therapyback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.ControlBox = false;
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
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserPasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.Load += new System.EventHandler(this.frmUserPasswordReset_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToLoginToolStripMenuItem;
    }
}