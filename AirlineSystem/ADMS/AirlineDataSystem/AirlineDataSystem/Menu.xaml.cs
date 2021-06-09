using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm1
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

     

        private void btnPassenger(object sender, RoutedEventArgs e)
        {
            Window passenger = new PassengerMenu();
            passenger.ShowDialog();
            passenger.Title = "Passengers";
        }

        private void btnFlights(object sender, RoutedEventArgs e)
        {
            Window flights = new FlightsMenu();
            flights.ShowDialog();
            flights.Title = "Flights";

        }

        private void btnAirline(object sender, RoutedEventArgs e)
        {
            Window airline = new AirlineMenu();
            airline.ShowDialog();
            airline.Title = "Airlines";


        }

        private void btnCustomer(object sender, RoutedEventArgs e)
        {
            Window customer = new CustomerMenu();
            customer.ShowDialog();
            customer.Title = "Customers";

        }
    }
}
