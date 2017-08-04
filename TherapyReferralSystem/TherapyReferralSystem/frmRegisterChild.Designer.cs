namespace TherapyReferralSystem
{
    partial class frmRegisterChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterChild));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbxSpecCon = new System.Windows.Forms.RichTextBox();
            this.lblSpecCon = new System.Windows.Forms.Label();
            this.dtpDOA = new System.Windows.Forms.DateTimePicker();
            this.lblDOF = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbBSF = new System.Windows.Forms.ComboBox();
            this.lblBSF = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.cmbCluster = new System.Windows.Forms.ComboBox();
            this.lblCluster = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(587, 436);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 51;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(587, 475);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbxSpecCon
            // 
            this.rtbxSpecCon.Location = new System.Drawing.Point(228, 434);
            this.rtbxSpecCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbxSpecCon.Name = "rtbxSpecCon";
            this.rtbxSpecCon.Size = new System.Drawing.Size(335, 96);
            this.rtbxSpecCon.TabIndex = 49;
            this.rtbxSpecCon.Text = "";
            // 
            // lblSpecCon
            // 
            this.lblSpecCon.AutoSize = true;
            this.lblSpecCon.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecCon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecCon.Location = new System.Drawing.Point(12, 436);
            this.lblSpecCon.Name = "lblSpecCon";
            this.lblSpecCon.Size = new System.Drawing.Size(204, 20);
            this.lblSpecCon.TabIndex = 48;
            this.lblSpecCon.Text = "Special Considerations";
            // 
            // dtpDOA
            // 
            this.dtpDOA.Location = new System.Drawing.Point(228, 399);
            this.dtpDOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOA.Name = "dtpDOA";
            this.dtpDOA.Size = new System.Drawing.Size(200, 22);
            this.dtpDOA.TabIndex = 47;
            // 
            // lblDOF
            // 
            this.lblDOF.AutoSize = true;
            this.lblDOF.BackColor = System.Drawing.Color.Transparent;
            this.lblDOF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOF.Location = new System.Drawing.Point(12, 399);
            this.lblDOF.Name = "lblDOF";
            this.lblDOF.Size = new System.Drawing.Size(166, 20);
            this.lblDOF.TabIndex = 46;
            this.lblDOF.Text = "Date of Admission";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(228, 363);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 22);
            this.txtID.TabIndex = 45;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 362);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 20);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "ID Number";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(228, 325);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(201, 24);
            this.cmbGender.TabIndex = 43;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 325);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 20);
            this.lblGender.TabIndex = 42;
            this.lblGender.Text = "Gender";
            // 
            // cmbBSF
            // 
            this.cmbBSF.FormattingEnabled = true;
            this.cmbBSF.Location = new System.Drawing.Point(228, 178);
            this.cmbBSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBSF.Name = "cmbBSF";
            this.cmbBSF.Size = new System.Drawing.Size(201, 24);
            this.cmbBSF.TabIndex = 41;
            // 
            // lblBSF
            // 
            this.lblBSF.AutoSize = true;
            this.lblBSF.BackColor = System.Drawing.Color.Transparent;
            this.lblBSF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSF.Location = new System.Drawing.Point(12, 177);
            this.lblBSF.Name = "lblBSF";
            this.lblBSF.Size = new System.Drawing.Size(59, 20);
            this.lblBSF.TabIndex = 40;
            this.lblBSF.Text = "B/S/F";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(228, 289);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(201, 22);
            this.txtLName.TabIndex = 39;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(12, 288);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(92, 20);
            this.lblLName.TabIndex = 38;
            this.lblLName.Text = "Lastname";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(228, 254);
            this.txtMName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(201, 22);
            this.txtMName.TabIndex = 37;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(228, 217);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(201, 22);
            this.txtFName.TabIndex = 36;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.BackColor = System.Drawing.Color.Transparent;
            this.lblMName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(12, 251);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(121, 20);
            this.lblMName.TabIndex = 35;
            this.lblMName.Text = "Middle Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(12, 214);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(95, 20);
            this.lblFName.TabIndex = 34;
            this.lblFName.Text = "Firstname";
            // 
            // cmbHouse
            // 
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Location = new System.Drawing.Point(228, 142);
            this.cmbHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(201, 24);
            this.cmbHouse.TabIndex = 33;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(12, 140);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(62, 20);
            this.lblHouse.TabIndex = 32;
            this.lblHouse.Text = "House";
            // 
            // cmbCluster
            // 
            this.cmbCluster.FormattingEnabled = true;
            this.cmbCluster.Location = new System.Drawing.Point(228, 103);
            this.cmbCluster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCluster.Name = "cmbCluster";
            this.cmbCluster.Size = new System.Drawing.Size(201, 24);
            this.cmbCluster.TabIndex = 31;
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.BackColor = System.Drawing.Color.Transparent;
            this.lblCluster.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCluster.Location = new System.Drawing.Point(12, 103);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(70, 20);
            this.lblCluster.TabIndex = 30;
            this.lblCluster.Text = "Cluster";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(228, 65);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbStatus.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 20);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 20);
            this.lblNumber.TabIndex = 27;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(228, 30);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 22);
            this.txtNumber.TabIndex = 26;
            // 
            // frmRegisterChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 569);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbxSpecCon);
            this.Controls.Add(this.lblSpecCon);
            this.Controls.Add(this.dtpDOA);
            this.Controls.Add(this.lblDOF);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbBSF);
            this.Controls.Add(this.lblBSF);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.cmbHouse);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.cmbCluster);
            this.Controls.Add(this.lblCluster);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegisterChild";
            this.Text = "Register Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbxSpecCon;
        private System.Windows.Forms.Label lblSpecCon;
        private System.Windows.Forms.DateTimePicker dtpDOA;
        private System.Windows.Forms.Label lblDOF;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbBSF;
        private System.Windows.Forms.Label lblBSF;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cmbHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.ComboBox cmbCluster;
        private System.Windows.Forms.Label lblCluster;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
    }
}