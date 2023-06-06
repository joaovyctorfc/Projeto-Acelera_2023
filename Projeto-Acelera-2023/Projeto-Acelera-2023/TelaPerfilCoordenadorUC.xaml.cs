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

    public partial class TelaPerfilCoordenadorUC : UserControl
    {
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaPerfilCoordenadorUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;

            campoNome.VerticalContentAlignment = VerticalAlignment.Center;
            campoEmail.VerticalContentAlignment = VerticalAlignment.Center;
            campoTelefone.VerticalContentAlignment = VerticalAlignment.Center;

            if (SalvarDados.CoordenadorLogado != null)
            {
                var usuarioLogado = SalvarDados.CoordenadorLogado;
                campoNome.AppendText(usuarioLogado.Nome);
                campoEmail.AppendText(usuarioLogado.Email);
                campoTelefone.AppendText(usuarioLogado.Telefone);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoTelefone_TextChanged(object sender, EventArgs e)
        {
            var formattedText = FormatarTelefone(campoTelefone.Text);
            campoTelefone.Text = formattedText;
            campoTelefone.SelectionStart = formattedText.Length;
        }

        private string FormatarTelefone(string text)
        {
            // Remove qualquer caractere não numérico do texto
            var digitsOnly = new string(text.Where(char.IsDigit).ToArray());

            // Formata o telefone com parênteses e hífens
            if (digitsOnly.Length >= 11)
            {
                return string.Format("({0}) {1}-{2}",
                    digitsOnly.Substring(0, 2),
                    digitsOnly.Substring(2, 4),
                    digitsOnly.Substring(7, Math.Min(digitsOnly.Length - 7, 4)));
            }

            return text; // Retorna o texto original se não for possível formatar
        }

        private void CampoTelefone_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Campo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (SalvarDados.CoordenadorLogado != null)
            {
                var usuarioLogado = SalvarDados.CoordenadorLogado;

                usuarioLogado.Nome = campoNome.Text;
                usuarioLogado.Email = campoEmail.Text;
                usuarioLogado.Telefone = campoTelefone.Text;

                foreach (var usuario in SalvarDados.ListaUsuarios)
                {
                    if (usuario.Email == usuarioLogado.Email)
                    {
                        // atualiza as propriedades do usuário
                        usuario.Nome = usuarioLogado.Nome;
                        usuario.Email = usuarioLogado.Email;
                        usuario.Telefone = usuarioLogado.Telefone;

                        // exibe uma mensagem confirmando a atualização
                        MessageBox.Show("Dados atualizados com sucesso!");
                        break;
                    }
                }
            }
        }

        private void campoNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

