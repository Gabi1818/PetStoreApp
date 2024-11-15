using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Sluzba
    {
        public int Id { get; set; }
        public DateTime DatumCas { get; set; }
        public string KategorieSluzby { get; set; }
        public decimal Cena { get; set; }

        public Sluzba(int id, DateTime datumCas, string kategorieSluzby, decimal cena)
        {
            Id = id;
            DatumCas = datumCas;
            KategorieSluzby = kategorieSluzby;
            Cena = cena;
        }
    }
}
