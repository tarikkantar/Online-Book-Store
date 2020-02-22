using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store 
{
    class ShoppingCart
    {
        public List<ItemToPurchase> ItemsToPurchase;
        public Customer Customer;
        public double PaymentAmount;
        ShoppingCartFormcs shoppingForm;
        List<ShoppingCartPanel> list;

        public ShoppingCart()
        {
            ItemsToPurchase = new List<ItemToPurchase>();
        }

        public void PlaceOrder(string shipmentAdress, string email)
        {
            shoppingForm.Close();
            shoppingForm.Dispose();
            InvoiceForm invoice = new InvoiceForm(shipmentAdress, email);
            invoice.ShowDialog();
            ItemsToPurchase.Clear();
            list.Clear();
        }

        public void removeProduct(ItemToPurchase item)
        {
            ItemsToPurchase.Remove(item);
            foreach (var it in list)
            {
                if (it.item == item)
                {
                    list.Remove(it);
                    break;
                }
            }
            refreshPanel();
        }

        public void refreshPanel()
        {
            shoppingForm.fillPanel();
        }

        public void ShowProducts()
        {
            list = new List<ShoppingCartPanel>();

            foreach (ItemToPurchase item in ItemsToPurchase)
            {
                ShoppingCartPanel pnl = new ShoppingCartPanel(item);
                list.Add(pnl);
            }
            shoppingForm = new ShoppingCartFormcs(list);
            if (list.Count != 0)
                shoppingForm.ShowDialog();

        }

        public void CancelOrder()
        {
            ItemsToPurchase.Clear();
            list.Clear();
            PaymentAmount = 0;
            shoppingForm.Close();
            shoppingForm.Dispose();
        }
    }
}
