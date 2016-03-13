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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Widgets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ToggleButtonsImage : Page
    {
        public ToggleButtonsImage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void back_pressed(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageZoomInOut));
        }

        private void t100_click(object sender, RoutedEventArgs e)
        {
            if(t100.IsChecked == true)
            {
                image.Width = 250;
                image.Height = 250;

                t75.IsChecked = false;
                t50.IsChecked = false;
                t25.IsChecked = false;
            }            
        }

        private void t75_click(object sender, RoutedEventArgs e)
        {
            if (t75.IsChecked == true)
            {
                image.Width = 200;
                image.Height = 200;

                t100.IsChecked = false;
                t50.IsChecked = false;
                t25.IsChecked = false;
            }
        }

        private void t50_click(object sender, RoutedEventArgs e)
        {
            if (t50.IsChecked == true)
            {
                image.Width = 125;
                image.Height = 125;

                t75.IsChecked = false;
                t100.IsChecked = false;
                t25.IsChecked = false;
            }
        }

        private void t25_click(object sender, RoutedEventArgs e)
        {
            if (t25.IsChecked == true)
            {
                image.Width = 75;
                image.Height = 75;

                t75.IsChecked = false;
                t50.IsChecked = false;
                t100.IsChecked = false;
            }
        }
    }
}
