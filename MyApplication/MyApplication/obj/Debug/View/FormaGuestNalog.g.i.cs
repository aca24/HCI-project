﻿#pragma checksum "..\..\..\View\FormaGuestNalog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA21EF3374EC72152592B7FCAC75053B2B5980AA604832FC9767494651BEEA96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyApplication.Validation;
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
    /// FormaGuestNalog
    /// </summary>
    public partial class FormaGuestNalog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtJmbg;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIme;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrezime;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink RegistujSe;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kreiraj;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\View\FormaGuestNalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
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
            System.Uri resourceLocater = new System.Uri("/MyApplication;component/view/formaguestnalog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\FormaGuestNalog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.txtJmbg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPrezime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RegistujSe = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 148 "..\..\..\View\FormaGuestNalog.xaml"
            this.RegistujSe.Click += new System.Windows.RoutedEventHandler(this.RegistujSe_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Kreiraj = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\View\FormaGuestNalog.xaml"
            this.Kreiraj.Click += new System.Windows.RoutedEventHandler(this.Kreiraj_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\View\FormaGuestNalog.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.Odustani_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

