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
        private SalvarVagas SalvarVagas = new SalvarVagas();

        public string DadosParaPainel { get; set; }

        public VagasControl(Vaga vaga, List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            this.vaga = vaga;
            var usuarioLogado = SalvarDados.AlunoLogado;
            AtualizarCampos();

            var candidato = new Candidatos
            {
                Nome = usuarioLogado.Nome,
                Semestre = usuarioLogado.Semestre,
                Curso = usuarioLogado.Curso,
                Aprovacao = ""
            };

            listaCandidatos.Add(candidato);
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

        }
    }
}
