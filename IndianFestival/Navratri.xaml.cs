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
    /// Interaction logic for Navratri.xaml
    /// </summary>
    public partial class Navratri : Window
    {
        public Navratri()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fest_Navratri_info.DataContext = App._info4;
            tb_Navratri_head.Text = "What is Navratri Festival?";
            fest_Navratri_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Navratri_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Navratri_info.Source = imgSur;
            //img_Navratri_TB.Text = "Diyas";
        }

        private void Btn_Navratri_intro(object sender, RoutedEventArgs e)
        {
            fest_Navratri_info.DataContext = App._info4;
            tb_Navratri_head.Text = "What is Navratri Festival?";
            fest_Navratri_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Navratri_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Navratri_info.Source = imgSur;
            //img_Navratri_TB.Text = "Diyas";
        }

        private void Btn_Navratri_EachDay(object sender, RoutedEventArgs e)
        {
            fest_Navratri_info.DataContext = App._info4;
            tb_Navratri_head.Text = "Significance of Each Day";
            fest_Navratri_info.SetBinding(TextBlock.TextProperty, "EachDay");
            Uri u = new Uri("image/Navratri_EachDay.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Navratri_info.Source = imgSur;
            img_Navratri_TB.Text = "Navadurga - The nine goddesses worshipped in Navaratri.";
        }

        private void Btn_Navratri_Practices(object sender, RoutedEventArgs e)
        {
            fest_Navratri_info.DataContext = App._info4;
            tb_Navratri_head.Text = "Religious Significance";
            fest_Navratri_info.SetBinding(TextBlock.TextProperty, "ReligiousPractices");
            Uri u = new Uri("image/Navratri_Practices.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Navratri_info.Source = imgSur;
            img_Navratri_TB.Text = "Durga Puja pandals in Kolkata during Navratri";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
