/*

Programação Orientada a Objetos - Banco (Classe Poupança)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco{

    class Poupanca : Conta{

        private int tipo;

        public Poupanca(int anumero, double asaldo, String acliente, int atipo) : base(anumero, asaldo, acliente){
        
            tipo = atipo;
        }

        public Poupanca(){
        
            tipo = 0;
        }

        public void setTipo(int atipo){
        
            tipo = atipo;
        }

        public int getTipo(){
        
            return tipo;
        }

        public override void Saca(double s){
        
            saldo = saldo - s - 0.1;
        }
    }
}
