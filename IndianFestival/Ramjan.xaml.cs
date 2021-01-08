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

namespace IndianFestival
{
    /// <summary>
    /// Interaction logic for Ramjan.xaml
    /// </summary>
    public partial class Ramjan : Window
    {
        public Ramjan()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fest_Ramjan_info.DataContext = App._info5;
            tb_Ramjan_head.Text = "What is Ramdan?";
            fest_Ramjan_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Ramjan_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ramjan_info.Source = imgSur;
            //img_Ramjan_TB.Text = "Diyas";
        }

        private void Btn_Ramjan_intro(object sender, RoutedEventArgs e)
        {
            fest_Ramjan_info.DataContext = App._info5;
            tb_Ramjan_head.Text = "What is Ramdan?";
            fest_Ramjan_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Ramjan_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ramjan_info.Source = imgSur;
            //img_Ramjan_TB.Text = "Diyas";
        }

        private void Btn_Ramjan_History(object sender, RoutedEventArgs e)
        {
            fest_Ramjan_info.DataContext = App._info5;
            tb_Ramjan_head.Text = "History";
            fest_Ramjan_info.SetBinding(TextBlock.TextProperty, "History");
            Uri u = new Uri("image/Ramjan_History.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ramjan_info.Source = imgSur;
            //img_Ramjan_TB.Text = "Diyas";s
        }

        private void Btn_Ramjan_Religious(object sender, RoutedEventArgs e)
        {
            fest_Ramjan_info.DataContext = App._info5;
            tb_Ramjan_head.Text = "Religious Significance";
            fest_Ramjan_info.SetBinding(TextBlock.TextProperty, "Religious");
            Uri u = new Uri("image/Ramjan_Significance.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ramjan_info.Source = imgSur;
            img_Ramjan_TB.Text = "Iftar at Sultan Ahmed Mosque In Istanbul, Turkey";
        }

        private void Btn_Ramjan_Cultural(object sender, RoutedEventArgs e)
        {
            fest_Ramjan_info.DataContext = App._info5;
            tb_Ramjan_head.Text = "Cultural Practices";
            fest_Ramjan_info.SetBinding(TextBlock.TextProperty, "Cultural");
            Uri u = new Uri("image/Ramjan_Cultural.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ramjan_info.Source = imgSur;
            img_Ramjan_TB.Text = "Ramadan in the Old City of Jerusalem";
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
