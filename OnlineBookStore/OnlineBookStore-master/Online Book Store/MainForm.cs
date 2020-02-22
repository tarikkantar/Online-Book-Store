using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Collections;

namespace Online_Book_Store
{
    public partial class MainForm : Form
    {
        public BackgroundWorker worker = new BackgroundWorker();
        WebClient wc = new WebClient();
        Customer user;
        List<Product> booklist;
        List<Product> musiclist;
        List<Product> magazinelist;
        List<Product> CurrentProductList;
        PanelProductCreator panelCreator;
        ArrayList productList;
        public static bool IsAdmin;
        private static ShoppingCart shoppingCart;

        internal static ShoppingCart ShoppingCart
        { get
            {
                return shoppingCart;
            }
            set
            {
                shoppingCart = value;
            }
        }

        public MainForm(Customer customer)
        {
            InitializeComponent();
            user = customer;
            CurrentProductList = new List<Product>();
            shoppingCart = new ShoppingCart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelCreator = new PanelProductCreator();
            Database database = Database.DatabaseObj();
            productList = new ArrayList();
            booklist = database.BookLoader();
            CurrentProductList.AddRange(booklist);
            musiclist = database.MusicCDLoader();
            magazinelist = database.MagazineLoader();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);
            cmbProduct.SelectedIndex = 0;
            lbUsername.Text = user.Username;
            if (IsAdmin == true)
            {
                btnAdminProfile.Visible = true;
            }
            else
            {
                btnAdminProfile.Visible = false;
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserProfile_MouseEnter(object sender, EventArgs e)
        {
            btnUserProfile.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void btnShoppingCart_MouseEnter(object sender, EventArgs e)
        {
            btnShoppingCart.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void btnAdminProfile_MouseEnter(object sender, EventArgs e)
        {
            btnAdminProfile.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void btnUserProfile_MouseLeave(object sender, EventArgs e)
        {
            btnUserProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnShoppingCart_MouseLeave(object sender, EventArgs e)
        {
            btnShoppingCart.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnAdminProfile_MouseLeave(object sender, EventArgs e)
        {
            btnAdminProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpnlItems.Controls.Clear();
            CurrentProductList.Clear();

            foreach (var item in (List<Product>)productList[cmbProduct.SelectedIndex])
            {
                if (item.Category == cmbCategory.SelectedItem.ToString())
                {
                    CurrentProductList.Add(item);
                    PanelProduct pnl = panelCreator.CreatePanel(item);
                    flpnlItems.Controls.Add(pnl);
                }
                else if (cmbCategory.SelectedItem.ToString() == "Hepsi")
                {
                    CurrentProductList.Add(item);
                    PanelProduct pnl = panelCreator.CreatePanel(item);
                    flpnlItems.Controls.Add(pnl);
                }
            }

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpnlItems.Controls.Clear();
            cmbCategory.Items.Clear();
            switch (cmbProduct.SelectedIndex)
            {
                case 0:
                    string[] category = new string[] { "Hepsi", "Bilim Kurgu", "Klasik", "Kurgu", "Tarih", "Edebiyat" };
                    cmbCategory.Items.AddRange(category);
                    break;
                case 1:
                    category = new string[] { "Hepsi", "Gündem", "Haber", "Spor", "Bilişim", "Teknoloji", "Siyaset", "Bilim", "Tarih", "Yemek" };
                    cmbCategory.Items.AddRange(category);
                    break;
                case 2:
                    category = new string[] { "Hepsi", "Pop", "Rock", "Klasik", "Opera", "Caz", "Blues", "Rap" };
                    cmbCategory.Items.AddRange(category);
                    break;
                default:
                    break;
            }
            cmbCategory.SelectedIndex = 0;
            
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {         
            UserProfileForm userProfile = new UserProfileForm(user);
            user.printCustomerDetails(user);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            shoppingCart.ShowProducts();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfileForm root = new AdminProfileForm();
            root.ShowDialog();
            booklist.Clear();
            musiclist.Clear();
            magazinelist.Clear();
            CurrentProductList.Clear();
            booklist = FormLogin.DatabaseObject.BookLoader();
            CurrentProductList.AddRange(booklist);
            musiclist = FormLogin.DatabaseObject.MusicCDLoader();
            magazinelist = FormLogin.DatabaseObject.MagazineLoader();
            productList.Clear();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);
            btnAdminProfile.Visible = IsAdmin;
            cmbProduct_SelectedIndexChanged(cmbProduct, null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
