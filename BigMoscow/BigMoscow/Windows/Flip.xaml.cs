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
using System.Windows.Media.Animation;

namespace BigMoscow.Windows
{
    /// <summary>
    /// Interaction logic for Scroll.xaml
    /// </summary>
    public partial class Flip : Window
    {
        static public bool Activity = false;

        public CarouselPage carousel;
        public FeedBackWindow feedback;
        public PageQuestion question;
        public JournalsPage journalsPage;
        public PageMedia mediaPage;
        public PageSend sendPage;
        ulong time = 0;
        private Point initialpoint;

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
            //sendPage.InitializeComponent();
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
        DispatcherTimer activityTimer;

        int currentImageIndex = 0;
        int slideLen = 4;
        String[] backgroundImagesURIs = { "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.jpg",
                                          "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.png" };
        List<string> slides;
        public Flip()
        {
            activityTimer = new DispatcherTimer();
            activityTimer.Tick += new EventHandler(Counter);
            activityTimer.Interval = new TimeSpan(0, 0, 1);
            activityTimer.Start();


            CultureInfo c = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            InitializeComponent();
            carousel = new CarouselPage(this);
            frame.Content = carousel;
            String uri = "../../../../../Slides";
            swipeGrid.ManipulationStarted += GridMovementStarting;
            swipeGrid.ManipulationDelta += GridMovementDelta;

        }
        void GridMovementStarting(object sender, ManipulationStartedEventArgs e)
        {
            initialpoint = e.ManipulationOrigin;
            //System.Diagnostics.Debug.WriteLine("GridMovementStarting");
        }
        void GridMovementDelta(object sender, ManipulationDeltaEventArgs e)
        {
            Point currentpoint = e.ManipulationOrigin;
            System.Diagnostics.Debug.WriteLine(currentpoint.X - initialpoint.X);
           
              
                if (currentpoint.X - initialpoint.X >= 500)//500 is the threshold value, where you want to trigger the swipe right event
                {
                    System.Diagnostics.Debug.WriteLine("Swipe Right");
                    //TabControl.SpinToPrevious();
                    e.Complete();
                }
            if (currentpoint.X - initialpoint.X <= -500)
            {
                System.Diagnostics.Debug.WriteLine("Swipe Left");
                //TabControl.SpinToPrevious();
                e.Complete();
            }


        }

        void Counter(object sender, EventArgs e)
        {
            time++;
            if (time > 120 )
            {
                showCarouselPage();
            }
           // System.Diagnostics.Debug.WriteLine(String.Format("time {0}", time));
        }
        public void DetectTouch(object sender, EventArgs e)
        {
            time = 0;
            //System.Diagnostics.Debug.WriteLine(" DetectTouch");
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            
            Storyboard st = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation(1.0, 0.0, new TimeSpan(0, 0, 4));
            Storyboard.SetTargetName(animation, "Background");
            Storyboard.SetTargetProperty(animation, new PropertyPath(Brush.OpacityProperty));

            st.Children.Add(animation);

            st.Begin();

            shortTimer = new DispatcherTimer();
            shortTimer.Tick += new EventHandler(shortTimer_Tick);
            shortTimer.Interval = new TimeSpan(0, 0, 2);
            shortTimer.Start();

            
        }

        DispatcherTimer shortTimer;
        private void shortTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = currentImageIndex >= slideLen - 1 ? 0 : currentImageIndex + 1;

            // + String.Format("anim_slide{0}", currentImageIndex);

            Uri imageUri = new Uri(slides[currentImageIndex]);
            BitmapImage image = new BitmapImage(imageUri);
            ImageBrush brush = new ImageBrush(image);
            carousel.Background = brush;

            shortTimer.Stop();
            shortTimer = null;
        }

        private void Window_TouchMove(object sender, TouchEventArgs e)
        {

        }
    }
}
