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
    public partial class ShoppingCartFormcs : Form
    {
        List<ShoppingCartPanel> list;
        double totalPrice;
        Customer customer;
        public ShoppingCartFormcs(List<ShoppingCartPanel> list)
        {
            InitializeComponent();
            this.list = list;
            fillPanel();
            customer = FormLogin.Customer;
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
        }
        public void fillPanel()
        {
            totalPrice = 0;
            pnlProducts.Controls.Clear();
            if (list.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş, lütfen ürün ekleyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            foreach (var item in list)
            {
                totalPrice += item.item.Product.Price * item.item.Quantity;
                pnlProducts.Controls.Add(item);
            }
            lblTotalPrice.Text = totalPrice + " TL";
            MainForm.ShoppingCart.PaymentAmount = totalPrice;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı");
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Geçersiz E-Posta adresi.", "Uyarı");
            }
            else
            {
                MainForm.ShoppingCart.PlaceOrder(txtAddress.Text, txtEmail.Text);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Siparişiniz iptal edilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                MainForm.ShoppingCart.CancelOrder();
            }
        }
    }
}
