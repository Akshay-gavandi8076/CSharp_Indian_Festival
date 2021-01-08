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
    /// Interaction logic for Vijayadashami.xaml
    /// </summary>
    public partial class Vijayadashami : Window
    {
        public Vijayadashami()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Vijayadashmi_info.DataContext = App._info2;
            tb_Vijayadashmi_head.Text = "What is Vijayadashami Festival?";
            Vijayadashmi_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Vijayadashami_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Vijayadasmi_info.Source = imgSur;
            img_Vijayadashmi_TB.Text = "Vijayadasami reveres either Durga's or Rama's victory over evil depending on the region.";
        }

        private void Btn_Vijayadashmi_intro(object sender, RoutedEventArgs e)
        {
            Vijayadashmi_info.DataContext = App._info2;
            tb_Vijayadashmi_head.Text = "What is Vijayadashami Festival?";
            Vijayadashmi_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Vijayadashami_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Vijayadasmi_info.Source = imgSur;
            img_Vijayadashmi_TB.Text = "Vijayadasami reveres either Durga's or Rama's victory over evil depending on the region.";
        }

        private void Btn_Vijayadashmi_Etymology(object sender, RoutedEventArgs e)
        {
            tb_Vijayadashmi_head.Text = "Etymology";
            Vijayadashmi_info.SetBinding(TextBlock.TextProperty, "Etymology");
            Uri u = new Uri("", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Vijayadasmi_info.Source = imgSur;
            img_Vijayadashmi_TB.Text = "";
        }

        private void Btn_Vijayadashmi_History(object sender, RoutedEventArgs e)
        {
            tb_Vijayadashmi_head.Text = "History";
            Vijayadashmi_info.SetBinding(TextBlock.TextProperty, "History");
            Uri u = new Uri("", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Vijayadasmi_info.Source = imgSur;
            img_Vijayadashmi_TB.Text = "";
        }

        private void Btn_Vijayadashmi_Religious(object sender, RoutedEventArgs e)
        {
            tb_Vijayadashmi_head.Text = "Religious  Significance";
            Vijayadashmi_info.SetBinding(TextBlock.TextProperty, "Religious");
            Uri u = new Uri("image/Vijayadashami_north.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Vijayadasmi_info.Source = imgSur;
            img_Vijayadashmi_TB.Text = "Dasara is observed with the burning of Ravana effigies.";
        }

        //private void Btn_Vijayadashmi_Quiz(object sender, RoutedEventArgs e)
        //{
        //    var quiz = new Quiz2();
        //    quiz.Owner = this;
        //    quiz.Show();
        //}
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
