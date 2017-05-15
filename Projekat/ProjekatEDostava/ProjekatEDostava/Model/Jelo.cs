using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatEDostava.Model
{
    public class Jelo
    {
        int id;
        static int trenutniID = 1;
        Image slika;
        string naziv;
        string opis;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }
        public Jelo()
        {
            id = trenutniID++;

        }
        public void promjeniSliku(Image _slika)
        {
            
        }
        public void promjeniOpis(string _opis)
        {

        }
        public string ispisiJelo()
        {
            return "";
        }
    }
}
