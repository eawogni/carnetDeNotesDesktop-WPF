﻿#pragma checksum "..\..\FenetreModule - Copier.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "66E891B3387ECDCA31667208B7211093"
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
    /// FenetreModule
    /// </summary>
    public partial class FenetreModule : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\FenetreModule - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdModule;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FenetreModule - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomModule;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FenetreModule - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoefficientModule;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\FenetreModule - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ajouter;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\FenetreModule - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Annuler;
        
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
            System.Uri resourceLocater = new System.Uri("/AppliCarnet2Notes;component/fenetremodule%20-%20copier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenetreModule - Copier.xaml"
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
            this.IdModule = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NomModule = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CoefficientModule = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\FenetreModule - Copier.xaml"
            this.Ajouter.Click += new System.Windows.RoutedEventHandler(this.Click_Ajouter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\FenetreModule - Copier.xaml"
            this.Annuler.Click += new System.Windows.RoutedEventHandler(this.Click_Annuler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
