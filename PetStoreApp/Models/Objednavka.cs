using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Objednavka
    {
        public int Id { get; set; }
        public List<Polozka> Polozky { get; set; } = new List<Polozka>();

        public Objednavka(int id)
        {
            Id = id;
        }

        public void PridejPolozku(Polozka polozka)
        {
            Polozky.Add(polozka);
        }

        public List<Polozka> GetSeznamPolozek()
        {
            return Polozky;
        }
    }
}
