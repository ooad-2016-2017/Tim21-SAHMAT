using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class UposlenikRestorana:Osoba
    {
        string imeRestorana;
        List<Narudzba> narudzbe;
        public UposlenikRestorana() : base()
        {

        }
        public void validirajNarudzbu(int idNarudzbe)
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
