﻿#pragma checksum "..\..\StudentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07FA263127FC57D53301E1776D79F9E46CF1C6F23F722B76B86B3ED12E6AFEDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Учет_посещаемости;


namespace Учет_посещаемости {
    
    
    /// <summary>
    /// StudentWindow
    /// </summary>
    public partial class StudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Grup;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Predm;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cpez;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Attend;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Out;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Info;
        
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
            System.Uri resourceLocater = new System.Uri("/Учет посещаемости;component/studentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentWindow.xaml"
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
            this.Grup = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\StudentWindow.xaml"
            this.Grup.Click += new System.Windows.RoutedEventHandler(this.Grup_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Predm = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\StudentWindow.xaml"
            this.Predm.Click += new System.Windows.RoutedEventHandler(this.Predm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Cpez = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\StudentWindow.xaml"
            this.Cpez.Click += new System.Windows.RoutedEventHandler(this.Cpez_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Attend = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\StudentWindow.xaml"
            this.Attend.Click += new System.Windows.RoutedEventHandler(this.Attend_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Out = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\StudentWindow.xaml"
            this.Out.Click += new System.Windows.RoutedEventHandler(this.Out_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Info = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

