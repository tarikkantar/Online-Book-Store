namespace Online_Book_Store
{
    partial class FormForgotPassword
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
            this.pcbValidation = new System.Windows.Forms.PictureBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtDesign2 = new System.Windows.Forms.TextBox();
            this.txtDesign1 = new System.Windows.Forms.TextBox();
            this.lblRegisterCode = new System.Windows.Forms.Label();
            this.txtRegisterCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbValidation
            // 
            this.pcbValidation.BackColor = System.Drawing.Color.Transparent;
            this.pcbValidation.Image = global::Online_Book_Store.Properties.Resources.success_checked_interface_icon_6156_512x512;
            this.pcbValidation.Location = new System.Drawing.Point(219, 418);
            this.pcbValidation.Name = "pcbValidation";
            this.pcbValidation.Size = new System.Drawing.Size(133, 115);
            this.pcbValidation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbValidation.TabIndex = 62;
            this.pcbValidation.TabStop = false;
            this.pcbValidation.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(219, 335);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(133, 54);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Şifreyi Yenile";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Online_Book_Store.Properties.Resources.siyah;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(207, 46);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 130);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 60;
            this.pbLogo.TabStop = false;
            // 
            // txtDesign2
            // 
            this.txtDesign2.Enabled = false;
            this.txtDesign2.Location = new System.Drawing.Point(97, 297);
            this.txtDesign2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesign2.Multiline = true;
            this.txtDesign2.Name = "txtDesign2";
            this.txtDesign2.Size = new System.Drawing.Size(370, 2);
            this.txtDesign2.TabIndex = 59;
            // 
            // txtDesign1
            // 
            this.txtDesign1.Enabled = false;
            this.txtDesign1.Location = new System.Drawing.Point(97, 254);
            this.txtDesign1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesign1.Multiline = true;
            this.txtDesign1.Name = "txtDesign1";
            this.txtDesign1.Size = new System.Drawing.Size(370, 2);
            this.txtDesign1.TabIndex = 58;
            // 
            // lblRegisterCode
            // 
            this.lblRegisterCode.AutoSize = true;
            this.lblRegisterCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblRegisterCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegisterCode.Cursor = System.Windows.Forms.Cursors.No;
            this.lblRegisterCode.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblRegisterCode.ForeColor = System.Drawing.Color.White;
            this.lblRegisterCode.Location = new System.Drawing.Point(11, 418);
            this.lblRegisterCode.Name = "lblRegisterCode";
            this.lblRegisterCode.Size = new System.Drawing.Size(513, 71);
            this.lblRegisterCode.TabIndex = 57;
            this.lblRegisterCode.Text = "Güvenliğiniz için E-Posta adresinize 5 haneli bir doğrulama kodu\r\n gönderdik. Lüt" +
    "fen posta kutunuzu kontrol edin ve size gönderilen\r\n kodu aşağıdaki kutucuğa gir" +
    "in.";
            this.lblRegisterCode.Visible = false;
            // 
            // txtRegisterCode
            // 
            this.txtRegisterCode.BackColor = System.Drawing.Color.White;
            this.txtRegisterCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegisterCode.Location = new System.Drawing.Point(190, 524);
            this.txtRegisterCode.MaxLength = 5;
            this.txtRegisterCode.Name = "txtRegisterCode";
            this.txtRegisterCode.Size = new System.Drawing.Size(198, 40);
            this.txtRegisterCode.TabIndex = 4;
            this.txtRegisterCode.Visible = false;
            this.txtRegisterCode.TextChanged += new System.EventHandler(this.txtRegisterCode_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(238, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(238, 210);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(80, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 23);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "E-Posta Adresiniz :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(80, 211);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 23);
            this.lblUsername.TabIndex = 52;
            this.lblUsername.Text = "Kullanıcı Adı :";
            // 
            // FormForgotPassword
            // 
            this.AcceptButton = this.btnResetPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 673);
            this.Controls.Add(this.pcbValidation);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtDesign2);
            this.Controls.Add(this.txtDesign1);
            this.Controls.Add(this.lblRegisterCode);
            this.Controls.Add(this.txtRegisterCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbValidation;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtDesign2;
        private System.Windows.Forms.TextBox txtDesign1;
        private System.Windows.Forms.Label lblRegisterCode;
        private System.Windows.Forms.TextBox txtRegisterCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
    }
}