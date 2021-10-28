/*

Programação Orientada a Objetos - Raíz Quadrada (Programa Principal)
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

namespace RaizQuadrada{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e){
        
            try{
            
                  tb2.Text = (Math.Sqrt(double.Parse(tb1.Text))).ToString();
            }

            catch(FormatException naoNumero){
            
                MessageBox.Show(naoNumero.Message, "Operação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally{

                Console.WriteLine("Qualé...");
            }
        }
    }
}
