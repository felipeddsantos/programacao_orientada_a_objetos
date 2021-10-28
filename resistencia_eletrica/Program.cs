/*

Programação Orientada a Objetos - Resistência Elétrica (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistenciaEletrica{

    class Program{
    
        static void Main(string[] args){
        
            Resistor r1 = new Resistor();
            Resistor r2 = new Resistor();
            Resistor rs = new Resistor();
            Resistor rp = new Resistor();

            Console.WriteLine("Insira os atributos do primeiro resistor (resistência e máxima potência):\n");
            r1.setResistencia(double.Parse(Console.ReadLine()));
            r1.setPotencia(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nInsira os atributos do segundo resistor (resistência e máxima potência):\n");
            r2.setResistencia(double.Parse(Console.ReadLine()));
            r2.setPotencia(double.Parse(Console.ReadLine()));

            rs = r1.ResistorSerie(r2);
            rp = r1.ResistorParalelo(r2);

            Console.WriteLine("Resistência e máxima potência equivalente em série:\n");
            rs.ImprimeResistor();
            Console.WriteLine("\nResistência e máxima potência equivalente em paralelo:\n");
            rp.ImprimeResistor();
            Console.ReadLine();
        }
    }
}
