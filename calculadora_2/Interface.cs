/*

Programação Orientada a Objetos - Calculadora II (Programa Principal)
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

namespace Calculadora2{

    public partial class Interface : Form{
    
        double[] value = new double[1000];
        double result = 0.0;
        int aux = 0, dot = 0, i = 0;

        public Interface(){
        
            InitializeComponent();
        }

        public double Operacoes(int aux, double num1, double num2){
        
            if(aux == 1)

                return num1 + num2;

            if(aux == 2)

                return num1 - num2;

            if(aux == 3)

                return (num1 * num2);

            if(aux == 4){

                if(num2 != 0)

                    return num1 / num2;
                
                else
                
                    MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if(aux == 5)

                return Math.Pow(num1, num2);

            if(aux == 6)

                return num1 * num2 * 0.01;

            else

                return num2;
        }

        private void b0_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 0.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b1_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 1.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i-1], value[i]);

            value[i] = result;
        }

        private void b2_Click(object sender, EventArgs e){
        
            if(dot == 0)
        
                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 2.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i-1], value[i]);

            value[i] = result;
        }

        private void b3_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";
                
            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 3.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b4_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 4.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b5_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1) 

                i--;

            dot = 1;

            i++;

            value[i] = 5.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b6_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 6.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b7_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 7.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b8_Click(object sender, EventArgs e){
            
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 8.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void b9_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";
   
            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 9.0;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void bpi_Click(object sender, EventArgs e)
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = Math.PI;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void be_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = Math.E;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void ba_Click(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 1.61803398875;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void bphi_Click_1(object sender, EventArgs e){
        
            if(dot == 0)

                number.Text = "";

            if(dot == -1 || dot == 1)

                i--;

            dot = 1;

            i++;

            value[i] = 0.123456789101112;

            number.Text = number.Text + value[i].ToString();

            value[i] = double.Parse(number.Text);

            result = Operacoes(aux, value[i - 1], value[i]);

            value[i] = result;
        }

        private void btmais_Click(object sender, EventArgs e){
        
            aux = 1;
            dot = 0;
        }

        private void bmenos_Click(object sender, EventArgs e){

            aux = 2;
            dot = 0;
        }

        private void bproduto_Click(object sender, EventArgs e){
        
            aux = 3;
            dot = 0;
        }

        private void bdivisao_Click(object sender, EventArgs e){
        
            aux = 4;
            dot = 0;
        }

        private void braiz_Click(object sender, EventArgs e){
        
            if(value[i] < 0){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = Math.Sqrt(value[i]);
        }

        private void bpotencia_Click(object sender, EventArgs e){
            
            aux = 5;
            dot = 0;
        }

        private void bporcento_Click(object sender, EventArgs e){
        
            aux = 6;
            dot = 0;
        }

        private void bexp_Click(object sender, EventArgs e){
            
            result = Math.Exp(value[i]);
        }

        private void bfatorial_Click_1(object sender, EventArgs e){
        
            if(value[i] < 0 || ((float)value[i] - (int)value[i]) != 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            int k = 1;

            for(int j = 1; j <= (int)value[i]; j++)
               
                k = j * k;

            result = (double)k;
        }

        private void bln_Click(object sender, EventArgs e){
        
            if(value[i] <= 0){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = Math.Log(value[i]);
        }

        private void blog_Click(object sender, EventArgs e){
            
            if(value[i] <= 0){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = Math.Log10(value[i]);
        }

        private void bsen_Click(object sender, EventArgs e){
            
            result = Math.Sin(value[i]);
        }

        private void bcos_Click_1(object sender, EventArgs e){
            
            result = Math.Cos(value[i]);
        }

        private void btg_Click(object sender, EventArgs e){
            
            if(Math.Cos(value[i]) == 0){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = Math.Tan(value[i]);
        }

        private void bcotg_Click(object sender, EventArgs e){
        
            if(Math.Tan(value[i]) == 0){
              
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = 1 / Math.Tan(value[i]);
        }

        private void bsec_Click(object sender, EventArgs e){
            
            if(Math.Cos(value[i]) == 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = 1 / Math.Cos(value[i]);
        }

        private void bcossec_Click_1(object sender, EventArgs e){
           
            if(Math.Sin(value[i]) == 0){
              
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = 1 / Math.Sin(value[i]);
        }

        private void bsenh_Click_1(object sender, EventArgs e){
            
            result = Math.Sinh(value[i]);
        }

        private void cosh_Click(object sender, EventArgs e){
           
            result = Math.Cosh(value[i]);
        }

        private void btgh_Click_1(object sender, EventArgs e){
           
            if(Math.Cosh(value[i]) == 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else

                result = Math.Tanh(value[i]);
        }

        private void bcotgh_Click_1(object sender, EventArgs e){
        
            if(Math.Tanh(value[i]) == 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = 1 / Math.Tanh(value[i]);
        }

        private void bsech_Click_1(object sender, EventArgs e){
            
            if(Math.Cosh(value[i]) == 0){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = 1 / Math.Cosh(value[i]);
        }

        private void bcossech_Click_1(object sender, EventArgs e){
        
            if(Math.Sinh(value[i]) == 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else

                result = 1 / Math.Sinh(value[i]);
        }

        private void barcsen_Click(object sender, EventArgs e){
            
            if(value[i] < -1 || value[i] > 1){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = Math.Asin(value[i]);
        }
        
        private void barccos_Click(object sender, EventArgs e){
           
            if(value[i] < -1 || value[i] > 1){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = Math.Acos(value[i]);
        }
        
        private void barctg_Click(object sender, EventArgs e){
        
            result = Math.Atan(value[i]);
        }
        
        private void barccotg_Click_1(object sender, EventArgs e){
        
            result = ((Math.PI / 2) - Math.Atan(value[i]));
        }
        
        private void barcsec_Click_1(object sender, EventArgs e){
        
            if(value[i] > -1 && value[i] < 1){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = ((Math.PI / 2) - Math.Asin(1 / value[i]));
        }
        private void barccossec_Click_1(object sender, EventArgs e){
        
            if(value[i] > -1 && value[i] < 1){
            
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
            
                result = Math.Asin(1 / value[i]);
        }
        
        private void barcsenh_Click(object sender, EventArgs e){
            
            result = Math.Log(value[i] + Math.Sqrt(value[i] * value[i] + 1));
        }
        
        private void barccosh_Click(object sender, EventArgs e){
            
            if(value[i] < 1){
               
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = Math.Log(value[i] + Math.Sqrt(value[i] * value[i] - 1));
        }
        
        private void barctgh_Click(object sender, EventArgs e){
            
            if(value[i] <= -1 || value[i] >= 1){
               
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
              
                result = 0.5 * Math.Log((1 + value[i]) / (1 - value[i]));
        }
        
        private void barccotgh_Click(object sender, EventArgs e){
            
            if(value[i] >= -1 && value[i] <= 1){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = 0.5 * Math.Log((value[i] + 1) / (value[i] - 1));
        }
        
        private void barcsech_Click(object sender, EventArgs e){
           
            if(value[i] <= 0 || value[i] > 1){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = Math.Log((1 + Math.Sqrt(1 - value[i] * value[i])) / (value[i]));
        }
        
        private void barccossech_Click(object sender, EventArgs e){
            
            if(value[i] == 0){
                
                MessageBox.Show("Valor inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                number.Text = "";

                aux = dot = 0;
            }

            else
                
                result = Math.Log((1 + Math.Sqrt(1 + value[i] * value[i])) / (value[i]));
        }

        private void brad_Click(object sender, EventArgs e){
            
            result = (value[i] * (Math.PI / 180));
        }

        private void bgrau_Click(object sender, EventArgs e){
            
            result = ((180 / Math.PI) * value[i]);
        }

        private void blimpar_Click(object sender, EventArgs e){
            
            number.Text = " ";
        }

        private void bdot_Click(object sender, EventArgs e){
           
            dot = -1;

            number.Text = number.Text + ",";
        } 

        private void btigual_Click(object sender, EventArgs e){

            number.Text = result.ToString();

            value[i] = result;

            aux = dot = 0;
        }
    }
}
