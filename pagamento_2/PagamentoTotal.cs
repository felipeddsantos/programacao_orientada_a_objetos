/*

Programação Orientada a Objetos - Pagamento II (Classe Pagamento Total)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento{

    class PagamentoTotal{
    
        protected long CPF;
        protected double valor;
        protected int codigo;

        public PagamentoTotal(){
        
            CPF = 0;
            valor = 0.0;
            codigo = 0;
        }

        public PagamentoTotal(long aCPF, double avalor, int acodigo){
        
            CPF = aCPF;
            valor = avalor;
            codigo = acodigo;
        }

        public long getCPF(){
        
            return CPF;
        }

        public void setCPF(long aCPF){
        
            CPF = aCPF;
        }
        public double getValor(){
        
            return valor;
        }

        public void setValor(double avalor){
        
            valor = avalor;
        }
        
        public int getCodigo(){
        
            return codigo;
        }

        public void setCodigo(int acodigo){
        
            codigo = acodigo;
        }

        public virtual void Fatura(){}
    }
}
