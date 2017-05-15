using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Korisnik:Osoba
    {
        #region varijable
        List<Narudzba> narudzbe;
        List<Kupon> kuponi;
        #endregion
        #region geteri i seteri
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
        #endregion
        public Korisnik() : base()
        {

        }
        #region metode
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
        #endregion
    }
}
