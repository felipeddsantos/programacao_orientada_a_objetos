/*

Programação Orientada a Objetos - Registro Aluno II (Classe Aluno)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAluno{

    class Aluno{
    
        public String nome;
        private String numero_matricula;
        private int periodo;
        public Materia[] lista_materias; 
        public int i;    

        public Aluno(){
        
            nome = " ";
            numero_matricula = " ";
            periodo = 0;
            Materia [] lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String _nome, String _numero_matricula, int _periodo){
        
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[8];
            i = 0;
        }

        public String getNome(){
        
            return nome;
        }

        public void setNome(String _nome){
        
            nome = _nome;
        }

        public void associaMateria(Materia m){
        
            lista_materias[i] = m;
            i++; 
        }
    }
}
