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
            this.mnuProfileView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.picbxProfilePic = new System.Windows.Forms.PictureBox();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnuProfileForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileTherRef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProfile
            // 
            this.mnuProfile.BackColor = System.Drawing.Color.DimGray;
            this.mnuProfile.Font = new System.Drawing.Font("Myriad Pro Light", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileFile,
            this.mnuProfileView,
            this.mnuProfileHelp,
            this.mnuProfileForm});
            this.mnuProfile.Location = new System.Drawing.Point(0, 0);
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(450, 26);
            this.mnuProfile.TabIndex = 0;
            this.mnuProfile.Text = "MENU";
            // 
            // mnuProfileFile
            // 
            this.mnuProfileFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReturn});
            this.mnuProfileFile.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuProfileFile.ForeColor = System.Drawing.Color.White;
            this.mnuProfileFile.Name = "mnuProfileFile";
            this.mnuProfileFile.Size = new System.Drawing.Size(44, 22);
            this.mnuProfileFile.Text = "File";
            // 
            // mnuProfileReturn
            // 
            this.mnuProfileReturn.Name = "mnuProfileReturn";
<<<<<<< HEAD
            this.mnuProfileReturn.Size = new System.Drawing.Size(152, 22);
=======
            this.mnuProfileReturn.Size = new System.Drawing.Size(121, 22);
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
            this.mnuProfileReturn.Text = "Return";
            this.mnuProfileReturn.Click += new System.EventHandler(this.mnuProfileReturn_Click);
            // 
            // mnuProfileView
            // 
            this.mnuProfileView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReports});
            this.mnuProfileView.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuProfileView.ForeColor = System.Drawing.Color.White;
            this.mnuProfileView.Name = "mnuProfileView";
            this.mnuProfileView.Size = new System.Drawing.Size(52, 22);
            this.mnuProfileView.Text = "View";
            // 
            // mnuProfileReports
            // 
            this.mnuProfileReports.Name = "mnuProfileReports";
<<<<<<< HEAD
            this.mnuProfileReports.Size = new System.Drawing.Size(152, 22);
=======
            this.mnuProfileReports.Size = new System.Drawing.Size(126, 22);
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
            this.mnuProfileReports.Text = "Reports";
            this.mnuProfileReports.Click += new System.EventHandler(this.mnuProfileReports_Click);
            // 
            // mnuProfileHelp
            // 
            this.mnuProfileHelp.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuProfileHelp.ForeColor = System.Drawing.Color.White;
            this.mnuProfileHelp.Name = "mnuProfileHelp";
<<<<<<< HEAD
            this.mnuProfileHelp.Size = new System.Drawing.Size(52, 22);
=======
            this.mnuProfileHelp.Size = new System.Drawing.Size(51, 22);
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
            this.mnuProfileHelp.Text = "Help";
            this.mnuProfileHelp.Click += new System.EventHandler(this.mnuProfileHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // picbxProfilePic
            // 
            this.picbxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxProfilePic.Location = new System.Drawing.Point(278, 70);
            this.picbxProfilePic.Name = "picbxProfilePic";
            this.picbxProfilePic.Size = new System.Drawing.Size(133, 173);
            this.picbxProfilePic.TabIndex = 2;
            this.picbxProfilePic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Work ID ???";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "able to edit";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(131, 97);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(128, 20);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.Text = "able to edit";
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(131, 124);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.Text = "able to edit";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(131, 181);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(128, 20);
            this.txtPosition.TabIndex = 12;
            this.txtPosition.Text = "shouldnt be able to edit";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 209);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "shouldnt be able to edit";
            // 
            // txtWorkID
            // 
            this.txtWorkID.Location = new System.Drawing.Point(131, 240);
            this.txtWorkID.Name = "txtWorkID";
            this.txtWorkID.Size = new System.Drawing.Size(128, 20);
            this.txtWorkID.TabIndex = 14;
            this.txtWorkID.Text = "shouldnt be able to edit";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(28, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "pic box";
            // 
            // btnChangePic
            // 
            this.btnChangePic.Location = new System.Drawing.Point(299, 259);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(112, 23);
            this.btnChangePic.TabIndex = 19;
            this.btnChangePic.Text = "Change picture ";
            this.btnChangePic.UseVisualStyleBackColor = true;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mnuProfileForm
            // 
            this.mnuProfileForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileTherRef,
            this.mnuProfileRegChild,
            this.mnuProfileRegUser});
            this.mnuProfileForm.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mnuProfileForm.ForeColor = System.Drawing.Color.White;
            this.mnuProfileForm.Name = "mnuProfileForm";
            this.mnuProfileForm.Size = new System.Drawing.Size(60, 22);
            this.mnuProfileForm.Text = "Form";
            // 
            // mnuProfileTherRef
            // 
            this.mnuProfileTherRef.Name = "mnuProfileTherRef";
            this.mnuProfileTherRef.Size = new System.Drawing.Size(198, 22);
            this.mnuProfileTherRef.Text = "Therapy Referral";
            this.mnuProfileTherRef.Click += new System.EventHandler(this.mnuProfileTherRef_Click);
            // 
            // mnuProfileRegChild
            // 
            this.mnuProfileRegChild.Name = "mnuProfileRegChild";
            this.mnuProfileRegChild.Size = new System.Drawing.Size(198, 22);
            this.mnuProfileRegChild.Text = "Register Child";
            this.mnuProfileRegChild.Click += new System.EventHandler(this.mnuProfileRegChild_Click);
            // 
            // mnuProfileRegUser
            // 
            this.mnuProfileRegUser.Name = "mnuProfileRegUser";
            this.mnuProfileRegUser.Size = new System.Drawing.Size(198, 22);
            this.mnuProfileRegUser.Text = "Register User";
            this.mnuProfileRegUser.Click += new System.EventHandler(this.mnuProfileRegUser_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Form_Texture;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.picbxProfilePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuProfile);
            this.MainMenuStrip = this.mnuProfile;
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.mnuProfile.ResumeLayout(false);
            this.mnuProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileFile;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbxProfilePic;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileReports;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileForm;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileTherRef;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileRegChild;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileRegUser;
    }
}