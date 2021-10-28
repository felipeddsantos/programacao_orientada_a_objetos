/*

Programação Orientada a Objetos - Calculadora I (Classe Calculadora)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora{

    public class Calculadora{
    
        //Atributos ou caracteristicas da classe
        private double resultado;
        private double valor;
        private string operacao;

        //Construtor nulo ou vazio
        public Calculadora(){
        
            resultado = 0.0;
            valor = 0.0;
            operacao = "";
        }

        public Calculadora(double _r, double _v, string _op){
        
            resultado = _r;
            valor = _r;
            operacao = _op;
        }

        //O método get é sempre uma função
        public double getValor(){
        
            return valor;
        }

        //O método set é sempre uma procedure
        public void setValor(double _v){
        
            valor = _v;
        }
        public string getOperacao(){
        
            return operacao;
        }

        public void setOperacao(string _o){
        
            operacao = _o;
        }

        public double getResultado(){
        
            return resultado;
        }

        public void setResultado(double _r){
        
            resultado = _r;
        }

        public void Calcular(){
        
            if(operacao.Equals("+"))
            
                resultado = resultado + valor;
                
            if(operacao.Equals("-"))
            
                resultado = resultado - valor;
                
            if(operacao.Equals("/"))
            
                resultado = resultado / valor;
                
            if(operacao.Equals("*"))
            
                resultado = resultado * valor;
        }
    }
}
