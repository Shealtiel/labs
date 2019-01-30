using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWPLab
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            OurFrame.Navigate(typeof(Page1));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            OurFrame.Navigate(typeof(Page1));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (OurFrame.CanGoBack)
            {
                OurFrame.GoBack();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (OurFrame.CanGoForward)
            {
                OurFrame.GoForward();
            }
        }
    }
}
