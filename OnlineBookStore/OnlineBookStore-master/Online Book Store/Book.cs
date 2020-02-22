using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Online_Book_Store
{
    public class Book : Product
    {
        private int page;

        private string isbn;
        private string author;
        private string publisher;
        private string content;

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }
        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }
        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public Book(string id, string name, double price) : base(id, name, price) { }

        public override void ShowDetails()
        {
            BookForm bookForm = new BookForm(this);
            bookForm.ShowDialog();
            bookForm.Dispose();
        }
    }
}
