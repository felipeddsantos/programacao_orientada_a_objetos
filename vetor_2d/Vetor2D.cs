/*

Programação Orientada a Objetos - Vetor 2D (Classe Vetor 2D)
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
        double x, y;

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

        //Métodos
        public double Modulo(){

            return Math.Sqrt(x * x + y * y);
        }

        public double PEscalar(Vetor2D vet){

            return (vet.x * x + vet.y * y);
        }

        public double Angulo(Vetor2D vet){

            return (Math.Acos((vet.x * x + vet.y * y) / (vet.Modulo() * (Math.Sqrt(x * x + y * y))))) * 180 / Math.PI;
        }

        public Vetor2D Projecao(Vetor2D vet){
        
            Vetor2D vet3 = new Vetor2D();
            vet3.x = ((vet.x * x + vet.y * y) * vet.x) / (vet.x * vet.x + vet.y * vet.y);
            vet3.y = ((vet.x * x + vet.y * y) * vet.y) / (vet.x * vet.x + vet.y * vet.y);
            
            return vet3;
        }
    }
}
