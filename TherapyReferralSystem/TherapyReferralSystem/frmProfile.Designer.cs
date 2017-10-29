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
            this.mnuProfileForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileTherRef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileRegChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picbxProfilePic = new System.Windows.Forms.PictureBox();
            this.mnuProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProfile
            // 
            this.mnuProfile.BackColor = System.Drawing.Color.Teal;
            this.mnuProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnuProfile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileFile,
            this.mnuProfileView,
            this.mnuProfileHelp,
            this.mnuProfileForm});
            this.mnuProfile.Location = new System.Drawing.Point(0, 0);
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuProfile.Size = new System.Drawing.Size(600, 28);
            this.mnuProfile.TabIndex = 0;
            this.mnuProfile.Text = "MENU";
            // 
            // mnuProfileFile
            // 
            this.mnuProfileFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReturn});
            this.mnuProfileFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProfileFile.ForeColor = System.Drawing.Color.White;
            this.mnuProfileFile.Name = "mnuProfileFile";
            this.mnuProfileFile.Size = new System.Drawing.Size(48, 24);
            this.mnuProfileFile.Text = "File";
            // 
            // mnuProfileReturn
            // 
            this.mnuProfileReturn.Name = "mnuProfileReturn";
            this.mnuProfileReturn.Size = new System.Drawing.Size(134, 26);
            this.mnuProfileReturn.Text = "Return";
            this.mnuProfileReturn.Click += new System.EventHandler(this.mnuProfileReturn_Click);
            // 
            // mnuProfileView
            // 
            this.mnuProfileView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileReports});
            this.mnuProfileView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProfileView.ForeColor = System.Drawing.Color.White;
            this.mnuProfileView.Name = "mnuProfileView";
            this.mnuProfileView.Size = new System.Drawing.Size(57, 24);
            this.mnuProfileView.Text = "View";
            // 
            // mnuProfileReports
            // 
            this.mnuProfileReports.Name = "mnuProfileReports";
            this.mnuProfileReports.Size = new System.Drawing.Size(143, 26);
            this.mnuProfileReports.Text = "Reports";
            this.mnuProfileReports.Click += new System.EventHandler(this.mnuProfileReports_Click);
            // 
            // mnuProfileHelp
            // 
            this.mnuProfileHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProfileHelp.ForeColor = System.Drawing.Color.White;
            this.mnuProfileHelp.Name = "mnuProfileHelp";
            this.mnuProfileHelp.Size = new System.Drawing.Size(56, 24);
            this.mnuProfileHelp.Text = "Help";
            this.mnuProfileHelp.Click += new System.EventHandler(this.mnuProfileHelp_Click);
            // 
            // mnuProfileForm
            // 
            this.mnuProfileForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfileTherRef,
            this.mnuProfileRegChild,
            this.mnuProfileRegUser});
            this.mnuProfileForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProfileForm.ForeColor = System.Drawing.Color.White;
            this.mnuProfileForm.Name = "mnuProfileForm";
            this.mnuProfileForm.Size = new System.Drawing.Size(60, 24);
            this.mnuProfileForm.Text = "Form";
            // 
            // mnuProfileTherRef
            // 
            this.mnuProfileTherRef.Name = "mnuProfileTherRef";
            this.mnuProfileTherRef.Size = new System.Drawing.Size(209, 26);
            this.mnuProfileTherRef.Text = "Therapy Referral";
            this.mnuProfileTherRef.Click += new System.EventHandler(this.mnuProfileTherRef_Click);
            // 
            // mnuProfileRegChild
            // 
            this.mnuProfileRegChild.Name = "mnuProfileRegChild";
            this.mnuProfileRegChild.Size = new System.Drawing.Size(209, 26);
            this.mnuProfileRegChild.Text = "Register Child";
            this.mnuProfileRegChild.Click += new System.EventHandler(this.mnuProfileRegChild_Click);
            // 
            // mnuProfileRegUser
            // 
            this.mnuProfileRegUser.Name = "mnuProfileRegUser";
            this.mnuProfileRegUser.Size = new System.Drawing.Size(209, 26);
            this.mnuProfileRegUser.Text = "Register User";
            this.mnuProfileRegUser.Click += new System.EventHandler(this.mnuProfileRegUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROFILE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SURNAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "MOBILE NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "POSITION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "WORK ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 22);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(175, 122);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(169, 22);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(175, 155);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 22);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(175, 188);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(169, 22);
            this.txtPosition.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(175, 222);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(169, 22);
            this.txtID.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Snow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(24, 351);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(235, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE INFORMATION";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangePic
            // 
            this.btnChangePic.BackColor = System.Drawing.Color.Snow;
            this.btnChangePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePic.Location = new System.Drawing.Point(371, 315);
            this.btnChangePic.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(203, 28);
            this.btnChangePic.TabIndex = 19;
            this.btnChangePic.Text = "CHANGE PICTURE";
            this.btnChangePic.UseVisualStyleBackColor = false;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(371, 351);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 28);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picbxProfilePic
            // 
            this.picbxProfilePic.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.DefaultPro;
            this.picbxProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxProfilePic.Location = new System.Drawing.Point(371, 75);
            this.picbxProfilePic.Margin = new System.Windows.Forms.Padding(4);
            this.picbxProfilePic.Name = "picbxProfilePic";
            this.picbxProfilePic.Size = new System.Drawing.Size(199, 212);
            this.picbxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxProfilePic.TabIndex = 2;
            this.picbxProfilePic.TabStop = false;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.Profile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbxProfilePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuProfile);
            this.MainMenuStrip = this.mnuProfile;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
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