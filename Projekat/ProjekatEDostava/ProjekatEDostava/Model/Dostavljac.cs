using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Dostavljac:Osoba
    {
        #region varijable
        string imeRestorana;
        List<Narudzba> narudzbe;
        #endregion
        public Dostavljac() : base()
        {

        }
        #region metode
        public void skiniNarudzbu(int idNarudzbe)
        {

        }
        #endregion
        #region geteri i seteri
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
        #endregion
    }
}
