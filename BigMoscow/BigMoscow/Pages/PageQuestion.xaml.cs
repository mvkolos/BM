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
using Newtonsoft.Json;
using System.IO;
using System.Configuration;

namespace BigMoscow.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {
       

        public PageQuestion()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void LoadCombobox()
        {
            StreamReader sr = new StreamReader("../../../../../Countries/" + Properties.Resources.magazine + ".json", Encoding.GetEncoding(1251));
            string s = sr.ReadToEnd();
            Countries[] objArr = null ;
            sr.Close();

            objArr = JsonConvert.DeserializeObject<Countries[]>(s);



            foreach (var item in objArr)
            {
                combobox_country.Items.Add(item.name);
            }
        }
        private void combobox_country_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCombobox();
        }

        private void RU_click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "ru-RU";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Dispatcher.Invoke(() =>
            {
                combobox_country.Items.Clear();
                LoadCombobox();
            }
            );

        }

        private void en_click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "en-US";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Dispatcher.Invoke(() =>
            {
                combobox_country.Items.Clear();
                LoadCombobox();
            }
           );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void texbox_question_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    public class Countries
    {
        public string name { get; set; }
        public string code { get; set; }

    }
}
