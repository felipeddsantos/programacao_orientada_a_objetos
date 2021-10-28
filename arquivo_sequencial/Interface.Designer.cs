/*

Programação Orientada a Objetos - Arquivo Sequencial (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace ArquivoSequencial{

    partial class Interface{

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.tbPrimeiroNome = new System.Windows.Forms.TextBox();
            this.tbUltimoNome = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.btCriarArquivo = new System.Windows.Forms.Button();
            this.btGravarRegistro = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btAbrirArquivo = new System.Windows.Forms.Button();
            this.btProximoRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Último nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(195, 55);
            this.tbConta.Margin = new System.Windows.Forms.Padding(4);
            this.tbConta.Name = "tbConta";
            this.tbConta.Size = new System.Drawing.Size(239, 22);
            this.tbConta.TabIndex = 4;
            // 
            // tbPrimeiroNome
            // 
            this.tbPrimeiroNome.Location = new System.Drawing.Point(195, 107);
            this.tbPrimeiroNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrimeiroNome.Name = "tbPrimeiroNome";
            this.tbPrimeiroNome.Size = new System.Drawing.Size(239, 22);
            this.tbPrimeiroNome.TabIndex = 5;
            // 
            // tbUltimoNome
            // 
            this.tbUltimoNome.Location = new System.Drawing.Point(195, 165);
            this.tbUltimoNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbUltimoNome.Name = "tbUltimoNome";
            this.tbUltimoNome.Size = new System.Drawing.Size(239, 22);
            this.tbUltimoNome.TabIndex = 6;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(195, 225);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(239, 22);
            this.tbSaldo.TabIndex = 7;
            // 
            // btCriarArquivo
            // 
            this.btCriarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarArquivo.Location = new System.Drawing.Point(21, 264);
            this.btCriarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btCriarArquivo.Name = "btCriarArquivo";
            this.btCriarArquivo.Size = new System.Drawing.Size(109, 78);
            this.btCriarArquivo.TabIndex = 8;
            this.btCriarArquivo.Text = "Criar arquivo";
            this.btCriarArquivo.UseVisualStyleBackColor = true;
            this.btCriarArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCriarArquivo_MouseClick);
            // 
            // btGravarRegistro
            // 
            this.btGravarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarRegistro.Location = new System.Drawing.Point(173, 264);
            this.btGravarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btGravarRegistro.Name = "btGravarRegistro";
            this.btGravarRegistro.Size = new System.Drawing.Size(117, 78);
            this.btGravarRegistro.TabIndex = 9;
            this.btGravarRegistro.Text = "Gravar Registro";
            this.btGravarRegistro.UseVisualStyleBackColor = true;
            this.btGravarRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGravarRegistro_MouseClick);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(333, 264);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 78);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Fechar arquivo";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSair_MouseClick);
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.AutoEllipsis = true;
            this.btAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirArquivo.Location = new System.Drawing.Point(108, 349);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(101, 76);
            this.btAbrirArquivo.TabIndex = 11;
            this.btAbrirArquivo.Text = "Abrir arquivo";
            this.btAbrirArquivo.UseVisualStyleBackColor = true;
            this.btAbrirArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAbrirArquivo_MouseClick);
            // 
            // btProximoRegistro
            // 
            this.btProximoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoRegistro.Location = new System.Drawing.Point(264, 349);
            this.btProximoRegistro.Name = "btProximoRegistro";
            this.btProximoRegistro.Size = new System.Drawing.Size(104, 76);
            this.btProximoRegistro.TabIndex = 12;
            this.btProximoRegistro.Text = "Próximo registro";
            this.btProximoRegistro.UseVisualStyleBackColor = true;
            this.btProximoRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btProximoRegistro_MouseClick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 437);
            this.Controls.Add(this.btProximoRegistro);
            this.Controls.Add(this.btAbrirArquivo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGravarRegistro);
            this.Controls.Add(this.btCriarArquivo);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbUltimoNome);
            this.Controls.Add(this.tbPrimeiroNome);
            this.Controls.Add(this.tbConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Interface";
            this.Text = "Gerenciador de contas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConta;
        private System.Windows.Forms.TextBox tbPrimeiroNome;
        private System.Windows.Forms.TextBox tbUltimoNome;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Button btCriarArquivo;
        private System.Windows.Forms.Button btGravarRegistro;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAbrirArquivo;
        private System.Windows.Forms.Button btProximoRegistro;
    }
}
