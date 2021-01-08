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
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            festinfo.DataContext = App._info1;
            tbhead.Text = "What is Diwali Festival?";
            festinfo.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Diwali_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            imginfo.Source = imgSur;
            imgTB.Text = "Diyas";
        }

        private void Btn_Diwali_intro(object sender, RoutedEventArgs e)
        {
            festinfo.DataContext = App._info1;
            tbhead.Text = "What is Diwali Festival?";
            festinfo.SetBinding(TextBlock.TextProperty, "intro");
            Uri u = new Uri("image/Diwali_intro.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            imginfo.Source = imgSur;
            imgTB.Text = "Diyas";
        }

        private void Btn_Diwali_History(object sender, RoutedEventArgs e)
        {
            tbhead.Text = "History";
            festinfo.SetBinding(TextBlock.TextProperty, "historical");
            Uri u = new Uri("image/Diwali_History.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            imginfo.Source = imgSur;
            imgTB.Text = "William Simpson labelled his chromolithograph of 1867 CE as 'Dewali feast of lamps'.";
        }

        private void Btn_Diwali_Religious(object sender, RoutedEventArgs e)
        {
            tbhead.Text = "Religious Significance";
            festinfo.SetBinding(TextBlock.TextProperty, "religious");
            Uri u = new Uri("image/Diwali_Religious_Laxmi.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            imginfo.Source = imgSur;
            imgTB.Text = "Diwali is celebrated in the honour of Lakshmi, the goddess of wealth.";
        }

        private void Btn_Diwali_Descripton(object sender, RoutedEventArgs e)
        {
            tbhead.Text = "Description";
            festinfo.SetBinding(TextBlock.TextProperty, "description");
            Uri u = new Uri("image/Diwali_Description.jpg", UriKind.Relative);
            BitmapImage imgSur = new BitmapImage(u);
            imginfo.Source = imgSur;
            imgTB.Text = "Diwali celebrations include puja (prayers) to Lakshmi and Ganesha. ";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }

        //private void Btn_Diwali_Quiz(object sender, RoutedEventArgs e)
        //{
        //    var quiz = new Quiz();
        //    quiz.Owner = this;
        //    quiz.Show();
        //}
    }
}
