﻿namespace TherapyReferralSystem
{
    partial class frmAdminPWordReset
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.mnuAdminPR = new System.Windows.Forms.MenuStrip();
            this.mnuAdminPRFile = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdminPRReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdminPRHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblR = new System.Windows.Forms.Label();
            this.lblREmail = new System.Windows.Forms.Label();
            this.mnuAdminPR.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(219, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "USER EMAIL ADDRESS:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(247, 62);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 30);
            this.txtEmail.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Snow;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(234, 143);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mnuAdminPR
            // 
            this.mnuAdminPR.BackColor = System.Drawing.Color.Teal;
            this.mnuAdminPR.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdminPR.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdminPR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdminPRFile,
            this.mnuAdminPRHelp});
            this.mnuAdminPR.Location = new System.Drawing.Point(0, 0);
            this.mnuAdminPR.Name = "mnuAdminPR";
            this.mnuAdminPR.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuAdminPR.Size = new System.Drawing.Size(558, 28);
            this.mnuAdminPR.TabIndex = 4;
            this.mnuAdminPR.Text = "MENU";
            // 
            // mnuAdminPRFile
            // 
            this.mnuAdminPRFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuAdminPRReturn});
            this.mnuAdminPRFile.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdminPRFile.ForeColor = System.Drawing.Color.White;
            this.mnuAdminPRFile.Name = "mnuAdminPRFile";
            this.mnuAdminPRFile.Size = new System.Drawing.Size(61, 24);
            this.mnuAdminPRFile.Text = "File";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuAdminPRReturn
            // 
            this.mnuAdminPRReturn.Name = "mnuAdminPRReturn";
            this.mnuAdminPRReturn.Size = new System.Drawing.Size(174, 26);
            this.mnuAdminPRReturn.Text = "Logout";
            this.mnuAdminPRReturn.Click += new System.EventHandler(this.mnuAdminPRReturn_Click);
            // 
            // mnuAdminPRHelp
            // 
            this.mnuAdminPRHelp.Font = new System.Drawing.Font("Verily Serif Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdminPRHelp.ForeColor = System.Drawing.Color.White;
            this.mnuAdminPRHelp.Name = "mnuAdminPRHelp";
            this.mnuAdminPRHelp.Size = new System.Drawing.Size(61, 24);
            this.mnuAdminPRHelp.Text = "Help";
            this.mnuAdminPRHelp.Click += new System.EventHandler(this.mnuAdminPRHelp_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.Location = new System.Drawing.Point(529, 70);
            this.lblR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(21, 22);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "*";
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.Font = new System.Drawing.Font("Verily Serif Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREmail.ForeColor = System.Drawing.Color.Red;
            this.lblREmail.Location = new System.Drawing.Point(21, 107);
            this.lblREmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(0, 22);
            this.lblREmail.TabIndex = 5;
            // 
            // frmAdminPWordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.UserPasswordReset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.ControlBox = false;
            this.Controls.Add(this.mnuAdminPR);
            this.Controls.Add(this.lblREmail);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Verily Serif Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmAdminPWordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Password Reset";
            this.mnuAdminPR.ResumeLayout(false);
            this.mnuAdminPR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReset;
 
        private System.Windows.Forms.MenuStrip mnuAdminPR;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminPRFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminPRReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminPRHelp;
 
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblREmail;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}