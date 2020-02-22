using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public partial class MagazineForm : Form
    {
        Magazine magazine;

        public MagazineForm(Magazine magazine)
        {
            InitializeComponent();
            this.magazine = magazine;
            this.Text = magazine.Name;
            txtName.Text = magazine.Name;
            txtCategory.Text = magazine.Category;
            txtPrice.Text = magazine.Price + " TL";
            txtContent.Text = magazine.Issue;
            pbMagazine.Image = magazine.Picture;
            pbMagazine.SizeMode = PictureBoxSizeMode.StretchImage;
            txtCounter.Text = "1";
            txtIsbn.Text = magazine.Isbn;
        }
    }
}
