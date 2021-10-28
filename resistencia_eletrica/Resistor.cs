/*

Programação Orientada a Objetos - Resistência Elétrica (Classe Resistor)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistenciaEletrica{

    class Resistor{
    
        private double resistencia, mpotencia;

        public Resistor(){
        
            resistencia = 0.0;
            mpotencia = 0.0;
        }

        public Resistor(double aresistor, double ampotencia){
        
            resistencia = aresistor;
            mpotencia = ampotencia;
        }

        public double getResistencia(){
        
            return resistencia;
        }

        public void setResistencia(double aresistencia){
        
            resistencia = aresistencia;
        }

        public double getPotencia(){
        
            return mpotencia;
        }

        public void setPotencia(double ampotencia){
        
            mpotencia = ampotencia;
        }

        public Resistor ResistorSerie(Resistor ar){
        
            Resistor r = new Resistor();
            r.resistencia = (resistencia + ar.resistencia);
            
            if(ar.mpotencia < mpotencia)
            
                r.mpotencia = ar.mpotencia;
                
            else
               
                r.mpotencia = mpotencia;
           
            return r;
        }

        public Resistor ResistorParalelo(Resistor ar){
        
            Resistor r = new Resistor();
            r.resistencia = ((resistencia * ar.resistencia) / (resistencia + ar.resistencia));
            
            if(ar.mpotencia < mpotencia)
            
                r.mpotencia = ar.mpotencia;
                
            else
            
                r.mpotencia = mpotencia;
                
            return r;
        }

        public void ImprimeResistor(){
        
            Console.WriteLine("Resistência: {0} Ohm", resistencia);
            Console.WriteLine("\nMéxima Potência: {0} W", mpotencia);
        }
    }
}
