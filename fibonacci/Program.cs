/*

Programação Orientada a Objetos - Fibonacci (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci{

    class Program{
    
        static void Main(string[] args){

            int[] fib = new int[20];
            int n;
            fib[0] = 0;
            fib[1] = 1;

            Console.WriteLine("Insira o índice de Fibonacci:");

            n = int.Parse(Console.ReadLine());
            
            if (n < 0){
            
                Console.WriteLine("Índice inválido.");
                Console.ReadKey();
            }

            for (int i = 2; i <= n; i++)
            
                fib[i]= fib[i - 1] + fib[i - 2];
                
            Console.WriteLine("Número de Fibonacci: " + fib[n]);

            Console.ReadKey();
        }
    }
}
