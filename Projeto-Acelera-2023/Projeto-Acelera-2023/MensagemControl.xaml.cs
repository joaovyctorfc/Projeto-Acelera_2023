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
    /// Interação lógica para MensagemControl.xam
    /// </summary>
    public partial class MensagemControl : UserControl
    {

        private Mensagem mensagem;
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public SalvarDados SalvarDados = new SalvarDados();
        public MensagemControl(Mensagem mensagem,List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> listaMensagem)
        {
            InitializeComponent();
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarMensagem.ListaMensagem = listaMensagem;
            this.mensagem = mensagem;
   
            AtualizarCampos();
        }

        private void botaoCandidatar_Click(object sender, RoutedEventArgs e)
        {
            mensagem.Visibilidade = "0";
        }
        private void AtualizarCampos()
        {
            labelNome.Content = mensagem.Nome;
            labelAssunto.Content = mensagem.Assunto;
            labelConteudo.Text = mensagem.Conteudo;
        }
    }
}
