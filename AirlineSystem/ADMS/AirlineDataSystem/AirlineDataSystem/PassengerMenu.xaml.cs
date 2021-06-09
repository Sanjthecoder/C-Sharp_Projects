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
    /// Interaction logic for PassengerMenu.xaml
    /// </summary>
    public partial class PassengerMenu : Window
    {
        private List<Passenger> passengerList = new List<Passenger>();
        public PassengerMenu()
        {
            InitializeComponent();
            passengerList.Add(new Passenger(0, 0, 0));
            passengerList.Add(new Passenger(1, 1, 1));
            passengerList.Add(new Passenger(2, 2, 2));
            passengerList.Add(new Passenger(3, 3, 3));
            passengerList.Add(new Passenger(4, 4, 4));

            var id = from passengers in passengerList
                     select passengers.ID;

            lstPassenger.DataContext = id;

        }

        private void lstPassenger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstPassenger.SelectedIndex;

            var selectedId = from passengers in passengerList
                             where passengers.ID == i
                             select passengers;

            foreach(var s in selectedId)
            {
                userId.Text = s.ID.ToString();
                userCustomerId.Text = s.customerId.ToString();
                userFlightId.Text = s.flightId.ToString();

            }


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(userId.Text == "" || userCustomerId.Text == "" || userFlightId.Text == "")
            {
                MessageBox.Show("Please fill in all boxes", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                passengerList.Add(new Passenger(Int32.Parse(userId.Text), Int32.Parse(userCustomerId.Text), Int32.Parse(userFlightId.Text) ));

                var id = from passengers in passengerList
                         select passengers.ID;

                lstPassenger.DataContext = id;

            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {


            Passenger c = new Passenger(Int32.Parse(userId.Text), Int32.Parse(userCustomerId.Text), Int32.Parse(userFlightId.Text));

            c = passengerList[lstPassenger.SelectedIndex];


            var id = from passengers in passengerList
                     select passengers.ID;

            lstPassenger.DataContext = id;



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
