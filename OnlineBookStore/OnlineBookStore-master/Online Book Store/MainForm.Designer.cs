namespace Online_Book_Store
{
    partial class MainForm
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
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flpnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pnlUser.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlUser.Controls.Add(this.lbUsername);
            this.pnlUser.Controls.Add(this.btnAdminProfile);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.btnShoppingCart);
            this.pnlUser.Controls.Add(this.btnUserProfile);
            this.pnlUser.Location = new System.Drawing.Point(0, 154);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(225, 589);
            this.pnlUser.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(34, 495);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(95, 24);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username";
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminProfile.FlatAppearance.BorderSize = 0;
            this.btnAdminProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdminProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminProfile.ForeColor = System.Drawing.Color.White;
            this.btnAdminProfile.Location = new System.Drawing.Point(0, 205);
            this.btnAdminProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(225, 65);
            this.btnAdminProfile.TabIndex = 3;
            this.btnAdminProfile.Text = "Yönetici Profili";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            this.btnAdminProfile.MouseEnter += new System.EventHandler(this.btnAdminProfile_MouseEnter);
            this.btnAdminProfile.MouseLeave += new System.EventHandler(this.btnAdminProfile_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 136);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(225, 65);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShoppingCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShoppingCart.ForeColor = System.Drawing.Color.White;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 68);
            this.btnShoppingCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(225, 65);
            this.btnShoppingCart.TabIndex = 1;
            this.btnShoppingCart.Text = "Alışveriş Sepeti";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            this.btnShoppingCart.MouseEnter += new System.EventHandler(this.btnShoppingCart_MouseEnter);
            this.btnShoppingCart.MouseLeave += new System.EventHandler(this.btnShoppingCart_MouseLeave);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.FlatAppearance.BorderSize = 0;
            this.btnUserProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnUserProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserProfile.ForeColor = System.Drawing.Color.White;
            this.btnUserProfile.Location = new System.Drawing.Point(0, 0);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(225, 65);
            this.btnUserProfile.TabIndex = 0;
            this.btnUserProfile.Text = "Kullanıcı Profili";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            this.btnUserProfile.MouseEnter += new System.EventHandler(this.btnUserProfile_MouseEnter);
            this.btnUserProfile.MouseLeave += new System.EventHandler(this.btnUserProfile_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(225, 154);
            this.pnlLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 28);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 28);
            this.panel2.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Online_Book_Store.Properties.Resources.siyah;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(38, 12);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 130);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // flpnlItems
            // 
            this.flpnlItems.AutoScroll = true;
            this.flpnlItems.BackColor = System.Drawing.Color.Transparent;
            this.flpnlItems.Location = new System.Drawing.Point(230, 94);
            this.flpnlItems.Margin = new System.Windows.Forms.Padding(2);
            this.flpnlItems.Name = "flpnlItems";
            this.flpnlItems.Size = new System.Drawing.Size(945, 634);
            this.flpnlItems.TabIndex = 12;
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.ForeColor = System.Drawing.Color.White;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Kitap",
            "Dergi",
            "Müzik CD"});
            this.cmbProduct.Location = new System.Drawing.Point(233, 41);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(165, 30);
            this.cmbProduct.TabIndex = 13;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(402, 41);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(165, 30);
            this.cmbCategory.TabIndex = 14;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 739);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.flpnlItems);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpnlItems;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}