/*

Programação Orientada a Objetos - Retângulo (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo{

    class Program{
    
        static void Main(string[] args){
        
            Console.WriteLine("Classe Retangulo");

            //Objeto da classe Retangulo chamado r1
            //Memoria RAM aloca um espaço chamado Retangulo::r1, com o tamanho de dois inteiros
            Retangulo r1 = new Retangulo();
            Retangulo r2 = new Retangulo(6,8);

            Console.WriteLine("O valor da base do objeto r1 é: " + r1.getBas());
            Console.WriteLine("O valor da altura do objeto r1 é: " + r1.getAlt());

            Console.WriteLine("O valor da base do objeto r2 é: " + r2.getBas());
            Console.WriteLine("O valor da altura do objeto r2 é: " + r2.getAlt());

            Console.ReadLine();

            r1.setBas(5);
            r1.setAlt(8);

            Console.WriteLine("O valor da base do objeto r1 é: " + r1.getBas());
            Console.WriteLine("O valor da altura do objeto r1 é: " + r1.getAlt());

            Console.WriteLine("O valor do perímetro do objeto r1 é: " + r1.perimetro());
            Console.WriteLine("O valor da área do objeto r1 é: " + r1.area());

            Console.WriteLine("O valor do perímetro do objeto r2 é: " + r2.perimetro());
            Console.WriteLine("O valor da área do objeto r2 é: " + r2.area());

            Console.ReadLine();
        }
    }
}
