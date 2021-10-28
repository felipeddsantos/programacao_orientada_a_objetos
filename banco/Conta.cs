/*

Programação Orientada a Objetos - Banco (Classe Conta)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco{

    class Conta{
    
        protected int numero;
        protected double saldo;
        protected String cliente;

        public void setNumero(int anumero){
        
            numero = anumero;
        }

        public void setSaldo(double asaldo){
        
            saldo = asaldo;
        }

        public void setCliente(String acliente){
        
            cliente = acliente;
        }

        public int setNumero(){
        
            return numero;
        }

        public double getSaldo(){
        
            return saldo;
        }

        public String getCliente(){
        
            return cliente;
        }

        public Conta(int anumero, double asaldo, String acliente){
        
            numero = anumero;
            cliente = acliente;
            saldo = asaldo;
        }

        public Conta(){
        
            numero = 0;
            cliente = " ";
            saldo = 0.0;
        }

        public void Deposita(double d){
        
            saldo += d;
        }

        public virtual void Saca(double s){ }
    }
}
