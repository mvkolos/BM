﻿#pragma checksum "..\..\..\Pages\PageQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C46454E1DE70BCA7DBCB17DE546A7134"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// PageQuestion
    /// </summary>
    public partial class PageQuestion : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 152 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button magazines_back_button;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_you_are;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_country;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox_business;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r1;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r2;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r3;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Pages\PageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r4;
        
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
            System.Uri resourceLocater = new System.Uri("/BigMoscow;component/pages/pagequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageQuestion.xaml"
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
            
            #line 10 "..\..\..\Pages\PageQuestion.xaml"
            ((BigMoscow.Pages.PageQuestion)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Pages\PageQuestion.xaml"
            ((BigMoscow.Pages.PageQuestion)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 120 "..\..\..\Pages\PageQuestion.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RU_click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 123 "..\..\..\Pages\PageQuestion.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.en_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.magazines_back_button = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\..\Pages\PageQuestion.xaml"
            this.magazines_back_button.Click += new System.Windows.RoutedEventHandler(this.magazines_back_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.combobox_you_are = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.combobox_country = ((System.Windows.Controls.ComboBox)(target));
            
            #line 200 "..\..\..\Pages\PageQuestion.xaml"
            this.combobox_country.Loaded += new System.Windows.RoutedEventHandler(this.combobox_country_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.combobox_business = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.r1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.r2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.r3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.r4 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            
            #line 220 "..\..\..\Pages\PageQuestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

