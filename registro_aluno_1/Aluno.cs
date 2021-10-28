/*

Programação Orientada a Objetos - Registro Aluno I (Classe Aluno)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno_Materia{

    class Aluno{
    
        //Atributos
        private String nome;
        private String numero_matricula;
        private int periodo;
        private Materia[] lista_materias;
        private int i;

        //Métodos
        public Aluno(){
        
            nome = " ";
            numero_matricula = " ";
            periodo = 0;
            lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String _nome, String _numero_matricula,  int  _periodo){
        
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[8];
            i = 0;
        }

        public String getNome(){
        
            return nome;
        }

        public void setNome(String  _nome){
        
            nome = _nome; 
        }

        public void associaMateria(Materia m){
        
            if(i <= 7){
            
                lista_materias[i] = m;
                i++;
            }
            
            else
            
                Console.WriteLine("O Número máximo de matérias permitias foi alcançado");
        }
    }
}
