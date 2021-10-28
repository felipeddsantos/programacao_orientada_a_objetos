/*

Programação Orientada a Objetos - Pagamento II (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace Pagamento{

    partial class Interface{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btcadastro = new System.Windows.Forms.Button();
            this.rbsaude = new System.Windows.Forms.RadioButton();
            this.rbalimento = new System.Windows.Forms.RadioButton();
            this.btcriar = new System.Windows.Forms.Button();
            this.btrelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(165, 39);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(100, 20);
            this.tbnome.TabIndex = 0;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(165, 191);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 1;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(165, 115);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // btcadastro
            // 
            this.btcadastro.Location = new System.Drawing.Point(51, 335);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(75, 23);
            this.btcadastro.TabIndex = 8;
            this.btcadastro.Text = "Registrar";
            this.btcadastro.UseVisualStyleBackColor = true;
            this.btcadastro.Click += new System.EventHandler(this.btcadastro_Click);
            // 
            // rbsaude
            // 
            this.rbsaude.AutoSize = true;
            this.rbsaude.Location = new System.Drawing.Point(385, 76);
            this.rbsaude.Name = "rbsaude";
            this.rbsaude.Size = new System.Drawing.Size(56, 17);
            this.rbsaude.TabIndex = 9;
            this.rbsaude.TabStop = true;
            this.rbsaude.Text = "Saúde";
            this.rbsaude.UseVisualStyleBackColor = true;
            // 
            // rbalimento
            // 
            this.rbalimento.AutoSize = true;
            this.rbalimento.Location = new System.Drawing.Point(385, 161);
            this.rbalimento.Name = "rbalimento";
            this.rbalimento.Size = new System.Drawing.Size(77, 17);
            this.rbalimento.TabIndex = 10;
            this.rbalimento.TabStop = true;
            this.rbalimento.Text = "Alimentícia";
            this.rbalimento.UseVisualStyleBackColor = true;
            // 
            // btcriar
            // 
            this.btcriar.Location = new System.Drawing.Point(231, 334);
            this.btcriar.Name = "btcriar";
            this.btcriar.Size = new System.Drawing.Size(75, 23);
            this.btcriar.TabIndex = 11;
            this.btcriar.Text = "Criar arquivo";
            this.btcriar.UseVisualStyleBackColor = true;
            this.btcriar.Click += new System.EventHandler(this.btcriar_Click);
            // 
            // btrelatorio
            // 
            this.btrelatorio.Location = new System.Drawing.Point(408, 334);
            this.btrelatorio.Name = "btrelatorio";
            this.btrelatorio.Size = new System.Drawing.Size(75, 23);
            this.btrelatorio.TabIndex = 12;
            this.btrelatorio.Text = "Relatório";
            this.btrelatorio.UseVisualStyleBackColor = true;
            this.btrelatorio.Click += new System.EventHandler(this.btrelatorio_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btrelatorio);
            this.Controls.Add(this.btcriar);
            this.Controls.Add(this.rbalimento);
            this.Controls.Add(this.rbsaude);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbnome);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.RadioButton rbsaude;
        private System.Windows.Forms.RadioButton rbalimento;
        private System.Windows.Forms.Button btcriar;
        private System.Windows.Forms.Button btrelatorio;
    }
}
