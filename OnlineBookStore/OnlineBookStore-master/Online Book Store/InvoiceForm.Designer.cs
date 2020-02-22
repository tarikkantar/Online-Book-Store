namespace Online_Book_Store
{
    partial class InvoiceForm
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
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCompInf = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lblCustInf = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pnlInvoice.Controls.Add(this.pbLogo);
            this.pnlInvoice.Controls.Add(this.listView1);
            this.pnlInvoice.Controls.Add(this.lblCompInf);
            this.pnlInvoice.Controls.Add(this.lbTotal);
            this.pnlInvoice.Controls.Add(this.lbTotalPrice);
            this.pnlInvoice.Controls.Add(this.lblCustInf);
            this.pnlInvoice.Controls.Add(this.lblDate);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(739, 669);
            this.pnlInvoice.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.name,
            this.quantity,
            this.uPrice,
            this.tPrice});
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 222);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(686, 355);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 39;
            // 
            // name
            // 
            this.name.Text = "Ürün";
            this.name.Width = 199;
            // 
            // quantity
            // 
            this.quantity.Text = "Miktar";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uPrice
            // 
            this.uPrice.Text = "Birim Fiyat";
            this.uPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tPrice
            // 
            this.tPrice.Text = "Toplam Fiyat";
            this.tPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tPrice.Width = 63;
            // 
            // lblCompInf
            // 
            this.lblCompInf.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCompInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblCompInf.Location = new System.Drawing.Point(482, 12);
            this.lblCompInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompInf.Name = "lblCompInf";
            this.lblCompInf.Size = new System.Drawing.Size(224, 78);
            this.lblCompInf.TabIndex = 2;
            this.lblCompInf.Text = "Şirket Bilgileri";
            this.lblCompInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lbTotal.Location = new System.Drawing.Point(495, 605);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(71, 24);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Toplam";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(617, 604);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(89, 25);
            this.lbTotalPrice.TabIndex = 7;
            this.lbTotalPrice.Text = "Price";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustInf
            // 
            this.lblCustInf.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCustInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblCustInf.Location = new System.Drawing.Point(191, 105);
            this.lblCustInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustInf.Name = "lblCustInf";
            this.lblCustInf.Size = new System.Drawing.Size(515, 113);
            this.lblCustInf.TabIndex = 3;
            this.lblCustInf.Text = "Müşteri Bilgileri";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblDate.Location = new System.Drawing.Point(191, 37);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(146, 28);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tarih";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Online_Book_Store.Properties.Resources.siyah;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(20, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(164, 176);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 669);
            this.Controls.Add(this.pnlInvoice);
            this.Name = "InvoiceForm";
            this.Text = "Fatura";
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader uPrice;
        private System.Windows.Forms.ColumnHeader tPrice;
        private System.Windows.Forms.Label lblCompInf;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lblCustInf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}