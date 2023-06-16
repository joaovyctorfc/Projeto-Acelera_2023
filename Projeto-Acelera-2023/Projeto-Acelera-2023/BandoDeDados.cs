using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Acelera_2023
{
    public class Usuario
    {
        public string Id { get; set; }
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
        private static int proximoIdAluno = 1;
        private static int proximoIdCoordenador = 1;
        private static int proximoIdEmpresa = 1;
        public List<Usuario> ListaUsuarios { get; set; }
        public static Usuario AlunoLogado { get; set; }
        public static Usuario CoordenadorLogado { get; set; }
        public static Usuario EmpresaLogado { get; set; }

        public static string GerarNovoId(string tipo)
        {
            int proximoId;
            int ultimoDigito;

            switch (tipo)
            {
                case "Aluno":
                    proximoId = proximoIdAluno;
                    ultimoDigito = 0;
                    proximoIdAluno++;
                    break;
                case "Coordenador":
                    proximoId = proximoIdCoordenador;
                    ultimoDigito = 5;
                    proximoIdCoordenador++;
                    break;
                case "Empresa":
                    proximoId = proximoIdEmpresa;
                    ultimoDigito = 9;
                    proximoIdEmpresa++;
                    break;
                default:
                    throw new ArgumentException("Tipo de usuário inválido");
            }

            string novoId = proximoId.ToString("D2") + ultimoDigito.ToString();
            return novoId;
        }
        public SalvarDados()
        {
            ListaUsuarios = new List<Usuario>();
            var usuarioPreRegistrado = new Usuario
            {
                Id = "01",
                Nome = "João",
                Email = "teste@gmail.com",
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
                Id = "02",
                Nome = "teste",
                Email = "teste@gmail.com",
                Senha = "123",
                ConfirmaSenha = "1234",
                Telefone = "none",
                Cargo = "Empresa",
                Endereco = "none"
            };
            ListaUsuarios.Add(usuarioPreRegistrado2);

            var usuarioPreRegistrado3 = new Usuario
            {
                Id = "03",
                Nome = "Pedro",
                Email = "teste@gmail.com",
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
        public static List<Vaga> ListaVagas { get; set; }
        public List<Candidatos> ListaCandidatos { get; set; }
        public SalvarVagas()
        {
            ListaVagas = new List<Vaga>();
            ListaCandidatos = new List<Candidatos>();
        }
    }

    public class Mensagem
    {
        public string Nome { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public string Visibilidade { get; set; }
    }
    public class SalvarMensagem
    {
        public static List<Mensagem> ListaMensagem { get; set; }
        public SalvarMensagem()
        {
            ListaMensagem = new List<Mensagem>();
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
