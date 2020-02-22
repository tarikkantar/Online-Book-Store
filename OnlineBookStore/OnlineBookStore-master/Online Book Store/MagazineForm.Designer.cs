namespace Online_Book_Store
{
    partial class MagazineForm
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
            this.pbMagazine = new System.Windows.Forms.PictureBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lbContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagazine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMagazine
            // 
            this.pbMagazine.BackColor = System.Drawing.Color.Transparent;
            this.pbMagazine.Location = new System.Drawing.Point(23, 26);
            this.pbMagazine.Name = "pbMagazine";
            this.pbMagazine.Size = new System.Drawing.Size(200, 300);
            this.pbMagazine.TabIndex = 1;
            this.pbMagazine.TabStop = false;
            // 
            // txtCounter
            // 
            this.txtCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCounter.ForeColor = System.Drawing.Color.White;
            this.txtCounter.Location = new System.Drawing.Point(324, 341);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(206, 19);
            this.txtCounter.TabIndex = 36;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(324, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(252, 19);
            this.txtPrice.TabIndex = 34;
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsbn.ForeColor = System.Drawing.Color.White;
            this.txtIsbn.Location = new System.Drawing.Point(324, 94);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(252, 19);
            this.txtIsbn.TabIndex = 33;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(324, 59);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(252, 19);
            this.txtCategory.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(324, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(252, 19);
            this.txtName.TabIndex = 28;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbCategory.Location = new System.Drawing.Point(229, 61);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(60, 19);
            this.lbCategory.TabIndex = 27;
            this.lbCategory.Text = "Konusu:";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.BackColor = System.Drawing.Color.Transparent;
            this.lbIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIsbn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbIsbn.Location = new System.Drawing.Point(229, 96);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(57, 19);
            this.lbIsbn.TabIndex = 23;
            this.lbIsbn.Text = "Barkod:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbPrice.Location = new System.Drawing.Point(229, 131);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 19);
            this.lbPrice.TabIndex = 22;
            this.lbPrice.Text = "Fiyat:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbName.Location = new System.Drawing.Point(229, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 19);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "İsim:";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(324, 164);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(252, 145);
            this.txtContent.TabIndex = 39;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.BackColor = System.Drawing.Color.Transparent;
            this.lbContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbContent.Location = new System.Drawing.Point(229, 166);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(48, 19);
            this.lbContent.TabIndex = 38;
            this.lbContent.Text = "İçerik:";
            // 
            // MagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(602, 400);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbIsbn);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbMagazine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MagazineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dergi Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.pbMagazine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMagazine;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbIsbn;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbContent;
    }
}