/*

Programação Orientada a Objetos - Registro Aluno II (Programa Principal)
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

namespace RegistroAluno{

    public partial class Interface : Form{

        String nome_aluno, matricula, nome_materia, codigo_materia;
        int periodo;
        Aluno aL = new Aluno();
        Materia mL = new Materia();
        Materia [] lista_materias = new Materia[8];
        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaMaterias = new List<Materia>();

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos){
        
            Aluno achei_aluno = null;

            for(int i = 0; i < alunos.Count(); i++){
            
                if(nome_aluno == alunos[i].getNome()){
                
                    achei_aluno = alunos[i];
                    
                    break;
                }
            }
            
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias){
        
            Materia achei_materia = new Materia ();

            for(int i = 0; i < materias.Count(); i++){
                
                if(nome_materia == materias[i].nome){
                
                    achei_materia = materias[i];
                    
                    break;
                }
            }
            
            return achei_materia;
        }

        private void bcadastrar2_Click(object sender, EventArgs e){
        
            nome_materia = tbnome2.Text;
            codigo_materia = tbcodigo1.Text;
            Materia m = new Materia(nome_materia, codigo_materia);
            listaMaterias.Add(m);
            MessageBox.Show("Materia cadastrada com sucesso", "Materia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tbnome2.Text = "";
            tbcodigo1.Text = "";
        }

        private void bassociar_Click(object sender, EventArgs e){
        
            int i;
            aL = achaAluno(tbnomealuno.Text, listaAlunos);
            mL = achaMateria(tbnomemateria.Text, listaMaterias);
            aL.associaMateria(mL);
            MessageBox.Show("Associação realizada com sucesso", "Associar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tbnomealuno.Text = "";
            tbnomemateria.Text = "";
        }

        private void bcadastrar_Click(object sender, EventArgs e){
        
            nome_aluno = tbaluno1.Text;
            matricula = tbmatricula1.Text;
            periodo = int.Parse(tbperiodo1.Text);
            Aluno a = new Aluno(nome_aluno, matricula, periodo);
            listaAlunos.Add(a);
            MessageBox.Show("Aluno cadastrado com sucesso", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tbaluno1.Text = "";
            tbmatricula1.Text = "";
            tbperiodo1.Text = "";
        }

        private void brelatorio_Click(object sender, EventArgs e){
        
            int j;
            String aux1 = "";
            String aux2 = "";

            for(j = 0; j < listaAlunos.Count; j++){
               
                if(listaAlunos[j].nome == tbnome3.Text)
               
                    break;
            }

            for(int k = 0; k < (listaAlunos[j].i); k++){
                
                aux1 = aux2 + listaAlunos[j].lista_materias[k].nome + "\n";
                label1.Text = aux2 + listaAlunos[j].lista_materias[k].nome ;
                aux2 = aux1;
            }

            label9.Text = "Matérias associadas ao aluno";
        }

        public Form1(){
        
            InitializeComponent();
        }
    }
}
