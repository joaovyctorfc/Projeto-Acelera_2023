﻿#pragma checksum "..\..\TelaPrincipalAluno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C582C8B16FB8B253CAC3739A5D125CFBE094798E7451097E4882DE78349B1765"
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
    /// TelaPrincipalAluno
    /// </summary>
    public partial class TelaPrincipalAluno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\TelaPrincipalAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoVagasAnalise;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\TelaPrincipalAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoSair;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TelaPrincipalAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoPerfil;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TelaPrincipalAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoVagas;
        
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
            System.Uri resourceLocater = new System.Uri("/Projeto-Acelera-2023;component/telaprincipalaluno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TelaPrincipalAluno.xaml"
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
            this.botaoVagasAnalise = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.botaoSair = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.botaoPerfil = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\TelaPrincipalAluno.xaml"
            this.botaoPerfil.Click += new System.Windows.RoutedEventHandler(this.botaoPerfil_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.botaoVagas = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

