﻿using System;
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
using System.Windows.Threading;

namespace Projeto_Acelera_2023
{
    public partial class TelaPrincipalEmpresa : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;
        public TelaPrincipalEmpresa(List<Usuario> listaUsuarios, List<Vaga> listaVagas, List<Candidatos> listaCandidatos)
        {
            InitializeComponent();
            SalvarDados.ListaUsuarios = listaUsuarios;
            SalvarVagas.ListaVagas = listaVagas;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           if(hidden)
            {
                sidePanel.Width += 1;
                if(sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 40)
                {
                    timer.Stop();
                    hidden = true;
                }

            }
        }

        public SalvarDados SalvarDados = new SalvarDados();
        public SalvarVagas SalvarVagas = new SalvarVagas();
        public SalvarCandidatos SalvarCandidatos = new SalvarCandidatos();






    
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Panel_Header(object sender, MouseButtonEventArgs e)
        {

        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            var TelaPerfilEmpresa = new TelaPerfilEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaPerfilEmpresa.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            var TelaVagasEmpresa = new TelaVagasEmpresa(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaVagasEmpresa.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            var TelaCadastroVagas = new TelaCadastroVagas(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            TelaCadastroVagas.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            var Login = new TelaLogin(SalvarDados.ListaUsuarios, SalvarVagas.ListaVagas, SalvarCandidatos.ListaCandidatos);
            Login.Show();
            this.Hide();
        }
    }
}