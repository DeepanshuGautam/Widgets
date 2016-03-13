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
    public sealed partial class RadioImage : Page
    {
        public RadioImage()
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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (r100.IsChecked == true)
            {
                image.Height = 250;
                image.Width = 250;
            }
            if (r75.IsChecked == true)
            {
                image.Height = 210;
                image.Width = 210;
            }
            if (r50.IsChecked == true)
            {
                image.Height = 150;
                image.Width = 150;
            }
            if (r40.IsChecked == true)
            {
                image.Height = 120;
                image.Width = 120;
            }
            if (r30.IsChecked == true)
            {
                image.Height = 90;
                image.Width = 90;
            }
            if (r20.IsChecked == true)
            {
                image.Height = 60;
                image.Width = 60;
            }
        }

        private void back_pressed(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageZoomInOut));
        }
    }
}
