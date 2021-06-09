using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for FlightsMenu.xaml
    /// </summary>
    public partial class FlightsMenu : Window
    {
        private List<Flights> flightList = new List<Flights>();
        public FlightsMenu()
        {
            InitializeComponent();
            flightList.Add(new Flights(1, 1, "Yellowknife", "Toronto", "2021-02-14", 6.30));
            flightList.Add(new Flights(2, 2, "Washington", "New Hampsire", "2021-03-20", 18.30));
            flightList.Add(new Flights(3, 3, "Beruit", "Dehli", "2021-3-3", 9.30));
            flightList.Add(new Flights(4, 4, "Melbourne ", "Vancouver", "2021-1-27", 12.30));
            flightList.Add(new Flights(5, 5, "Dubai", "St.Petersburg", "2021-1-30", 6.30));

            var id = from flights in flightList
                     select flights.ID;

            listFlights.DataContext = id;
        }


        private void ListFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = listFlights.SelectedIndex;
            var selectedId = from flights in flightList
                             where flights.ID == i
                             select flights;

            foreach(var s in selectedId)
            {
                userId.Text = s.ID.ToString();
                userAirlineId.Text = s.AirlineId.ToString();
                userDepartureCity.Text = s.DepartureCity;
                userDestionationCity.Text = s.DestinationCity;
                userDepartureDate.Text = s.DepatureDate;
                userFlightTime.Text =s.FlightTime.ToString();
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
    }
}
