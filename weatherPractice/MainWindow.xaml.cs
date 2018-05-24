using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace weatherPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<City> CityList { get; set; }
        public CityMainWeather CityMainWeather { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            using (StreamReader r = new StreamReader("city.list.json"))
            {
                string json = r.ReadToEnd();
                CityList = JsonConvert.DeserializeObject<List<City>>(json);
            }

            GetWeatherInfo("Astana");

        }


        public void GetWeatherInfo(string city)
        {
            var searchCityId = CityList.Where(c => c.Name == city).Select(c => c.Id).SingleOrDefault();

            string url = @"https://api.openweathermap.org/data/2.5/forecast?APPID=eb5e75d2643132a6c84e9c510ec6219e&id=";

            using (var client = new WebClient())
            {
                /*+ searchCityId.ToString()*/
                client.DownloadStringAsync(new Uri(url + searchCityId));
                client.DownloadStringCompleted += ClientDownloadStringCompleted;
            }
        }

        private void ClientDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            CityMainWeather = JsonConvert.DeserializeObject<CityMainWeather>(e.Result);
        }
    }
}
