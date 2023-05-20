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
    public partial class TelaVagasEmpresa : Window
    {
        public SalvarVagas SalvarVagas;
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        public TelaVagasEmpresa(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarVagas = new SalvarVagas();
            SalvarVagas.ListaVagas = listaVagas;

            AdicionarDadosTabela();
        }
        private void AdicionarDadosTabela()
        {
            tabelaEmpresa.ItemsSource = SalvarVagas.ListaVagas;
        }

            private void botaoPerfil_Click(object sender, RoutedEventArgs e)
        {
            var Perfil = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }
        private void botaoVagas_Click_1(object sender, RoutedEventArgs e)
        {
            var Vagas = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Vagas.Show();
            this.Hide();
        }

        private void botaoCriarVaga_Click_1(object sender, RoutedEventArgs e)
        {
            var CriarVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            CriarVagas.Show();
            this.Hide();
        }

        private void botaoSair_Click(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void tabelaEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void botaoAtualizar_Click(object sender, RoutedEventArgs e)
        {
            tabelaEmpresa.Items.Refresh();
        }
    }
}
