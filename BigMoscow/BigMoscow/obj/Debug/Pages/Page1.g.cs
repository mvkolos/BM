﻿#pragma checksum "..\..\..\Pages\Page1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E5A31B28C85D884FF409693968994F05"
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
using BigMoscow.Controls.en12;
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
using WPFMitsuControls;


namespace BigMoscow {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PageGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel coversPanel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel BookDock;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFMitsuControls.Book myBook;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockFeedBack;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel content_magaz;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_info;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button carousel_back_button;
        
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
            System.Uri resourceLocater = new System.Uri("/BigMoscow;component/pages/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Page1.xaml"
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
            this.PageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.coversPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.BookDock = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.myBook = ((WPFMitsuControls.Book)(target));
            return;
            case 5:
            
            #line 61 "..\..\..\Pages\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Feedback_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockFeedBack = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 96 "..\..\..\Pages\Page1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuRuClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 99 "..\..\..\Pages\Page1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuengClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.content_magaz = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 104 "..\..\..\Pages\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mail_button_click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.button_info = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\Page1.xaml"
            this.button_info.Click += new System.Windows.RoutedEventHandler(this.button_info_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.carousel_back_button = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Pages\Page1.xaml"
            this.carousel_back_button.Click += new System.Windows.RoutedEventHandler(this.carousel_back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

