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
    /// Interação lógica para TelaMensagensAlunoUC.xam
    /// </summary>
    public partial class TelaMensagensAlunoUC : UserControl
    {
        public TelaMensagensAlunoUC(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos, List<Mensagem> listaMensagem)
        {
            InitializeComponent();
            SalvarMensagem.ListaMensagem = listaMensagem;
            SalvarVagas.ListaVagas = listaVagas;
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarCandidatos.ListaCandidatos = listaCandidatos;
            var usuarioLogado = SalvarDados.AlunoLogado;
            string id = usuarioLogado.Id;
            if (listaMensagem != null)
            {
                foreach (var mensagem in listaMensagem)
                {
                    if (mensagem.Visibilidade.Equals(id) && mensagem.Visibilidade != "0")
                    {
                        var mensagemControl = new MensagemControl(mensagem, SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos, SalvarMensagem.ListaMensagem);
                        tabelaMensagem.Children.Add(mensagemControl);
                    }
                }
            }
        }

        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();
        public SalvarMensagem SalvarMensagem = new SalvarMensagem();

    }
    }

