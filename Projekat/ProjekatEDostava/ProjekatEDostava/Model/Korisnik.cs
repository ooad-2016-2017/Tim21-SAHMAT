using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Korisnik:Osoba
    {
        List<Narudzba> narudzbe;
        List<Kupon> kuponi;
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

        public List<Kupon> Kuponi
        {
            get
            {
                return kuponi;
            }

            set
            {
                kuponi = value;
            }
        }

        public Korisnik() : base()
        {

        }
        public void dodajNarudzbu(Narudzba narudzba)
        {

        }
        public void dodajIskoristenKupon(Kupon kupon)
        {

        }
        public int dajStatusPopusta()
        {
            return 0;
        }
    }
}
