/*

Programação Orientada a Objetos - Registro Aluno II (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace RegistroAluno{

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
            this.tbperiodo1 = new System.Windows.Forms.TextBox();
            this.tbmatricula1 = new System.Windows.Forms.TextBox();
            this.tbaluno1 = new System.Windows.Forms.TextBox();
            this.periodo1 = new System.Windows.Forms.Label();
            this.matricula1 = new System.Windows.Forms.Label();
            this.nome1 = new System.Windows.Forms.Label();
            this.bcadastrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bcadastrar2 = new System.Windows.Forms.Button();
            this.tbnome2 = new System.Windows.Forms.TextBox();
            this.tbcodigo1 = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.Label();
            this.codigo1 = new System.Windows.Forms.Label();
            this.lista1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.brelatorio = new System.Windows.Forms.Button();
            this.tbnome3 = new System.Windows.Forms.TextBox();
            this.nome3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbnomealuno = new System.Windows.Forms.TextBox();
            this.tbnomemateria = new System.Windows.Forms.TextBox();
            this.nomealuno = new System.Windows.Forms.Label();
            this.nomemateria = new System.Windows.Forms.Label();
            this.bassociar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.lista1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.lista1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbperiodo1);
            this.tabPage1.Controls.Add(this.tbmatricula1);
            this.tabPage1.Controls.Add(this.tbaluno1);
            this.tabPage1.Controls.Add(this.periodo1);
            this.tabPage1.Controls.Add(this.matricula1);
            this.tabPage1.Controls.Add(this.nome1);
            this.tabPage1.Controls.Add(this.bcadastrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbperiodo1
            // 
            this.tbperiodo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbperiodo1.Location = new System.Drawing.Point(129, 265);
            this.tbperiodo1.Name = "tbperiodo1";
            this.tbperiodo1.Size = new System.Drawing.Size(100, 26);
            this.tbperiodo1.TabIndex = 6;
            // 
            // tbmatricula1
            // 
            this.tbmatricula1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmatricula1.Location = new System.Drawing.Point(129, 156);
            this.tbmatricula1.Name = "tbmatricula1";
            this.tbmatricula1.Size = new System.Drawing.Size(100, 26);
            this.tbmatricula1.TabIndex = 5;
            // 
            // tbaluno1
            // 
            this.tbaluno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaluno1.Location = new System.Drawing.Point(129, 51);
            this.tbaluno1.Name = "tbaluno1";
            this.tbaluno1.Size = new System.Drawing.Size(100, 26);
            this.tbaluno1.TabIndex = 4;
            // 
            // periodo1
            // 
            this.periodo1.AutoSize = true;
            this.periodo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodo1.Location = new System.Drawing.Point(25, 261);
            this.periodo1.Name = "periodo1";
            this.periodo1.Size = new System.Drawing.Size(81, 24);
            this.periodo1.TabIndex = 3;
            this.periodo1.Text = "Período:";
            // 
            // matricula1
            // 
            this.matricula1.AutoSize = true;
            this.matricula1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula1.Location = new System.Drawing.Point(25, 152);
            this.matricula1.Name = "matricula1";
            this.matricula1.Size = new System.Drawing.Size(90, 24);
            this.matricula1.TabIndex = 2;
            this.matricula1.Text = "Matrícula:";
            // 
            // nome1
            // 
            this.nome1.AutoSize = true;
            this.nome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome1.Location = new System.Drawing.Point(25, 47);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(67, 24);
            this.nome1.TabIndex = 1;
            this.nome1.Text = "Nome:";
            // 
            // bcadastrar
            // 
            this.bcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcadastrar.Location = new System.Drawing.Point(617, 352);
            this.bcadastrar.Name = "bcadastrar";
            this.bcadastrar.Size = new System.Drawing.Size(130, 34);
            this.bcadastrar.TabIndex = 0;
            this.bcadastrar.Text = "Cadastrar";
            this.bcadastrar.UseVisualStyleBackColor = true;
            this.bcadastrar.Click += new System.EventHandler(this.bcadastrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bcadastrar2);
            this.tabPage2.Controls.Add(this.tbnome2);
            this.tabPage2.Controls.Add(this.tbcodigo1);
            this.tabPage2.Controls.Add(this.nome2);
            this.tabPage2.Controls.Add(this.codigo1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matéria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bcadastrar2
            // 
            this.bcadastrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcadastrar2.Location = new System.Drawing.Point(597, 347);
            this.bcadastrar2.Name = "bcadastrar2";
            this.bcadastrar2.Size = new System.Drawing.Size(130, 34);
            this.bcadastrar2.TabIndex = 7;
            this.bcadastrar2.Text = "Cadastrar";
            this.bcadastrar2.UseVisualStyleBackColor = true;
            this.bcadastrar2.Click += new System.EventHandler(this.bcadastrar2_Click);
            // 
            // tbnome2
            // 
            this.tbnome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnome2.Location = new System.Drawing.Point(129, 63);
            this.tbnome2.Name = "tbnome2";
            this.tbnome2.Size = new System.Drawing.Size(100, 26);
            this.tbnome2.TabIndex = 6;
            // 
            // tbcodigo1
            // 
            this.tbcodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo1.Location = new System.Drawing.Point(129, 183);
            this.tbcodigo1.Name = "tbcodigo1";
            this.tbcodigo1.Size = new System.Drawing.Size(100, 26);
            this.tbcodigo1.TabIndex = 5;
            // 
            // nome2
            // 
            this.nome2.AutoSize = true;
            this.nome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome2.Location = new System.Drawing.Point(21, 59);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(67, 24);
            this.nome2.TabIndex = 3;
            this.nome2.Text = "Nome:";
            // 
            // codigo1
            // 
            this.codigo1.AutoSize = true;
            this.codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo1.Location = new System.Drawing.Point(21, 179);
            this.codigo1.Name = "codigo1";
            this.codigo1.Size = new System.Drawing.Size(76, 24);
            this.codigo1.TabIndex = 2;
            this.codigo1.Text = "Código:";
            // 
            // lista1
            // 
            this.lista1.Controls.Add(this.label1);
            this.lista1.Controls.Add(this.label9);
            this.lista1.Controls.Add(this.brelatorio);
            this.lista1.Controls.Add(this.tbnome3);
            this.lista1.Controls.Add(this.nome3);
            this.lista1.Location = new System.Drawing.Point(4, 22);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(797, 429);
            this.lista1.TabIndex = 2;
            this.lista1.Text = "Relatório";
            this.lista1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 17;
            // 
            // brelatorio
            // 
            this.brelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brelatorio.Location = new System.Drawing.Point(605, 351);
            this.brelatorio.Name = "brelatorio";
            this.brelatorio.Size = new System.Drawing.Size(130, 34);
            this.brelatorio.TabIndex = 8;
            this.brelatorio.Text = "Relatório";
            this.brelatorio.UseVisualStyleBackColor = true;
            this.brelatorio.Click += new System.EventHandler(this.brelatorio_Click);
            // 
            // tbnome3
            // 
            this.tbnome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnome3.Location = new System.Drawing.Point(126, 69);
            this.tbnome3.Name = "tbnome3";
            this.tbnome3.Size = new System.Drawing.Size(100, 26);
            this.tbnome3.TabIndex = 7;
            // 
            // nome3
            // 
            this.nome3.AutoSize = true;
            this.nome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome3.Location = new System.Drawing.Point(20, 65);
            this.nome3.Name = "nome3";
            this.nome3.Size = new System.Drawing.Size(67, 24);
            this.nome3.TabIndex = 4;
            this.nome3.Text = "Nome:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbnomealuno);
            this.tabPage4.Controls.Add(this.tbnomemateria);
            this.tabPage4.Controls.Add(this.nomealuno);
            this.tabPage4.Controls.Add(this.nomemateria);
            this.tabPage4.Controls.Add(this.bassociar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(797, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Associar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbnomealuno
            // 
            this.tbnomealuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnomealuno.Location = new System.Drawing.Point(201, 60);
            this.tbnomealuno.Name = "tbnomealuno";
            this.tbnomealuno.Size = new System.Drawing.Size(100, 26);
            this.tbnomealuno.TabIndex = 12;
            // 
            // tbnomemateria
            // 
            this.tbnomemateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnomemateria.Location = new System.Drawing.Point(201, 170);
            this.tbnomemateria.Name = "tbnomemateria";
            this.tbnomemateria.Size = new System.Drawing.Size(100, 26);
            this.tbnomemateria.TabIndex = 11;
            // 
            // nomealuno
            // 
            this.nomealuno.AutoSize = true;
            this.nomealuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomealuno.Location = new System.Drawing.Point(19, 56);
            this.nomealuno.Name = "nomealuno";
            this.nomealuno.Size = new System.Drawing.Size(149, 24);
            this.nomealuno.TabIndex = 10;
            this.nomealuno.Text = "Nome do aluno:";
            // 
            // nomemateria
            // 
            this.nomemateria.AutoSize = true;
            this.nomemateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomemateria.Location = new System.Drawing.Point(19, 166);
            this.nomemateria.Name = "nomemateria";
            this.nomemateria.Size = new System.Drawing.Size(159, 24);
            this.nomemateria.TabIndex = 9;
            this.nomemateria.Text = "Nome da matéria:";
            // 
            // bassociar
            // 
            this.bassociar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bassociar.Location = new System.Drawing.Point(610, 358);
            this.bassociar.Name = "bassociar";
            this.bassociar.Size = new System.Drawing.Size(130, 34);
            this.bassociar.TabIndex = 8;
            this.bassociar.Text = "Associar";
            this.bassociar.UseVisualStyleBackColor = true;
            this.bassociar.Click += new System.EventHandler(this.bassociar_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Interface";
            this.Text = "Aluno/Materia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.lista1.ResumeLayout(false);
            this.lista1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbperiodo1;
        private System.Windows.Forms.TextBox tbmatricula1;
        private System.Windows.Forms.TextBox tbaluno1;
        private System.Windows.Forms.Label periodo1;
        private System.Windows.Forms.Label matricula1;
        private System.Windows.Forms.Label nome1;
        private System.Windows.Forms.Button bcadastrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bcadastrar2;
        private System.Windows.Forms.TextBox tbnome2;
        private System.Windows.Forms.TextBox tbcodigo1;
        private System.Windows.Forms.Label nome2;
        private System.Windows.Forms.Label codigo1;
        private System.Windows.Forms.TabPage lista1;
        private System.Windows.Forms.Button brelatorio;
        private System.Windows.Forms.TextBox tbnome3;
        private System.Windows.Forms.Label nome3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbnomealuno;
        private System.Windows.Forms.TextBox tbnomemateria;
        private System.Windows.Forms.Label nomealuno;
        private System.Windows.Forms.Label nomemateria;
        private System.Windows.Forms.Button bassociar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
