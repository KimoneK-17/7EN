namespace TherapyReferralSystem
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
            this.lblR = new System.Windows.Forms.Label();
            this.lblREmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(202, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "USER EMAIL ADDRESS:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(220, 54);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(453, 50);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.Location = new System.Drawing.Point(432, 54);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(14, 17);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "*";
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.ForeColor = System.Drawing.Color.Red;
            this.lblREmail.Location = new System.Drawing.Point(13, 87);
            this.lblREmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(0, 17);
            this.lblREmail.TabIndex = 5;
            // 
            // frmAdminPWordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TherapyReferralSystem.Properties.Resources.AdminReset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 184);
            this.Controls.Add(this.lblREmail);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminPWordReset";
            this.Text = "frmAdminPWordReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblREmail;
    }
}