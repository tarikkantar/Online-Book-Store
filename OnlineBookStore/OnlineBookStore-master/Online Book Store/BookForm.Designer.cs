namespace Online_Book_Store
{
    partial class BookForm
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
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.Location = new System.Drawing.Point(23, 26);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(200, 300);
            this.pbBook.TabIndex = 0;
            this.pbBook.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbName.Location = new System.Drawing.Point(238, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "İsim:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbPrice.Location = new System.Drawing.Point(238, 236);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 19);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Fiyat:";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.BackColor = System.Drawing.Color.Transparent;
            this.lbIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIsbn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbIsbn.Location = new System.Drawing.Point(238, 201);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(57, 19);
            this.lbIsbn.TabIndex = 3;
            this.lbIsbn.Text = "Barkod:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbAuthor.Location = new System.Drawing.Point(238, 61);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(47, 19);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "Yazar:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lbPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPublisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbPublisher.Location = new System.Drawing.Point(238, 96);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(66, 19);
            this.lbPublisher.TabIndex = 5;
            this.lbPublisher.Text = "Yayınevi:";
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.BackColor = System.Drawing.Color.Transparent;
            this.lbPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbPage.Location = new System.Drawing.Point(238, 131);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(89, 19);
            this.lbPage.TabIndex = 6;
            this.lbPage.Text = "Sayfa Sayısı:";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.BackColor = System.Drawing.Color.Transparent;
            this.lbContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbContent.Location = new System.Drawing.Point(613, 9);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(48, 19);
            this.lbContent.TabIndex = 7;
            this.lbContent.Text = "İçerik:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbCategory.Location = new System.Drawing.Point(238, 166);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(60, 19);
            this.lbCategory.TabIndex = 8;
            this.lbCategory.Text = "Konusu:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(333, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(252, 19);
            this.txtName.TabIndex = 9;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(333, 59);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(252, 19);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPublisher.ForeColor = System.Drawing.Color.White;
            this.txtPublisher.Location = new System.Drawing.Point(333, 94);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(252, 19);
            this.txtPublisher.TabIndex = 11;
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPage.ForeColor = System.Drawing.Color.White;
            this.txtPage.Location = new System.Drawing.Point(333, 129);
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(252, 19);
            this.txtPage.TabIndex = 12;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(333, 164);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(252, 19);
            this.txtCategory.TabIndex = 13;
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsbn.ForeColor = System.Drawing.Color.White;
            this.txtIsbn.Location = new System.Drawing.Point(333, 199);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(252, 19);
            this.txtIsbn.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(333, 234);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(252, 19);
            this.txtPrice.TabIndex = 15;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(617, 42);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(257, 328);
            this.txtContent.TabIndex = 16;
            // 
            // txtCounter
            // 
            this.txtCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCounter.ForeColor = System.Drawing.Color.White;
            this.txtCounter.Location = new System.Drawing.Point(346, 341);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(167, 19);
            this.txtCounter.TabIndex = 18;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(931, 553);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbIsbn);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbIsbn;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtCounter;
    }
}