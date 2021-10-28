/*

Programação Orientada a Objetos - Pagamento II (Classe Alimentação)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento{

    class Alimentacao : PagamentoTotal{
    
        private String descricao;
        private double vlfatAliment;

        public Alimentacao() : base(){
        
            descricao = " ";
            vlfatAliment = 0.0;
        }

        public Alimentacao(long aCPF, double avalor, int acodigo, String adescricao, double avlfatAliment) : base(aCPF, avalor, acodigo){
        
            descricao = adescricao;
            vlfatAliment = avlfatAliment;
        }

        public String getDescricao(){
        
            return descricao;
        }

        public void setDescricao(String adescricao){
        
            descricao = adescricao;
        }

        public double getvlfatAliment(){
        
            return vlfatAliment;
        }

        public void setvlfatAliment(double avlfatAliment){
        
            vlfatAliment = avlfatAliment;
        }

        public override void Fatura(){
        
            vlfatAliment = valor + valor * 0.05;
        }
    }
}
