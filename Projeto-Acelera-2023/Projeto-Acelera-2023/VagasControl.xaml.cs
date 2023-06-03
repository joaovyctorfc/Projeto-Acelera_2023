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
    public partial class VagasControl : UserControl
    {
        private Vaga vaga;
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public SalvarDados SalvarDados = new SalvarDados();

        public string DadosParaPainel { get; set; }

        public VagasControl(Vaga vaga, List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            SalvarDados.ListaUsuarios = listaUsuarios;
            InitializeComponent();
            this.vaga = vaga;

            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            labelNome.Content = vaga.Nome;
            labelDescricao.Content = vaga.Descricao;
            labelSalario.Content = vaga.Salario;
            labelArea.Content = vaga.Area;
            labelFormato.Content = vaga.Formato;
        }
        private void botaoCandidatar_Click(object sender, RoutedEventArgs e)
        {
            if (SalvarDados.AlunoLogado != null)
            {
                var usuarioLogado = SalvarDados.AlunoLogado;

                var nome = usuarioLogado.Nome;
                var curso = usuarioLogado.Curso;
                var semestre = usuarioLogado.Semestre;
                var email = usuarioLogado.Email;
                var numero = usuarioLogado.Telefone;


                var candidato = new Candidatos
                {
                    Nome = nome,
                    Email = email,
                    Semestre = semestre,
                    Curso = curso,
                    Aprovacao = "Incerto",
                    IdVaga = vaga.id,
                    Empresa = SalvarDados.EmpresaLogado.Nome,
                    numero = numero,
                    descricao = vaga.Descricao,
                    formato = vaga.Formato
                };
                SalvarCandidatos.ListaCandidatos.Add(candidato);
                MessageBox.Show("Cadidatado com sucesso");
            }
        }
    }
}
