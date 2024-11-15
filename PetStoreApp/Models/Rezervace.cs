using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Rezervace
    {
        public int Id { get; set; }
        public DateTime DatumUskutecneni { get; set; }
        public DateTime DatumVyprseni { get; set; }
        public Polozka PolozkaRezervace { get; set; }
        public Zakaznik Zakaznik { get; set; }

        public Rezervace(DateTime datum, Polozka polozka, Zakaznik zakaznik)
        {
            Id = new Random().Next(1000, 9999); // Pro příklad generujeme ID náhodně
            DatumUskutecneni = datum;
            DatumVyprseni = datum.AddDays(7); // Nastavení vypršení za 7 dní
            PolozkaRezervace = polozka;
            Zakaznik = zakaznik;
        }
    }
}
