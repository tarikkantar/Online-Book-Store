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
    public partial class BookForm : Form
    {
        Book book;
        public BookForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            this.Text = book.Name;
            txtName.Text = book.Name;
            txtAuthor.Text = book.Author;
            txtPublisher.Text = book.Publisher;
            txtCategory.Text = book.Category;
            txtPage.Text = book.Page.ToString();
            txtPrice.Text = book.Price + " TL";
            txtContent.Text = book.Content;
            pbBook.Image = book.Picture;
            txtIsbn.Text = book.Isbn;
            pbBook.SizeMode = PictureBoxSizeMode.StretchImage;
            txtCounter.Text = "1";           
        }
    }
}
