﻿#pragma checksum "..\..\..\View\FormaTema.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F63D07D8CE5462048F78CACFED46A29FCB2E8509B061BCDEA2A823BDC37920F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyApplication.View;
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


namespace MyApplication.View {
    
    
    /// <summary>
    /// FormaTema
    /// </summary>
    public partial class FormaTema : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\View\FormaTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Potvrdi;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\FormaTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Napusti;
        
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
            System.Uri resourceLocater = new System.Uri("/MyApplication;component/view/formatema.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\FormaTema.xaml"
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
            
            #line 37 "..\..\..\View\FormaTema.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 38 "..\..\..\View\FormaTema.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.rb2_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Potvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\View\FormaTema.xaml"
            this.Potvrdi.Click += new System.Windows.RoutedEventHandler(this.Potvrdi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Napusti = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\View\FormaTema.xaml"
            this.Napusti.Click += new System.Windows.RoutedEventHandler(this.Odustani_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

