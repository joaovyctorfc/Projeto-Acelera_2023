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
using System.Windows.Threading;

namespace Projeto_Acelera_2023
{
    public partial class TelaPrincipalEmpresa : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;
        public TelaPrincipalEmpresa(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;
            if (SalvarDados.EmpresaLogado != null)
            {
                var usuarioLogado = SalvarDados.EmpresaLogado;
                if (usuarioLogado.Telefone.Equals("") && usuarioLogado.Curso.Equals("none") && usuarioLogado.Semestre.Equals("none"))
                {
                    MessageBox.Show("Finalize o Cadastro na aba Perfil antes de continuar");
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 40)
                {
                    timer.Stop();
                    hidden = true;
                }

            }
        }

        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        private void Panel_Header(object sender, MouseButtonEventArgs e)
        {

        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            painelTelas.Children.Clear();
            TelaPerfilEmpresaUC Perfil = new TelaPerfilEmpresaUC(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
            painelTelas.Children.Add(Perfil);
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            var usuarioLogado = SalvarDados.EmpresaLogado;

            if (usuarioLogado.Telefone.Equals(""))
            {
                MessageBox.Show("Finalize o Cadastro na aba Perfil antes de continuar");
            }
            else
            {
                painelTelas.Children.Clear();
                TelaVagasEmpresaUC Vagas = new TelaVagasEmpresaUC(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                painelTelas.Children.Add(Vagas);
            }
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            var usuarioLogado = SalvarDados.EmpresaLogado;
            if (usuarioLogado.Telefone.Equals(""))
            {
                MessageBox.Show("Finalize o Cadastro na aba Perfil antes de continuar");
            }
            else
            {
                painelTelas.Children.Clear();
                TelaCadastroVagasUC CadastroVagas = new TelaCadastroVagasUC(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                painelTelas.Children.Add(CadastroVagas);
            }
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
            this.Hide();
            SalvarDados.EmpresaLogado = null;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            var usuarioLogado = SalvarDados.EmpresaLogado;
            if (usuarioLogado.Telefone.Equals(""))
            {
                MessageBox.Show("Finalize o Cadastro na aba Perfil antes de continuar");
            }
            else
            {
                painelTelas.Children.Clear();
                TelaCandidatosEmpresaUC Candidatos = new TelaCandidatosEmpresaUC(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                painelTelas.Children.Add(Candidatos);
            }
        }

        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            
        }
    }
}