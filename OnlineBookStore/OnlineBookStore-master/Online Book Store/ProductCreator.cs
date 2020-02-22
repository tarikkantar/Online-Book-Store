using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    enum ProductType
    {
        Book,
        Magazine,
        MusicCD
    }

    class ProductCreator
    {
        public static Product createProduct(ProductType pType, string id, string name, double price)
        {
            Product product = null;

            switch (pType)
            {
                case ProductType.Book:
                    product = new Book(id, name, price);
                    break;

                case ProductType.Magazine:
                    product = new Magazine(id, name, price);
                    break;
                case ProductType.MusicCD:
                    product = new MusicCD(id, name, price);
                    break;
                default:
                    break;
            }
            return product;
        }
    }
}
