/*

Programação Orientada a Objetos - Loja de Games (Interface Cadastro de Clientes)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class CadastroClientes{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.labelFName = new System.Windows.Forms.Label();
            this.bInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb12 = new System.Windows.Forms.CheckBox();
            this.cb11 = new System.Windows.Forms.CheckBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb13 = new System.Windows.Forms.CheckBox();
            this.cb14 = new System.Windows.Forms.CheckBox();
            this.cb15 = new System.Windows.Forms.CheckBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.MaskedTextBox();
            this.tbData = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFName.Location = new System.Drawing.Point(92, 32);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(55, 20);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "Nome:";
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bInsert.Location = new System.Drawing.Point(96, 445);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(144, 59);
            this.bInsert.TabIndex = 7;
            this.bInsert.Text = "Realizar cadastro";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(92, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(92, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(92, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(92, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(91, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gêneros de preferência:";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb1.Location = new System.Drawing.Point(95, 289);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(65, 24);
            this.cb1.TabIndex = 16;
            this.cb1.Text = "Ação";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb9.Location = new System.Drawing.Point(377, 374);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(73, 24);
            this.cb9.TabIndex = 18;
            this.cb9.Text = "Horror";
            this.cb9.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb8.Location = new System.Drawing.Point(377, 332);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(59, 24);
            this.cb8.TabIndex = 19;
            this.cb8.Text = "FPS";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb7.Location = new System.Drawing.Point(377, 289);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(101, 24);
            this.cb7.TabIndex = 20;
            this.cb7.Text = "Estratégia";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb6.Location = new System.Drawing.Point(245, 374);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(84, 24);
            this.cb6.TabIndex = 21;
            this.cb6.Text = "Esporte";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb5.Location = new System.Drawing.Point(245, 332);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(79, 24);
            this.cb5.TabIndex = 22;
            this.cb5.Text = "Corrida";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb2.Location = new System.Drawing.Point(94, 332);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(79, 24);
            this.cb2.TabIndex = 23;
            this.cb2.Text = "Arcade";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb3.Location = new System.Drawing.Point(95, 374);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(92, 24);
            this.cb3.TabIndex = 24;
            this.cb3.Text = "Aventura";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb4.Location = new System.Drawing.Point(245, 289);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(77, 24);
            this.cb4.TabIndex = 25;
            this.cb4.Text = "Casual";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb12.Location = new System.Drawing.Point(516, 374);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(105, 24);
            this.cb12.TabIndex = 26;
            this.cb12.Text = "Plataforma";
            this.cb12.UseVisualStyleBackColor = true;
            // 
            // cb11
            // 
            this.cb11.AutoSize = true;
            this.cb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb11.Location = new System.Drawing.Point(516, 332);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(81, 24);
            this.cb11.TabIndex = 27;
            this.cb11.Text = "Musical";
            this.cb11.UseVisualStyleBackColor = true;
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb10.Location = new System.Drawing.Point(516, 289);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(60, 24);
            this.cb10.TabIndex = 28;
            this.cb10.Text = "Luta";
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // cb13
            // 
            this.cb13.AutoSize = true;
            this.cb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb13.Location = new System.Drawing.Point(655, 289);
            this.cb13.Name = "cb13";
            this.cb13.Size = new System.Drawing.Size(75, 24);
            this.cb13.TabIndex = 29;
            this.cb13.Text = "Puzzle";
            this.cb13.UseVisualStyleBackColor = true;
            // 
            // cb14
            // 
            this.cb14.AutoSize = true;
            this.cb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb14.Location = new System.Drawing.Point(655, 332);
            this.cb14.Name = "cb14";
            this.cb14.Size = new System.Drawing.Size(63, 24);
            this.cb14.TabIndex = 30;
            this.cb14.Text = "RPG";
            this.cb14.UseVisualStyleBackColor = true;
            // 
            // cb15
            // 
            this.cb15.AutoSize = true;
            this.cb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb15.Location = new System.Drawing.Point(655, 374);
            this.cb15.Name = "cb15";
            this.cb15.Size = new System.Drawing.Size(102, 24);
            this.cb15.TabIndex = 31;
            this.cb15.Text = "Simulação";
            this.cb15.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNome.Location = new System.Drawing.Point(254, 29);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 21);
            this.tbNome.TabIndex = 32;
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCPF.Location = new System.Drawing.Point(254, 62);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 21);
            this.tbCPF.TabIndex = 34;
            // 
            // tbCEP
            // 
            this.tbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCEP.Location = new System.Drawing.Point(254, 125);
            this.tbCEP.Mask = "00000-999";
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 21);
            this.tbCEP.TabIndex = 35;
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbData.Location = new System.Drawing.Point(254, 92);
            this.tbData.Mask = "00/00/0000";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 21);
            this.tbData.TabIndex = 36;
            this.tbData.ValidatingType = typeof(System.DateTime);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbTelefone.Location = new System.Drawing.Point(254, 155);
            this.tbTelefone.Mask = "(99) 0000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 21);
            this.tbTelefone.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(92, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEmail.Location = new System.Drawing.Point(254, 187);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 21);
            this.tbEmail.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(608, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 59);
            this.button1.TabIndex = 42;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(347, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 59);
            this.button2.TabIndex = 43;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 535);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.cb15);
            this.Controls.Add(this.cb14);
            this.Controls.Add(this.cb13);
            this.Controls.Add(this.cb10);
            this.Controls.Add(this.cb11);
            this.Controls.Add(this.cb12);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb8);
            this.Controls.Add(this.cb9);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.labelFName);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroClientes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb9;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb12;
        private System.Windows.Forms.CheckBox cb11;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.CheckBox cb13;
        private System.Windows.Forms.CheckBox cb14;
        private System.Windows.Forms.CheckBox cb15;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.MaskedTextBox tbCEP;
        private System.Windows.Forms.MaskedTextBox tbData;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
