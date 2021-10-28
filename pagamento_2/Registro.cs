/*

Programação Orientada a Objetos - Pagamento II (Classe Registro)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Pagamento{

    [Serializable]
    class Registro{
    
        string nome;
        string CPF;
        double valor;
        int codigo;

        public Registro(){
        
            CPF = "";
            valor = 0.0;
            codigo = 0;
            nome = "";
        }

        public Registro(string aCPF, double avalor, int acodigo, string anome){
        
            CPF = aCPF;
            valor = avalor;
            codigo = acodigo;
            nome = anome;
        }

        public string getCPF(){
        
            return CPF;
        }

        public void setCPF(string aCPF){
        
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

        public string getNome(){
        
            return nome;
        }

        public void setNome(string anome){
        
            nome = anome;
        }
    }
}
