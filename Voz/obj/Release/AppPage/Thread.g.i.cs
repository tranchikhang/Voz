﻿#pragma checksum "D:\Dropbox\.net project\Windows phone 8\Voz\Voz\AppPage\Thread.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC17B1230404621FEED7C3E331A87009"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Voz.AppPage {
    
    
    public partial class Thread : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.TextBlock textBlockTitle;
        
        internal System.Windows.Controls.ScrollViewer scrollViewerMain;
        
        internal System.Windows.Controls.TextBox textBoxCurrentPage;
        
        internal System.Windows.Controls.ListBox listBoxPosts;
        
        internal System.Windows.Controls.TextBox textBoxCurrentPageBottom;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Voz;component/AppPage/Thread.xaml", System.UriKind.Relative));
            this.textBlockTitle = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockTitle")));
            this.scrollViewerMain = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewerMain")));
            this.textBoxCurrentPage = ((System.Windows.Controls.TextBox)(this.FindName("textBoxCurrentPage")));
            this.listBoxPosts = ((System.Windows.Controls.ListBox)(this.FindName("listBoxPosts")));
            this.textBoxCurrentPageBottom = ((System.Windows.Controls.TextBox)(this.FindName("textBoxCurrentPageBottom")));
        }
    }
}

