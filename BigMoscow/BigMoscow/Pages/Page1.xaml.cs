using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
        private static ObservableCollection<UserControl> _p1Collection = new ObservableCollection<UserControl>();
        public Page1(Flip flip)
        {
            f = new FeedBackRepository();

            _flip = flip;
            Loaded += OnLoad;
            InitializeComponent();

            myBook.ItemsSource = _p1Collection;
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            BookAdd();
            CoversAdd();
            ContentAdd();
        }


        private void BookAdd()
        {
            while (_p1Collection.Any())
            {
                _p1Collection.RemoveAt(0);
            }

            List<string> pages = f.DirSearch(string.Format("../../../../../Magazines/{0}{1}", Properties.Resources.magazine, MagazineDictionary.GetDictionary()[CurrentJournal.journal]));//язык ресурсы

            foreach (var item in pages)
            {
                BitmapImage b = new BitmapImage();

                b.BeginInit();
                b.CacheOption = BitmapCacheOption.None;
                b.UriSource = new Uri(item);
                b.EndInit();
                ImageBrush content = new ImageBrush();
                
                content.ImageSource = b;
                p1 page = new p1(content);
                _p1Collection.Add(page);
            }

        }
        private void mail_button_click(object sender, RoutedEventArgs e)
        {
            _flip.frame.Content = new PageSend();
        }

        private void button_info_Click(object sender, RoutedEventArgs e)
        {
            _flip.frame.Content = new PageMedia();
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

        private static List<string> _covers;
        private void CoversAdd()
        {
            List<string> covers = _covers ?? (_covers = f.DirSearch(string.Format("../../../../../Covers")));
            List<UserControl> c = new List<UserControl>();
            List<string> covers_new = covers.Where(e => e.Contains("m" + Properties.Resources.magazine.ToLower())).ToList();
            coversPanel.Children.Clear();
            foreach (var item in covers_new)
            {
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.CacheOption = BitmapCacheOption.None;
                b.UriSource = new Uri(item);
                b.EndInit();
                ImageBrush content = new ImageBrush();
                content.ImageSource = b;
                Page_Carousel p = new Page_Carousel(_flip);
                p.BackGroundURL = item;
                Frame f = new Frame();
                f.Width = 186;
                f.Height = 260;
                Thickness th = f.Padding;
                th.Left = 10;
                th.Right = 5;
                th.Top = 10;
                th.Bottom = 5;
                f.Padding = th;
                f.Content = p;
                coversPanel.Children.Add(f);
                p.Background = content;
            }
        }
        private void ContentAdd()
        {
            CurrentJournal.Content_page_dictionary = new Dictionary<string, string>();
            var contents = MagazineDictionary.GetContent.Value;
            content_magaz.Children.Clear();
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
            myBook.CurrentSheetIndex = int.Parse(CurrentJournal.Content_page_dictionary[b.Content.ToString()]) / 2;
        }

        private void Feedback_Click(object sender, RoutedEventArgs e)
        {
            _flip.frame.Content = new PageQuestion();
        }
    }
}
