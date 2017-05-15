using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Jelovnik
    {
        #region varijable
        int id;
        List<Jelo> jela;
        static int trenutniID = 1;
        #endregion
        public Jelovnik()
        {
            id = trenutniID++;
        }
        #region metode
        public void izbrisiJelo(int idJela)
        {

        }
        public void azurirajJelo(int idJela)
        {

        }
        public string ispisiJelovnik()
        {
            return "";
        }
        public void dodajJelo(int idJela)
        {

        }
        #endregion
        #region geteri i seteri
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

        public List<Jelo> Jela
        {
            get
            {
                return jela;
            }

            set
            {
                jela = value;
            }
        }
        #endregion
    }
}
