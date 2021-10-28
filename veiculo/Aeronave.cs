/*

Programação Orientada a Objetos - Veículo (Classe Aeronave)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo{

    class Aeronave : Veiculo{
    
        //Atributo
        private int qte_turbinas;

        //Métodos
        public Aeronave(String _tipo, int _qte_turbinas) : base(_tipo){
        
            qte_turbinas = _qte_turbinas;
        }

        public override void mover(){
        
            Console.WriteLine("Acelerando a aeronave");
        }

        public override void parar(){
        
            Console.WriteLine("Brecando a aeronave");
        }
    }
}
