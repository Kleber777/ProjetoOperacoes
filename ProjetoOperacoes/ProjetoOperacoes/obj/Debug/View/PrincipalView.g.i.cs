﻿#pragma checksum "..\..\..\View\PrincipalView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2DA15B29497C3BE653E3CA30C54C15A6A53507BE5439A0A8A9F2777CD1851E48"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetoOperacoes;
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


namespace ProjetoOperacoes.View {
    
    
    /// <summary>
    /// PrincipalView
    /// </summary>
    public partial class PrincipalView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 473 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridPrincipal;
        
        #line default
        #line hidden
        
        
        #line 505 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVoltarLista;
        
        #line default
        #line hidden
        
        
        #line 521 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbSearch;
        
        #line default
        #line hidden
        
        
        #line 532 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer sV1;
        
        #line default
        #line hidden
        
        
        #line 533 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl listaProdutoView;
        
        #line default
        #line hidden
        
        
        #line 589 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstListaTiposContas;
        
        #line default
        #line hidden
        
        
        #line 654 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstAplicacaoConsolidada;
        
        #line default
        #line hidden
        
        
        #line 693 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstFutureApplication;
        
        #line default
        #line hidden
        
        
        #line 724 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstAccomplishedApplicationInputModel;
        
        #line default
        #line hidden
        
        
        #line 753 "..\..\..\View\PrincipalView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstAccomplishedApplicationInputModels;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetoOperacoes;component/view/principalview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PrincipalView.xaml"
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
            this.GridPrincipal = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btnVoltarLista = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.txtbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 521 "..\..\..\View\PrincipalView.xaml"
            this.txtbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sV1 = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.listaProdutoView = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.lstListaTiposContas = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.lstAplicacaoConsolidada = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.lstFutureApplication = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.lstAccomplishedApplicationInputModel = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.lstAccomplishedApplicationInputModels = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 537 "..\..\..\View\PrincipalView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AtualizarViewModel_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

