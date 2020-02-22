using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public partial class AdminProfileForm : Form
    {
        DataSet dataset;
        int index;
        static string ImagePath;
        static TextBox[] customerTextArray;
        static TextBox[] bookTextArray;
        static TextBox[] magazineTextArray;
        static TextBox[] musicCDTextArray;

        public AdminProfileForm()
        {
            InitializeComponent();
            dataset = new DataSet();
            FormLogin.DatabaseObject.Refresh(dataset);
            dgvBooks.DataSource = dataset.Tables[0];
            dgvCustomers.DataSource = dataset.Tables[1];
            dgvMusicCds.DataSource = dataset.Tables[2];
            dgvMagazines.DataSource = dataset.Tables[3];
            dgvCustomers.SelectAll();
            customerTextArray = new TextBox[] { txtCustomerName, txtCustomerSurname, txtCustomerAddress, txtCustomerEmail, txtCustomerUsername, txtCustomerPassword };
            bookTextArray = new TextBox[] { txtBookName, txtBookPrice, txtBookIsbn, txtBookAuthor, txtBookPublisher, txtBookPage, txtBookContent, txtBookCategory };
            magazineTextArray = new TextBox[] { txtMagazineName, txtMagazinePrice, txtMagazineCategory, txtMagazineIssue, txtMagazineIsbn };
            musicCDTextArray = new TextBox[] { txtMusicCdName, txtMusicCdPrice, txtMusicCdSinger, txtMusicCdCategory, txtMusicCdIsbn, txtMusicCdReleaseDate, txtMusicCdContent };
            btnCustomerDelete.Enabled = false;
            btnCustomerUpdate.Enabled = false;
            btnAddBook.Enabled = true;
            btnBookUpdate.Enabled = false;
            btnBookDelete.Enabled = false;
            btnBookImageChange.Enabled = true;
            btnAddMagazine.Enabled = true;
            btnMagazineImage.Enabled = true;
            btnDeleteMagazine.Enabled = false;
            btnUpdateMagazine.Enabled = false;
            btnAddMusicCd.Enabled = true;
            btnDeleteMusicCd.Enabled = false;
            btnUpdateMusicCd.Enabled = false;
            btnMusicCdImage.Enabled = true;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                btnCustomerDelete.Enabled = true;
                btnCustomerUpdate.Enabled = true;
                DataGridViewRow row = dgvCustomers.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                txtCustomerName.Text = cells[1].Value.ToString().Trim();
                txtCustomerSurname.Text = cells[2].Value.ToString().Trim();
                txtCustomerAddress.Text = cells[3].Value.ToString().Trim();
                txtCustomerEmail.Text = cells[4].Value.ToString().Trim();
                txtCustomerUsername.Text = cells[5].Value.ToString().Trim();
                txtCustomerPassword.Text = cells[6].Value.ToString().Trim();
                if (Convert.ToInt32(cells[8].Value) == 1)
                    cbIsAdmin.Checked = true;
                else
                    cbIsAdmin.Checked = false;
            }
            catch (Exception)
            {

            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                btnBookUpdate.Enabled = true;
                btnBookDelete.Enabled = true;
                btnBookImageChange.Enabled = true;
                DataGridViewRow row = dgvBooks.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                txtBookName.Text = cells[1].Value.ToString().Trim();
                txtBookPrice.Text = cells[2].Value.ToString().Trim();
                txtBookIsbn.Text = cells[3].Value.ToString().Trim();
                txtBookAuthor.Text = cells[4].Value.ToString().Trim();
                txtBookPublisher.Text = cells[5].Value.ToString().Trim();
                txtBookPage.Text = cells[6].Value.ToString().Trim();
                txtBookContent.Text = cells[7].Value.ToString().Trim();
                txtBookCategory.Text = cells[8].Value.ToString().Trim();

                try
                {
                    pbBook.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbBook.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbBook.Image = null;
                }

            }
            catch (Exception)
            {

            }
        }

        private void dgvMagazines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                btnMagazineImage.Enabled = true;
                btnUpdateMagazine.Enabled = true;
                btnDeleteMagazine.Enabled = true;
                btnMagazineImage.Enabled = true;
                DataGridViewRow row = dgvMagazines.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                txtMagazineName.Text = cells[1].Value.ToString().Trim();
                txtMagazinePrice.Text = cells[2].Value.ToString().Trim();
                txtMagazineCategory.Text = cells[3].Value.ToString().Trim();
                txtMagazineIssue.Text = cells[4].Value.ToString().Trim();
                txtMagazineIsbn.Text = cells[5].Value.ToString().Trim();
                try
                {
                    pbMagazineImage.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbMagazineImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbMagazineImage.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvMusicCds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                btnUpdateMusicCd.Enabled = true;
                btnDeleteMusicCd.Enabled = true;
                btnMusicCdImage.Enabled = true;
                DataGridViewRow row = dgvMusicCds.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                txtMusicCdName.Text = cells[1].Value.ToString().Trim();
                txtMusicCdPrice.Text = cells[2].Value.ToString().Trim();
                txtMusicCdSinger.Text = cells[3].Value.ToString().Trim();
                txtMusicCdCategory.Text = cells[4].Value.ToString().Trim();
                txtMusicCdIsbn.Text = cells[5].Value.ToString().Trim();
                txtMusicCdReleaseDate.Text = cells[6].Value.ToString().Trim();
                txtMusicCdContent.Text = cells[7].Value.ToString().Trim();
                try
                {
                    pbMusicCdImage.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbMusicCdImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbMusicCdImage.Image = null;
                }

            }
            catch (Exception)
            {

            }
        }

        private void tabctrlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs a = new DataGridViewCellEventArgs(0, 0);

            if (tabctrlAdmin.SelectedIndex == 0)
            {
                dgvCustomers.ClearSelection();
                dgvCustomers_CellClick(dgvCustomers, a);
            }
            else if (tabctrlAdmin.SelectedIndex == 1)
            {
                dgvBooks.ClearSelection();
                dgvBooks_CellClick(dgvBooks, a);
            }
            else if (tabctrlAdmin.SelectedIndex == 2)
            {
                dgvMagazines.ClearSelection();
                dgvMagazines_CellClick(dgvMagazines, a);
            }
            else
            {
                dgvMusicCds.ClearSelection();
                dgvMusicCds_CellClick(dgvMusicCds, a);
            }
        }

        private bool IsValidEmail(string email)
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

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(customerTextArray) || !IsValidEmail(txtCustomerEmail.Text))
            {
                MessageBox.Show("Boş alanları doldurun ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer tempCustomer = new Customer();
            tempCustomer.CustomerID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString().Trim());
            tempCustomer.Name = txtCustomerName.Text;
            tempCustomer.Surname = txtCustomerSurname.Text;
            tempCustomer.Address = txtCustomerAddress.Text;
            tempCustomer.Email = txtCustomerEmail.Text;
            tempCustomer.Username = txtCustomerUsername.Text;
            tempCustomer.Password = txtCustomerPassword.Text;
            if (cbIsAdmin.Checked == true)
            {
                tempCustomer.IsAdmin = true;
            }
            else
            {
                tempCustomer.IsAdmin = false;
            }
            FormLogin.DatabaseObject.CustomerUpdate(tempCustomer);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private bool checkWhiteSpace(TextBox[] array)
        {
            foreach (var item in array)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                    return false;
            }
            return true;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            delete(btnCustomerDelete);
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] values = {dgvBooks.CurrentRow.Cells[0].Value.ToString().Trim(), txtBookName.Text.Trim(),txtBookPrice.Text.Trim(), txtBookIsbn.Text.Trim(),
                txtBookAuthor.Text.Trim(), txtBookPublisher.Text.Trim(),txtBookPage.Text.Trim(), txtBookContent.Text.Trim(), txtBookCategory.Text.Trim() };
            FormLogin.DatabaseObject.BookUpdate(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnUpdateMagazine_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(magazineTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] values = {dgvMagazines.CurrentRow.Cells[0].Value.ToString().Trim(), txtMagazineName.Text.Trim(), txtMagazinePrice.Text.Trim(), txtMagazineCategory.Text.Trim(),
                txtMagazineIssue.Text.Trim(), txtMagazineIsbn.Text.Trim() };
            FormLogin.DatabaseObject.MagazineUpdate(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnUpdateMusicCd_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] values = { dgvMusicCds.CurrentRow.Cells[0].Value.ToString().Trim(), txtMusicCdName.Text.Trim(),txtMusicCdPrice.Text.Trim(), txtMusicCdSinger.Text.Trim(),
                txtMusicCdCategory.Text.Trim(), txtMusicCdIsbn.Text.Trim(),txtMusicCdReleaseDate.Text.Trim(),txtMusicCdContent.Text.Trim()};
            FormLogin.DatabaseObject.MusicCdUpdate(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            dgvBooks.SelectedCells[0].Selected = false;

            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = "1521201910";
            id += (dgvBooks.RowCount + 1).ToString().Trim();
            string[] values = new string[bookTextArray.Length + 1];
            values[0] = id;
            for (int i = 1; i < bookTextArray.Length + 1; i++)
            {
                values[i] = bookTextArray[i - 1].Text.Trim();
            }
            UploadPicture(id);
            FormLogin.DatabaseObject.AddBook(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {


            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = "1523201910";
            id += (dgvMagazines.RowCount + 1).ToString().Trim();
            string[] values = new string[magazineTextArray.Length + 1];
            values[0] = id;
            for (int i = 1; i < magazineTextArray.Length + 1; i++)
            {
                values[i] = magazineTextArray[i - 1].Text;
            }
            UploadPicture(id);
            FormLogin.DatabaseObject.AddMagazine(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnAddMusicCd_Click(object sender, EventArgs e)
        {

            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = "1522201910";
            id += (dgvMusicCds.RowCount + 1).ToString().Trim();
            string[] values = new string[musicCDTextArray.Length + 1];
            values[0] = id;
            for (int i = 1; i < musicCDTextArray.Length + 1; i++)
            {
                values[i] = musicCDTextArray[i - 1].Text;
            }
            UploadPicture(id);
            FormLogin.DatabaseObject.AddMusicCd(values);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            delete(btnBookDelete);
        }

        private void btnDeleteMagazine_Click(object sender, EventArgs e)
        {
            delete(btnDeleteMagazine);
        }

        private void btnDeleteMusicCd_Click(object sender, EventArgs e)
        {
            delete(btnDeleteMusicCd);
        }

        private void delete(object sender)
        {
            string table = "";
            string Id;
            var btn = sender as Button;
            if (btn.Name == "btnCustomerDelete")
            {
                Customer cstmr = new Customer();
                table = "[Customer]";
                DataGridViewRow row = dgvCustomers.Rows[index];

                Id = row.Cells[0].Value.ToString();
                if (Id == cstmr.CustomerID.ToString())
                {
                    MessageBox.Show("Kendinizi Silemezsiniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (btn.Name == "btnBookDelete")
            {
                table = "[Book]";
                DataGridViewRow row = dgvBooks.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            else if (btn.Name == "btnDeleteMusicCd")
            {
                table = "[MusicCd]";
                DataGridViewRow row = dgvMusicCds.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            else
            {
                table = "[Magazine]";
                DataGridViewRow row = dgvMagazines.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            FormLogin.DatabaseObject.Delete(table, Id);
            dataset.Clear();
            FormLogin.DatabaseObject.Refresh(dataset);
        }

        public void SetPicture(PictureBox pb)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // masaüstünü göstermesi için
            openFileDialog1.Filter = "Resim Dosyası |*.jpg";        // dosya filtrelemesi
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                            pb.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                            ImagePath = openFileDialog1.FileName;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }

        }

        private void btnMusicCdImage_Click(object sender, EventArgs e)
        {
            try
            {
                SetPicture(pbMusicCdImage);
                pbMusicCdImage.BackgroundImageLayout = ImageLayout.Stretch;
                string id = dgvMusicCds.CurrentRow.Cells[0].Value.ToString().Trim();
                UploadPicture(id);
            }
            catch (Exception)
            {
            }
        }

        private void btnBookImageChange_Click(object sender, EventArgs e)
        {
            try
            {
                SetPicture(pbBook);
                pbBook.BackgroundImageLayout = ImageLayout.Stretch;
                string id = dgvBooks.CurrentRow.Cells[0].Value.ToString().Trim();
                UploadPicture(id);
            }
            catch (Exception)
            {
            }
        }

        private void btnMagazineImage_Click(object sender, EventArgs e)
        {
            try
            {
                SetPicture(pbMagazineImage);
                pbMagazineImage.BackgroundImageLayout = ImageLayout.Stretch;
                string id = dgvMagazines.CurrentRow.Cells[0].Value.ToString().Trim();
                UploadPicture(id);
            }
            catch (Exception)
            {
            }
        }

        private void UploadPicture(string ID)
        {
            try
            {
                string destpath = Application.StartupPath + @"\Resources\" + ID + ".jpg";

                if (File.Exists(destpath))
                {
                    File.Delete(destpath);
                }
                    System.IO.File.Copy(ImagePath, destpath);
            }
            catch (Exception)
            {
            }
        }
    }
}
