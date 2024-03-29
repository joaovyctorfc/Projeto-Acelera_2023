﻿using System;
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
    public partial class TelaLogin : Window
    {

        public TelaLogin(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem>listaMensagem)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            SalvarMensagem.ListaMensagem = listaMensagem;
            campoEmail.VerticalContentAlignment = VerticalAlignment.Center;
            campoSenha.VerticalContentAlignment = VerticalAlignment.Center;
        }

        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCadastrar_Click(object sender, RoutedEventArgs e)
        {
            var Cadastro = new TelaCadastro(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
            Cadastro.Show();
            this.Hide();
        }

        private void linkRedefinir_Click(object sender, RoutedEventArgs e)
        {
            var Redefinir = new TelaRedefinirSenha(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
            Redefinir.Show();
            this.Hide();
        }

        private void botaoLogin_Click(object sender, RoutedEventArgs e)
        {
            if (campoEmail.Text.Equals("") || campoSenha.Password.Equals(""))
            {
                MessageBox.Show("Login ou senha em branco");
            }
            else
            {
                if (campoEmail.Text.Equals("admin") && campoSenha.Password.Equals("123"))
                {
                    var TelaCadastroADM = new TelaCadastroADM(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                    TelaCadastroADM.Show();
                    this.Hide();
                }
                else
                { bool encontrado = false;
                    foreach (var usuario in SalvarDados.ListaUsuarios)
                    {
                        if (campoEmail.Text.Equals(usuario.Email) && campoSenha.Password.Equals(usuario.Senha))
                        {
                            MessageBox.Show("Login com Sucesso !!!" + usuario.Cargo);
                            encontrado = true;

                            var cargo = usuario.Cargo;
                            if (cargo == "Aluno")
                            {
                                var TelaPrincipal = new TelaPrincipalAluno(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                                SalvarDados.AlunoLogado = usuario;
                                TelaPrincipal.Show();
                            }

                            if (cargo == "Empresa")
                            {
                                var TelaPrincipal = new TelaPrincipalEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                                SalvarDados.EmpresaLogado = usuario;
                                TelaPrincipal.Show();
                            }

                            if (cargo == "Coordenador")
                            {
                                var TelaPrincipal = new TelaPrincipalCoordenador(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                                SalvarDados.CoordenadorLogado = usuario;
                                TelaPrincipal.Show();
                            }

                        }
                    }
                    if (!encontrado)
                    {
                        MessageBox.Show("Login ou senha errado");
                    }
                }

            }
        }

        private void campoEmail_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
