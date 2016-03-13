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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Widgets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> strings = new List<string>() {"Zoom In/Out","Tip","Toggle","CheckBox" };
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
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
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void tip_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tip));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = listBox.SelectedItem.ToString();
            if(val == "Tip")
            {
                Frame.Navigate(typeof(Tip));
            }          
            else if (val == "Toggle")
            {
                Frame.Navigate(typeof(Toggle));
            }
            else if (val == "Zoom In/Out")
            {
                Frame.Navigate(typeof(ImageZoomInOut));
            }
            else if (val == "CheckBox")
            {
                Frame.Navigate(typeof(CheckBox));
            }           
        }

        private void bExit_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();   
        }
    }
}
