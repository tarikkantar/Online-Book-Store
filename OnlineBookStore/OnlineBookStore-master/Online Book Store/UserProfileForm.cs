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
    public partial class UserProfileForm : Form
    {
        Customer customer;

        public UserProfileForm(Customer currentCustomer)
        {
            customer = currentCustomer;
            InitializeComponent();
            txtName.Text = currentCustomer.Name;
            txtSurname.Text = currentCustomer.Surname;
            txtAddress.Text = currentCustomer.Address;
            txtEmail.Text = currentCustomer.Email;
            txtUsername.Text = currentCustomer.Username;
            txtPassword.Text = currentCustomer.Password;

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void pbShowCheckPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtCheckPassword.PasswordChar = '\0';
        }

        private void pbShowCheckPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtCheckPassword.PasswordChar = '*';
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            lbError.Text = null;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lbError.Text = "** Tüm alanları doldurun.";
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                lbError.Text = "** Geçersiz e-posta adresi.";
            }
            else if (txtPassword.Text != txtCheckPassword.Text)
            {
                lbError.Text = "** Şifreler uyuşmuyor.";
            }
            else
            {
                customer.Name = txtName.Text;
                customer.Username = txtUsername.Text;
                customer.Surname = txtSurname.Text;
                customer.Address = txtAddress.Text;
                customer.Email = txtEmail.Text;
                customer.Password = txtPassword.Text;
                FormLogin.DatabaseObject.CustomerUpdate(customer);
                this.Close();
                lbError.Text = "* Kaydınız başarı ile tamamlandı. *";
            }

        }

    }
}
