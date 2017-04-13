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


namespace BigMoscow.Windows
{
    /// <summary>
    /// Interaction logic for Scroll.xaml
    /// </summary>
    public partial class Flip : Window
    {
        public Flip()

        {
            CultureInfo c = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            InitializeComponent();
           
            frame.Content = new Page2(this);
        }
    }
}
