/*

Programação Orientada a Objetos - Loja de Games (Classe Página Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojaDeGames{

    public partial class PaginaPrincipal : Form{
    
        public PaginaPrincipal(){

            InitializeComponent(); 
        }

        private void FecharFormulariosFilhos(){

            for(int i = Application.OpenForms.Count - 1; i >= 0; i--){

                if(Application.OpenForms[i].IsMdiChild){

                    Application.OpenForms[i].Hide();
                }
            }
        }

        private void ShowForm(Form fmr){

            FecharFormulariosFilhos();
            fmr.MdiParent = this;
            fmr.WindowState = FormWindowState.Maximized;
            fmr.Show();
            fmr.Activate();
        }

        private void tclientes1_Click_1(object sender, EventArgs e){

            ShowForm(CadastroClientes.Instance);
        }

        private void tfuncionarios1_Click(object sender, EventArgs e){

            ShowForm(CadastroFuncionários.Instance);
        }

        private void tlivros1_Click_1(object sender, EventArgs e){

            ShowForm(CadastroJogos.Instance);
        }
        
        private void tnovidades_Click(object sender, EventArgs e){

            ShowForm(Novidades.Instance);
        }

        private void tcompras_Click(object sender, EventArgs e){

            ShowForm(Compras.Instance);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e){

            ShowForm(RelatórioClientes.Instance);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e){

            ShowForm(RelatórioFuncionários.Instance);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e){

            ShowForm(RelatórioJogos.Instance);
        }
    }
}
