/*

Programação Orientada a Objetos - Média Aritmética (Programa Principal)
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

namespace MediaAritimetica{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        private void button_OK_MouseClick(object sender, MouseEventArgs e){
        
            double n1, n2, media;
            n1 = Convert.ToDouble(tb_Numero1.Text);
            n2 = Convert.ToDouble(tb_Numero2.Text);
            media = (n1 + n2) / 2.0;
            tb_MediaAritmetica.Text = Convert.ToString(media);
        }
    }
}
