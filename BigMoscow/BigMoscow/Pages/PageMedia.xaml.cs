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
        int currentSlide;
        Flip _flip;
        public PageMedia(Flip flip)
        {
            InitializeComponent();
            _flip = flip;

        }

        private void click_left(object sender, RoutedEventArgs e)
        {
            if (currentSlide == 1)
            {
                SetBackGround("../../Images/Mediakit/08.png");
                currentSlide = 8;
            }
            else
            {
                currentSlide -= 1;
                SetBackGround("../../Images/Mediakit/0" + currentSlide + ".png");

            }
        }
        private void SetBackGround(string url)
        {
            BitmapImage b = new BitmapImage(new Uri(url, UriKind.Relative));

            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            Dispatcher.Invoke(() => canvas_media.Background = content);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SetBackGround("../../Images/Mediakit/01.png");
            currentSlide = 1;
        }

        private void click_right(object sender, RoutedEventArgs e)//
        {
            if (currentSlide==8)
            {
                SetBackGround("../../Images/Mediakit/01.png");
                currentSlide = 1;
            }
            else
            {
                currentSlide += 1;
                SetBackGround("../../Images/Mediakit/0" + currentSlide + ".png");
                
            }
        }

        private void magazines_back_Click(object sender, RoutedEventArgs e)
        {
            _flip.showJournalsPage();

        }

        private void carousel_back_Click(object sender, RoutedEventArgs e)
        {
            _flip.showCarouselPage();
        }
    }
}
