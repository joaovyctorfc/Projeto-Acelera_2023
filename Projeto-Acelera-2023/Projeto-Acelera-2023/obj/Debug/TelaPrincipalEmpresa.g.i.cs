﻿#pragma checksum "..\..\TelaPrincipalEmpresa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5081BF737190D78CA0DE675718D5D3790DCFAD174728B8D3CA02865A6F06012B"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Projeto_Acelera_2023;
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


namespace Projeto_Acelera_2023 {
    
    
    /// <summary>
    /// TelaPrincipalEmpresa
    /// </summary>
    public partial class TelaPrincipalEmpresa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\TelaPrincipalEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoCriarVaga;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\TelaPrincipalEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoSair;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TelaPrincipalEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoPerfil;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TelaPrincipalEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoVagas;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TelaPrincipalEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoVagasAnalise;
        
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
            System.Uri resourceLocater = new System.Uri("/Projeto-Acelera-2023;component/telaprincipalempresa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TelaPrincipalEmpresa.xaml"
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
            this.botaoCriarVaga = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\TelaPrincipalEmpresa.xaml"
            this.botaoCriarVaga.Click += new System.Windows.RoutedEventHandler(this.botaoCriarVaga_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.botaoSair = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\TelaPrincipalEmpresa.xaml"
            this.botaoSair.Click += new System.Windows.RoutedEventHandler(this.botaoSair_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.botaoPerfil = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\TelaPrincipalEmpresa.xaml"
            this.botaoPerfil.Click += new System.Windows.RoutedEventHandler(this.botaoPerfil_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.botaoVagas = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\TelaPrincipalEmpresa.xaml"
            this.botaoVagas.Click += new System.Windows.RoutedEventHandler(this.botaoVagas_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.botaoVagasAnalise = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\TelaPrincipalEmpresa.xaml"
            this.botaoVagasAnalise.Click += new System.Windows.RoutedEventHandler(this.botaoVagasAnalise_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

