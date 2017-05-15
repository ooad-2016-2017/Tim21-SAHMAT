using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Jelovnik
    {
        int id;
        List<Jelo> jela;
        static int trenutniID = 1;
        public Jelovnik()
        {
            id = trenutniID++;
        }
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
    }
}
