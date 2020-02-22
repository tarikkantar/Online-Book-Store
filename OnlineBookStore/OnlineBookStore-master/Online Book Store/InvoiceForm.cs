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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm(string shipmentAdress, string email)
        {
            InitializeComponent();
            lblCompInf.Text = "TKB Kitabevi" + Environment.NewLine + "Eskişehir - OGU" + Environment.NewLine + "Tel: 0222-222-22-22";
            lblDate.Text = DateTime.Now.ToLongDateString();
            Customer cust = new Customer();
            lblCustInf.Text = "Alıcı:" + Environment.NewLine + cust.Name + Environment.NewLine + email + Environment.NewLine + cust.Address;
            foreach (var item in MainForm.ShoppingCart.ItemsToPurchase)
            {
                ListViewItem l_item = new ListViewItem();
                if (item.Product is Book)
                    l_item.Text = "BO" + item.Product.ID.ToString();
                if (item.Product is Magazine)
                    l_item.Text = "MA" + item.Product.ID.ToString();
                if (item.Product is MusicCD)
                    l_item.Text = "MU" + item.Product.ID.ToString();
                l_item.SubItems.Add(item.Product.Name.ToString());
                l_item.SubItems.Add(item.Quantity.ToString());
                l_item.SubItems.Add(item.Product.Price.ToString());
                l_item.SubItems.Add((item.Product.Price * item.Quantity).ToString());
                listView1.Items.Add(l_item);
            }
            lbTotalPrice.Text = MainForm.ShoppingCart.PaymentAmount.ToString() + " TL";
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            using (var bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height))
            {
                Customer cust = new Customer();
                this.pnlInvoice.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Resources\");
                bitmap.Save(Application.StartupPath + @"\Resources\" + cust.Username + cust.PurchasesCounter + ".jpg");
                cust.PurchasesCounter++;
                FormLogin.DatabaseObject.CustomerUpdate(cust);
            }
        }
    }
}
