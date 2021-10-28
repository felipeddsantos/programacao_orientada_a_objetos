/*

Programação Orientada a Objetos - Arquivo Texto II (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace ArquivoTexto{

    partial class Interface{

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }
        
        private void InitializeComponent(){
        
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira arquivo ou diretório:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(33, 65);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(265, 20);
            this.tbEntrada.TabIndex = 1;
            this.tbEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEntrada_KeyDown);
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(33, 107);
            this.tbSaida.Multiline = true;
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(265, 327);
            this.tbSaida.TabIndex = 2;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 396);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.label1);
            this.Name = "Interface";
            this.Text = "Busca de arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.TextBox tbSaida;
    }
}
