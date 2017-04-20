using BigMoscow.Windows;
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

namespace BigMoscow.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMedia.xaml
    /// </summary>
    public partial class PageMedia : Page
    {
        int currentSlide =0;
        Flip _flip;
        string localized_folder = "en";
        int len_eng = 6;
        int len_ru = 7;

        public PageMedia(Flip flip)
        {
            InitializeComponent();
            _flip = flip;


        }

        private void click_left(object sender, RoutedEventArgs e)
        {
            if (currentSlide > 0)
            {
                currentSlide--;
            }
            SetBackGround();

            
        }
        private void SetBackGround()
        {
            string url = "../../Images/Mediakit/" + localized_folder + "/" + currentSlide.ToString() + ".jpg";
            BitmapImage b = new BitmapImage(new Uri(url, UriKind.Relative));

            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            Dispatcher.Invoke(() => canvas_media.Background = content);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SetBackGround();
        }

        private void click_right(object sender, RoutedEventArgs e)//
        {
            if(localized_folder=="en")
            {
                if(currentSlide<len_eng)
                {
                    currentSlide++;
                }
                
            }
            else
            {
                if (currentSlide < len_ru)
                {
                    currentSlide++;
                }
            }
            SetBackGround();
        }

        private void magazines_back_Click(object sender, RoutedEventArgs e)
        {
            _flip.showJournalsPage();

        }

        private void carousel_back_Click(object sender, RoutedEventArgs e)
        {
            _flip.showCarouselPage();
        }

        private void RU_click(object sender, RoutedEventArgs e)
        {
            currentSlide = 0;
            localized_folder = "ru";
            SetBackGround();
        }

        private void en_click(object sender, RoutedEventArgs e)
        {
            currentSlide = 0;
            
            localized_folder = "en";
            SetBackGround();
        }
    }
}
