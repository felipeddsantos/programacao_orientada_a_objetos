/*

Programação Orientada a Objetos - Vetor 3D (Classe Vetor 3D)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor{

    class Vetor2D{
    
        //Atributos
        protected double x, y;

        //Construtores
        public Vetor2D(){ 
        
            x = y = 0;
        }

        public Vetor2D(double a, double b){
        
            x = a;
            y = b;
        }

        //getters e setters
        public double getX(){
        
            return x;
        }

        public double getY(){
        
            return y;
        }

        public void setX(double xx){
        
            x = xx;
        }

        public void setY(double yy){
        
            y = yy;
        }
    }
}
