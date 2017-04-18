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
using BigMoscow.Logic;
using BigMoscow.Windows;
using System.Diagnostics;

namespace BigMoscow.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {

        public Flip flip;

        public PageQuestion()
        {
            InitializeComponent();
        }

        public PageQuestion(Flip flip)
        {
            this.flip = flip;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void LoadCombobox()
        {
            StreamReader sr = new StreamReader("../../../../../Countries/" + Properties.Resources.magazine + ".json", Encoding.UTF8);
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
                flip.frame.Content = new PageQuestion(flip);

            }
            );

        }
      
        private void en_click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "en-US";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Dispatcher.Invoke(() =>
            {
                flip.frame.Content = new PageQuestion(flip);
            }
           );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool f1 = false, f2 = false, f3 = false, f4 = false;
            List<string> questions = new List<string>(); ;
            if (r1.IsChecked == true)
            {
                f1 = true;
                questions.Add(r1.Content.ToString());
            }
            if (r2.IsChecked == true)
            {
                f2 = true;
                questions.Add(r2.Content.ToString());
            }
            if (r3.IsChecked == true)
            {
                f3 = true;
                questions.Add(r3.Content.ToString());
            }
            if (r4.IsChecked == true)
            {
                f4 = true;
                questions.Add(r4.Content.ToString());
            }

            
            if (!string.IsNullOrEmpty(texbox_question.Text))
            {
                questions.Add(texbox_question.Text);
            }
            if (questions.Count==0 || string.IsNullOrEmpty(combobox_business.Text) || string.IsNullOrEmpty(combobox_country.Text) || string.IsNullOrEmpty(combobox_you_are.Text) || (string.IsNullOrEmpty(texbox_question.Text) && !f1 && !f2 && !f3 && !f4))
            {
                MessageBox.Show(Properties.Resources.warning);
                return;
            }

            string q = Properties.Resources.Your_q + ":";
            foreach (var item in questions)
            {
                q += item + Environment.NewLine;
            }

            string str = Properties.Resources.You_are + ":" + combobox_you_are.Text + Environment.NewLine + Properties.Resources.Your_country + ":" + combobox_country.Text + Environment.NewLine + Properties.Resources.Your_business_sector + ":" + combobox_business.Text + Environment.NewLine + q;//combobox_business.Text + " " + combobox_country.Text + " " + combobox_you_are.Text + " " + texbox_question.Text;
            FeedBackRepository f = new FeedBackRepository();
            f.SendMessage(str);
            MessageBox.Show("ok");

        }


        private void texbox_question_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Page_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                Button_Click(sender, null);
            }
        }

        private void carousel_back_Click(object sender, RoutedEventArgs e)
        {
            flip.showCarouselPage();
        }

        private void magazines_back_Click(object sender, RoutedEventArgs e)
        {
            flip.showJournalsPage();
        }

        private Process _touchKeyboardProcess = null;

        private void startKeyboard()
        {
            if (_touchKeyboardProcess == null)
            {
                String touchKeyboardPath = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe";
                _touchKeyboardProcess = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + System.IO.Path.DirectorySeparatorChar + "osk.exe");
            }
        }

        private void removeKeyboard()
        {
            if (_touchKeyboardProcess != null)
            {
                _touchKeyboardProcess.Kill();
                _touchKeyboardProcess = null;
            }
        }

        private void texbox_question_GotTouchCapture(object sender, TouchEventArgs e)
        {
            //startKeyboard();
            
        }
    }
    public class Countries
    {
        public string name { get; set; }
        public string code { get; set; }

    }
}
