using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class StavkaNarudzbe
    {
        #region varijable
        int id;
        static int trenutniID = 1;
        int kolicina;
        double cijena;
        Jelo jelo;
        #endregion
        #region geteri i seteri
        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
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

        public Jelo Jelo
        {
            get
            {
                return jelo;
            }

            set
            {
                jelo = value;
            }
        }
        #endregion
        public StavkaNarudzbe()
        {
            id = trenutniID++;
            cijena = 0;
            kolicina = 0;
        }
    }
}
