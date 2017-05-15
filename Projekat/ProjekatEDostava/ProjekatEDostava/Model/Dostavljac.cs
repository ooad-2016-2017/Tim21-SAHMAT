using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Dostavljac:Osoba
    {
        string imeRestorana;
        List<Narudzba> narudzbe;
        public Dostavljac() : base()
        {

        }
        public void skiniNarudzbu(int idNarudzbe)
        {

        }
        public string ImeRestorana
        {
            get
            {
                return imeRestorana;
            }

            set
            {
                imeRestorana = value;
            }
        }

        public List<Narudzba> Narudzbe
        {
            get
            {
                return narudzbe;
            }

            set
            {
                narudzbe = value;
            }
        }
    }
}
