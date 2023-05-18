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
using System.Windows.Shapes;

namespace Projeto_Acelera_2023
{
    public partial class TelaCadastroVagas : Window
    {

        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public TelaCadastroVagas(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
          //  campoArea.DropDownStyle = ComboBoxStyle.DropDownList;
           // campoFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
        }
        public SalvarVagas SalvarVagas = new SalvarVagas();

        private void botaoCadastrarVaga_Click(object sender, EventArgs e)
        {
            CadastrarVaga();
        }

        public void CadastrarVaga()
        {

            var vaga = new Vaga
            {
                Nome = campoNome.Text,
                Descricao = campoDescricao.Text,
                Salario = campoSalario.Text,
                Area = campoArea.Text,
                Formato = campoFormato.Text,
                Aprovacao = "Em análise",

            };

            SalvarVagas.ListaVagas.Add(vaga);
            MessageBox.Show("Vaga cadastrada com sucesso!");

        }
        private void botaoTelaVagas_Click(object sender, EventArgs e)
        {

            var TelaVagas = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagas.Show();
            this.Hide();
        }
        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            var perfil = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            perfil.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void campoArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoSalario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

