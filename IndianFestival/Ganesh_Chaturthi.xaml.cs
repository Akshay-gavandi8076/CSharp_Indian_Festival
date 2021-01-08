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
    /// Interaction logic for Ganesh_Chaturthi.xaml
    /// </summary>
    public partial class Ganesh_Chaturthi : Window
    {
        public Ganesh_Chaturthi()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fest_Ganesh_info.DataContext = App._info3;
            tb_Ganesh_head.Text = "What is Ganesh Festival?";
            fest_Ganesh_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Ganesha_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ganesh_info.Source = imgSur;
            //img_Ganesh_TB.Text = "Diyas";
        }

        private void Btn_Ganesh_intro(object sender, RoutedEventArgs e)
        {
            fest_Ganesh_info.DataContext = App._info3;
            tb_Ganesh_head.Text = "What is Ganesh Festival?";
            fest_Ganesh_info.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Ganesha_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ganesh_info.Source = imgSur;
            //img_Ganesh_TB.Text = "Diyas";
        }

        private void Btn_Ganesh_History(object sender, RoutedEventArgs e)
        {
            fest_Ganesh_info.DataContext = App._info3;
            tb_Ganesh_head.Text = "History";
            fest_Ganesh_info.SetBinding(TextBlock.TextProperty, "History");
            Uri u = new Uri("image/Ganesh_History.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ganesh_info.Source = imgSur;
            img_Ganesh_TB.Text = "Ganesha, Basohli miniature, circa 1730.";
        }

        private void Btn_Ganesh_Religious(object sender, RoutedEventArgs e)
        {
            fest_Ganesh_info.DataContext = App._info3;
            tb_Ganesh_head.Text = "Religious Significance";
            fest_Ganesh_info.SetBinding(TextBlock.TextProperty, "Religious");
            Uri u = new Uri("image/Ganesh_Religious_Significance_Mumbai.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ganesh_info.Source = imgSur;
            img_Ganesh_TB.Text = "Ganesha Visarjan in Mumbai";
        }

        private void Btn_Ganesh_Descripton(object sender, RoutedEventArgs e)
        {
            fest_Ganesh_info.DataContext = App._info3;
            tb_Ganesh_head.Text = "Description";
            fest_Ganesh_info.SetBinding(TextBlock.TextProperty, "Description");
            Uri u = new Uri("image/Ganesh_Description.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            img_Ganesh_info.Source = imgSur;
            img_Ganesh_TB.Text = "Ganesh Idol in Khairatabad, Hyderabad, India";
        }

        //private void Btn_Ganesh_Quiz(object sender, RoutedEventArgs e)
        //{
        //    var quiz = new Quiz();
        //    quiz.Owner = this;
        //    quiz.Show();
        //}

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
