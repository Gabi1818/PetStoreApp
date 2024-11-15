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
            new Zbozi(1, "Krmivo", 10, 100),
            new Zbozi(2, "Hračky", 15, 50)
        };
        }
    }
}
