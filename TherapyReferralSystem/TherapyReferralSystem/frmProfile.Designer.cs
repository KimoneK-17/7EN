namespace TherapyReferralSystem
{
    partial class frmProfile
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
            this.mnuProfile = new System.Windows.Forms.MenuStrip();
            this.mnuProfileFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtWorkID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mnuProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProfile
            // 
            this.mnuProfile.BackColor = System.Drawing.Color.DimGray;
            this.mnuProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuProfile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileFile,
            this.mnuProfileView,
            this.mnuProfileHelp});
            this.mnuProfile.Location = new System.Drawing.Point(0, 0);
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuProfile.Size = new System.Drawing.Size(600, 32);
            this.mnuProfile.TabIndex = 0;
            this.mnuProfile.Text = "MENU";
            // 
            // mnuProfileFile
            // 
            this.mnuProfileFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReturn,
            this.mnuProfileLogout});
            this.mnuProfileFile.ForeColor = System.Drawing.Color.White;
            this.mnuProfileFile.Name = "mnuProfileFile";
            this.mnuProfileFile.Size = new System.Drawing.Size(57, 28);
            this.mnuProfileFile.Text = "File";
            // 
            // mnuProfileReturn
            // 
            this.mnuProfileReturn.Name = "mnuProfileReturn";
            this.mnuProfileReturn.Size = new System.Drawing.Size(150, 28);
            this.mnuProfileReturn.Text = "Return";
            this.mnuProfileReturn.Click += new System.EventHandler(this.mnuProfileReturn_Click);
            // 
            // mnuProfileLogout
            // 
            this.mnuProfileLogout.Name = "mnuProfileLogout";
            this.mnuProfileLogout.Size = new System.Drawing.Size(150, 28);
            this.mnuProfileLogout.Text = "Logout";
            // 
            // mnuProfileView
            // 
            this.mnuProfileView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReports});
            this.mnuProfileView.ForeColor = System.Drawing.Color.White;
            this.mnuProfileView.Name = "mnuProfileView";
            this.mnuProfileView.Size = new System.Drawing.Size(68, 28);
            this.mnuProfileView.Text = "View";
            // 
            // mnuProfileReports
            // 
            this.mnuProfileReports.Name = "mnuProfileReports";
            this.mnuProfileReports.Size = new System.Drawing.Size(158, 28);
            this.mnuProfileReports.Text = "Reports";
            this.mnuProfileReports.Click += new System.EventHandler(this.mnuProfileReports_Click);
            // 
            // mnuProfileHelp
            // 
            this.mnuProfileHelp.ForeColor = System.Drawing.Color.White;
            this.mnuProfileHelp.Name = "mnuProfileHelp";
            this.mnuProfileHelp.Size = new System.Drawing.Size(66, 28);
            this.mnuProfileHelp.Text = "Help";
            this.mnuProfileHelp.Click += new System.EventHandler(this.mnuProfileHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(371, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 212);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Work ID ???";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 22);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "able to edit";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(175, 119);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(169, 22);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.Text = "able to edit";
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(175, 153);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 22);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.Text = "able to edit";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(175, 223);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(169, 22);
            this.txtPosition.TabIndex = 12;
            this.txtPosition.Text = "shouldnt be able to edit";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(175, 257);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 22);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "shouldnt be able to edit";
            // 
            // txtWorkID
            // 
            this.txtWorkID.Location = new System.Drawing.Point(175, 295);
            this.txtWorkID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkID.Name = "txtWorkID";
            this.txtWorkID.Size = new System.Drawing.Size(169, 22);
            this.txtWorkID.TabIndex = 14;
            this.txtWorkID.Text = "shouldnt be able to edit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "pic box";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 187);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 22);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "able to edit";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 351);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Change picture ???";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWorkID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuProfile);
            this.MainMenuStrip = this.mnuProfile;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProfile";
            this.Text = "User Profile";
            this.mnuProfile.ResumeLayout(false);
            this.mnuProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileFile;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtWorkID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileReports;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileHelp;
    }
}