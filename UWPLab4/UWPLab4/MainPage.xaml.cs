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

namespace UWPLab4
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            OurMainFrame.Navigate(typeof(Books));
        }

        private void ButtonHamburger_Click(object sender, RoutedEventArgs e)
        {
            OurSplitView.IsPaneOpen = !OurSplitView.IsPaneOpen;
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            OurMainFrame.Navigate(typeof(Books));
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (OurMainFrame.CanGoBack)
            {
                OurMainFrame.GoBack();
            }

        }

        private void ButtonForward_Click(object sender, RoutedEventArgs e)
        {
            if (OurMainFrame.CanGoForward)
            {
                OurMainFrame.GoForward();
            }

        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            OurMainFrame.Navigate(typeof(Help));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxBooks.IsSelected)
            {
                OurMainFrame.Navigate(typeof(Books));
                return;
            }
            if (ListBoxMusic.IsSelected)
            {
                OurMainFrame.Navigate(typeof(Music));
                return;
            }
            if (ListBoxFilms.IsSelected)
            {
                OurMainFrame.Navigate(typeof(Films));
                return;
            }
        }

        private void OurMainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            string Name = e.SourcePageType.Name;
            TitleTextBlock.Text = Name;
            if (Name == "Books")
            {
                ListBoxBooks.IsSelected = true;
            }

            if (Name == "Music")
            {
                ListBoxMusic.IsSelected = true;
            }

            if (Name == "Films")
            {
                ListBoxFilms.IsSelected = true;
            }
        }
    }
}
