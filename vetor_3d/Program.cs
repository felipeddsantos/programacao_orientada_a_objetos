/*

Programação Orientada a Objetos - Vetor 3D (Programa Principal)
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
            
            Vetor3D vet1 = new Vetor3D();
            Vetor3D vet2 = new Vetor3D();
            Vetor3D vet3 = new Vetor3D();

            Console.WriteLine("Insira o vetor 1\n");

            vet1.setX(double.Parse(Console.ReadLine()));
            vet1.setY(double.Parse(Console.ReadLine()));
            vet1.setZ(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nInsira o vetor 2\n");

            vet2.setX(double.Parse(Console.ReadLine()));
            vet2.setY(double.Parse(Console.ReadLine()));
            vet2.setZ(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nVetor 1: ({0},{1},{2})", vet1.getX(), vet1.getY(), vet1.getZ());
            Console.WriteLine("\nVetor 2: ({0},{1},{2})", vet2.getX(), vet2.getY(), vet2.getZ());

            vet3 = vet1.Vetorial(vet2);

            Console.WriteLine("\nMódulo do vetor 1: " + vet1.Modulo());
            Console.WriteLine("\nMódulo do vetor 2: " + vet2.Modulo());
            Console.WriteLine("\nProduto vetorial entre vetor 1 e vetor 2: ({0},{1},{2})", vet3.getX(), vet3.getY(), vet3.getZ());
            Console.WriteLine("\nMódulo do produto vetorial: " + vet3.Modulo());

            Console.ReadLine();
        }
    }
}
