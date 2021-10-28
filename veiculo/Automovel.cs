/*

Programação Orientada a Objetos - Veículo (Classe Automóvel)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo{

    class Automovel : Veiculo{
        
        //Atributo
        private int qte_rodas; 

        //Métodos
        public Automovel(String _tipo, int _qte_rodas) : base(_tipo){
        
            qte_rodas = _qte_rodas;
        }

        public override void mover(){
        
            Console.WriteLine("Acelerando o automóvel");
        }

        public override void parar(){
        
            Console.WriteLine("Brecando o automóvel");
        }
    }
}
