﻿#pragma checksum "..\..\StormCloudWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "777C6BE0432399C8C01F1B7EA3E08AE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelixToolkit.Wpf;
using StormCloud;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace StormCloud {
    
    
    /// <summary>
    /// StormCloudWindow
    /// </summary>
    public partial class StormCloudWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal StormCloud.StormCloudWindow SCWindow;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HelixToolkit.Wpf.HelixViewport3D CurrentModel;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox autoGenerateCheck;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider autogenSlider;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Pop;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Mut;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer myScroll;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\StormCloudWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DesignGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StormCloud;component/stormcloudwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StormCloudWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SCWindow = ((StormCloud.StormCloudWindow)(target));
            return;
            case 2:
            this.CurrentModel = ((HelixToolkit.Wpf.HelixViewport3D)(target));
            return;
            case 3:
            this.autoGenerateCheck = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.autogenSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.Pop = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.Mut = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.myScroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 8:
            this.DesignGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 105 "..\..\StormCloudWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Generate);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\StormCloudWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Build);
            
            #line default
            #line hidden
            
            #line 110 "..\..\StormCloudWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseRightButtonDown_Build);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
