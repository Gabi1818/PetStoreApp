using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.Models
{
    public class Zbozi
    {
        public int Id { get; set; }
        public string Kategorie { get; set; }
        public int MnozstviNaSklade { get; set; }
        public decimal Cena { get; set; }
    }
}
