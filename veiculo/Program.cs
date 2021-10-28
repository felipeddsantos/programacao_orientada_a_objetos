/*

Programação Orientada a Objetos - Veículo (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo{

    class Program{
    
        static void Main(string[] args){

            Veiculo[] array_veiculos = new Veiculo[2];

            Automovel v1 = new Automovel("SPIN", 4);

            array_veiculos[0] = v1;

            Aeronave v2 = new Aeronave("AIRBUS", 2);

            array_veiculos[1] = v2;

            for(int i = 0; i < array_veiculos.Length; i++){
            
                array_veiculos[i].mover();
                array_veiculos[i].parar();
            }

            Console.ReadLine();
        }
    }
}
