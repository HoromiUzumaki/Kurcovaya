﻿#pragma checksum "..\..\AddAttendance.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B045F8CB7082BCE31878E90DF28EDA2DD4A8AA6216C235CE900E406BF591BCC"
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
    /// AddAttendance
    /// </summary>
    public partial class AddAttendance : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Fio;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Predmet;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Prich;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Dat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cohr;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddAttendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nom;
        
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
            System.Uri resourceLocater = new System.Uri("/Учет посещаемости;component/addattendance.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddAttendance.xaml"
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
            this.Fio = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.Predmet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Prich = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Dat = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Cohr = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddAttendance.xaml"
            this.Cohr.Click += new System.Windows.RoutedEventHandler(this.Cohr_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Nom = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

