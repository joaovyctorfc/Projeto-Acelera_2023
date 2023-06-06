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
        private void AdicionarDadosTabela()
        {
            tabelaEmpresa.ItemsSource = SalvarVagas.ListaVagas;
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

