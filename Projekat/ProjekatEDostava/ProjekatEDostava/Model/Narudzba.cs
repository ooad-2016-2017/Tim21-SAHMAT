using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Narudzba
    {
        #region VARIJABLE
        int id;
        static int trenutniID = 1;
        double cijena;
        DateTime datum;
        Kupon kupon;
        bool statusNarudzbe;
        List<StavkaNarudzbe> stavke;
        #endregion
        #region GETERI I SETERI
        public bool StatusNarudzbe
        {
            get
            {
                return statusNarudzbe;
            }

            set
            {
                statusNarudzbe = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

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

        public List<StavkaNarudzbe> Stavke
        {
            get
            {
                return stavke;
            }

            set
            {
                stavke = value;
            }
        }

        public Kupon Kupon
        {
            get
            {
                return kupon;
            }

            set
            {
                kupon = value;
            }
        }
        #endregion
        public Narudzba()
        {
            id = trenutniID++;
            statusNarudzbe = false;
            cijena = 0;
            datum = DateTime.Today;
        }
        #region metode
        public string prikaziNarudzbu()
        {
            return "";
        }
        public void validirajNarudzbu()
        {
        }
        public void obrisiStavku(int idStavke)
        {

        }
        public void dodajStavku(int idStavke)
        {

        }
        public void promjeniStatus()
        {

        }
        #endregion
    }
}
