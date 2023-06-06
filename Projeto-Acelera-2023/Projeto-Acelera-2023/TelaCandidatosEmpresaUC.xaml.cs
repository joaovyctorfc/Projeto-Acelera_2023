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

            int totalItens = Math.Max(candidatos.Count, vagas.Count);

            List<ItemTabela> itensTabela = new List<ItemTabela>();

            for (int i = 0; i < totalItens; i++)
            {
                string nome = i < candidatos.Count ? candidatos[i].Nome : string.Empty;
                string semestre = i < candidatos.Count ? candidatos[i].Semestre : string.Empty;
                string curso = i < candidatos.Count ? candidatos[i].Curso : string.Empty;
                string aprovacao = i < candidatos.Count ? candidatos[i].Aprovacao : string.Empty;

                string descricao = i < candidatos.Count ? vagas[i].Descricao : string.Empty;
                string formato = i < candidatos.Count ? vagas[i].Formato : string.Empty;
                string salario = i < candidatos.Count ? vagas[i].Salario : string.Empty;

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
                    tabelaEmpresa.Items.Refresh();
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
                    tabelaEmpresa.Items.Refresh();
                }
            }
        }

        private void tabelaCoordenador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
