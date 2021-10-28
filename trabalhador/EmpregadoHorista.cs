/*

Programação Orientada a Objetos - Trabalhador (Classe Empregado Horista)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhador{

    class EmpregadoHorista : Empregado{
    
        private int horas;
        private double preco_hora;

        public EmpregadoHorista(String anome, String aCPF, String aendereco, int ahoras, double apreco_hora) : base(anome, aCPF, aendereco){
        
            horas = ahoras;
            preco_hora = apreco_hora;
        }

        public EmpregadoHorista(): base(){
        
            horas = 0;
            preco_hora = 0.0;
        }

        public int getHoras(){
        
            return horas;
        }

        public void setHoras(int ahoras){
        
            horas = ahoras;
        }

        public double getPrecoHora(){
        
            return preco_hora;
        }

        public void setPrecoHora(double apreco_hora){
        
            preco_hora = apreco_hora;
        }

        public override double Salario(){
        
            return horas * preco_hora * 0.85;
        }
    }
}
