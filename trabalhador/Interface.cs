/*

Programação Orientada a Objetos - Trabalhador (Programa Principal)
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

namespace Trabalhador{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        String nome, CPF, endereco;
        int nhoras;
        double precohora, salario;

        private void bRelatorio_Click(object sender, EventArgs e){
        
            int j;
            String aux1 = "";
            String aux2 = "";

            for(int k = 0; k < listaempregados.Count; k++){
            
                if(listaempregados[k] is EmpregadoCLT){
                
                    EmpregadoCLT f = new EmpregadoCLT();
                    f = (EmpregadoCLT)listaempregados[k];
                    aux1 = aux2 + "Nome: " + f.getNome() + "\n" + "CPF: " + f.getCPF() + "\n" +
                    "Endereço: " + f.getEndereco() + "\n" + "Salário líquido: " + f.Salario() + "\n\n";
                    lRelatorio.Text = aux1;
                    aux2 = aux1;
                }

                if(listaempregados[k] is EmpregadoHorista){
                
                    EmpregadoHorista g = new EmpregadoHorista();
                    g = (EmpregadoHorista)listaempregados[k];
                    aux1 = aux2 + "Nome: " + g.getNome() + "\n" + "CPF: " + g.getCPF() + "\n" +
                    "Endereço: " + g.getEndereco() + "\n" + "Salário líquido: " + g.Salario() + "\n\n";
                    lRelatorio.Text = aux1;
                    aux2 = aux1;
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e){
        
            lRelatorio.Text = "";
        }

        Empregado e = new Empregado();
        List<Empregado> listaempregados = new List<Empregado>();

        private void btCadastro_Click(object sender, EventArgs e){
            
            if(rbHorista.Checked){
            
                nome = tbNome.Text;
                CPF = tbCPF.Text;
                endereco = tbEndereco.Text;
                nhoras = int.Parse(tbHoras.Text);
                precohora = double.Parse(tbPrecoHora.Text);
                EmpregadoHorista ea = new EmpregadoHorista(nome, CPF, endereco, nhoras, precohora);
                listaempregados.Add(ea);
                MessageBox.Show("Empregado horista registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbNome.Text = "";
                tbCPF.Text = "";
                tbEndereco.Text = "";
                tbHoras.Text = "";
                tbPrecoHora.Text = "";
                tbSalario.Text = "";
                rbHorista.Checked = false;
            }

            if(rbCLT.Checked){
            
                nome = tbNome.Text;
                CPF = tbCPF.Text;
                endereco = tbEndereco.Text;
                salario = double.Parse(tbSalario.Text);
                EmpregadoCLT eb = new EmpregadoCLT(nome, CPF, endereco, salario);
                listaempregados.Add(eb);
                MessageBox.Show("Empregado CLT registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbNome.Text = "";
                tbCPF.Text = "";
                tbEndereco.Text = "";
                tbSalario.Text = "";
                tbHoras.Text = "";
                tbPrecoHora.Text = "";
                rbCLT.Checked = false;
            }
        }
    }
}
