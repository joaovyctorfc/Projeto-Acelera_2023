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
    /// Interação lógica para TelaPerfilEmpresaUC.xam
    /// </summary>
    public partial class TelaPerfilEmpresaUC : UserControl
    {
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        public TelaPerfilEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;

            campoNome.VerticalContentAlignment = VerticalAlignment.Center;
            campoTelefone.VerticalContentAlignment = VerticalAlignment.Center;
            campoEndereco.VerticalContentAlignment = VerticalAlignment.Center;
            campoEmail.VerticalContentAlignment = VerticalAlignment.Center;

            if (SalvarDados.EmpresaLogado != null)
            {
                var usuarioLogado = SalvarDados.EmpresaLogado;
                campoNome.AppendText(usuarioLogado.Nome);
                campoEmail.AppendText(usuarioLogado.Email);
                campoTelefone.AppendText(usuarioLogado.Telefone);
                campoEndereco.AppendText(usuarioLogado.Endereco);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (SalvarDados.EmpresaLogado != null)
            {
                var usuarioLogado = SalvarDados.EmpresaLogado;

                usuarioLogado.Nome = campoNome.Text;
                usuarioLogado.Email = campoEmail.Text;
                usuarioLogado.Telefone = campoTelefone.Text;
                usuarioLogado.Endereco = campoEndereco.Text;

                foreach (var usuario in SalvarDados.ListaUsuarios)
                {
                    if (usuario.Email == usuarioLogado.Email)
                    {
                        // atualiza as propriedades do usuário
                        usuario.Nome = usuarioLogado.Nome;
                        usuario.Email = usuarioLogado.Email;
                        usuario.Telefone = usuarioLogado.Telefone;
                        usuario.Endereco = usuarioLogado.Endereco;

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