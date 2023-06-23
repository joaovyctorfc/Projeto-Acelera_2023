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
    /// <summary>
    /// Interação lógica para TelaCandidatosCoordenadorUC.xam
    /// </summary>
    public partial class TelaCandidatosCoordenadorUC : UserControl
    {
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaCandidatosCoordenadorUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            adicionarDadosTabela();
        }

        private void adicionarDadosTabela()
        {
            foreach (var candidato in SalvarCandidatos.ListaCandidatos)
            {
                var vaga = SalvarVagas.ListaVagas.FirstOrDefault(v => v.id == candidato.IdVaga);

                if (vaga != null)
                {
                    tabelaCoordenador.Items.Add(new
                    {
                        Nome = candidato.Nome,
                        Curso = candidato.Curso,
                        Empresa = vaga.Empresa,
                        Vaga = vaga.Nome,
                        Salario = vaga.Salario,
                        Descricao = vaga.Descricao,
                        Formato = vaga.Formato,
                        Aprovacao = candidato.Aprovacao
                    });
                }
            }
        }

        private void tabelaEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tabelaCoordenador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tabelaCoordenador_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
