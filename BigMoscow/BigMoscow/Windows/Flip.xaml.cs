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
using Bornander.UI.TabCarousel;
using System.Globalization;
using System.Configuration;
using System.Windows.Threading;
using BigMoscow.Logic;
using System.IO;
using BigMoscow.Pages;

namespace BigMoscow.Windows
{
    /// <summary>
    /// Interaction logic for Scroll.xaml
    /// </summary>
    public partial class Flip : Window
    {
        public CarouselPage carousel;
        public FeedBackWindow feedback;
        public PageQuestion question;
        public JournalsPage journalsPage;
        public PageMedia mediaPage;
        public PageSend sendPage;

        //SHOWS

        public void showQuestionPage(bool reload = false)
        {
            if (question == null || reload)
                question = new PageQuestion(this);

            Content = question;
            question.InitializeComponent();
        }

        public void showJournalsPage(bool reload = false)
        {
            if (journalsPage == null || reload)
                journalsPage = new JournalsPage(this);

            Content = journalsPage;
            journalsPage.InitializeComponent();
        }

        public void showCarouselPage(bool reload = false)
        {
            if (carousel == null || reload)
                carousel = new CarouselPage(this);

            Content = carousel;
            carousel.InitializeComponent();
        }


        public void showPageMedia(bool reload = false)
        {
            if (mediaPage == null || reload)
                mediaPage = new PageMedia(this);

            Content = mediaPage;
            mediaPage.InitializeComponent();
        }

        public void showSendPage(bool reload = false)
        {
            if (sendPage == null || reload)
                sendPage = new PageSend(this);

            Content = sendPage;
            sendPage.InitializeComponent();
        }

        public void reloadAllPages()
        {
            question = new PageQuestion(this);
            journalsPage = new JournalsPage(this);
            carousel = new CarouselPage(this);
            mediaPage = new PageMedia(this);
            sendPage = new PageSend(this);
        }

        //MAIN LOGICS

        DispatcherTimer dispatchTimer;

        int currentImageIndex = 0;
        int slideLen = 4;
        String[] backgroundImagesURIs = { "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.jpg",
                                          "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.png" };
        List<string> slides;
        public Flip()
        {
            
            CultureInfo c = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            InitializeComponent();
            carousel = new CarouselPage(this);
            frame.Content = carousel;
            String uri = "../../../../../Slides";
            slides = DirSearch(uri);

            StartTimer();
        }


        private void StartTimer()
        {
            dispatchTimer = new DispatcherTimer();
            dispatchTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatchTimer.Interval = new TimeSpan(0, 0, 5);
            dispatchTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            currentImageIndex = currentImageIndex>= slideLen-1? 0 : currentImageIndex + 1;

            // + String.Format("anim_slide{0}", currentImageIndex);
            
            Uri imageUri = new Uri(slides[currentImageIndex]);
            BitmapImage image = new BitmapImage(imageUri);
            ImageBrush brush = new ImageBrush(image);

            carousel.Background = brush;
        }
        public List<string> DirSearch(string sDir)
        {
            List<string> pages = new List<string>();
            DirectoryInfo item = new DirectoryInfo(sDir);
            try
            {
                foreach (var f in item.GetFiles())
                {
                    if (f.Extension.Equals(".png"))
                    {
                        pages.Add(f.FullName);
                    }
                }
                foreach (var f in item.GetDirectories())
                {
                    DirSearch(f.FullName);
                }

            }
            catch
            {

            }


            return pages;

        }

    }
}
