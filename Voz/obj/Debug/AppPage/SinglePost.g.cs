﻿#pragma checksum "E:\Dropbox\.net project\Windows phone 8\Voz\Voz\AppPage\SinglePost.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D8730BE966E9F54E39A4174F5BB10B3B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MSPToolkit.Controls;
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
    
    
    public partial class SinglePost : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.TextBlock textBlock_PostTime;
        
        internal System.Windows.Controls.TextBlock textBlock_PostCount;
        
        internal System.Windows.Controls.Image image_Ava;
        
        internal System.Windows.Controls.TextBlock textBlock_User;
        
        internal System.Windows.Controls.TextBlock textBlock_JD;
        
        internal System.Windows.Controls.TextBlock textBlock_Posts;
        
        internal System.Windows.Controls.TextBlock textBlock_Location;
        
        internal MSPToolkit.Controls.HTMLViewer htmlViewer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Voz;component/AppPage/SinglePost.xaml", System.UriKind.Relative));
            this.textBlock_PostTime = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_PostTime")));
            this.textBlock_PostCount = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_PostCount")));
            this.image_Ava = ((System.Windows.Controls.Image)(this.FindName("image_Ava")));
            this.textBlock_User = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_User")));
            this.textBlock_JD = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_JD")));
            this.textBlock_Posts = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_Posts")));
            this.textBlock_Location = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_Location")));
            this.htmlViewer = ((MSPToolkit.Controls.HTMLViewer)(this.FindName("htmlViewer")));
        }
    }
}

