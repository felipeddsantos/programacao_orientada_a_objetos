/*

Programação Orientada a Objetos - Registro Aluno I (Classe Bomba Atômica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAluno{

    class BombaAtomica{
    
        //Atributos
        private String senha;

        //Atributos
        public BombaAtomica(){
        
            senha = "KABUM";
        }

        public String getSenha(){
        
            return senha; 
        }
    }
}
