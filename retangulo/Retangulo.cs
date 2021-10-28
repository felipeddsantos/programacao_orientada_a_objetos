/*

Programação Orientada a Objetos - Retângulo (Classe Retângulo)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo{

    class Retangulo{
    
        //Atributos
        private int bas;
        private int alt;

        //Construtor: nome do metodo igual ao nome da classe, responsavel em criar objetos para a classe
        //Construtor default: aridade = 0
        public Retangulo(){

            bas = alt = 10;
        }

        //Construtor: nome do metodo igual ao nome da classe, responsavel em criar objetos para a classe
        //Não é construtor default: aridade = 2
        public Retangulo(int b, int a){

            bas = b;
            alt = a;
        }

         public int getBas(){

            return bas;
        }

        public int getAlt(){

            return alt;
        }

        public void setBas(int nbas){

            bas = nbas;
        }

        public void setAlt(int nalt){

            alt = nalt;
        }

        public int perimetro(){

            return 2 * (alt + bas);
        }

        public int area(){

            return bas * alt;
        }
    }
}
