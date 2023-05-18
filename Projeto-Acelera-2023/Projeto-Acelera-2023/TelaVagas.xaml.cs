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
    public partial class TelaVagas : Window
    {
        private List<Vaga> listaVagas;

        public TelaVagas(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;

            this.listaVagas = listaVagas;

            foreach (var vaga in listaVagas)
            {
                if (vaga.Aprovacao.Equals("Aprovado"))
                {
                    var vagaControl = new VagasControl(vaga, SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
                    vagaControl.SetVaga(vaga);
                  //  campoVagas.Controls.Add(vagaControl);
                }
            }
        }
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        private void BotaoInicio_Click(object sender, EventArgs e)
        {

        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            var Perfil = new TelaPerfilAluno(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }

        private void botaoVagas_Click(object sender, EventArgs e)
        {
            var Vagas = new TelaVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Vagas.Show();
            this.Hide();
        }
    }
}

