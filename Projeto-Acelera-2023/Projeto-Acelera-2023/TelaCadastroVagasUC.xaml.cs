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

    public partial class TelaCadastroVagasUC : UserControl
    {
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaCadastroVagasUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> mensagem)
        {
            InitializeComponent();

            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;

            campoNome.VerticalContentAlignment = VerticalAlignment.Center;
            campoArea.VerticalContentAlignment = VerticalAlignment.Center;
            campoDescricao.VerticalContentAlignment = VerticalAlignment.Center;
            campoFormato.VerticalContentAlignment = VerticalAlignment.Center;
            campoSalario.VerticalContentAlignment = VerticalAlignment.Center;

        }
        public SalvarVagas SalvarVagas = new SalvarVagas();

        public string GerarRandomId(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return id;
        }

        public void CadastrarVaga()
        {
            string randomId = GerarRandomId(8);

            var vaga = new Vaga
            {
                Nome = campoNome.Text,
                Descricao = campoDescricao.Text,
                Salario = campoSalario.Text,
                Area = campoArea.Text,
                Formato = campoFormato.Text,
                Aprovacao = "Em análise",
                id = randomId,
                Empresa = SalvarDados.EmpresaLogado.Nome
            };

            var candidatosAssociados = SalvarCandidatos.ListaCandidatos.Where(c => c.IdVaga == vaga.id).ToList();

            foreach (var candidato in candidatosAssociados)
            {
                SalvarCandidatos.ListaCandidatos.Remove(candidato);
            }

            SalvarVagas.ListaVagas.Add(vaga);
            MessageBox.Show("Vaga cadastrada com sucesso!");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void campoSalario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVaga();
        }

        private void campoNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
