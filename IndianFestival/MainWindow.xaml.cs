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

namespace IndianFestival
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
        private void Btn_Diwali(object sender, RoutedEventArgs e)
        {
            var information = new Information();
            information.Owner = this;
            Visibility = Visibility.Collapsed;
            //information.Show();

            information.ShowDialog();

        }
        private void Btn_Diwali_Text(object sender, RoutedEventArgs e)
        {
            var information = new Information();
            information.Owner = this;
            information.Show();
            Visibility = Visibility.Collapsed;
        }
        private void Btn_Vijayadashmi(object sender, RoutedEventArgs e)
        {
            var vijayadashmi = new Vijayadashami();
            vijayadashmi.Owner = this;
            vijayadashmi.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Vijayadashmi_Text(object sender, RoutedEventArgs e)
        {
            var vijayadashmi = new Vijayadashami();
            vijayadashmi.Owner = this;
            vijayadashmi.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Quiz(object sender, RoutedEventArgs e)
        {
            var quiz = new Quiz();
            quiz.Owner = this;
            quiz.Show();
            Visibility = Visibility.Collapsed;

        }

        private void Btn_Ganesh_Chaturthi(object sender, RoutedEventArgs e)
        {
            var ganesh = new Ganesh_Chaturthi();
            ganesh.Owner = this;
            ganesh.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Ganesh_Text(object sender, RoutedEventArgs e)
        {
            var ganesh = new Ganesh_Chaturthi();
            ganesh.Owner = this;
            ganesh.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Navratri(object sender, RoutedEventArgs e)
        {
            var navratri = new Navratri();
            navratri.Owner = this;
            navratri.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Navratri_Text(object sender, RoutedEventArgs e)
        {
            var navratri = new Navratri();
            navratri.Owner = this;
            navratri.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Ramjan(object sender, RoutedEventArgs e)
        {
            var ramjan = new Ramjan();
            ramjan.Owner = this;
            ramjan.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Ramjan_Text(object sender, RoutedEventArgs e)
        {
            var ramjan = new Ramjan();
            ramjan.Owner = this;
            ramjan.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Shivratri(object sender, RoutedEventArgs e)
        {
            var shivratri = new Shivratri();
            shivratri.Owner = this;
            shivratri.Show();
            Visibility = Visibility.Collapsed;
        }

        private void Btn_Shivratri_Text(object sender, RoutedEventArgs e)
        {
            var shivratri = new Shivratri();
            shivratri.Owner = this;
            shivratri.Show();
            Visibility = Visibility.Collapsed;
        }
    }
}
