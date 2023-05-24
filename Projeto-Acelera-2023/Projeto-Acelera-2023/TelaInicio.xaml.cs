using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projeto_Acelera_2023
{
    public partial class TelaInicio : Window
    {
        public TelaInicio()
        {
            InitializeComponent();
        }
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        private void botaoLogin_Click(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void botaoCadastrar_Click(object sender, RoutedEventArgs e)
        {
            var TelaCadastro = new TelaCadastro(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastro.Show();
            this.Hide();
        }


        //_________________Front___________________//
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

            var TelaCadastro = new TelaCadastro(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastro.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

    }
}
