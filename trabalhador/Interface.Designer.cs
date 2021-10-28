/*

Programação Orientada a Objetos - Trabalhador (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace Trabalhador{

    partial class Interface{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbPrecoHora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lRelatorio = new System.Windows.Forms.Label();
            this.bRelatorio = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 442);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbHoras);
            this.tabPage1.Controls.Add(this.tbPrecoHora);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbSalario);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btCadastro);
            this.tabPage1.Controls.Add(this.tbCPF);
            this.tabPage1.Controls.Add(this.tbEndereco);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbHoras
            // 
            this.tbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoras.Location = new System.Drawing.Point(175, 284);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 22);
            this.tbHoras.TabIndex = 13;
            // 
            // tbPrecoHora
            // 
            this.tbPrecoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoHora.Location = new System.Drawing.Point(437, 284);
            this.tbPrecoHora.Name = "tbPrecoHora";
            this.tbPrecoHora.Size = new System.Drawing.Size(100, 22);
            this.tbPrecoHora.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Horas trabalhadas:";
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalario.Location = new System.Drawing.Point(89, 206);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 22);
            this.tbSalario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salário:";
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(204, 351);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(300, 30);
            this.btCadastro.TabIndex = 7;
            this.btCadastro.Text = "Registrar";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(82, 98);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 22);
            this.tbCPF.TabIndex = 6;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(109, 149);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(100, 22);
            this.tbEndereco.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(82, 42);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 22);
            this.tbNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHorista);
            this.groupBox1.Controls.Add(this.rbCLT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(526, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de trabalhador:";
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(47, 142);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(69, 20);
            this.rbHorista.TabIndex = 1;
            this.rbHorista.TabStop = true;
            this.rbHorista.Text = "Horista";
            this.rbHorista.UseVisualStyleBackColor = true;
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(47, 59);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(51, 20);
            this.rbCLT.TabIndex = 0;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btLimpar);
            this.tabPage2.Controls.Add(this.lRelatorio);
            this.tabPage2.Controls.Add(this.bRelatorio);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lRelatorio
            // 
            this.lRelatorio.AutoSize = true;
            this.lRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRelatorio.Location = new System.Drawing.Point(23, 124);
            this.lRelatorio.Name = "lRelatorio";
            this.lRelatorio.Size = new System.Drawing.Size(0, 15);
            this.lRelatorio.TabIndex = 1;
            // 
            // bRelatorio
            // 
            this.bRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio.Location = new System.Drawing.Point(101, 20);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(500, 50);
            this.bRelatorio.TabIndex = 0;
            this.bRelatorio.Text = "Gerar relatório";
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(646, 354);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 35);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbPrecoHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.Label lRelatorio;
        private System.Windows.Forms.Button btLimpar;
    }
}
