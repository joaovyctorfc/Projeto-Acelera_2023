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
        public SalvarMensagem SalvarMensagem = new SalvarMensagem(); // Adicionado
        
        
        public TelaVagasEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            SalvarVagas = new SalvarVagas();
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarMensagem.ListaMensagem = mensagem; // Adicionado
            AdicionarDadosTabela();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Button btnExcluir = (Button)sender;
            var dataGridRow = FindParent<DataGridRow>(btnExcluir);

            if (dataGridRow != null)
            {
                Vaga vaga = (Vaga)dataGridRow.Item;

                // Remover a vaga da lista de vagas
                SalvarVagas.ListaVagas.Remove(vaga);

                // Remover a vaga da tabela
                tabelaEmpresa.Items.Remove(vaga);
            }
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
                if (vaga.Empresa == SalvarDados.EmpresaLogado.Nome)
                {
                    tabelaEmpresa.Items.Add(vaga);
                }
            }
        }

        private void tabelaEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void botaoAtualizar_Click(object sender, RoutedEventArgs e)
        {
            tabelaEmpresa.Items.Refresh();
        }

        private void btnChat_Click(object sender, RoutedEventArgs e)
        {
            Button btnChat = (Button)sender;
            var dataGridRow = FindParent<DataGridRow>(btnChat);

            if (dataGridRow != null)
            {
                Candidatos candidato = (Candidatos)dataGridRow.Item;
                string nomeCandidato = candidato.Nome;

                // Encontrar o ID do usuário com base no nome do candidato
                string idUsuario = SalvarDados.ListaUsuarios
                    .Where(usuario => usuario.Nome == nomeCandidato)
                    .Select(usuario => usuario.Id)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(idUsuario))
                {
                    // Agora você tem o ID do usuário correspondente ao nome do candidato selecionado
                    // Faça o que desejar com o ID, como salvá-lo em uma variável ou passá-lo para outra tela

                    // Exemplo de como passar o ID para outra tela
                    mainGrid.Children.Clear();
                    TelaCadastroMensagemEmpresaUC CadastroMensagem = new TelaCadastroMensagemEmpresaUC(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem, idUsuario);
                    mainGrid.Children.Add(CadastroMensagem);
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
            }
        }

        private void tabelaEmpresa_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
