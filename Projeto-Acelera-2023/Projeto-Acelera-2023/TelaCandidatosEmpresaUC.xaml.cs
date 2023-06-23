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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_Acelera_2023
{
    /// <summary>
    /// Interação lógica para TelaCandidatosEmpresaUC.xam
    /// </summary>
    public partial class TelaCandidatosEmpresaUC : UserControl
    {
        public TelaCandidatosEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> listamensagem)
        {
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            InitializeComponent();
            AdicionarDadosTabela();
        }
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();


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
            foreach (var candidato in SalvarCandidatos.ListaCandidatos)
            {
                tabelaEmpresa.Items.Add(candidato);
            }
        }

        private void Aprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Candidatos candidatos)
            {
                candidatos.Aprovacao = "Aprovado";
                tabelaEmpresa.Items.Refresh();
            }
        }

        private void Reprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Candidatos candidatos)
            {
                candidatos.Aprovacao = "Reprovado";
                tabelaEmpresa.Items.Refresh();
            }
        }

        private void tabelaEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

