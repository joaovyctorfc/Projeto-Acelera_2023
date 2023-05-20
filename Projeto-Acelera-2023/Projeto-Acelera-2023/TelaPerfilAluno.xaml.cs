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
    public partial class TelaPerfilAluno : Window
    {
        public TelaPerfilAluno(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            // campoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            //  campoSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;

            if (SalvarDados.AlunoLogado != null)
            {
                var usuarioLogado = SalvarDados.AlunoLogado;
                campoNome.AppendText(usuarioLogado.Nome);
                campoEmail.AppendText(usuarioLogado.Email);
                campoSemestre.SelectedItem = usuarioLogado.Semestre;
                campoCurso.SelectedItem = usuarioLogado.Curso;
                campoTelefone.AppendText(usuarioLogado.Telefone);

            }
        }
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


        }
        public SalvarDados SalvarDados = new SalvarDados();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botaoVagasAnalise_Click(object sender, EventArgs e)
        {
            var TelaPrincipalAluno = new TelaPrincipalAluno(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaPrincipalAluno.Show();
            this.Hide();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            var telaLogin = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            telaLogin.Show();
            this.Hide();
        }

        private void BotaoVagas_Click(object sender, EventArgs e)
        {
            var TelaVagas = new TelaVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagas.Show();
            this.Hide();
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

        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            var Perfil = new TelaPerfilAluno(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Perfil.Show();
            this.Hide();
        }

        private void campoSemestre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void botaoVagasAnalise_Click_1(object sender, RoutedEventArgs e)
        {
            var TelaPrincipalAluno = new TelaPrincipalAluno(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaPrincipalAluno.Show();
            this.Hide();
        }

        private void botaoSair_Click_1(object sender, RoutedEventArgs e)
        {
            var telaLogin = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            telaLogin.Show();
            this.Hide();
        }

        private void botaoVagas_Click_1(object sender, RoutedEventArgs e)
        {
            var TelaVagas = new TelaVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagas.Show();
            this.Hide();
        }

        private void btnEdit_Click_1(object sender, RoutedEventArgs e)
        {
            if (SalvarDados.AlunoLogado != null)
            {
                var usuarioLogado = SalvarDados.AlunoLogado;

                usuarioLogado.Nome = campoNome.Text;
                usuarioLogado.Curso = campoCurso.Text;
                usuarioLogado.Semestre = campoSemestre.Text;
                usuarioLogado.Telefone = campoTelefone.Text;

                foreach (var usuario in SalvarDados.ListaUsuarios)
                {
                    if (usuario.Email == usuarioLogado.Email)
                    {
                        // atualiza as propriedades do usuário
                        usuario.Nome = usuarioLogado.Nome;
                        usuario.Curso = usuarioLogado.Curso;
                        usuario.Semestre = usuarioLogado.Semestre;
                        usuario.Telefone = usuarioLogado.Telefone;

                        // exibe uma mensagem confirmando a atualização
                        MessageBox.Show("Dados atualizados com sucesso!");
                        break;
                    }
                }
            }
        }
    }
}


