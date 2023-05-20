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
    public partial class TelaPerfilEmpresa : Window
    {
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaPerfilEmpresa(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
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

        private void botaoSair_Click(object sender, EventArgs e)
        {
            var telaLogin = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            telaLogin.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void botaoVagas_Click(object sender, EventArgs e)
        {
            var TelaVagasEmpresa = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagasEmpresa.Show();
            this.Hide();
        }

        private void botaoCriarVaga_Click(object sender, EventArgs e)
        {
            var TelaCadastroVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastroVagas.Show();
            this.Hide();
        }

        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            var Perfil = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }

        private void botaoVagasAnalise_Click(object sender, EventArgs e)
        {

        }

        private void campoEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void botaoVagas_Click_1(object sender, RoutedEventArgs e)
        {
            var TelaVagas = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagas.Show();
            this.Hide();
        }

        private void botaoPerfil_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botaoCriarVaga_Click_1(object sender, RoutedEventArgs e)
        {
            var TelaCadastroVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastroVagas.Show();
            this.Hide();
        }

        private void botaoVagasAnalise_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

