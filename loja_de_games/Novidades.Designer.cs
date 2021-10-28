/*

Programação Orientada a Objetos - Loja de Games (Interface Novidades)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class Novidades{    

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbFiltro4 = new System.Windows.Forms.TextBox();
            this.btFiltro4 = new System.Windows.Forms.Button();
            this.rbCPF1 = new System.Windows.Forms.RadioButton();
            this.rbNome1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFiltro4
            // 
            this.tbFiltro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFiltro4.Location = new System.Drawing.Point(373, 85);
            this.tbFiltro4.Name = "tbFiltro4";
            this.tbFiltro4.Size = new System.Drawing.Size(137, 21);
            this.tbFiltro4.TabIndex = 26;
            // 
            // btFiltro4
            // 
            this.btFiltro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btFiltro4.Location = new System.Drawing.Point(576, 65);
            this.btFiltro4.Name = "btFiltro4";
            this.btFiltro4.Size = new System.Drawing.Size(121, 59);
            this.btFiltro4.TabIndex = 24;
            this.btFiltro4.Text = "Procurar";
            this.btFiltro4.UseVisualStyleBackColor = true;
            this.btFiltro4.Click += new System.EventHandler(this.btFiltro4_Click);
            // 
            // rbCPF1
            // 
            this.rbCPF1.AutoSize = true;
            this.rbCPF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCPF1.Location = new System.Drawing.Point(250, 121);
            this.rbCPF1.Name = "rbCPF1";
            this.rbCPF1.Size = new System.Drawing.Size(58, 24);
            this.rbCPF1.TabIndex = 23;
            this.rbCPF1.TabStop = true;
            this.rbCPF1.Text = "CPF";
            this.rbCPF1.UseVisualStyleBackColor = true;
            // 
            // rbNome1
            // 
            this.rbNome1.AutoSize = true;
            this.rbNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbNome1.Location = new System.Drawing.Point(250, 52);
            this.rbNome1.Name = "rbNome1";
            this.rbNome1.Size = new System.Drawing.Size(69, 24);
            this.rbNome1.TabIndex = 22;
            this.rbNome1.TabStop = true;
            this.rbNome1.Text = "Nome";
            this.rbNome1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(71, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Procurar cliente por:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Título,
            this.Código,
            this.Publicação,
            this.Editora,
            this.Preço,
            this.Quantidade,
            this.Column1});
            this.dataGridView4.Location = new System.Drawing.Point(29, 183);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(843, 150);
            this.dataGridView4.TabIndex = 18;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Publicação
            // 
            this.Publicação.HeaderText = "Plataforma";
            this.Publicação.Name = "Publicação";
            this.Publicação.ReadOnly = true;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Gênero";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Desenvolvedora";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Preço";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantidade Disponível";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(530, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 70);
            this.button1.TabIndex = 27;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(218, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 70);
            this.button2.TabIndex = 28;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Novidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(909, 520);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFiltro4);
            this.Controls.Add(this.btFiltro4);
            this.Controls.Add(this.rbCPF1);
            this.Controls.Add(this.rbNome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Novidades";
            this.Text = "Preferências do cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFiltro4;
        private System.Windows.Forms.Button btFiltro4;
        private System.Windows.Forms.RadioButton rbCPF1;
        private System.Windows.Forms.RadioButton rbNome1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
