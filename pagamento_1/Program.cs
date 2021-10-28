/*

Programação Orientada a Objetos - Pagamento I (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento{

    class Program{
    
        static void Main(string[] args){
        
            Pagamento[] pagamentos = new Pagamento[6];
            pagamentos[0] = new Saude();
            pagamentos[1] = new Saude();
            pagamentos[2] = new Saude();
            pagamentos[3] = new Alimentacao();
            pagamentos[4] = new Alimentacao();
            pagamentos[5] = new Alimentacao();

            for(int i = 0; i < 6; i++){
            
                Console.WriteLine("\nInsira os dados do pagamento {0}: (CPF, Valor, Codigo)\n", i + 1);
                
                pagamentos[i].setCPF(long.Parse(Console.ReadLine()));
                pagamentos[i].setValor(double.Parse(Console.ReadLine()));
                pagamentos[i].setCodigo(int.Parse(Console.ReadLine()));
                pagamentos[i].Fatura();
            }

            Console.WriteLine("Historico de pagamentos:");

            for(int i = 0; i < 3; i++){
            
                Console.WriteLine("\n\nPagamento {0}: ", i + 1);
                Console.WriteLine("\nCPF: {0}, Valor: {1}, Codigo: {2}, Descricao/Estabelecimento: {3}, Fatura: {4}",
                    pagamentos[i].getCPF(), pagamentos[i].getValor(), pagamentos[i].getCodigo(), 
                    pagamentos[i].getEstabelecimento, pagamentos[i].Fatura());
            }

            for(int i = 3; i < 6; i++){
            
                Console.WriteLine("\n\nPagamento {0}: ", i + 1);
                Console.WriteLine("\nCPF: {0}, Valor: {1}, Codigo: {2}, Descricao/Estabelecimento: {3}, Fatura: {4}",
                    pagamentos[i].getCPF(), pagamentos[i].getValor(), pagamentos[i].getCodigo(),
                    pagamentos[i].getDescricao(), pagamentos[i].Fatura());
            }

            Console.ReadLine();
        }
    }
}
