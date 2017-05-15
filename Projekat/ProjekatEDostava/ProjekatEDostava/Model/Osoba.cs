using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatEDostava.Model
{
    public class Osoba
    {
        string ime;
        string prezime;
        int id;
        string brTelefona;
        string adresa;
        string username;
        string password;
        Image slika;
        static int trenutniID = 1;
        public Osoba()
        {
            id = trenutniID++;
        }
        public string ispisiOsobu()
        {
            return "";
        }
        

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
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

        public string BrTelefona
        {
            get
            {
                return brTelefona;
            }

            set
            {
                brTelefona = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }
    }
}
