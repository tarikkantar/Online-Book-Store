using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Book_Store
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        Customer customer;
        private static int id;

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            lbError.Text = null;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lbError.Text = null;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(rtxAdress.Text) || string.IsNullOrWhiteSpace(txtEMail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lbError.Text = "** Tüm alanları doldurun.";
            }
            else if (!IsValidEmail(txtEMail.Text))
            {
                lbError.Text = "** Geçersiz e-posta adresi.";
            }
            else if (txtPassword.Text != txtCheckPassword.Text)
            {
                lbError.Text = "** Şifreler uyuşmuyor.";
            }
            else
            {
                if (FormLogin.DatabaseObject.UsernameControl(txtUsername.Text))
                {
                    lbError.Text = "** Bu kullanıcı adı daha önceden alınmış.";
                }
                else
                {
                    customer = new Customer();
                    id = FormLogin.DatabaseObject.FindCounter() + 1;
                    customer.saveCustomer(id, txtName.Text, txtSurname.Text, rtxAdress.Text, txtEMail.Text, txtUsername.Text, txtPassword.Text);
                    FormLogin.DatabaseObject.AddCustomer(customer);
                    lbError.Text = "* Kaydınız başarı ile tamamlandı. *";
                }
            }
        }
    }
}
