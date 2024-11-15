using PetStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PetStoreApp.Views
{
    /// <summary>
    /// Interaction logic for ServiceManagementWindow.xaml
    /// </summary>
    public partial class ServiceManagementWindow : Window
    {
        private List<Sluzba> services = new List<Sluzba>();
        private int serviceIdCounter = 1;

        public ServiceManagementWindow()
        {
            InitializeComponent();
            UpdateServiceList();
        }

        private void AddService(object sender, RoutedEventArgs e)
        {
            // Získáme vstupy z formuláře
            string category = ServiceCategory.Text;
            decimal price;
            DateTime date = ServiceDate.SelectedDate ?? DateTime.Now;

            if (decimal.TryParse(ServicePrice.Text, out price))
            {
                // Vytvoříme novou službu a přidáme ji do seznamu
                Sluzba newService = new Sluzba(serviceIdCounter++, date, category, price);
                services.Add(newService);

                // Aktualizujeme zobrazení seznamu služeb
                UpdateServiceList();

                // Vymažeme vstupy formuláře
                ServiceCategory.Clear();
                ServicePrice.Clear();
                ServiceDate.SelectedDate = null;
            }
            else
            {
                MessageBox.Show("Cena musí být číslo.");
            }
        }

        private void UpdateServiceList()
        {
            ServiceList.Items.Clear();
            foreach (var service in services)
            {
                ServiceList.Items.Add($"{service.Id}: {service.KategorieSluzby} - {service.DatumCas.ToShortDateString()} - {service.Cena} Kč");
            }
        }
    }
}
