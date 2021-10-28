/*

Programação Orientada a Objetos - Veículo (Classe Veículo)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo{

    class Veiculo{
    
        //Atributos
        protected String tipo;

        //Métodos
        public Veiculo(String  _tipo){
        
            tipo = _tipo;
        }

        public String getTipo(){
        
            return tipo;
        }

        public void setTipo(String _tipo){
        
            tipo = _tipo;
        }

        public virtual void mover(){}

        public virtual void parar(){}
    }
}
