// Updated by XamlIntelliSenseFileGenerator 24/05/2023 21:51:26
#pragma checksum "..\..\TelaLogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2046469B4840F3FD0EEF9AC8318DF88270945CC08B74A01D0E7EF445AAD7D361"
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


namespace Projeto_Acelera_2023
{


    /// <summary>
    /// TelaLogin
    /// </summary>
    public partial class TelaLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 155 "..\..\TelaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botaoLogin;

#line default
#line hidden


#line 156 "..\..\TelaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock linkRedefinir;

#line default
#line hidden


#line 166 "..\..\TelaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox campoEmail;

#line default
#line hidden


#line 167 "..\..\TelaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox campoSenha;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projeto-Acelera-2023;component/telalogin.xaml", System.UriKind.Relative);

#line 1 "..\..\TelaLogin.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.___Sem_Nome_ = ((Projeto_Acelera_2023.TelaLogin)(target));
                    return;
                case 2:
                    this.botaoLogin = ((System.Windows.Controls.Button)(target));

#line 155 "..\..\TelaLogin.xaml"
                    this.botaoLogin.Click += new System.Windows.RoutedEventHandler(this.botaoLogin_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.linkRedefinir = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:

#line 157 "..\..\TelaLogin.xaml"
                    ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.linkRedefinir_Click);

#line default
#line hidden
                    return;
                case 5:

#line 162 "..\..\TelaLogin.xaml"
                    ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.linkCadastrar_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.campoEmail = ((System.Windows.Controls.TextBox)(target));

#line 166 "..\..\TelaLogin.xaml"
                    this.campoEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.campoEmail_TextChanged_1);

#line default
#line hidden
                    return;
                case 7:
                    this.campoSenha = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window ___Sem_Nome_;
    }
}

