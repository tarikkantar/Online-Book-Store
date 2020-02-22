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
    public partial class MusicForm : Form
    {
        MusicCD musicCD;
        public MusicForm(MusicCD musicCD)
        {
            this.musicCD = musicCD;
            InitializeComponent();
            this.Text = musicCD.Name;
            txtName.Text = musicCD.Name;
            txtSinger.Text = musicCD.Singer;
            txtCategory.Text = musicCD.Category;
            txtPrice.Text = musicCD.Price + " TL";
            pbMusic.Image = musicCD.Picture;
            txtIsbn.Text = musicCD.Isbn;
            txtReleaseYear.Text = musicCD.ReleaseDate.ToString();
            pbMusic.SizeMode = PictureBoxSizeMode.StretchImage;
            txtCounter.Text = "1";
            string[] contentText = musicCD.Content.Split(',');
            for (int i = 0; i < contentText.Length; i++)
            {
                txtContent.Text += contentText[i] + Environment.NewLine;
            }
        }
    }
}
