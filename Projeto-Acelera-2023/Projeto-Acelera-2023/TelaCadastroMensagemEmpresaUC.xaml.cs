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

    public partial class TelaCadastroMensagemEmpresaUC : UserControl
    {
        public TelaCadastroMensagemEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            campoNome.VerticalContentAlignment = VerticalAlignment.Center;
            campoAssunto.VerticalContentAlignment = VerticalAlignment.Center;
            campoConteudo.VerticalContentAlignment = VerticalAlignment.Center;
        }
        public SalvarMensagem SalvarMensagem = new SalvarMensagem();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastrarMensagem();
        }

        private void campoNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void campoAssunto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void campoConteudo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void CadastrarMensagem()
        {
            var mensagem = new Mensagem
            {
                Nome = campoNome.Text,
                Assunto = campoAssunto.Text,
                Conteudo = campoConteudo.Text,
                Visibilidade = "1",
            };
            try
            {
                SalvarMensagem.ListaMensagem.Add(mensagem);
                MessageBox.Show("Mensagem Enviada com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao Enviar Mensagem!");
            }
        }
    }
}
