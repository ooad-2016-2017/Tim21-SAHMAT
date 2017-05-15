using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatEDostava.Model
{
    public class eDostava
    {
        List<Osoba> osobe;
        List<Restoran> restorani;
        public void dodajRestoran(Restoran restoran)
        {

        }
        public void brisiRestoran(int idRestorana)
        {

        }
        public void azurirajRestoran(int idRestoran)
        {

        }
        public void dodajOsobu(Osoba osoba)
        {

        }
        public void brisiOsobu(int idOsobe)
        {

        }
        public void azurirajOsobu(int idOsobe)
        {

        }
        public List<Osoba> Osobe
        {
            get
            {
                return osobe;
            }

            set
            {
                osobe = value;
            }
        }

        public List<Restoran> Restorani
        {
            get
            {
                return restorani;
            }

            set
            {
                restorani = value;
            }
        }
    }
}
