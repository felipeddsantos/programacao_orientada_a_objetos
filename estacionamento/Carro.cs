/*

Programação Orientada a Objetos - Estacionamento (Classe Carro)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento{

    class Carro{
    
        public String placa, marca;
        public Tempo entrada, saida;

        public Carro(){
        
            marca = " " ;
            placa = " " ;
            entrada = new Tempo();
            saida = new Tempo();
        }

        public Carro(String _placa, String _marca, Tempo t, Tempo z){
        
            placa = _placa;
            marca = _marca;
            entrada = new Tempo(t);
            saida = new Tempo(z);
        }
        
        public String getMarca(){

            return marca;
        }

        public void setMarca(String _marca){

            marca = _marca;
        }

        public String getPlaca(){

            return placa;
        }

        public void setPlaca(String _placa){

            placa = _placa;
        }

        public void ImprimeCarro(){
        
            Tempo aux = new Tempo();
            
            Console.WriteLine("\nMarca: {0}", marca);
            Console.WriteLine("\nPlaca: {0}", placa);
            Console.WriteLine("\nHorario de entrada:\n");
            entrada.ImprimeTempo();
            
            Console.WriteLine("\nHorario de saida:\n");
            saida.ImprimeTempo();
            
            Console.WriteLine("\nTempo de permanecimento no estacionamento:\n");
            aux = saida.Subtrai(entrada);
        }

        public void Conta(){
        
            double conta;
            
            entrada = saida.Subtrai(entrada);
            entrada.ImprimeTempo();
            conta = entrada.hora * 7.0 + ((entrada.min / 60.0) * 7.0) + ((entrada.seg / 3600.0) * 7.0);
            Console.WriteLine("\nConta a ser paga: {0}", conta);
        }
    }
}
