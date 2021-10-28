/*

Programação Orientada a Objetos - Loja de Games (Interface Cadastro de Jogos)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class CadastroJogos{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDesenvolvedora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bInsertl = new System.Windows.Forms.Button();
            this.labelFName = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlataforma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbQuantidade.Location = new System.Drawing.Point(284, 245);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 21);
            this.tbQuantidade.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(97, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Quantidade disponível:";
            // 
            // tbPreco
            // 
            this.tbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPreco.Location = new System.Drawing.Point(284, 213);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(100, 21);
            this.tbPreco.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(98, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Preço:";
            // 
            // tbDesenvolvedora
            // 
            this.tbDesenvolvedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDesenvolvedora.Location = new System.Drawing.Point(284, 187);
            this.tbDesenvolvedora.Name = "tbDesenvolvedora";
            this.tbDesenvolvedora.Size = new System.Drawing.Size(100, 21);
            this.tbDesenvolvedora.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(97, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "Desenvolvedora:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCodigo.Location = new System.Drawing.Point(284, 91);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 21);
            this.tbCodigo.TabIndex = 82;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbTitulo.Location = new System.Drawing.Point(284, 61);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 21);
            this.tbTitulo.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(97, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Plataforma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(98, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Código:";
            // 
            // bInsertl
            // 
            this.bInsertl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bInsertl.Location = new System.Drawing.Point(125, 378);
            this.bInsertl.Name = "bInsertl";
            this.bInsertl.Size = new System.Drawing.Size(144, 59);
            this.bInsertl.TabIndex = 76;
            this.bInsertl.Text = "Realizar Cadastro";
            this.bInsertl.UseVisualStyleBackColor = true;
            this.bInsertl.Click += new System.EventHandler(this.bInsertl_Click_1);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFName.Location = new System.Drawing.Point(97, 64);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(51, 20);
            this.labelFName.TabIndex = 75;
            this.labelFName.Text = "Título:";
            // 
            // tbGenero
            // 
            this.tbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbGenero.Location = new System.Drawing.Point(284, 154);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 21);
            this.tbGenero.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(97, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Gênero:";
            // 
            // tbPlataforma
            // 
            this.tbPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPlataforma.Location = new System.Drawing.Point(284, 121);
            this.tbPlataforma.Name = "tbPlataforma";
            this.tbPlataforma.Size = new System.Drawing.Size(100, 21);
            this.tbPlataforma.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(585, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 59);
            this.button1.TabIndex = 95;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(354, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 59);
            this.button2.TabIndex = 96;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPlataforma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDesenvolvedora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bInsertl);
            this.Controls.Add(this.labelFName);
            this.Name = "CadastroJogos";
            this.Text = "Cadastro de produtos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDesenvolvedora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bInsertl;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlataforma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
