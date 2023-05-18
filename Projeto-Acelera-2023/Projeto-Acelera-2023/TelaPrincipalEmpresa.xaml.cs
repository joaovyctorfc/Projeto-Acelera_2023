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
    public partial class TelaPrincipalEmpresa : Window
    {
        public TelaPrincipalEmpresa(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
        }

        private void botaoCriarVaga_Click(object sender, EventArgs e)
        {
            var TelaCadastroVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastroVagas.Show();
            this.Hide();
        }

        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            var TelaPerfilEmpresa = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaPerfilEmpresa.Show();
            this.Hide();
        }

        private void botaoVagas_Click(object sender, EventArgs e)
        {
            var TelaVagasEmpresa = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagasEmpresa.Show();
            this.Hide();
        }
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        private void botaoSair_Click(object sender, EventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void botaoVagasAnalise_Click(object sender, EventArgs e)
        {
 
        }

        private void botaoVagasAnalise_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}