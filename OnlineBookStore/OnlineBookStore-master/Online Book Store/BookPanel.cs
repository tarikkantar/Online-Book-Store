 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store
{
    class BookPanel : PanelProduct
    {
        public Label Author;
        public Label Price;
        public Book book;

        public BookPanel(Book book)
        {
            this.book = book;
            this.BackColor = Color.FromArgb(160, 0, 190, 190);
            this.Size = new Size(290, 190);
            this.BorderStyle = BorderStyle.None;

            Picture = new PictureBox();
            Picture.Size = new Size(105, 160);
            Picture.BackgroundImage = book.Picture;
            Picture.BackgroundImageLayout = ImageLayout.Stretch;
            Picture.BackColor = Color.Transparent;

            Show_Details = new PictureBox();
            Show_Details.Size = new Size(32, 32);
            Show_Details.BackgroundImage = Properties.Resources.loupe;
            Show_Details.BackgroundImageLayout = ImageLayout.Stretch;
            Show_Details.Cursor = Cursors.Hand;
            Show_Details.BackColor = Color.Transparent;
            Show_Details.Click += new EventHandler(Show_DetailsClick);

            Add_Cart = new PictureBox();
            Add_Cart.Size = new Size(32, 32);
            Add_Cart.BackColor = Color.Transparent;
            Add_Cart.BackgroundImage = Properties.Resources.showDetails;
            Add_Cart.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Cart.Cursor = Cursors.Hand;
            Add_Cart.Click += new EventHandler(Add_CartClick);

            name = new Label();
            name.AutoSize = true;
            name.Text = book.Name;
            name.BackColor = Color.Transparent;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Font = new Font("Calibri", (float)12);
            name.ForeColor = Color.White;
            this.Controls.Add(name);

            Author = new Label();
            Author.AutoSize = true;
            Author.Text = book.Author;
            Author.BackColor = Color.Transparent;
            Author.ForeColor = Color.White;
            Author.Font = new Font("Calibri", (float)10);
            this.Controls.Add(Author);

            Price = new Label();
            Price.AutoSize = true;
            Price.Text = book.Price + " TL";
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Calibri", (float)11.25);
            Price.ForeColor = Color.White;
            this.Controls.Add(Price);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);// Author label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 110);//  Price label
            this.Controls[2].BringToFront();
            this.Controls.Add(Picture);
            this.Controls[3].Location = new Point(10, 15); //Item image
            this.Controls.Add(Show_Details);
            this.Controls[4].Location = new Point(170, 140); //Magnifier image
            this.Controls.Add(Add_Cart);
            this.Controls[5].Location = new Point(225, 140); //Add to cart image
        }

        void Show_DetailsClick(object sender, EventArgs e)
        {
            book.ShowDetails();
        }

        void Add_CartClick(object sender, EventArgs e)
        {
            foreach (var it in MainForm.ShoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.book)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.book;
            item.Quantity = 1;
            MainForm.ShoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.Name.Trim() + " sepetinize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
