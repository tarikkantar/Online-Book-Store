using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public enum MusicType
    {
        Pop,
        Rock,
        Klasik,
        Opera,
        Caz,
        Blues,
        Rap
    }

    public class MusicCD : Product
    {
        private int releaseDate;
        private string singer;
        private string isbn;
        private string content;
        private MusicType cdType;

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

        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
            }
        }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        internal MusicType CdType
        {
            get
            {
                return cdType;
            }

            set
            {
                cdType = value;
            }
        }

        public MusicCD(string id, string name, double price) : base(id, name, price) { }

        public override void ShowDetails()
        {
            MusicForm musicForm = new MusicForm(this);
            musicForm.ShowDialog();
            musicForm.Dispose();
        }

        public static MusicType GetMusicType(string Mtype)
        {
            MusicType musicType = new MusicType();
            switch (Mtype)
            {
                case "Pop":
                    musicType = MusicType.Pop;
                    break;
                case "Blues":
                    musicType = MusicType.Blues;
                    break;
                case "Caz":
                    musicType = MusicType.Caz;
                    break;
                case "Klasik":
                    musicType = MusicType.Klasik;
                    break;
                case "Opera":
                    musicType = MusicType.Opera;
                    break;
                case "Rap":
                    musicType = MusicType.Rap;
                    break;
                case "Rock":
                    musicType = MusicType.Rock;
                    break;
                default:
                    musicType = MusicType.Pop;
                    break;
            }
            return musicType;
        }
    }
}
