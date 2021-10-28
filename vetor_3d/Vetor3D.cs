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

namespace Vetor{

    class Vetor3D : Vetor2D{
    
        private double z;

        public Vetor3D() :base(){
        
            z = 0;
        }

        public Vetor3D(double a, double b, double c) : base(a, b){
        
            z = c;
        }
        
        public double getZ(){
        
            return z;
        }

        public void setZ(double zz){
        
            z = zz;
        }

        public Vetor3D Vetorial(Vetor3D vet){
        
            Vetor3D vet3 = new Vetor3D();
            vet3.x = (y * vet.z) - (vet.y * z);
            vet3.y = - ((x * vet.z) - (vet.x * z));
            vet3.z = (x * vet.y) - (vet.x * y);
            
            return vet3; 
        }
        
        public double Modulo(){
        
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
