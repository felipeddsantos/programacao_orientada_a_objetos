/*

Programação Orientada a Objetos - Trabalhador (Classe Empregado)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhador{

    class Empregado{
    
        protected String nome, CPF, endereco;

        public Empregado(String anome, String aCPF, String aendereco){
        
            nome = anome;
            CPF = aCPF;
            endereco = aendereco;
        }

        public Empregado(){
        
            nome = " ";
            CPF = " ";
            endereco = " ";
        }

        public string getNome(){
        
            return nome;
        }

        public string getCPF(){
        
            return CPF;
        }

        public string getEndereco(){
        
            return endereco;
        }

        public void setNome(String anome){
        
            nome = anome;
        }

        public void setCPF(String aCPF){
        
            CPF = aCPF;
        }

        public void setendereco(String aendereco){
        
            endereco = aendereco;
        }

        public virtual double Salario(){
        
            return 1.0;
        }
    }
}
