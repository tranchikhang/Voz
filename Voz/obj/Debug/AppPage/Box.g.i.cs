﻿#pragma checksum "D:\Dropbox\.net project\Windows phone 8\Voz\Voz\AppPage\Box.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B9BB790D794708028CFCC607AB8A5B0F"
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
    
    
    public partial class Box : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.TextBlock textBlockBoxTitle;
        
        internal System.Windows.Controls.ScrollViewer scrollViewer_Main;
        
        internal System.Windows.Controls.TextBox textBoxCurrentPage;
        
        internal System.Windows.Controls.ListBox listBoxTopics;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Voz;component/AppPage/Box.xaml", System.UriKind.Relative));
            this.textBlockBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockBoxTitle")));
            this.scrollViewer_Main = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer_Main")));
            this.textBoxCurrentPage = ((System.Windows.Controls.TextBox)(this.FindName("textBoxCurrentPage")));
            this.listBoxTopics = ((System.Windows.Controls.ListBox)(this.FindName("listBoxTopics")));
            this.textBoxCurrentPageBottom = ((System.Windows.Controls.TextBox)(this.FindName("textBoxCurrentPageBottom")));
        }
    }
}

