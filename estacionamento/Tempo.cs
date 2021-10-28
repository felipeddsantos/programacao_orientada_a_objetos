/*

Programação Orientada a Objetos - Estacionamento (Classe Tempo)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento{

    class Tempo{
    
        //Atributos
        public int hora, min, seg;

        //Métodos
        public Tempo(){
        
            hora = 0;
            min = 0;
            seg = 0;
        }

        public Tempo(Tempo t){
        
            hora = t.hora;
            min = t.min;
            seg = t.seg;
        }

        public int getHora(){

            return hora;
        }

        public void setHora(int _hora){

            hora = _hora;
        }

        public int getMin(){

            return min;
        }

        public void setMin(int _min){

            min = _min;
        }

        public int getSeg(){

            return seg;
        }

        public void setSeg(int _seg){

            seg = _seg;
        }

        public void ImprimeTempo(){
        
            Console.WriteLine("{0} : {1} : {2}", hora, min, seg);
        }

        public void EntradaTempo(){
        
            hora = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            seg = int.Parse(Console.ReadLine());
        }

        public Tempo Soma(Tempo a){
        
            Tempo t = new Tempo();

            if(seg + a.seg > 60){
            
                t.seg = seg + a.seg - 60;
                min++;
            }

            else if(seg + a.seg == 60){
            
                t.seg = 0;
                min++;
            }
            
            else
            
                t.min = min + a.min;

            if(min + a.min > 60){
            
                t.min = min + a.min - 60;
                hora++;
            }

            else if(min + a.min == 60){
            
                t.min = 0;
                hora++;
            }

            else
            
                t.seg = seg + a.seg;

            t.hora = hora - a.hora;
            
            return t;
        }

        public Tempo Subtrai(Tempo a){
        
            Tempo t = new Tempo();

            if(seg - a.seg < 0){
            
                t.seg = 60 - (a.seg - seg);
                min--;
            }

            else if(seg == a.seg)
            
                t.seg = 0;

            else
            
                t.seg = seg - a.seg;

            if(min - a.min < 0){
            
                t.min = 60 - (a.min - min);
                hora--;
            }

            else if(min == a.min)
            
                t.min = 0;

            else
            
                t.min = min - a.min;

            t.hora = hora - a.hora;
            
            return t;
        }
    }
}
