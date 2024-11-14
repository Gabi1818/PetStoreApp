using PetStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Zbozi> ZboziList { get; set; }

        public MainViewModel()
        {
            ZboziList = new ObservableCollection<Zbozi>
            {
                new Zbozi { Id = 1, Kategorie = "Krmivo", MnozstviNaSklade = 10, Cena = 100 },
                new Zbozi { Id = 2, Kategorie = "Hračky", MnozstviNaSklade = 15, Cena = 50 }
            };
        }
    }
}
