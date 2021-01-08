using IndianFestival.Classes;
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
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : Window
    {
        int id = 0;
        //int temp = -1;
        Question question;
        public Quiz()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            question = new Question { id = 0, qText = "How long Diwali Festival celebrated?" };
            question.answers.Add(new Answer { aText = "10", isCorrcect = false });
            question.answers.Add(new Answer { aText = "4", isCorrcect = false });
            question.answers.Add(new Answer { aText = "5", isCorrcect = true });
            question.answers.Add(new Answer { aText = "7", isCorrcect = false });

            DataContext = question;

        }
        private void Btn_newQuestion_Click(object sender, RoutedEventArgs e)
        {
            var buttonswd = sender;
            //MessageBox.Show("It was correct.......1"+ buttonswd.ToString());

            int gotocase = RetriData(id);

            switch (gotocase)
            {
                case 1:
                    question = new Question { qText = "In which month Diwali Festival celebrated?" };
                    question.answers.Add(new Answer { aText = "mid-October and mid-November", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "mid-Decenber and mid-January", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "mid-February and mid-March", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "mid-April and mid-May", isCorrcect = false });
                    DataContext = question;
                    break;

                case 2:
                    question = new Question { qText = "Who kidnapped sita?" };
                    question.answers.Add(new Answer { aText = "Laxman", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Sita", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Ram", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Ravan", isCorrcect = true });
                    DataContext = question;

                    break;

                case 3:
                    question = new Question { qText = "Diwali symbollized?" };
                    question.answers.Add(new Answer { aText = "victory of light over darkness, good over evil, and knowledge over ignorance", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "victory of darkness over light,evil over good,and ignorance over knowledge", isCorrcect = false });
                    DataContext = question;

                    break;
                case 4:
                    question = new Question { qText = "The Diyas(Lamps) are symbolising the part of?" };
                    question.answers.Add(new Answer { aText = "Sun", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "Moon", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "None of above", isCorrcect = false });
                    DataContext = question;
                    break;
                case 5:
                    Uri u = new Uri("image/Ganesh_History.jpg", UriKind.Relative);
                    BitmapImage imgSur = new BitmapImage(u);
                    Q_img.Source = imgSur;
                    question = new Question { qText = "Guess the picture.." };
                    question.answers.Add(new Answer { aText = "Ganesha, Karnataka, circa 1730", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Ganesha, Basohli miniture, circa 1730", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "Ganesha, Bhopal miniture, circa 1730", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "None of above ", isCorrcect = false });
                    DataContext = question;

                    break;
                case 6:
                    Uri a = new Uri("", UriKind.Relative);
                    BitmapImage img_Sur = new BitmapImage(a);
                    Q_img.Source = img_Sur;
                    question = new Question { qText = "How Dasara is celebrated?" };
                    question.answers.Add(new Answer { aText = "Burning of Ravana effigies", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "Burning of Ram effigies", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Burning of Bhim effigies", isCorrcect = false });
                    DataContext = question;

                    break;
                case 7:
                    question = new Question { qText = "How many days Ganesh Chaturthi celebrates?" };
                    question.answers.Add(new Answer { aText = "7", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "21", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "11", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "3", isCorrcect = false });
                    DataContext = question;

                    break;
                case 8:
                    question = new Question { qText = "Which the color code on day 2 on Navratri?" };
                    question.answers.Add(new Answer { aText = "Blue", isCorrcect = true });
                    question.answers.Add(new Answer { aText = "Red", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Black", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "Green", isCorrcect = false });
                    DataContext = question;

                    break;
                case 9:
                    question = new Question { qText = "What is Suhur?" };
                    question.answers.Add(new Answer { aText = "The pre-dawn meal after the fast.", isCorrcect = false });
                    question.answers.Add(new Answer { aText = "The pre-dawn meal before the fast.", isCorrcect = true });
                    DataContext = question;

                    break;
                case 10:
                    MessageBox.Show("Quiz has finished.......");
                    break;
                default:
                    break;
            }

            /* for (id = 1; id < 10; id++)
             {
                 Question dataQuestion = DataFetch(id);
                 DataContext = dataQuestion;
 */



            //if (id == 1 )
            //{
            //    question = new Question { qText = "In which month Diwali Festival celebrated?" };
            //    question.answers.Add(new Answer { aText = "mid-October and mid-November", isCorrcect = true });
            //    question.answers.Add(new Answer { aText = "mid-Decenber and mid-January", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "mid-February and mid-March", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "mid-April and mid-May", isCorrcect = false });
            //    DataContext = question;
            //    MessageBox.Show("It was correct.......1");
            //    continue;
            //}
            //else if (id == 2)
            //{
            //    question = new Question { qText = "Diwali symbollized?" };
            //    question.answers.Add(new Answer { aText = "victory of light over darkness, good over evil, and knowledge over ignorance", isCorrcect = true });
            //    question.answers.Add(new Answer { aText = "victory of darkness over light,evil over good,and ignorance over knowledge", isCorrcect = false });
            //    DataContext = question;
            //    MessageBox.Show("It was correct.......2");
            //    continue;
            //}
            //else if (id == 3)
            //{
            //    question = new Question { qText = "Diwali is celebrated in the honour of?" };
            //    question.answers.Add(new Answer { aText = "Ganesha", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "Lakshami", isCorrcect = true });
            //    question.answers.Add(new Answer { aText = "Shiv", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "Ravan", isCorrcect = false });
            //    DataContext = question;
            //    MessageBox.Show("It was correct.......3");
            //    continue;
            //}
            //else if (id == 4)
            //{
            //    question = new Question { qText = "The Diyas(Lamps) are symbolising the part of?" };
            //    question.answers.Add(new Answer { aText = "Sun", isCorrcect = true });
            //    question.answers.Add(new Answer { aText = "Moon", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "None of above", isCorrcect = false });
            //    DataContext = question;
            //    continue;
            //}
            //else if (id == 5)
            //{
            //    question = new Question { qText = "The Diyas(Lamps) are symbolising the part of?" };
            //    question.answers.Add(new Answer { aText = "Sun", isCorrcect = true });
            //    question.answers.Add(new Answer { aText = "Moon", isCorrcect = false });
            //    question.answers.Add(new Answer { aText = "None of above", isCorrcect = false });
            //    DataContext = question;
            //    continue;
            //}
            /*

                        }*/


        }


        int RetriData(int increm)
        {
            id = id + 1;
            return id;
        }


        private void LBx_answers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var answ = (sender as ListBox).SelectedItem as Answer;
            if (answ != null)
            {
                if (answ.isCorrcect)
                {
                    MessageBox.Show("It's correct");
                    // update performance
                    //Question_Click();
                }
                else
                {
                    MessageBox.Show("Ops, It's wrong");
                    // update performance
                }
            }

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
