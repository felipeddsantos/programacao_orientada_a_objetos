/*

Programação Orientada a Objetos - Loja de Games (Interface Cadastro de Funcionários)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class CadastroFuncionarios{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbEmailf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefonef = new System.Windows.Forms.MaskedTextBox();
            this.tbDataf = new System.Windows.Forms.MaskedTextBox();
            this.tbCEPf = new System.Windows.Forms.MaskedTextBox();
            this.tbCPFf = new System.Windows.Forms.TextBox();
            this.tbNomef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bInsertf = new System.Windows.Forms.Button();
            this.labelFName = new System.Windows.Forms.Label();
            this.tbFuncao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmailf
            // 
            this.tbEmailf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEmailf.Location = new System.Drawing.Point(287, 202);
            this.tbEmailf.Name = "tbEmailf";
            this.tbEmailf.Size = new System.Drawing.Size(100, 21);
            this.tbEmailf.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(125, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Email:";
            // 
            // tbTelefonef
            // 
            this.tbTelefonef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbTelefonef.Location = new System.Drawing.Point(287, 170);
            this.tbTelefonef.Mask = "(99) 0000-0000";
            this.tbTelefonef.Name = "tbTelefonef";
            this.tbTelefonef.Size = new System.Drawing.Size(100, 21);
            this.tbTelefonef.TabIndex = 68;
            // 
            // tbDataf
            // 
            this.tbDataf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDataf.Location = new System.Drawing.Point(287, 107);
            this.tbDataf.Mask = "00/00/0000";
            this.tbDataf.Name = "tbDataf";
            this.tbDataf.Size = new System.Drawing.Size(100, 21);
            this.tbDataf.TabIndex = 67;
            this.tbDataf.ValidatingType = typeof(System.DateTime);
            // 
            // tbCEPf
            // 
            this.tbCEPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCEPf.Location = new System.Drawing.Point(287, 140);
            this.tbCEPf.Mask = "00000-999";
            this.tbCEPf.Name = "tbCEPf";
            this.tbCEPf.Size = new System.Drawing.Size(100, 21);
            this.tbCEPf.TabIndex = 66;
            // 
            // tbCPFf
            // 
            this.tbCPFf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCPFf.Location = new System.Drawing.Point(287, 77);
            this.tbCPFf.Name = "tbCPFf";
            this.tbCPFf.Size = new System.Drawing.Size(100, 21);
            this.tbCPFf.TabIndex = 65;
            // 
            // tbNomef
            // 
            this.tbNomef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNomef.Location = new System.Drawing.Point(287, 44);
            this.tbNomef.Name = "tbNomef";
            this.tbNomef.Size = new System.Drawing.Size(100, 21);
            this.tbNomef.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(125, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Data de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(125, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(125, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "CEP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(125, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Telefone:";
            // 
            // bInsertf
            // 
            this.bInsertf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bInsertf.Location = new System.Drawing.Point(129, 371);
            this.bInsertf.Name = "bInsertf";
            this.bInsertf.Size = new System.Drawing.Size(144, 59);
            this.bInsertf.TabIndex = 43;
            this.bInsertf.Text = "Realizar cadastro";
            this.bInsertf.UseVisualStyleBackColor = true;
            this.bInsertf.Click += new System.EventHandler(this.bInsertf_Click_1);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFName.Location = new System.Drawing.Point(125, 47);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(55, 20);
            this.labelFName.TabIndex = 42;
            this.labelFName.Text = "Nome:";
            // 
            // tbFuncao
            // 
            this.tbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFuncao.Location = new System.Drawing.Point(287, 235);
            this.tbFuncao.Name = "tbFuncao";
            this.tbFuncao.Size = new System.Drawing.Size(100, 21);
            this.tbFuncao.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(125, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Cargo:";
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbSalario.Location = new System.Drawing.Point(287, 267);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 21);
            this.tbSalario.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(125, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Salário:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(564, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 59);
            this.button1.TabIndex = 75;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(346, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 59);
            this.button2.TabIndex = 76;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(920, 542);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFuncao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmailf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTelefonef);
            this.Controls.Add(this.tbDataf);
            this.Controls.Add(this.tbCEPf);
            this.Controls.Add(this.tbCPFf);
            this.Controls.Add(this.tbNomef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInsertf);
            this.Controls.Add(this.labelFName);
            this.Name = "CadastroFuncionarios";
            this.Text = "Cadastro de funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbEmailf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbTelefonef;
        private System.Windows.Forms.MaskedTextBox tbDataf;
        private System.Windows.Forms.MaskedTextBox tbCEPf;
        private System.Windows.Forms.TextBox tbCPFf;
        private System.Windows.Forms.TextBox tbNomef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bInsertf;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox tbFuncao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
