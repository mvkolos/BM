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
using BigMoscow.Logic;
using BigMoscow.Windows;
using BigMoscow.Pages;
using BigMoscow.Controls.en12;
using System.Configuration;

namespace BigMoscow
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        FeedBackRepository f;
        Flip _flip;
        public Page1(Flip flip)
        {
            f = new FeedBackRepository();

            _flip = flip;
            InitializeComponent();



        }

        private void BookAdd()
        {

            List<string> pages = f.DirSearch(string.Format("../../../../../Magazines/{0}{1}", Properties.Resources.magazine, MagazineDictionary.GetDictionary()[CurrentJournal.journal]));//язык ресурсы

            foreach (var item in pages)
            {
                BitmapImage b = new BitmapImage(new Uri(item));
                ImageBrush content = new ImageBrush();
                content.ImageSource = b;


                myBook.Items.Add(new p1(content));


            }


        }
        private void mail_button_click(object sender, RoutedEventArgs e)
        {
            _flip.frame.Content = new PageSend();
        }

        private void button_info_Click(object sender, RoutedEventArgs e)
        {
            _flip.frame.Content = new PageInfo();
        }

        private void MenuRuClick(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "ru-RU";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.frame.Content = new Page1(_flip);
        }

        private void MenuengClick(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "en-US";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.frame.Content = new Page1(_flip);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() => BookAdd());
            CoversAdd();

            ContentAdd();

        }
        private void CoversAdd()
        {
            List<string> covers = f.DirSearch(string.Format("../../../../../Covers"));
            List<UserControl> c = new List<UserControl>();
            List<string> covers_new = covers.Where(e => e.Contains("m" + Properties.Resources.magazine.ToLower())).ToList();
            foreach (var item in covers_new)
            {
                BitmapImage b = new BitmapImage(new Uri(item));
                ImageBrush content = new ImageBrush();
                content.ImageSource = b;
                Page_Carousel p = new Page_Carousel(_flip);
                p.BackGroundURL = item;
                Frame f = new Frame();
                f.Width = 192;
                f.Height = 256;
                Thickness th = f.Padding;
                th.Left = 10;
                th.Right = 20;
                th.Top = 10;
                th.Bottom = 10;
                f.Padding = th;
                f.Content = p;
                coversPanel.Children.Add(f);
                p.Background = content;




            }



        }
        private void ContentAdd()
        {
            CurrentJournal.Content_page_dictionary = new Dictionary<string, string>();
            var contents = MagazineDictionary.GetContent();
            if (contents.Keys.Contains(MagazineDictionary.GetDictionary()[CurrentJournal.journal]))
            {
                string[] cont = contents[MagazineDictionary.GetDictionary()[CurrentJournal.journal]];
                foreach (var item in cont)
                {
                    Button b = new Button();
                    b.Height = 50;
                    b.Width = 140;
                    b.Content = item.Split(';')[0];
                    CurrentJournal.Content_page_dictionary.Add(item.Split(';')[0], item.Split(';')[1]);
                    b.Click += B_Click;
                    content_magaz.Children.Add(b);
                }
            }
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Dispatcher.Invoke(() => myBook.CurrentSheetIndex = (int.Parse(CurrentJournal.Content_page_dictionary[b.Content.ToString()])) / 2);

        }
    }
}
