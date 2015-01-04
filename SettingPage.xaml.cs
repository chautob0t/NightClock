using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;    // to add persistant brightness setting
using Microsoft.Phone.Shell;

namespace NightClock
{
    public partial class Settingsage : PhoneApplicationPage
    {
        double brightness;
        int brightnes;
        IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
        
        public Settingsage()
        {
            InitializeComponent();
            if (settings.Contains("brightness"))
            {
                opacityValueSlider.Value = (double)settings["brightness"] * 100.0; 
                // need to multiply by 100 because value stored in settings["brightness"] is 0.0 to 1.0
            }
            else
            {
                opacityValueSlider.Value = 30;
                // default case, used when application is initialized for the first time
            }
        }

       

        private void opacityValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (opacityValueSlider != null)
            // need to check this if condition otherwise this event if fired while the slider is being constructed 
            // and leads to a null reference exception since we try to access opcaityValueSlider.value
            {
                brightness = opacityValueSlider.Value;
                brightnes = (int)brightness;
                currentBrightnessTextblock.Text = "Current Brightness = " + brightnes.ToString() + "%";

                if (settings.Contains("brightness"))
                {
                    settings.Remove("brightness");
                    double v = opacityValueSlider.Value / 100;
                    settings.Add("brightness", v);  // storing brightness directly in range 0.0 - 1.0
                    settings.Save();        // don't forget to save
                }
                else
                {
                    // this case is for first run of the app since no settings exist at first run
                    double v = opacityValueSlider.Value / 100;
                    settings.Add("brightness", v);
                    settings.Save();        // don't forget to save
                }
            }
        }
    }
}