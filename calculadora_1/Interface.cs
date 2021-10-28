/*

Programação Orientada a Objetos - Calculadora I (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora{

    public partial class Interface : Form{
    
        public Calculadora calcWindows = new Calculadora();
        public string operacao = "";

        public Interface(){
        
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e){
        
            textResult.Text = textResult.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e){
        
            textResult.Text = "";
            calcWindows.setResultado(0.0);
            calcWindows.setOperacao("");
            calcWindows.setValor(0.0);
        }

        private void btnSoma_Click(object sender, EventArgs e){
        
            calcWindows.setOperacao("+");
            calcWindows.setResultado(Convert.ToDouble(textResult.Text));
            textResult.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e){
        
            calcWindows.setValor(Convert.ToDouble(textResult.Text));
            calcWindows.Calcular();
            textResult.Text = Convert.ToString(calcWindows.getResultado());
        }

        private void btnDiv_Click(object sender, EventArgs e){
        
            calcWindows.setOperacao("/");
            calcWindows.setResultado(Convert.ToDouble(textResult.Text));
            textResult.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e){
        
            calcWindows.setOperacao("*");
            calcWindows.setResultado(Convert.ToDouble(textResult.Text));
            textResult.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e){
        
            calcWindows.setOperacao("-");
            calcWindows.setResultado(Convert.ToDouble(textResult.Text));
            textResult.Text = "";
        }  
    }
}
