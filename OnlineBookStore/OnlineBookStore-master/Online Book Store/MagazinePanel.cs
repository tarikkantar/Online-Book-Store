using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store
{
    class MagazinePanel : PanelProduct
    {
        public Label Issue;
        public Label Type;
        public Label Price;
        public Magazine magazine;

        public MagazinePanel(Magazine magazine)
        {
            this.magazine = magazine;
            this.BackColor = Color.FromArgb(160, 0, 190, 190);
            this.Size = new Size(290, 190);
            this.BorderStyle = BorderStyle.None;

            Picture = new PictureBox();
            Picture.Size = new System.Drawing.Size(105, 160);
            Picture.BackgroundImage = magazine.Picture;
            Picture.BackgroundImageLayout = ImageLayout.Stretch;
            Picture.BackColor = Color.Transparent;

            Show_Details = new PictureBox();
            Show_Details.Size = new Size(32, 32);
            Show_Details.BackgroundImage = Properties.Resources.loupe;
            Show_Details.BackgroundImageLayout = ImageLayout.Stretch;
            Show_Details.Cursor = Cursors.Hand;
            Show_Details.Click += new EventHandler(Show_DetailsClick);
            Show_Details.BackColor = Color.Transparent;

            Add_Cart = new PictureBox();
            Add_Cart.Size = new Size(32, 32);
            Add_Cart.BackgroundImage = Properties.Resources.showDetails;
            Add_Cart.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Cart.Cursor = Cursors.Hand;
            Add_Cart.Click += new EventHandler(Add_CartClick);
            Add_Cart.BackColor = Color.Transparent;

            name = new Label();
            name.AutoSize = true;
            name.Text = magazine.Name;
            name.BackColor = Color.Transparent;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.ForeColor = Color.White;
            name.Font = new Font("Calibri", (float)12);
            this.Controls.Add(name);

            Type = new Label();
            Type.AutoSize = true;
            Type.BackColor = Color.Transparent;
            Type.Text = magazine.Category;
            Type.Font = new Font("Calibri", (float)10);
            Type.ForeColor = Color.White;
            this.Controls.Add(Type);

            Price = new Label();
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Text = magazine.Price + " TL";
            Price.ForeColor = Color.White;
            this.Controls.Add(Price);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 55);// Type label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 110);//  Price label
            this.Controls[2].BringToFront();
            this.Controls.Add(Picture);
            this.Controls[3].Location = new Point(10, 15); //Picturebox
            this.Controls.Add(Show_Details);
            this.Controls[4].Location = new Point(170, 140);//Magnifier image
            this.Controls.Add(Add_Cart);
            this.Controls[5].Location = new Point(225, 140); //Add to cart image
        }

        void Show_DetailsClick(object sender, EventArgs e)
        {
            magazine.ShowDetails();
        }

        void Add_CartClick(object sender, EventArgs e)
        {
            foreach (var it in MainForm.ShoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.magazine)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.magazine;
            item.Quantity = 1;
            MainForm.ShoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
