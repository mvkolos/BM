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
using BigMoscow.Logic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;
using BigMoscow.Windows;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;

namespace BigMoscow.Pages
{
   

    /// <summary>
    /// Логика взаимодействия для PageSend.xaml
    /// </summary>
    public partial class PageSend : Page
    {
        Flip _flip;
        FeedBackRepository feed;
        public PageSend(Flip flip)
        {
            feed = new FeedBackRepository();
            InitializeComponent();
            //DisableWPFTabletSupport();
            _flip = flip;
        }

        private void button_send_smth_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox_Email.Text))
            {
                feed.SendPDF(textbox_Email.Text);
                //MessageBox.Show(Properties.Resources.message);
                _flip.showJournalsPage();
            }

        }
        public static void DisableWPFTabletSupport()
        {
            // Get a collection of the tablet devices for this window.  
            TabletDeviceCollection devices = System.Windows.Input.Tablet.TabletDevices;

            if (devices.Count > 0)
            {
                // Get the Type of InputManager.
                Type inputManagerType = typeof(System.Windows.Input.InputManager);

                // Call the StylusLogic method on the InputManager.Current instance.
                object stylusLogic = inputManagerType.InvokeMember("StylusLogic",
                            BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                            null, InputManager.Current, null);

                if (stylusLogic != null)
                {
                    //  Get the type of the stylusLogic returned from the call to StylusLogic.
                    Type stylusLogicType = stylusLogic.GetType();

                    // Loop until there are no more devices to remove.
                    while (devices.Count > 0)
                    {
                        // Remove the first tablet device in the devices collection.
                        stylusLogicType.InvokeMember("OnTabletRemoved",
                                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
                                null, stylusLogic, new object[] { (uint)0 });
                    }
                }

            }
        }

        private void textbox_Email_GotFocus(object sender, RoutedEventArgs e)
        {
            startKeyboard();
        }
        //Bigmoscow@3dday.ru
        //bigmsc
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InputPanelConfiguration cp = new InputPanelConfiguration();
            IInputPanelConfiguration icp = cp as IInputPanelConfiguration;
            if (icp != null)
                icp.EnableFocusTracking();
        }

        private void textbox_Email_GotTouchCapture(object sender, TouchEventArgs e)
        {
            startKeyboard();
        }

        private Process _touchKeyboardProcess = null;

        private void startKeyboard()
        {
            if (_touchKeyboardProcess == null )
            {
                String touchKeyboardPath = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe";
                _touchKeyboardProcess = Process.Start(touchKeyboardPath);
            }
        }

        private void removeKeyboard()
        {
            if (_touchKeyboardProcess != null)
            {
                _touchKeyboardProcess.Kill();
                _touchKeyboardProcess = null;
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

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Button)
            {
                Button button = (Button)e.OriginalSource;
                //if (button == carousel_back_button)
                //{
                //    _flip.showCarouselPage();
                //}
            }
        }

        private void StackPanel_PreviewTouchDown(object sender, TouchEventArgs e)
        {
            if (e.OriginalSource is Button)
            {

            }
        }

        private void en_click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "en-US";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.showSendPage(true);
        }

        private void RU_click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings["Culture"] = "ru-RU";

            Properties.Resources.Culture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            _flip.showSendPage(true);
        }
    }
    [Guid("41C81592-514C-48BD-A22E-E6AF638521A6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInputPanelConfiguration
    {
        /// 
        /// Enables a client process to opt-in to the focus tracking mechanism for Windows Store apps that controls the invoking and dismissing semantics of the touch keyboard.
        /// 
        /// If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.
        int EnableFocusTracking();
    }

    [ComImport, Guid("2853ADD3-F096-4C63-A78F-7FA3EA837FB7")]
    class InputPanelConfiguration
    {
    }
   
}
