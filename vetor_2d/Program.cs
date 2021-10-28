/*

Programação Orientada a Objetos - Vetor 2D (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor{

    class Program{
    
        static void Main(string[] args){
            
            Vetor2D vet1 = new Vetor2D(3, 4);
            Vetor2D vet2 = new Vetor2D(5, 1);
            Vetor2D vet3 = new Vetor2D();

            Console.WriteLine("O valor de x do objeto vet1 é: " + vet1.getX());
            Console.WriteLine("\nO valor de y do objeto vet1 é: " + vet1.getY());

            Console.WriteLine("\nO valor de x do objeto vet2 é: " + vet2.getX());
            Console.WriteLine("\nO valor de y do objeto vet2 é: " + vet2.getY());

            vet3 = vet1.Projecao(vet2);

            Console.WriteLine("\nO módulo do vetor vet1 é: " + vet1.Modulo());
            Console.WriteLine("\nO módulo do vetor vet2 é: " + vet2.Modulo());
            Console.WriteLine("\nA componente x da projeção do vetor vet1 na direção de vet2 eh: " + vet3.getX());
            Console.WriteLine("A componente y da projeção do vetor vet1 na direção de vet2 eh: " + vet3.getY());
            Console.WriteLine("O ângulo entre o vetor vet1 e vet2 é: " + vet1.Angulo(vet2));
            Console.WriteLine("\nO produto escalar entre o vetor vet1 e o vetor vet2 é: " + vet1.PEscalar(vet2));

            Console.ReadLine();
        }
    }
}
