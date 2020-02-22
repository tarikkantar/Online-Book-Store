using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public enum MagazineType
    {
        Gündem,
        Haber,
        Spor,
        Bilişim,
        Teknoloji,
        Siyaset,
        Bilim,
        Tarih,
        Yemek
    }

    public class Magazine : Product
    {
        private string issue;
        private MagazineType magazineType;
        private string isbn;

        public string Issue
        {
            get
            {
                return issue;
            }
            set
            {
                issue = value;
            }
        }

        internal MagazineType MagazineType
        {
            get
            {
                return magazineType;
            }
            set
            {
                magazineType = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public Magazine(string id, string name, double price) : base(id, name, price) { }

        public override void ShowDetails()
        {
            MagazineForm magazineForm = new MagazineForm(this);
            magazineForm.ShowDialog();
            magazineForm.Dispose();
        }

        public static MagazineType GetMagazineType(string Mtype)
        {
            MagazineType magazineType = new MagazineType();
            switch (Mtype)
            {
                case "Gündem":
                    magazineType = MagazineType.Gündem;
                    break;
                case "Haber":
                    magazineType = MagazineType.Haber;
                    break;
                case "Spor":
                    magazineType = MagazineType.Spor;
                    break;
                case "Bilişim":
                    magazineType = MagazineType.Bilişim;
                    break;
                case "Teknoloji":
                    magazineType = MagazineType.Teknoloji;
                    break;
                case "Siyaset":
                    magazineType = MagazineType.Siyaset;
                    break;
                case "Bilim":
                    magazineType = MagazineType.Bilim;
                    break;
                case "Tarih":
                    magazineType = MagazineType.Tarih;
                    break;
                case "Yemek":
                    magazineType = MagazineType.Yemek;
                    break;
                default:
                    magazineType = MagazineType.Gündem;
                    break;
            }
            return magazineType;
        }
    }
}
