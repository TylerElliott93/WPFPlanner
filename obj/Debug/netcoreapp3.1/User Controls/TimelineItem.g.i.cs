﻿#pragma checksum "..\..\..\..\User Controls\TimelineItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AAC6484AE1A24D9E0CB7F058D8577BA09B5EC2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFPlanner.User_Controls;


namespace WPFPlanner.User_Controls {
    
    
    /// <summary>
    /// TimelineItem
    /// </summary>
    public partial class TimelineItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\User Controls\TimelineItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\User Controls\TimelineItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonHourDecrement;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\User Controls\TimelineItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonHourIncrement;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\User Controls\TimelineItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMinuteDecrement;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\User Controls\TimelineItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMinuteIncrement;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFPlanner;component/user%20controls/timelineitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\User Controls\TimelineItem.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\User Controls\TimelineItem.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonHourDecrement = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\User Controls\TimelineItem.xaml"
            this.ButtonHourDecrement.Click += new System.Windows.RoutedEventHandler(this.ButtonHourDecrement_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonHourIncrement = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\User Controls\TimelineItem.xaml"
            this.ButtonHourIncrement.Click += new System.Windows.RoutedEventHandler(this.ButtonHourIncrement_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonMinuteDecrement = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\User Controls\TimelineItem.xaml"
            this.ButtonMinuteDecrement.Click += new System.Windows.RoutedEventHandler(this.ButtonMinuteDecrement_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonMinuteIncrement = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\User Controls\TimelineItem.xaml"
            this.ButtonMinuteIncrement.Click += new System.Windows.RoutedEventHandler(this.ButtonMinuteIncrement_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

