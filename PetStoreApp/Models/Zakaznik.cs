using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }

        public Zakaznik(int id, string jmeno, string prijmeni, string email)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
        }

        public Rezervace VytvorRezervaci(DateTime datum, Polozka polozka)
        {
            return new Rezervace(datum, polozka, this);
        }

        public void ZaplatObjednavku(Objednavka objednavka)
        {
            // Logika pro zaplacení objednávky
            Console.WriteLine($"Zákazník {Jmeno} zaplatil objednávku {objednavka.Id}");
        }

        public void NajmiSluzbu(Sluzba sluzba)
        {
            // Logika pro najmutí služby
            Console.WriteLine($"Zákazník {Jmeno} si najal službu {sluzba.KategorieSluzby}");
        }
    }
}
