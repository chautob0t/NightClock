using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;        // to use MarketPlace review task, email task
using System.Windows.Threading;     // to use DispatcherTimer
using NightClock.Resources;

namespace NightClock
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // code to localize the ApplicationBar
            BuildLocalizedApplicationBar();

            DispatcherTimer d = new DispatcherTimer();
            d.Interval = TimeSpan.FromSeconds(1);
            d.Tick += d_Tick;       // a tick is registered every second and the d_Tick function is called
            d.Start();
            // ticks were used FromSeconds(1) to update time each second
        }

        int i = 0;

        // Tick event handler
        void d_Tick(object sender, EventArgs e)
        {
            // a textblock is kept active of 600 ticks (or seconds)
            // this could be done using FromMinutes(10) tick event but that way we cannot live update the seconds
            i++;
            dateTextBlock.Text = DateTime.Now.ToLongDateString();
            if (i >= 0 && i <= 600)
            {
                resetTextBoxes(1);
                timeBlock1.Text = DateTime.Now.ToLongTimeString();
            }
            else if (i > 600 && i <= 1200)
            {
                resetTextBoxes(2);
                timeBlock2.Text = DateTime.Now.ToLongTimeString();
            }
            else if (i > 1200 && i <= 1800)
            {
                resetTextBoxes(3);
                timeBlock3.Text = DateTime.Now.ToLongTimeString();
            }
            else if (i > 1800 && i <= 2400)
            {
                resetTextBoxes(4);
                timeBlock4.Text = DateTime.Now.ToLongTimeString();
            }
            else if (i > 2400 && i <= 3000)
            {
                resetTextBoxes(5);
                timeBlock5.Text = DateTime.Now.ToLongTimeString();
                if (i == 3000) i = 0;
            }
        }

        // Function to reset other textblocks to create a moving text effect
        void resetTextBoxes(int num)
        {
            switch (num)
            {
                case 1:
                  //  timeBlock1.Text = "";
                    timeBlock2.Text = "";
                    timeBlock3.Text = "";
                    timeBlock4.Text = "";
                    timeBlock5.Text = "";
                    timeBlock2.Text = "";
                    break;
                case 2:
                    timeBlock1.Text = "";
                  //  timeBlock2.Text = "";
                    timeBlock3.Text = "";
                    timeBlock4.Text = "";
                    timeBlock5.Text = "";
                    timeBlock2.Text = "";
                    break;
                case 3:
                    timeBlock1.Text = "";
                    timeBlock2.Text = "";
                  //  timeBlock3.Text = "";
                    timeBlock4.Text = "";
                    timeBlock5.Text = "";
                    timeBlock2.Text = "";
                    break;
                case 4:
                    timeBlock1.Text = "";
                    timeBlock2.Text = "";
                    timeBlock3.Text = "";
                  //  timeBlock4.Text = "";
                    timeBlock5.Text = "";
                    timeBlock2.Text = "";
                    break;
                case 5:
                    timeBlock1.Text = "";
                    timeBlock2.Text = "";
                    timeBlock3.Text = "";
                    timeBlock4.Text = "";
                    timeBlock5.Text = "";
                   // timeBlock2.Text = "";
                    break;
            }
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }


        // code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
        // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
     
        // Create a new menu item with the localized string from AppResources.
           ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem("rate & review");
           ApplicationBar.MenuItems.Add(appBarMenuItem);
           ApplicationBarMenuItem appBarMenuItem2 = new ApplicationBarMenuItem("feedback");
           ApplicationBar.MenuItems.Add(appBarMenuItem2);
           appBarMenuItem.Click += appBarMenuItem_Click;
           appBarMenuItem2.Click += appBarMenuItem2_Click;
        }

        void appBarMenuItem2_Click(object sender, EventArgs e)
        {
            // event handler for feedback option
            EmailComposeTask feedback = new EmailComposeTask();
            feedback.To = "vaibhav_vc@outlook.com";
            feedback.Subject = "Feedback for App: Night Clock v2";
            feedback.Show();
        }

        void appBarMenuItem_Click(object sender, EventArgs e)
        {
            // event handler for review task
            MarketplaceReviewTask mrkt = new MarketplaceReviewTask();
            mrkt.Show();
        }

        private void visitBlog_Click(object sender, RoutedEventArgs e)
        {
            // funtion to launch IE and load the URL given

            //Create a new instance of the Task
            WebBrowserTask webtask = new WebBrowserTask();

            //Set the url property
            webtask.URL = "http://www.chauhanvaibhav.net/";

            //launch the task
            webtask.Show();

        }
    }
}