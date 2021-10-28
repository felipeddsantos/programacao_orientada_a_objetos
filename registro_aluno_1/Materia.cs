/*

Programação Orientada a Objetos - Registro Aluno I (Classe Matéria)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAluno{

    class Materia{
    
        //Atributos
        private String nome;
        private String codigo;

        //Métodos
        public Materia(){
        
            nome = " ";
            codigo = " ";
        }

        public Materia(String _nome, String  _codigo){
        
            nome = _nome;
            codigo = _codigo;
        }

        public string Nome{get => nome; set => nome = value;}
        public string Codigo{get => codigo; set => codigo = value;}
    }
}
