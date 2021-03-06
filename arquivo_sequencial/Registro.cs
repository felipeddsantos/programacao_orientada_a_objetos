/*

Programação Orientada a Objetos - Arquivo Sequencial (Classe Registro)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoSequencial{

    [Serializable]
    public class Registro{
    
        //Atributos 
        private int conta;
        private string primeiro_nome;
        private string ultimo_nome;
        private double saldo;

        //Métodos
        public Registro(){
        
            conta = 0;
            primeiro_nome = "";
            ultimo_nome = "";
            saldo = 0.0; 
        }

        public Registro(int _conta, string _primeiro_nome, string _ultimo_nome, double _saldo){
        
            conta = _conta;
            primeiro_nome = _primeiro_nome;
            ultimo_nome = _ultimo_nome;
            saldo = _saldo;
        } 

        public int getConta(){
        
            return conta;
        }

        public void setConta(int _conta){
        
            conta = _conta;
        }

        public string getPrimeiroNome(){
        
            return primeiro_nome;
        }

        public void setPrimeiroNome(string _primeiro_nome){
        
            primeiro_nome = _primeiro_nome;
        }

        public string getUltimoNome(){
        
            return ultimo_nome;
        }

        public void setUltimoNome(string _ultimo_nome){
        
            ultimo_nome = _ultimo_nome;
        }

        public double getSaldo(){
        
            return saldo;
        }

        public void setSaldo(double _saldo){
        
            saldo = _saldo;
        }
    }
}
