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
    /// Interação lógica para TelaVagasEmpresaUC.xam
    /// </summary>
    public partial class TelaVagasEmpresaUC : UserControl
    {

        public SalvarVagas SalvarVagas;
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaVagasEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            SalvarVagas = new SalvarVagas();
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            SalvarDados.ListaUsuarios = listaUsuarios;
            AdicionarDadosTabela();
        }

        private void btnAdicionarCandidato_Click(object sender, RoutedEventArgs e)
        {
            tabelaEmpresa.Visibility = Visibility.Collapsed;
            Button btnAdicionarCandidato = (Button)sender;
            var dataGridRow = FindParent<DataGridRow>(btnAdicionarCandidato);

            if (dataGridRow != null)
            {
                Vaga vaga = (Vaga)dataGridRow.Item;
                tabelaCandidatos.ItemsSource = null; // Limpa a coleção de itens existente
                tabelaCandidatos.Items.Clear();

                foreach (var candidato in SalvarCandidatos.ListaCandidatos)
                {
                    if (candidato.IdVaga == vaga.id && candidato.Empresa == vaga.Empresa)
                    {
                        tabelaCandidatos.Items.Add(candidato);
                    }
                }

                stackPanelCandidatos.Visibility = Visibility.Visible;
            }
        }


        private static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);

            if (parent == null)
                return null;

            T parentT = parent as T;
            return parentT ?? FindParent<T>(parent);
        }
        private void AdicionarDadosTabela()
        {

            foreach (var vaga in SalvarVagas.ListaVagas)
            {
                tabelaEmpresa.Items.Add(vaga);
            }
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

