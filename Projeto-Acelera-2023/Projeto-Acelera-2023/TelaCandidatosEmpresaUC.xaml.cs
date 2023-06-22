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
    /// Interação lógica para TelaCandidatosEmpresaUC.xam
    /// </summary>
    public partial class TelaCandidatosEmpresaUC : UserControl
    {
        public TelaCandidatosEmpresaUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> listamensagem)
        {
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            InitializeComponent();
            AdicionarDadosTabela();
        }
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();

        private void AdicionarDadosTabela()
        {

            var candidatos = SalvarCandidatos.ListaCandidatos.Where(c => c.Empresa == SalvarDados.EmpresaLogado.Nome).ToList();
            var vagas = SalvarVagas.ListaVagas.Where(v => v.Empresa == SalvarDados.EmpresaLogado.Nome).ToList();

            int totalItens = Math.Min(candidatos.Count, vagas.Count);

            List<ItemTabela> itensTabela = new List<ItemTabela>();

            for (int i = 0; i < totalItens; i++)
            {
                bool candidatoDisponivel = i < candidatos.Count;
                bool vagaDisponivel = i < vagas.Count;
                
                if (candidatoDisponivel && vagaDisponivel &&
                            !string.IsNullOrEmpty(candidatos[i].Nome) &&
                            !string.IsNullOrEmpty(candidatos[i].Semestre) &&
                            !string.IsNullOrEmpty(candidatos[i].Curso) &&
                            !string.IsNullOrEmpty(candidatos[i].Aprovacao) &&
                            !string.IsNullOrEmpty(vagas[i].Descricao) &&
                            !string.IsNullOrEmpty(vagas[i].Formato) &&
                            !string.IsNullOrEmpty(vagas[i].Salario))

                {
                    string nome = candidatos[i].Nome;
                    string semestre = candidatos[i].Semestre;
                    string curso = candidatos[i].Curso;
                    string aprovacao = candidatos[i].Aprovacao;

                    string descricao = vagas[i].Descricao;
                    string formato = vagas[i].Formato;
                    string salario = vagas[i].Salario;

                    ItemTabela item = new ItemTabela
                    {
                        Nome = nome,
                        Curso = curso,
                        Semestre = semestre,
                        Aprovacao = aprovacao,
                        Descricao = descricao,
                        Formato = formato,
                        Salario = salario,
                    };

                    itensTabela.Add(item);
                }

                tabelaEmpresa.ItemsSource = itensTabela;
            }
        }

        private class ItemTabela
        {
            public string Nome { get; set; }
            public string Semestre { get; set; }
            public string Curso { get; set; }
            public string Aprovacao { get; set; }
            public string Descricao { get; set; }
            public string Formato { get; set; }
            public string Salario { get; set; }

        }

        private void Aprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is ItemTabela item)
            {
                var candidato = SalvarCandidatos.ListaCandidatos.FirstOrDefault(c => c.Nome == item.Nome && c.Semestre == item.Semestre && c.Curso == item.Curso);
                if (candidato != null)
                {
                    candidato.Aprovacao = "Aprovado";

                    var itensTabelaAtualizados = tabelaEmpresa.ItemsSource.Cast<ItemTabela>().ToList();
                    itensTabelaAtualizados.RemoveAll(c => c.Nome == candidato.Nome && c.Semestre == candidato.Semestre && c.Curso == candidato.Curso);

                    tabelaEmpresa.ItemsSource = itensTabelaAtualizados;
                    MessageBox.Show("Candidato aprovado!");
                }
            }
        }


        private void Reprovar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is ItemTabela item)
            {
                var candidato = SalvarCandidatos.ListaCandidatos.FirstOrDefault(c => c.Nome == item.Nome && c.Semestre == item.Semestre && c.Curso == item.Curso);
                if (candidato != null)
                {
                    candidato.Aprovacao = "Reprovado";

                    var itensTabelaAtualizados = tabelaEmpresa.ItemsSource.Cast<ItemTabela>().ToList();
                    itensTabelaAtualizados.RemoveAll(c => c.Nome == candidato.Nome && c.Semestre == candidato.Semestre && c.Curso == candidato.Curso);

                    tabelaEmpresa.ItemsSource = itensTabelaAtualizados;
                    MessageBox.Show("Candidato reprovado!");
                }
            }
        }


        private void tabelaCoordenador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
