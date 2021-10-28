/*

Programação Orientada a Objetos - Pagamento II (Classe Saúde)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento{

    class Saude : PagamentoTotal{

        private String estabelecimento;
        private double vlfatSaude;

        public Saude() : base(){
        
            estabelecimento = " ";
            vlfatSaude = 0.0;
        }

        public Saude(long aCPF, double avalor, int acodigo, String aestabelecimento, double avlfatSaude) : base(aCPF, avalor, acodigo){
        
            estabelecimento = aestabelecimento;
            vlfatSaude = avlfatSaude;
        }

        public String getEstabelecimento(){
        
            return estabelecimento;
        }

        public void setEstabelecimento(String aestabelecimento){
        
            estabelecimento = aestabelecimento;
        }

        public double getvlfatSaude(){
        
            return vlfatSaude;
        }

        public void setvlfatSaude(double avlfatSaude){
        
            vlfatSaude = avlfatSaude;
        }

        public override void Fatura(){
        
            vlfatSaude = valor + valor * 0.12;
        }
    }
}
