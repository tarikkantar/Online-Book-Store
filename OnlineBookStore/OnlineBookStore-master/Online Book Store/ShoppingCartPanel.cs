using System;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public class ShoppingCartPanel : Panel
    {
        Label lbProductName;
        Label lbProductType;
        Label lbPrice;
        Button btnRemoveItem;
        ComboBox cmbQuantity;
        PictureBox pbThumbnail;
        public ItemToPurchase item;
        public ShoppingCartPanel(ItemToPurchase item)
        {
            this.item = item;
            this.Size = new Size(550, 85);
            this.BackColor = Color.FromArgb(160, 0, 190, 190);
            this.BorderStyle = BorderStyle.FixedSingle;

            lbProductName = new Label();
            lbProductName.AutoSize = false;
            lbProductName.Size = new Size(200, 20);
            lbProductName.Text = item.Product.Name;
            lbProductName.BackColor = Color.Transparent;
            lbProductName.Font = new Font("Calibri", (float)11.25);
            this.Controls.Add(lbProductName);

            lbProductType = new Label();
            lbProductType.AutoSize = false;
            lbProductType.Size = new Size(200, 15);
            lbProductType.Font = new Font("Calibri", (float)10.25);
            if (item.Product is Book)
                lbProductType.Text = "Kitap";
            else if (item.Product is Magazine)
                lbProductType.Text = "Dergi";
            else
                lbProductType.Text = "Musik CD";
            lbProductType.BackColor = Color.Transparent;
            this.Controls.Add(lbProductType);

            lbPrice = new Label();
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Calibri", (float)10.25);
            lbPrice.Text = item.Product.Price * item.Quantity + " TL";
            lbPrice.BackColor = Color.Transparent;
            this.Controls.Add(lbPrice);

            cmbQuantity = new ComboBox();
            for (int i = 1; i <= 100; i++)
            {
                cmbQuantity.Items.Add(i.ToString());
            }
            cmbQuantity.SelectedIndex = item.Quantity - 1;
            cmbQuantity.SelectedIndexChanged += new EventHandler(cbChange);
            cmbQuantity.Size = new Size(61, 21);
            cmbQuantity.IntegralHeight = false;
            cmbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuantity.MaxDropDownItems = 6;
            this.Controls.Add(cmbQuantity);

            pbThumbnail = new PictureBox();
            pbThumbnail.Image = item.Product.Picture;
            pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThumbnail.Size = new Size(59, 78);
            pbThumbnail.BackColor = Color.Transparent;
            this.Controls.Add(pbThumbnail);

            btnRemoveItem = new Button();
            btnRemoveItem.Text = "Sepetten Çıkar";
            btnRemoveItem.TextAlign = ContentAlignment.MiddleCenter;
            btnRemoveItem.Size = new Size(100, 25);
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.BackColor = Color.FromArgb(34,36,49);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Click += new EventHandler(buttonClick);
            btnRemoveItem.Image = Properties.Resources.closeiconblue;
            btnRemoveItem.ImageAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(btnRemoveItem);

            this.Controls[0].Location = new Point(63, 24);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(63, 54);// Type label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(466, 26);// Price label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(316, 24);//  Combobox
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(3, 3);// picturebox
            this.Controls[4].BringToFront();
            this.Controls[5].Location = new Point(440, 55);//Button

        }
        void buttonClick(object sender, EventArgs e)
        {
            MainForm.ShoppingCart.removeProduct(this.item);
        }
        void cbChange(object sender, EventArgs e)
        {
            item.Quantity = cmbQuantity.SelectedIndex + 1;
            lbPrice.Text = item.Product.Price * item.Quantity + " TL";
            MainForm.ShoppingCart.refreshPanel();
        }
    }
}
