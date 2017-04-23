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
using System.Windows.Threading;
using BigMoscow.Controls;

namespace BigMoscow
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class JournalsPage : Page
    {
        FeedBackRepository f;
        Flip _flip;
        private static ObservableCollection<UserControl> _p1Collection = new ObservableCollection<UserControl>();
        static bool eng_local = true;
        MagazineDictionary d;
        public JournalsPage(Flip flip)
        {
           
            f = new FeedBackRepository();

            _flip = flip;
            Loaded += OnLoad;
            InitializeComponent();

            myBook.ItemsSource = _p1Collection;
        }


        private void OnLoad(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = Flip.Local ? "en-US" : "ru-RU";
            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            BookAdd();
            CoversAdd();
            ContentAdd();
        }
        
        public void BookAdd()
        {
            while (_p1Collection.Any())
            {
                _p1Collection.RemoveAt(0);
            }

            List<string> pages = f.DirSearch(string.Format("../../../../../Magazines/{0}{1}", Properties.Resources.magazine, MagazineDictionary.magazinesDictionary[CurrentJournal.journal]));//язык ресурсы

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
            System.Diagnostics.Debug.WriteLine("BOOK SIZE {0}",_p1Collection.Count);

        }
        private void mail_button_click(object sender, RoutedEventArgs e)
        {
            _flip.showSendPage();
        }

        private void button_info_Click(object sender, RoutedEventArgs e)
        {
            _flip.showPageMedia();
        }

        private void MenuRuClick(object sender, RoutedEventArgs e)
        {
            Flip.Local = false;
            ConfigurationManager.AppSettings["Culture"] = "ru-RU";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            
            _flip.showJournalsPage(true);
           // ContentAdd();
        }

        private void MenuengClick(object sender, RoutedEventArgs e)
        {
            Flip.Local = true;
            ConfigurationManager.AppSettings["Culture"] = "en-US";

             Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            
            _flip.showJournalsPage(true);
           // ContentAdd();
        }

        private static List<string> _covers;
        private void CoversAdd()
        {
            
            List<string> covers = _covers ?? (_covers = f.DirSearch(string.Format("../../../../../SmallCovers")));
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
                Page_Carousel p = new Page_Carousel(this);
                p.BackGroundURL = item;
                Frame fr = new Frame();
                fr.Width = 186;
                fr.Height = 248;
                Thickness th = fr.Padding;
                th.Left = 10;
                th.Right = 5;
                th.Top = 10;
                th.Bottom = 5;
                fr.Padding = th;
                fr.Content = p;
                coversPanel.Children.Add(fr);
                p.Background = content;
            }
        }

        public void ContentAdd()
        {
          
            //ConfigurationManager.AppSettings["Culture"] = "ru-RU";
            //Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);

            //Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);

            CurrentJournal.Content_page_dictionary = new Dictionary<string, string>();
            MagazineDictionary.AddContent();
            var contents = MagazineDictionary.contentDictionary;// MagazineDictionary.GetContent.Value;

            //System.Diagnostics.Debug.WriteLine(contents[MagazineDictionary.GetDictionary()[CurrentJournal.journal]]);
            
            content_magaz.Children.Clear();
            if (contents.Keys.Contains(MagazineDictionary.magazinesDictionary[CurrentJournal.journal]))
            {
                
                string[] cont = contents[MagazineDictionary.magazinesDictionary[CurrentJournal.journal]];
                int count = cont.Length;

                int i = 0;
                SolidColorBrush[] backgroundColors = getBackgroundBrushes();
                SolidColorBrush[] borderColors = getBorderBrushes();
                foreach (var item in cont)
                {
                    Button b = new Button();
                    b.Style = FindResource("NonSelectableButton") as Style;

                    b.Background = backgroundColors[0];
                    b.BorderBrush = borderColors[0];
                    Thickness margin = b.Margin;
                    margin.Top = 10;
                    margin.Right = 20;
                    b.Margin = margin;
                    b.Foreground= backgroundColors[1];
                    b.VerticalAlignment = VerticalAlignment.Center;
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    i += 1;

                    b.Height = 45;
                    b.Width = 180;
                    b.FontSize = 13;
                    b.FontFamily= new FontFamily("Segoe UI");
                    b.Content = item.Split(';')[0];
                    
                    b.HorizontalAlignment = HorizontalAlignment.Left;
                    if (!CurrentJournal.Content_page_dictionary.ContainsKey(item.Split(';')[0]))
                    {
                        int idx = Flip.Local ? 2 : 1;
                        CurrentJournal.Content_page_dictionary.Add(item.Split(';')[0], item.Split(';')[idx]);
                    }
                    // 
                    b.Click += B_Click;
                    content_magaz.Children.Add(b);
                }
            }
        }


        private SolidColorBrush[] getBackgroundBrushes()
        {
            SolidColorBrush[] colors = {
                getColorFromHex("#7F000000"),
                getColorFromHex("#FFDCDCDC"),
                getColorFromHex("#FF303463"),
                getColorFromHex("#FFD4AFE7"),
                getColorFromHex("#FF818182")
            };

            return colors;
        }

        private SolidColorBrush[] getBorderBrushes()
        {
            SolidColorBrush[] colors = {
                getColorFromHex("#00707070"),
                getColorFromHex("#FFF02E2E"),
                getColorFromHex("#00707070"),
                getColorFromHex("#00707070"),
                getColorFromHex("#00707070")
            };

            return colors;
        }

        private SolidColorBrush getColorFromHex(String hex)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom(hex));
        }
        

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
           
            myBook.CurrentSheetIndex = (int.Parse(CurrentJournal.Content_page_dictionary[b.Content.ToString()]))/ 2;
            System.Diagnostics.Debug.WriteLine(String.Format("page {0}", myBook.CurrentSheetIndex));
            //myBook.
        }

        private void Feedback_Click(object sender, RoutedEventArgs e)
        {
            _flip.showQuestionPage();
        }

        private void carousel_back_Click(object sender, RoutedEventArgs e)
        {
            _flip.showCarouselPage();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
