using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Polozka
    {
        public int Mnozstvi { get; set; }
        public decimal Cena { get; set; }
        public bool JeDostupne { get; set; }

        public Polozka(int mnozstvi, decimal cena)
        {
            Mnozstvi = mnozstvi;
            Cena = cena;
            JeDostupne = mnozstvi > 0;
        }

        public decimal VypocitejCenu()
        {
            return Mnozstvi * Cena;
        }

        public int GetMnozstvi()
        {
            return Mnozstvi;
        }
    }
}
