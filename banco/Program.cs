/*

Programação Orientada a Objetos - Banco (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco{

    class Program{
    
        static void Main(string[] args){
        
            Conta a = new Conta(1, 234.55, "Maria");
            Corrente b = new Corrente(1, 212, "Joao");
            Poupanca c = new Poupanca(2, 453.99, "Felipe", 3);

            Console.WriteLine("Saldo da corrente: {0} \n\n", b.getSaldo());
            Console.WriteLine("Saldo da poupanca: {0} \n\n", c.getSaldo());

            Console.WriteLine("Quanto vc quer sacar da corrente? \n\n");

            b.Saca(double.Parse(Console.ReadLine()));

            Console.WriteLine("Quanto vc quer sacar da poupanca? \n\n");

            c.Saca(double.Parse(Console.ReadLine()));

            Console.WriteLine("Saldo da corrente: {0} \n\n", b.getSaldo());
            Console.WriteLine("Saldo da poupanca: {0} \n\n", c.getSaldo());

            Console.WriteLine("Quanto vc quer depositar na corrente? \n\n");

            b.Deposita(double.Parse(Console.ReadLine()));

            Console.WriteLine("Quanto vc quer depositar na poupanca? \n\n");

            c.Deposita(double.Parse(Console.ReadLine()));

            Console.WriteLine("Saldo da corrente: {0} \n\n", b.getSaldo());
            Console.WriteLine("Saldo da poupanca: {0} \n\n", c.getSaldo());

            Console.ReadLine();
        }
    }
}
