namespace Online_Book_Store
{
    partial class FormSignUp
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbEMail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCheckPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCheckPassword = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rtxAdress = new System.Windows.Forms.RichTextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.pbShowCheckPassword = new System.Windows.Forms.PictureBox();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCheckPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbName.Location = new System.Drawing.Point(100, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "İsim";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.BackColor = System.Drawing.Color.Transparent;
            this.lbSurname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbSurname.Location = new System.Drawing.Point(100, 150);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(69, 23);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Soyisim";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.BackColor = System.Drawing.Color.Transparent;
            this.lbAdress.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbAdress.Location = new System.Drawing.Point(100, 200);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(55, 23);
            this.lbAdress.TabIndex = 2;
            this.lbAdress.Text = "Adres";
            // 
            // lbEMail
            // 
            this.lbEMail.AutoSize = true;
            this.lbEMail.BackColor = System.Drawing.Color.Transparent;
            this.lbEMail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbEMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbEMail.Location = new System.Drawing.Point(100, 320);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(68, 23);
            this.lbEMail.TabIndex = 3;
            this.lbEMail.Text = "E-posta";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbUsername.Location = new System.Drawing.Point(100, 370);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 23);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Kullanıcı Adı";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbPassword.Location = new System.Drawing.Point(100, 420);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(59, 23);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Parola";
            // 
            // lbCheckPassword
            // 
            this.lbCheckPassword.AutoSize = true;
            this.lbCheckPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbCheckPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCheckPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbCheckPassword.Location = new System.Drawing.Point(100, 470);
            this.lbCheckPassword.Name = "lbCheckPassword";
            this.lbCheckPassword.Size = new System.Drawing.Size(189, 23);
            this.lbCheckPassword.TabIndex = 6;
            this.lbCheckPassword.Text = "Parolayı Yeniden Giriniz";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(365, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 29);
            this.txtName.TabIndex = 7;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(365, 150);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(289, 29);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtCheckPassword
            // 
            this.txtCheckPassword.BackColor = System.Drawing.Color.White;
            this.txtCheckPassword.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCheckPassword.Location = new System.Drawing.Point(365, 470);
            this.txtCheckPassword.Name = "txtCheckPassword";
            this.txtCheckPassword.PasswordChar = '*';
            this.txtCheckPassword.Size = new System.Drawing.Size(289, 29);
            this.txtCheckPassword.TabIndex = 10;
            // 
            // txtEMail
            // 
            this.txtEMail.BackColor = System.Drawing.Color.White;
            this.txtEMail.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEMail.ForeColor = System.Drawing.Color.Black;
            this.txtEMail.Location = new System.Drawing.Point(365, 316);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(289, 29);
            this.txtEMail.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(365, 370);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 29);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(365, 420);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 29);
            this.txtPassword.TabIndex = 13;
            // 
            // rtxAdress
            // 
            this.rtxAdress.BackColor = System.Drawing.Color.White;
            this.rtxAdress.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxAdress.ForeColor = System.Drawing.Color.Black;
            this.rtxAdress.Location = new System.Drawing.Point(365, 200);
            this.rtxAdress.Name = "rtxAdress";
            this.rtxAdress.Size = new System.Drawing.Size(289, 90);
            this.rtxAdress.TabIndex = 14;
            this.rtxAdress.Text = "";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(457, 553);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(197, 69);
            this.btnSignUp.TabIndex = 15;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.BackgroundImage = global::Online_Book_Store.Properties.Resources.visibility_button;
            this.pbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShowPassword.Location = new System.Drawing.Point(694, 420);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(36, 37);
            this.pbShowPassword.TabIndex = 16;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // pbShowCheckPassword
            // 
            this.pbShowCheckPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowCheckPassword.BackgroundImage = global::Online_Book_Store.Properties.Resources.visibility_button;
            this.pbShowCheckPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShowCheckPassword.Location = new System.Drawing.Point(694, 467);
            this.pbShowCheckPassword.Name = "pbShowCheckPassword";
            this.pbShowCheckPassword.Size = new System.Drawing.Size(36, 37);
            this.pbShowCheckPassword.TabIndex = 17;
            this.pbShowCheckPassword.TabStop = false;
            this.pbShowCheckPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowCheckPassword_MouseDown);
            this.pbShowCheckPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowCheckPassword_MouseUp);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbError.ForeColor = System.Drawing.Color.White;
            this.lbError.Location = new System.Drawing.Point(100, 33);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 22);
            this.lbError.TabIndex = 26;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Online_Book_Store.Properties.Resources.DSC1005055091;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 675);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.pbShowCheckPassword);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.rtxAdress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtCheckPassword);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbCheckPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbEMail);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCheckPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbEMail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCheckPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCheckPassword;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RichTextBox rtxAdress;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.PictureBox pbShowCheckPassword;
        private System.Windows.Forms.Label lbError;
    }
}