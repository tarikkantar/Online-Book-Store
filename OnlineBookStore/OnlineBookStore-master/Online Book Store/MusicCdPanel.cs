using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store
{
    class MusicCdPanel : PanelProduct
    {
        public Label Singer;
        public Label Type;
        public Label Price;
        public MusicCD musicCD;

        public MusicCdPanel(MusicCD musicCd)
        {
            this.musicCD = musicCd;
            this.BackColor = Color.FromArgb(160, 0, 190, 190);
            this.Size = new Size(290, 190);
            this.BorderStyle = BorderStyle.None;

            Picture = new PictureBox();
            Picture.Size = new Size(105, 160);
            Picture.BackgroundImage = musicCd.Picture;
            Picture.BackgroundImageLayout = ImageLayout.Zoom;
            Picture.BackColor = Color.Transparent;

            Show_Details = new PictureBox();
            Show_Details.Size = new Size(32, 32);
            Show_Details.BackgroundImage = Properties.Resources.loupe;
            Show_Details.BackgroundImageLayout = ImageLayout.Stretch;
            Show_Details.Cursor = Cursors.Hand;
            Show_Details.BackColor = Color.Transparent;
            Show_Details.Click += new EventHandler(panelClick);

            name = new Label();
            name.AutoSize = true;
            name.Text = musicCd.Name;
            name.BackColor = Color.Transparent;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.ForeColor = Color.White;
            name.Font = new Font("Calibri", (float)13);
            this.Controls.Add(name);

            Singer = new Label();
            Singer.AutoSize = true;
            Singer.Text = musicCd.Singer;
            Singer.BackColor = Color.Transparent;
            Singer.ForeColor = Color.White;
            Singer.Font = new Font("Calibri", (float)12);
            this.Controls.Add(Singer);

            Type = new Label();
            Type.AutoSize = true;
            Type.Text = musicCd.Category;
            Type.BackColor = Color.Transparent;
            Type.Font = new Font("Calibri", (float)10);
            Type.ForeColor = Color.White;
            this.Controls.Add(Type);

            Price = new Label();
            Price.AutoSize = true;
            Price.Text = musicCd.Price + " TL";
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Calibri", (float)11.25);
            Price.ForeColor = Color.White;
            this.Controls.Add(Price);

            Add_Cart = new PictureBox();
            Add_Cart.Size = new Size(32, 32);
            Add_Cart.BackgroundImage = Properties.Resources.showDetails;
            Add_Cart.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Cart.Cursor = Cursors.Hand;
            Add_Cart.BackColor = Color.Transparent;
            Add_Cart.Click += new EventHandler(addCart);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);// Singer label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 80);// Type label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(125, 110);//  Price label
            this.Controls[3].BringToFront();
            this.Controls.Add(Picture);
            this.Controls[4].Location = new Point(10, 15); //Picturebox
            this.Controls.Add(Show_Details);
            this.Controls[5].Location = new Point(175, 140);//Magnifier image
            this.Controls.Add(Add_Cart);
            this.Controls[6].Location = new Point(225, 140); //Add to cart image
        }

        private void panelClick(object sender, EventArgs e)
        {
            musicCD.ShowDetails();
        }

        void addCart(object sender, EventArgs e)
        {
            foreach (var it in MainForm.ShoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.musicCD)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.musicCD;
            item.Quantity = 1;
            MainForm.ShoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
