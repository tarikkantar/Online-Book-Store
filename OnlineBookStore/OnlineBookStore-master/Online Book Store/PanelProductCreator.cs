using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class PanelProductCreator
    {
        public PanelProduct CreatePanel(Product product)
        {
            PanelProduct panel = null;

            if (product is Book)
            {
                panel = new BookPanel((Book)product);
            }
            else if (product is Magazine)
            {
                panel = new MagazinePanel((Magazine)product);
            }
            else
                panel = new MusicCdPanel((MusicCD)product);

            return panel;
        }
    }
}
