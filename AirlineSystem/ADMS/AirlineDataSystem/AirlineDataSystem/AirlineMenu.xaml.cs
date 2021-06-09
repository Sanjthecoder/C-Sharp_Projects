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
    /// Interaction logic for AirlineMenu.xaml
    /// </summary>
    public partial class AirlineMenu : Window
    {
        private List<Airline> airline = new List<Airline>();
        public AirlineMenu()
        {
            InitializeComponent();
            airline.Add(new Airline(1, "Air Canada", "SR71-Fighter Jet", 2, "beef"));
            airline.Add(new Airline(2, "NATO", "Water Bomber", 2, "Chicken"));
            airline.Add(new Airline(3, "USA Military", "Transport", 40, "Rat Stew"));
            airline.Add(new Airline(4, "Quantis", "Medium Passenger", 124, "Gumbo"));
            airline.Add(new Airline(5, "Emirates", "Boeing 787-9", 400, "halal beef"));

        }
    }
}
