﻿#pragma checksum "C:\Users\Vaibhav\documents\visual studio 2013\Projects\NightClock\NightClock\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DB6B893DDCE98B6FE976B8381CFD923"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NightClock {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivot;
        
        internal System.Windows.Controls.TextBlock dateTextBlock;
        
        internal System.Windows.Controls.TextBlock timeBlock1;
        
        internal System.Windows.Controls.TextBlock timeBlock2;
        
        internal System.Windows.Controls.TextBlock timeBlock3;
        
        internal System.Windows.Controls.TextBlock timeBlock4;
        
        internal System.Windows.Controls.TextBlock timeBlock5;
        
        internal System.Windows.Controls.Button visitBlog;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/NightClock;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivot")));
            this.dateTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("dateTextBlock")));
            this.timeBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock1")));
            this.timeBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock2")));
            this.timeBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock3")));
            this.timeBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock4")));
            this.timeBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock5")));
            this.visitBlog = ((System.Windows.Controls.Button)(this.FindName("visitBlog")));
        }
    }
}

