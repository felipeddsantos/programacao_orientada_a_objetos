/*

Programação Orientada a Objetos - Trabalhador (Classe Empregado CLT)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhador{

    class EmpregadoCLT : Empregado{
    
        private double salariobruto;

        public EmpregadoCLT(String anome, String aCPF, String aendereco, double asalariobruto) : base(anome, aCPF, aendereco){
        
            salariobruto = asalariobruto;
        }

        public EmpregadoCLT() : base(){
        
            salariobruto = 0.0;
        }

        public double getSalarioBruto(){
        
            return salariobruto;
        }

        public void setSalarioBruto(double asalariobruto){
        
            salariobruto = asalariobruto;
        }

        public override double Salario(){
        
            if(salariobruto <= 5000.00)

                return salariobruto * 0.85;
                
            else
            
                return salariobruto * 0.725;
        }
    }
}
