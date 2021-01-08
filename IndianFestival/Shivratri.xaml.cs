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
    /// Interaction logic for Shivratri.xaml
    /// </summary>
    public partial class Shivratri : Window
    {
        public Shivratri()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "What is Maha Shivratri?";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Shivratri_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Shivratri_info.Source = imgSur;
            //img_Shivratri_TB.Text = "Diyas";
        }

        private void Btn_Shivratri_intro(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "What is Maha Shivratri?";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Shivratri_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Shivratri_info.Source = imgSur;
            //img_Shivratri_TB.Text = "Diyas";
        }

        private void Btn_Shivratri_History(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "History";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "History");
            Uri u = new Uri("image/Shivratri_History.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Shivratri_info.Source = imgSur;
            //img_Shivratri_TB.Text = "Diyas";
        }

        private void Btn_Shivratri_Significance(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "Significance";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "significance");
            Uri u = new Uri("image/Shivratri_Significance.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Shivratri_info.Source = imgSur;
            img_Shivratri_TB.Text = "Mahasivaratri is observed at night, usually in lighted temples or specially prepared prabha";
        }

        private void Btn_Shivratri_Story(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "Stories & Beliefs";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "story");
            Uri u = new Uri("image/Shivratri_story.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Shivratri_info.Source = imgSur;
            //img_Shivratri_TB.Text = "Diyas";
        }

        private void Btn_Shivratri_Description(object sender, RoutedEventArgs e)
        {
            fest_Shivratri_info.DataContext = App._info6;
            tb_Shivratri_head.Text = "Description";
            fest_Shivratri_info.SetBinding(TextBlock.TextProperty, "description");
            //Uri u = new Uri("image/Diwali_intro.jpg", UriKind.Relative);
            //BitmapImage imgSur = new BitmapImage(u);
            //img_Shivratri_info.Source = imgSur;
            //img_Shivratri_TB.Text = "Diyas";
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
