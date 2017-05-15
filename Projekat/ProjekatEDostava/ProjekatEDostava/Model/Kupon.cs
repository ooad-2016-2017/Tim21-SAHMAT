using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class Kupon
    {
        int id;
        static int trenutniID = 1;
        string kod;
        double kolicinaPopusta;
        bool tipKupona;

        public string Kod
        {
            get
            {
                return kod;
            }

            set
            {
                kod = value;
            }
        }

        public double KolicinaPopusta
        {
            get
            {
                return kolicinaPopusta;
            }

            set
            {
                kolicinaPopusta = value;
            }
        }

        public bool TipKupona
        {
            get
            {
                return tipKupona;
            }

            set
            {
                tipKupona = value;
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
        public Kupon()
        {
            id = trenutniID++;
            kod = "";
            TipKupona = false;
            kolicinaPopusta = 0;
        }
    }
}
