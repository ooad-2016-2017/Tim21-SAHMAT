using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Racun
    {
        static int trenutniID = 1;
        int id;
        public Racun()
        {
            id = trenutniID++;
        }
        public void printajRacun()
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
    }
}
