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
    public partial class FormLogin : Form
    {
        private static Database databaseObject = Database.DatabaseObj();
        internal static Database DatabaseObject
        {
            get
            {
                return databaseObject;
            }
            set
            {
                databaseObject = value;
            }
        }

        internal static Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }
        private static Customer customer = new Customer();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(0,190,190);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Hide();
            FormSignUp fsn = new FormSignUp();
            fsn.ShowDialog();
            fsn = null;
            Show();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer loginedCustomer = new Customer();
            Customer = databaseObject.GetCustomer(txtUsername.Text, txtPassword.Text);
            if (Customer != null)
            {
                this.Hide();
                loginedCustomer = Customer;
                MainForm mainform = new MainForm(Customer);
                mainform.ShowDialog();
                mainform = null;
                GC.Collect();
                txtUsername.Clear();
                txtPassword.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış !", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            btnForgotPassword.Font = new Font("Calibri", 13);
        }

        private void btnForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            btnForgotPassword.Font = new Font("Calibri",11,FontStyle.Underline);
        }

        private void btnSingUp_MouseEnter(object sender, EventArgs e)
        {
            btnSingUp.Font=new Font("Calibri", 16);
        }

        private void btnSingUp_MouseLeave(object sender, EventArgs e)
        {
            btnSingUp.Font = new Font("Calibri", 13);
        }

        public void ForgotMyPasswordScreen()
        {
            if(this.Opacity!=0)
            {
                this.Opacity=0;
            }
              
           else if(this.Opacity!=100)
            {
                this.Opacity=100;
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotMyPasswordScreen();
            FormForgotPassword fpf = new FormForgotPassword(this);
            fpf.Show();
        }
    }
}
