using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Acelera_2023
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public string Cargo { get; set; }
        public string Semestre { get; set; }
        public string Curso { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
    public class SalvarDados
    {
        public List<Usuario> ListaUsuarios { get; set; }
        public static Usuario AlunoLogado { get; set; }
        public static Usuario CoordenadorLogado { get; set; }
        public static Usuario EmpresaLogado { get; set; }

        public SalvarDados()
        {
            ListaUsuarios = new List<Usuario>();
            var usuarioPreRegistrado = new Usuario
            {
                Nome = "João",
                Email = "vanderjr29@gmail.com",
                Senha = "123",
                ConfirmaSenha = "123",
                Cargo = "Coordenador",
                Semestre = "none",
                Telefone = "none",
                Curso = "none",
                Endereco = "none"
            };
            ListaUsuarios.Add(usuarioPreRegistrado);

            var usuarioPreRegistrado2 = new Usuario
            {
                Nome = "teste",
                Email = "vanderjr29@gmail.com",
                Senha = "123",
                ConfirmaSenha = "1234",
                Telefone = "none",
                Cargo = "Empresa",
                Endereco = "none"
            };
            ListaUsuarios.Add(usuarioPreRegistrado2);

            var usuarioPreRegistrado3 = new Usuario
            {
                Nome = "Pedro",
                Email = "vanderjr29@gmail.com",
                Senha = "123",
                ConfirmaSenha = "123",
                Cargo = "Aluno",
                Semestre = "none",
                Telefone = "none",
                Curso = "none",
                Endereco = "none"
            };
            ListaUsuarios.Add(usuarioPreRegistrado3);
        }
    }

    public class Vaga
    {
        public string Nome { get; set; }
        public string Salario { get; set; }
        public string Descricao { get; set; }
        public string Area { get; set; }
        public string Formato { get; set; }
        public string Aprovacao { get; set; }
        public string id { get; set; }
        public string Empresa { get; set; }
    }
    public class SalvarVagas
    {
        public List<Vaga> ListaVagas { get; set; }
        public List<Candidatos> ListaCandidatos { get; set; }
        public SalvarVagas()
        {
            ListaVagas = new List<Vaga>();
            ListaCandidatos = new List<Candidatos>();
        }
    }

    public class Candidatos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Semestre { get; set; }
        public string Curso { get; set; }
        public string Aprovacao { get; set; }
        public string IdVaga { get; set; }
        public string Empresa { get; set; }
        public string numero { get; set; }
        public string descricao { get; set; }
        public string formato { get; set; }
    }
    public class SalvarCandidatos
    {
        public List<Candidatos> ListaCandidatos { get; set; }

        public SalvarCandidatos()
        {
            ListaCandidatos = new List<Candidatos>();
        }
    }
}
