﻿#pragma checksum "..\..\..\Pages\PageSend.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA9683EE2BA04C725BD2EDD8D38C49E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BigMoscow;
using BigMoscow.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BigMoscow.Pages {
    
    
    /// <summary>
    /// PageSend
    /// </summary>
    public partial class PageSend : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\PageSend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button magazines_back_button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageSend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button carousel_back_button;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PageSend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Email;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\PageSend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_send_smth;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BigMoscow;component/pages/pagesend.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageSend.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Pages\PageSend.xaml"
            ((BigMoscow.Pages.PageSend)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.magazines_back_button = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\PageSend.xaml"
            this.magazines_back_button.Click += new System.Windows.RoutedEventHandler(this.magazines_back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.carousel_back_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\PageSend.xaml"
            this.carousel_back_button.Click += new System.Windows.RoutedEventHandler(this.carousel_back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textbox_Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\Pages\PageSend.xaml"
            this.textbox_Email.GotFocus += new System.Windows.RoutedEventHandler(this.textbox_Email_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\Pages\PageSend.xaml"
            this.textbox_Email.GotTouchCapture += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.textbox_Email_GotTouchCapture);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_send_smth = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Pages\PageSend.xaml"
            this.button_send_smth.Click += new System.Windows.RoutedEventHandler(this.button_send_smth_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

