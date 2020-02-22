using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Online_Book_Store
{
    public partial class FormForgotPassword : Form
    {
        FormLogin fl = null;
        Random random = new Random();
        int registerKey;
        private Customer customer = new Customer();
        public FormForgotPassword(FormLogin loginForm)
        {
            InitializeComponent();
            fl = loginForm;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fl.ForgotMyPasswordScreen();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (lblUsername.Text == "Yeni şifre Girin")
            {
                if (txtUsername.Text == txtEmail.Text)
                {
                    customer.Password = txtUsername.Text.Trim();
                    FormLogin.DatabaseObject.CustomerUpdate(customer);
                    DialogResult passwordDialog = MessageBox.Show("Şifreniz değiştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (passwordDialog == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Customer loginedCustomer = new Customer();
                loginedCustomer = FormLogin.DatabaseObject.GetCustomerWtihEmail(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                customer = loginedCustomer;
                if (loginedCustomer != null)
                {
                    try
                    {
                        string gmailAddress = txtEmail.Text;
                        lblRegisterCode.Visible = true;
                        txtRegisterCode.Visible = true;
                        registerKey = random.Next(10000, 99999);

                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Timeout = 50000;
                        sc.Host = "smtp.gmail.com";
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("k.t.b.kitapdergicd@gmail.com", "KtbKitabeVi.9756");

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("k.t.b.kitapdergicd@gmail.com", "TKB Kitabevi");
                        mail.To.Add(gmailAddress);
                        mail.Subject = "TKB Kitabevi Parola Sıfırlama";
                        mail.IsBodyHtml = true;
                        mail.Body = "Parola sıfırlama işleminiz için doğrulama kodunuz " + registerKey.ToString();
                        sc.Send(mail);
                    }
                    catch (Exception)
                    {
                        lblRegisterCode.Visible = false;
                        txtRegisterCode.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya E-Posta adresiniz hatalı! Lütfen bilgilerinizi kontrol edip tekrar deneyin.");
                }
            }

        }

        private void txtRegisterCode_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterCode.Text == registerKey.ToString())
            {
                pcbValidation.Visible = true;
                lblRegisterCode.Visible = false;
                txtRegisterCode.Visible = false;
                txtUsername.Text = "";
                txtEmail.Text = "";

                lblUsername.Text = "Yeni şifre Girin";
                lblEmail.Text = "Şifrenizi doğrulayın";
            }
        }

        //private void btnResetPassword_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine("dasd");

        //    if (lblUsername.Text == "Yeni şifre Girin")
        //    {
        //        if(txtUsername.Text == txtEmail.Text)
        //        {
        //            customer.Password = txtUsername.Text.Trim();
        //            FormLogin.DatabaseObject.CustomerUpdate(customer);
        //            DialogResult passwordDialog = MessageBox.Show("Şifreniz değiştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            if (passwordDialog == DialogResult.OK)
        //            {
        //                this.Close();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Şifreler uyuşmuyor!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    else
        //    {
        //        Customer loginedCustomer = new Customer();
        //        loginedCustomer = FormLogin.DatabaseObject.GetCustomerWtihEmail(txtUsername.Text.Trim(), txtEmail.Text.Trim());
        //        customer = loginedCustomer;
        //        if (loginedCustomer != null)
        //        {
        //            try
        //            {
        //                string gmailAddress = txtEmail.Text;
        //                lblRegisterCode.Visible=true;
        //                txtRegisterCode.Visible = true;
        //                registerKey = random.Next(10000, 99999);

        //                SmtpClient sc = new SmtpClient();
        //                sc.Port = 587;
        //                sc.Timeout = 50000;
        //                sc.Host = "smtp.gmail.com";
        //                sc.EnableSsl = true;
        //                sc.Credentials = new NetworkCredential("k.t.b.kitapdergicd@gmail.com", "KtbKitabeVi.9756");

        //                MailMessage mail = new MailMessage();
        //                mail.From = new MailAddress("k.t.b.kitapdergicd@gmail.com", "TKB Kitabevi");
        //                mail.To.Add(gmailAddress);
        //                mail.Subject = "TKB Kitabevi Parola Sıfırlama";
        //                mail.IsBodyHtml = true;
        //                mail.Body = "Parola sıfırlama işleminiz için doğrulama kodunuz " + registerKey.ToString();
        //                sc.Send(mail);
        //            }
        //            catch (Exception)
        //            {
        //                lblRegisterCode.Visible = false;
        //                txtRegisterCode.Visible = false;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Kullanıcı Adı veya E-Posta adresiniz hatalı! Lütfen bilgilerinizi kontrol edip tekrar deneyin.");
        //        }
        //    }                          
        //}

        //private void txtRegisterCode_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtRegisterCode.Text == registerKey.ToString())
        //    {
        //        pcbValidation.Visible = true;
        //        lblRegisterCode.Text = "";
        //        txtRegisterCode.Visible = false;
        //        txtUsername.Text = "";
        //        txtEmail.Text = "";

        //        lblUsername.Text = "Yeni şifre Girin";
        //        lblEmail.Text = "Şifrenizi doğrulayın";
        //    }
        //}
    }
}

