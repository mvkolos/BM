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

namespace BigMoscow.Windows
{
    /// <summary>
    /// Interaction logic for Scroll.xaml
    /// </summary>
    public partial class Flip : Window
    {
        public Page2 carousel;
        DispatcherTimer dispatchTimer;

        int currentImageIndex = 0;
        String[] backgroundImagesURIs = { "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.jpg",
                                          "D:/Users/Marya/BM/BigMoscow/BigMoscow/UI/MainScreen/mainscreenMain.png" };

        public Flip()
        {
            CultureInfo c = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            InitializeComponent();
            carousel = new Page2(this);
            frame.Content = carousel;

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
            currentImageIndex = currentImageIndex + 1 >= backgroundImagesURIs.Length ? 0 : currentImageIndex + 1;
            Uri imageUri = new Uri(backgroundImagesURIs[currentImageIndex]);
            BitmapImage image = new BitmapImage(imageUri);
            ImageBrush brush = new ImageBrush(image);

            carousel.Background = brush;
        }
    }
}
