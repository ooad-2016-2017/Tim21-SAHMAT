using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Racun
    {
        #region varijable
        static int trenutniID = 1;
        int id;
        #endregion
        public Racun()
        {
            id = trenutniID++;
        }
        #region metode
        public void printajRacun()
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
        #endregion
    }
}
