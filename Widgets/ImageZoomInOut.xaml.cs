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
    public sealed partial class ImageZoomInOut : Page
    {
        List<string> strings = new List<string>() {"Slider", "Radio Buttons","Toggle Buttons" };
        public ImageZoomInOut()
        {
            this.InitializeComponent();
            listBox.ItemsSource = strings;
            listBox.SelectionChanged += listBox_SelectionChanged;            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = listBox.SelectedItem.ToString();
            if (val == "Slider")
            {
                //For slider
                Frame.Navigate(typeof(ImagePage));
            }
            else if (val == "Radio Buttons")
            {
                //for radio buttons
                Frame.Navigate(typeof(RadioImage));
            }
            else if (val == "Toggle Buttons")
            {
                //for radio buttons
                Frame.Navigate(typeof(ToggleButtonsImage));
            }
        }

        private void back_pressed(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void listbox_selected(object sender, TappedRoutedEventArgs e)
        {
            string val = listBox.SelectedItem.ToString();
            if (val == "Slider")
            {
                //For slider
                Frame.Navigate(typeof(ImagePage));
            }
            else if (val == "Radio Buttons")
            {
                //for radio buttons
                Frame.Navigate(typeof(RadioImage));
            }
            else if (val == "Toggle Buttons")
            {
                //for radio buttons
                Frame.Navigate(typeof(ToggleButtonsImage));
            }
        }
    }
}
