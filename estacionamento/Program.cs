/*

Programação Orientada a Objetos - Estacionamento (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento{

    class Program{
    
        static void Main(string[] args){

            List<Carro> lista_carros = new List<Carro>();
            Tempo aentrada = new Tempo();
            Tempo asaida = new Tempo();
            String amarca, aplaca;

            for(int i = 0; i < 5; i++){
            
                Console.WriteLine("Insira os dados do veiculo {0}", i + 1);
                Console.WriteLine("\n\nHorario de entrada:\n");
                aentrada.EntradaTempo();
                
                Console.WriteLine("\n\nHorario de saida:\n");
                asaida.EntradaTempo();
                
                Console.WriteLine("\nInsira a placa:\n");
                aplaca = Console.ReadLine();
                
                Console.WriteLine("\nInsira a marca:\n");
                amarca = Console.ReadLine();
                
                Carro c = new Carro(aplaca, amarca, aentrada, asaida);
                lista_carros.Add(c);
                
                Console.Clear();
            }

            Console.WriteLine("Relatorio completo:");

            for(int i = 0; i < 5; i++){
            
                Console.WriteLine("\n\nDados do carro {0}: ", i + 1);
                lista_carros[i].ImprimeCarro();
                lista_carros[i].Conta();
            }

            Console.ReadLine();
        }
    }
}
