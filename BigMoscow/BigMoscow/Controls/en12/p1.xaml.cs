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

namespace BigMoscow.Controls.en12
{
    /// <summary>
    /// Interaction logic for p1.xaml
    /// </summary>
    public partial class p1 : UserControl
    {
        ImageBrush _b;
        public p1(ImageBrush b)
        {
            //System.Diagnostics.Debug.WriteLine("constr");
            _b = b;
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.canvas.Background = _b;
        }
        ~p1()
        {
            //System.Diagnostics.Debug.WriteLine("destr");
           _b = null;
        }
    }
}
