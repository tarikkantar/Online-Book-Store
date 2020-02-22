using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    abstract class PanelProduct : Panel
    {
        public Label name;
        public PictureBox Picture;
        public PictureBox Add_Cart;
        public PictureBox Show_Details;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
