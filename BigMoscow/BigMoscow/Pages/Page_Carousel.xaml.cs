﻿using BigMoscow.Logic;
using BigMoscow.Pages;
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
using System.Windows.Threading;

namespace BigMoscow
{
    /// <summary>
    /// Логика взаимодействия для Page_Carousel.xaml
    /// </summary>
    public partial class Page_Carousel : Page
    {
        JournalsPage page;
        Flip flip;
        public string BackGroundURL;

        public Page_Carousel(JournalsPage page)
        {
            InitializeComponent();
            this.page = page;
        }

        public Page_Carousel(Flip flip)
        {
            InitializeComponent();
            this.flip = flip;
        }
        
        private void button_pattern_Click(object sender, RoutedEventArgs e)
        {
           string[] new_url = BackGroundURL.Split(new char[] { '.' });
           CurrentJournal.journal = "."+new_url[new_url.Length - 2];

            if (page != null)
            {
                page.BookAdd();
                page.ContentAdd();
            } else if (flip != null)
            {
                flip.showJournalsPage();
            }

            
        }
    }
}
