﻿#pragma checksum "..\..\Ujjatek.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0CE714007C4D37238229CDFED87CA2E1"
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


namespace Raetreon {
    
    
    /// <summary>
    /// Ujjatek
    /// </summary>
    public partial class Ujjatek : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image karakterkep;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bnyil;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button jnyil;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox kasztvalaszto;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kivalazt_kaszt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox karakternev;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fegyvervalaszto;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button visszalep;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Ujjatek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letrehoz;
        
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
            System.Uri resourceLocater = new System.Uri("/Raetreon;component/ujjatek.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Ujjatek.xaml"
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
            this.karakterkep = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.bnyil = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Ujjatek.xaml"
            this.bnyil.Click += new System.Windows.RoutedEventHandler(this.bnyil_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.jnyil = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Ujjatek.xaml"
            this.jnyil.Click += new System.Windows.RoutedEventHandler(this.jnyil_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.kasztvalaszto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.kivalazt_kaszt = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Ujjatek.xaml"
            this.kivalazt_kaszt.Click += new System.Windows.RoutedEventHandler(this.kivalaszt_kaszt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.karakternev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.fegyvervalaszto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.visszalep = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Ujjatek.xaml"
            this.visszalep.Click += new System.Windows.RoutedEventHandler(this.visszalep_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.letrehoz = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Ujjatek.xaml"
            this.letrehoz.Click += new System.Windows.RoutedEventHandler(this.letrehoz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

