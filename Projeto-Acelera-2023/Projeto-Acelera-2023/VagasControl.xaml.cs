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
            var candidato = new Candidatos
            {
                Nome = usuarioLogado.Nome,
                Semestre = usuarioLogado.Semestre,
                Curso = usuarioLogado.Curso,
                Aprovacao = ""
            };

            listaCandidatos.Add(candidato);
        }

        public void SetVaga(Vaga vaga)
        {
            labelNome.Content = vaga.Nome;
            labelDescricao.Content = vaga.Descricao;
            labelSalario.Content = vaga.Salario;
        }

        private void label1_Click(object sender, RoutedEventArgs e)
        {
            // Implemente o código necessário
        }

        private void botaoConfirmar_Click(object sender, RoutedEventArgs e)
        {
            // Implemente o código necessário
        }

        private void VagasControl_Load(object sender, RoutedEventArgs e)
        {
            // Implemente o código necessário
        }

        private void botaoCandidatar_Click(object sender, RoutedEventArgs e)
        {
            // Implemente o código necessário
        }
    }
}
