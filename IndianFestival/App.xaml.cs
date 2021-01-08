using IndianFestival.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IndianFestival
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<DataIndianFestival> _info1;
        public static ObservableCollection<Data_Vijayadashmi_Indian_Festival> _info2;
        public static ObservableCollection<Data_Ganesh_Chathurthi_Festival> _info3;
        public static ObservableCollection<Data_Navratri_Festival> _info4;
        public static ObservableCollection<Data_Ramjan_Festival> _info5;
        public static ObservableCollection<Data_Shivratri_Festival> _info6;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _info1 = GenerateInfo(1);
            _info1 = MYStorage.ReadXml<ObservableCollection<DataIndianFestival>>("InfoIndianFest.xml");
            _info2 = GenerateVijayadashmiInfo(1);
            _info2 = MYStorage.ReadXml<ObservableCollection<Data_Vijayadashmi_Indian_Festival>>
                ("Info_Vijayadashmi_IndianFest.xml");
            _info3 = GenerateGaneshInfo(1);
            _info3 = MYStorage.ReadXml<ObservableCollection<Data_Ganesh_Chathurthi_Festival>>("Info_Ganesh_IndianFest.xml");
            _info4 = GenerateNavratriInfo(1);
            _info4 = MYStorage.ReadXml<ObservableCollection<Data_Navratri_Festival>>("Info_Navratri.xml");
            _info5 = GenerateRamjanInfo(1);
            _info5 = MYStorage.ReadXml<ObservableCollection<Data_Ramjan_Festival>>("Info_Ramjan.xml");
            _info6 = GenerateShivratriInfo(1);
            _info6 = MYStorage.ReadXml<ObservableCollection<Data_Shivratri_Festival>>("Info_Shivratri.xml");
        }

        private ObservableCollection<DataIndianFestival> GenerateInfo(int v)
        {
            var infolst = new ObservableCollection<DataIndianFestival>();

            infolst.Add(new DataIndianFestival { intro = "Diwali, Divali, Deepavali is the Hindu festival of lights, usually lasting five days and celebrated during the Hindu Lunisolar month Kartika (between mid-October and mid-November). One of the most popular festivals of Hinduism, Diwali symbolizes the spiritual victory of light over darkness, good over evil, and knowledge over ignorance. The festival is widely associated with Lakshmi, goddess of prosperity, but regional traditions connect it to Sita and Rama, Vishnu, Krishna, Durga, Kali, Dhanvantari, or Vishvakarman." });
            return infolst;

        }
        private ObservableCollection<Data_Vijayadashmi_Indian_Festival> GenerateVijayadashmiInfo(int v)
        {
            var info_Vijayadashami_lst = new ObservableCollection<Data_Vijayadashmi_Indian_Festival>();

            info_Vijayadashami_lst.Add(new Data_Vijayadashmi_Indian_Festival { intro = "Diwali, Divali, Deepavali is the Hindu festival of lights, usually lasting five days and celebrated during the Hindu Lunisolar month Kartika (between mid-October and mid-November). One of the most popular festivals of Hinduism, Diwali symbolizes the spiritual victory of light over darkness, good over evil, and knowledge over ignorance. The festival is widely associated with Lakshmi, goddess of prosperity, but regional traditions connect it to Sita and Rama, Vishnu, Krishna, Durga, Kali, Dhanvantari, or Vishvakarman." });
            return info_Vijayadashami_lst;

        }

        private ObservableCollection<Data_Ganesh_Chathurthi_Festival> GenerateGaneshInfo(int v)
        {
            var info_Ganesh_lst = new ObservableCollection<Data_Ganesh_Chathurthi_Festival>();

            info_Ganesh_lst.Add(new Data_Ganesh_Chathurthi_Festival { intro = "Hiiiiiii" });
            return info_Ganesh_lst;

        }

        private ObservableCollection<Data_Navratri_Festival> GenerateNavratriInfo(int v)
        {
            var info_Navratri_lst = new ObservableCollection<Data_Navratri_Festival>();

            info_Navratri_lst.Add(new Data_Navratri_Festival { intro = "Hiiiiiii" });
            return info_Navratri_lst;

        }

        private ObservableCollection<Data_Ramjan_Festival> GenerateRamjanInfo(int v)
        {
            var info_Ramjan_lst = new ObservableCollection<Data_Ramjan_Festival>();

            info_Ramjan_lst.Add(new Data_Ramjan_Festival { intro = "Hiiiiiii" });
            return info_Ramjan_lst;

        }

        private ObservableCollection<Data_Shivratri_Festival> GenerateShivratriInfo(int v)
        {
            var info_Shivratri_lst = new ObservableCollection<Data_Shivratri_Festival>();

            info_Shivratri_lst.Add(new Data_Shivratri_Festival { intro = "Hiiiiiii" });
            return info_Shivratri_lst;

        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            //MYStorage.WriteXml<ObservableCollection<DataIndianFestival>>(_info1, "InfoIndianFest.xml");
            //MYStorage.WriteXml<ObservableCollection<Data_Vijayadashmi_Indian_Festival>>(_info2, "Info_Vijayadashmi_IndianFest.xml");
            //MYStorage.WriteXml<ObservableCollection<Data_Ganesh_Chathurthi_Festival>>(_info3, "Info_Ganesh_IndianFest.xml");
            //MYStorage.WriteXml<ObservableCollection<Data_Navratri_Festival>>(_info4, "Info_Navratri.xml");
            //MYStorage.WriteXml<ObservableCollection<Data_Ramjan_Festival>>(_info5,"Info_Ramjan.xml");
            //MYStorage.WriteXml<ObservableCollection<Data_Shivratri_Festival>>(_info6, "Info_Shivratri.xml");
        }
    }
}
