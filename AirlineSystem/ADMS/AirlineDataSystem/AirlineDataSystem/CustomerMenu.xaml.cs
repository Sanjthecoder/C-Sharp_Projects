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
    /// Interaction logic for CustomerMenu.xaml
    /// </summary>
    public partial class CustomerMenu : Window
    {
        private List<Customer> customerList = new List<Customer>();
        public CustomerMenu()
        {
            InitializeComponent();
            customerList.Add(new Customer(0, "Sanji", "123 ham road","sanji@gmail.com", "289-991-4615"));
            customerList.Add(new Customer(1, "Fru", "1233 lamb road", "fru@gmail.com", "289-991-7563"));
            customerList.Add(new Customer(2, "Anton", "123 bingi road", "antoin@gmail.com", "289-991-6784"));
            customerList.Add(new Customer(3, "Keanu", "123 taco road", "keanu@gmail.com", "289-991-5354"));
            customerList.Add(new Customer(4, "Bingi", "1233 yarsp road", "bingi@gmail.com", "289-991-1244"));

            var id = from customer in customerList
                     select customer.ID;

            ListCustomer.DataContext = id;
        }

        private void ListCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = ListCustomer.SelectedIndex;
            var selectedId = from customer in customerList
                             where customer.ID == i
                             select customer;
            
            foreach(var s in selectedId)
            {
                userId.Text = s.ID.ToString();
                userName.Text = s.name;
                userAddress.Text = s.address;
                userEmail.Text = s.email;
                userPhone.Text = s.phone;
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
