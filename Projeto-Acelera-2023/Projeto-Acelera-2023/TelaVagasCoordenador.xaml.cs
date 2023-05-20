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
    public partial class TelaVagasCoordenador : Window
    {
        public SalvarVagas SalvarVagas;
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        public TelaVagasCoordenador(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarVagas = new SalvarVagas();
            SalvarVagas.ListaVagas = listaVagas;
            AdicionarDadosTabela();
        }

        private void tabelaCoordenador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            var selectedVaga = (Vaga)dataGrid.SelectedItem;

            if (selectedVaga != null)
            {
                selectedVaga.Aprovacao = "Aprovado";
              
            }
        }

        private DataGridCell GetCell(DependencyObject depObj)
        {
            // Encontra a célula do DataGrid a partir do elemento de origem
            while (depObj != null && !(depObj is DataGridCell))
            {
                depObj = VisualTreeHelper.GetParent(depObj);
            }

            return depObj as DataGridCell;
        }

        private FrameworkElement GetCellContent(DataGridColumn column, DataGridRow row)
        {
            if (column.GetCellContent(row) is FrameworkElement cellContent)
            {
                return cellContent;
            }

            return null;
        }

        private void AdicionarDadosTabela()
        {
            foreach (var vaga in SalvarVagas.ListaVagas)
            {
                tabelaCoordenador.Items.Add(vaga);
            }
        }

        private void botaoSair_Click(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void botaoPerfil_Click(object sender, RoutedEventArgs e)
        {
            var Perfil = new TelaPerfilCoordenador(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }

        private void botaoVagas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botaoVagasAnalise_Click(object sender, RoutedEventArgs e)
        {
            var Vagas = new TelaVagasCoordenador(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Vagas.Show();
            this.Hide();
        }

        private void Aprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Vaga vaga)
            {
                vaga.Aprovacao = "Aprovado";
                tabelaCoordenador.Items.Refresh();
            }
        }

        private void Reprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Vaga vaga)
            {
                vaga.Aprovacao = "Reprovado";
                tabelaCoordenador.Items.Refresh();

              
            }
        }


    }
}

