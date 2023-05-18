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

        private void tabelaEmpresa_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var cell = GetCell(e.OriginalSource as DependencyObject);
            if (cell != null && cell.Column.Header.ToString() == "colunaTabela" && cell.DataContext is Vaga vaga)
            {
                // Lógica para lidar com o evento de clique na célula
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

        // panel2.Visibility = Visibility.Visible;
        //panel2.SetValue(Panel.ZIndexProperty, 1);

        private void AdicionarDadosTabela()
        {
            tabelaEmpresa.AutoGenerateColumns = false;
            tabelaEmpresa.Items.Clear();

            foreach (var vaga in SalvarVagas.ListaVagas)
            {
                DataGridTemplateColumn buttonColumn = new DataGridTemplateColumn();
                buttonColumn.Header = "+";

                FrameworkElementFactory buttonFactory = new FrameworkElementFactory(typeof(Button));
                buttonFactory.SetValue(Button.ContentProperty, "+");

                buttonColumn.CellTemplate = new DataTemplate() { VisualTree = buttonFactory };
                tabelaEmpresa.Columns.Add(buttonColumn);

                tabelaEmpresa.Items.Add(vaga);
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
            var Perfil = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }

        private void botaoVagas_Click(object sender, RoutedEventArgs e)
        {
            var Vagas = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Vagas.Show();
            this.Hide();
        }

        private void botaoCriarVaga_Click(object sender, RoutedEventArgs e)
        {
            var CriarVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            CriarVagas.Show();
            this.Hide();
        }

        private void botaoSair_Click_1(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

   
    }
}
