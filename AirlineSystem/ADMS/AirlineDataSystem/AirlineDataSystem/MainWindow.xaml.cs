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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string user = "pendu";
        private string pass = "bandre";
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((user == User.Text) && (pass == Pass.Password))
            {
                Window menu = new Menu();
                menu.ShowDialog();
                menu.Title = "Menu";

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
