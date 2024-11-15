using PetStoreApp.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PetStoreApp.Views;

namespace PetStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCustomerManagement(object sender, RoutedEventArgs e)
        {
            // Otevře okno pro správu zákazníků
            //CustomerManagementWindow customerWindow = new CustomerManagementWindow();
            //customerWindow.Show();
        }

        private void OpenProductManagement(object sender, RoutedEventArgs e)
        {
            // Otevře okno pro správu zboží
            //ProductManagementWindow productWindow = new ProductManagementWindow();
            //productWindow.Show();
        }

        private void OpenServiceManagement(object sender, RoutedEventArgs e)
        {
            // Otevře okno pro správu služeb
            ServiceManagementWindow serviceWindow = new ServiceManagementWindow();
            serviceWindow.Show();
        }

        private void OpenReservationManagement(object sender, RoutedEventArgs e)
        {
            // Otevře okno pro správu rezervací
            //ReservationManagementWindow reservationWindow = new ReservationManagementWindow();
            //reservationWindow.Show();
        }
    }
}