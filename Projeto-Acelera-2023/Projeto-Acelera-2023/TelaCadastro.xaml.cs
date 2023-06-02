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
using System.Text.RegularExpressions;

namespace Projeto_Acelera_2023
{
    public partial class TelaCadastro : Window
    {
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        public TelaCadastro(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            //campoCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            campoNome.VerticalContentAlignment = VerticalAlignment.Center;
            campoEmail.VerticalContentAlignment = VerticalAlignment.Center;
            campoSenha.VerticalContentAlignment = VerticalAlignment.Center;
            campoConfirmarSenha.VerticalContentAlignment = VerticalAlignment.Center;
            campoCargo.VerticalContentAlignment = VerticalAlignment.Center;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        public void Cadastro()
        {
            if (!Regex.IsMatch(campoEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido. Por favor, verifique o endereço de e-mail digitado.");
                return;
            }
            else
            {
                if (!campoSenha.Text.Equals(campoConfirmarSenha.Text))
                {
                    MessageBox.Show("Senhas não são iguais.");
                    return;
                }
                else
                {
                    var usuario = new Usuario
                    {
                        Nome = campoNome.Text,
                        Email = campoEmail.Text,
                        Senha = campoSenha.Text,
                        ConfirmaSenha = campoConfirmarSenha.Text,
                        Cargo = campoCargo.Text,
                        Semestre = "none",
                        Telefone = "none",
                        Curso = "none",
                        Endereco = "none"
                    };

                    SalvarDados.ListaUsuarios.Add(usuario);
                    MessageBox.Show("Usuário salvo com sucesso!");
                    var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
                    Login.Show();
                    this.Hide();
                }
            }
        }

        private void linkLogin_Click(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }

        private void CampoNome_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void campoCargo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastro();
        }
        
        private void campoNome_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
