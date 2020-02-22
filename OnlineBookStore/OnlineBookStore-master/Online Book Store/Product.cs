using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Online_Book_Store
{
    public abstract class Product
    {
        private string id;
        private string name;
        private string category;
        private double price;
        private Image picture;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Image Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public Product(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public abstract void ShowDetails();
    }
}
