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
using System.Net;
using System.Net.Mail;

namespace Projeto_Acelera_2023
{
    public partial class TelaRedefinirSenha : Window
    {
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        private string codigoVerificacao;
        Random rnd = new Random();
        public TelaRedefinirSenha(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            //campoCodigo.Enabled = false;
        }

        public void Email()
        {
            try
            {
                // Configurações do servidor SMTP
                var smtpServer = "smtp.office365.com";
                var smtpPort = 587;
                var smtpUsername = "connect.fatec@hotmail.com";
                var smtpPassword = "connect2023";


                // Cria um objeto de email
                var email = new MailMessage();
                email.From = new MailAddress("connect.fatec@hotmail.com");
                email.To.Add("" + campoEmail.Text);
                email.Subject = "Código de Verificação";
                email.Body = "Olá. Segue o código para realizar a troca da Senha \n" + codigoVerificacao + ".";



                // Configura o cliente SMTP
                var smtp = new SmtpClient(smtpServer, smtpPort);
                smtp.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtp.EnableSsl = true;



                // Envia o email
                smtp.Send(email);
            }
            catch
            {
                MessageBox.Show("Erro ao Enviar E-mail !");
            }
        }

        private void botaoRedefinir_Click(object sender, RoutedEventArgs e)
        {
            if (campoEmail.Text.Equals("") || campoSenha.Text.Equals(""))
            {
                MessageBox.Show("Email ou Senha em branco");
            }
            else
            {
                bool encontrado = false;
                foreach (var usuario in SalvarDados.ListaUsuarios)
                {
                    if (campoEmail.Text.Equals(usuario.Email) && campoCodigo.Text.Equals(codigoVerificacao))
                    {
                        usuario.Senha = campoSenha.Text;
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("Email não cadastrado");
                }
                else
                {
                    MessageBox.Show("Senha redefinida com sucesso.");
                }
            }
        }

        private void botaoEnviarCodigo_Click(object sender, RoutedEventArgs e)
        {



            foreach (var usuario in SalvarDados.ListaUsuarios)
            {
                if (campoEmail.Text.Equals(usuario.Email))
                {
                    codigoVerificacao = rnd.Next(1000, 9999).ToString();
                    //campoCodigo.Enabled = true;
                    Email();
                }
            }
        }

        private void linkCadastrar_Click(object sender, RoutedEventArgs e)
        {
            var TelaCadastro = new TelaCadastro(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastro.Show();
            this.Hide();
        }

        private void linkLogin_Click(object sender, RoutedEventArgs e)
        {
            var TelaLogin = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaLogin.Show();
            this.Hide();
        }



    }
}
