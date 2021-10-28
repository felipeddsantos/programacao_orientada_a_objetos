/*

Programação Orientada a Objetos - Banco (Classe Corrente)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco{

    class Corrente : Conta{

        public Corrente(int anumero, double asaldo, String acliente) : base (anumero, asaldo, acliente){}

        public Corrente(){}
        
        public override void Saca(double s){
        
            saldo -= s;
        }
    }
}
