/*

Programação Orientada a Objetos - Tratamento de Exceção (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecao{

    class Program{
    
        public static int quociente(int numerador, int denominador){
        
            return numerador / denominador;
        }
        
        static void Main(string[] args){
        
            bool cloop = true;

            //Tratamento de exceções
            do{ 

                //Tente rodar o código abaixo
                try{ 
                
                    int numerador, denominador;

                    Console.WriteLine("Insira o numerador: ");
                    numerador = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nInsira o denominador: ");
                    denominador = int.Parse(Console.ReadLine());

                    double resultado = quociente(numerador, denominador);

                    Console.WriteLine("\nResultado: {0}", resultado);
                    Console.ReadLine();

                    cloop = false;
                }

                //Caso não funcione, pegue o tratamento das exceções abaixo
                catch(FormatException){
                
                    Console.WriteLine("\nInsira um número inteiro\n\n");
                }

                catch(DivideByZeroException){
                
                    Console.WriteLine("\nInsira um denominador diferente de zero\n\n");
                }

            }while(cloop);
        }
    }
}
