﻿#pragma checksum "..\..\FenetreAccueil.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56571DDBB3A92FCFE26D67E1F889F8120D135762"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppliCarnet2Notes;
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


namespace AppliCarnet2Notes {
    
    
    /// <summary>
    /// FenetreAccueil
    /// </summary>
    public partial class FenetreAccueil : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\FenetreAccueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\FenetreAccueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrénom;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FenetreAccueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CréerCarnet;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FenetreAccueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccéderCarnet;
        
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
            System.Uri resourceLocater = new System.Uri("/AppliCarnet2Notes;component/fenetreaccueil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenetreAccueil.xaml"
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
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtPrénom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CréerCarnet = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\FenetreAccueil.xaml"
            this.CréerCarnet.Click += new System.Windows.RoutedEventHandler(this.Click_CréerCarnet);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AccéderCarnet = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\FenetreAccueil.xaml"
            this.AccéderCarnet.Click += new System.Windows.RoutedEventHandler(this.ClickAccéderCarnet);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
