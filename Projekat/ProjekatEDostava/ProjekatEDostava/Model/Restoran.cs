using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatEDostava.Model
{
    public class Restoran
    {
        int id;
        string naziv;
        string adresa;
        Dictionary<string, string> web;
        double ocjena;
        List<string> reviews;
        string brTelefona;
        bool status;
        string radnoVrijeme;
        string radniDani;
        Image logo;
        bool onlinePlacanje;
        string vrijemeDostave;
        string opis;
        double minCijenaDostave;
        bool promoKod;
        string kratkiOpis;
        List<Dostavljac> dostavljaci;
        List<Narudzba> narudzbe;
        List<Kupon> kuponi;
        Jelovnik jelovnik;
        static int trenutniID = 1;
        public Restoran()
        {
            id = trenutniID++;
        }
        public void dodajReview(string review)
        {

        }
        public void dodajDostavljaca(Dostavljac dostavljac)
        {

        }
        public void obrisiDostavljaca(int idDostavljaca)
        {

        }
        public void dodajKupon(Kupon kupon)
        {

        }
        public void obrisiKupon(int idKupona)
        {

        }
        public void izmjeniKupon(int idKupona)
        {

        }
        public void dodajWeb(string s1, string s2)
        {

        }
        public void brisiWeb(string s)
        {

        }
        public void azurirajWeb(string s1, string s2)
        {

        }
        public void dodajUposlenog(UposlenikRestorana ur)
        {

        }
        public void obrisiUposlenog(int idUposlenog)
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

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
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

        public Dictionary<string, string> Web
        {
            get
            {
                return web;
            }

            set
            {
                web = value;
            }
        }

        public double Ocjena
        {
            get
            {
                return ocjena;
            }

            set
            {
                ocjena = value;
            }
        }

        public List<string> Reviews
        {
            get
            {
                return reviews;
            }

            set
            {
                reviews = value;
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

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string RadnoVrijeme
        {
            get
            {
                return radnoVrijeme;
            }

            set
            {
                radnoVrijeme = value;
            }
        }

        public string RadniDani
        {
            get
            {
                return radniDani;
            }

            set
            {
                radniDani = value;
            }
        }

        public Image Logo
        {
            get
            {
                return logo;
            }

            set
            {
                logo = value;
            }
        }

        public bool OnlinePlacanje
        {
            get
            {
                return onlinePlacanje;
            }

            set
            {
                onlinePlacanje = value;
            }
        }

        public string VrijemeDostave
        {
            get
            {
                return vrijemeDostave;
            }

            set
            {
                vrijemeDostave = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public double MinCijenaDostave
        {
            get
            {
                return minCijenaDostave;
            }

            set
            {
                minCijenaDostave = value;
            }
        }

        public bool PromoKod
        {
            get
            {
                return promoKod;
            }

            set
            {
                promoKod = value;
            }
        }

        public string KratkiOpis
        {
            get
            {
                return kratkiOpis;
            }

            set
            {
                kratkiOpis = value;
            }
        }

        public List<Dostavljac> Dostavljaci
        {
            get
            {
                return dostavljaci;
            }

            set
            {
                dostavljaci = value;
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

        public Jelovnik Jelovnik
        {
            get
            {
                return jelovnik;
            }

            set
            {
                jelovnik = value;
            }
        }

        public List<Kupon> Kuponi
        {
            get
            {
                return kuponi;
            }

            set
            {
                kuponi = value;
            }
        }
    }
}
