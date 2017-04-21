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
using System.Configuration;
using System.Windows.Threading;
using System.IO;
using System.Windows.Media.Animation;

namespace BigMoscow
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class CarouselPage : Page
    {
        Flip _flip;
        static string language = "en";
        int width = 267;
        int height = 356;
        DispatcherTimer dispatchTimer;

        int currentImageIndex = 0;
        int slideLen = 4;
        List<string> slides;
        bool touchMove = false;
        private Point initialpoint;

        public CarouselPage(Flip flip)
        {
            InitializeComponent();
            DataContext = TabControl;
            _flip = flip;
            //ConfigurationManager.AppSettings["Culture"] = "en-US";

            CreateTabs();

            TabControl.NumberOfTabs = 19;
            TabControl.AnimationDuration = 1000;

            String uri = "../../../../../Slides";
            slides = DirSearch(uri);

            ManipulationStarted += GridMovementStarting;
            ManipulationDelta += GridMovementDelta;
            TouchDown+= TouchMovementStarting;

            TabControl.ManipulationStarted += GridMovementStarting;
            TabControl.ManipulationDelta += GridMovementDelta;

            TouchMove += DetectMovement;
            TouchUp += CheckGesture;
            StartTimer();
        }
        void DetectMovement(object sender, TouchEventArgs e)
        {
            touchMove= true;
        }
        void CheckGesture(object sender, TouchEventArgs e)
        {
            TouchDevice c = e.TouchDevice;
            initialpoint = c.GetTouchPoint(this).Position;
        }
        void GridMovementStarting(object sender, ManipulationStartedEventArgs e)
        {
            initialpoint = e.ManipulationOrigin;
           // System.Diagnostics.Debug.WriteLine("GridMovementStarting");
        }
        void TouchMovementStarting(object sender, TouchEventArgs e)
        {
            TouchDevice c = e.TouchDevice;
            //c.GetTouchPoint(this).Position;
            Point currentpoint = c.GetTouchPoint(this).Position;
            if (currentpoint.X - initialpoint.X >= 500)//500 is the threshold value, where you want to trigger the swipe right event
            {
                System.Diagnostics.Debug.WriteLine("Swipe Right");
                TabControl.SpinToPrevious();
                //e.Complete();
            }
            if (currentpoint.X - initialpoint.X <=-500)//500 is the threshold value, where you want to trigger the swipe right event
            {
                System.Diagnostics.Debug.WriteLine("Swipe Left");
                TabControl.SpinToNext();
                //e.Complete();
            }
        }

        void GridMovementDelta(object sender, ManipulationDeltaEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("GridMovementDelta");
            if (e.IsInertial)
            {
                Point currentpoint = e.ManipulationOrigin;
                if (currentpoint.X - initialpoint.X >= 500)//500 is the threshold value, where you want to trigger the swipe right event
                {
                    System.Diagnostics.Debug.WriteLine("Swipe Right");
                    TabControl.SpinToPrevious();
                    e.Complete();
                }
                if (currentpoint.X - initialpoint.X <= 500)//500 is the threshold value, where you want to trigger the swipe right event
                {
                    System.Diagnostics.Debug.WriteLine("Swipe Left");
                    TabControl.SpinToNext();
                    e.Complete();
                }
            }
        }


        private void StartTimer()
        {
            dispatchTimer = new DispatcherTimer();
            dispatchTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatchTimer.Interval = new TimeSpan(0, 0, 10);
            dispatchTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            TabControl.SpinToNext();

            DoubleAnimation animation = new DoubleAnimation(1.0, 0.8, new TimeSpan(0, 0, 1));
            animation.AutoReverse = true;
            backgroundImage.BeginAnimation(ImageBrush.OpacityProperty, animation);

            shortTimer = new DispatcherTimer();
            shortTimer.Tick += new EventHandler(shortTimer_Tick);
            shortTimer.Interval = new TimeSpan(0, 0, 1);
            shortTimer.Start();


        }

        DispatcherTimer shortTimer;
        private void shortTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = currentImageIndex >= slideLen - 1 ? 0 : currentImageIndex + 1;
            backgroundImage.ImageSource = (ImageSource)(new ImageSourceConverter()).ConvertFromString(slides[currentImageIndex]);

            shortTimer.Stop();
            shortTimer = null;
        }

        private void CreateTabs()
        {
            String baseString = "../../../../../";
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2012-v.jpg", language), new Size(height, width)));//1
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2013-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2014-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2015-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2016-v.jpg", language), new Size(height, width)));//5
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.02_2012-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.02_2013-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.02_2014-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.02_2015-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.02_2016-v.jpg", language), new Size(height, width)));//10
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.03_2013-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.03_2014-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.03_2015-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.03_2016-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.04_2013-v.jpg", language), new Size(height, width)));//15
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.04_2015-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.04_2016-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.00_2017-v.jpg", language), new Size(height, width)));
            TabControl.AddTab(CreateFixedSizeLabel(string.Format(baseString + "Covers/ru.bigrussia.bgm{0}.01_2017-v.jpg", language), new Size(height, width)));


        }
        private  FrameworkElement CreateFixedSizeLabel(string uri_picture, Size size)
        {
            Page_Carousel label = new Page_Carousel(_flip);
            label.FontSize = 64;
           
            label.MinWidth = label.MaxWidth = label.Width = size.Width;
            label.MinHeight = label.MaxHeight = label.Height = size.Height;
            BitmapImage b = new BitmapImage(new Uri(uri_picture, UriKind.Relative));
            ImageBrush content = new ImageBrush();
            content.ImageSource = b;

            label.Background = content;
            label.BackGroundURL = uri_picture;

            return label;
        }
        

        private void HandlePrevious(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToPrevious();
        }

        private void HandleNext(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToNext();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            language = "ru";
            ConfigurationManager.AppSettings["Culture"] = "ru-RU";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.showCarouselPage(true);
        }

        private void MenuItenEngclick(object sender, RoutedEventArgs e)
        {
            language = "en";

            ConfigurationManager.AppSettings["Culture"] = "en-US";
            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.showCarouselPage(true);
        }

        private void MenuDeutschclick(object sender, RoutedEventArgs e)
        {
            language = "de";
            TabControl.RemoveTabs();
            CreateTabs();
            UpdateLayout();
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

        private void TabControl_TouchDown(object sender, TouchEventArgs e)
        {

        }
    }
}
