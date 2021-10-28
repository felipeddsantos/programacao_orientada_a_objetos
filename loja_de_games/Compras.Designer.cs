/*

Programação Orientada a Objetos - Loja de Games (Interface Compras)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class Compras{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.button123 = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.bProcurar12 = new System.Windows.Forms.Button();
            this.rbCódigo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btBusca12 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button48 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.button145 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // button123
            // 
            this.button123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button123.Location = new System.Drawing.Point(265, 389);
            this.button123.Name = "button123";
            this.button123.Size = new System.Drawing.Size(133, 72);
            this.button123.TabIndex = 19;
            this.button123.Text = "Sair";
            this.button123.UseVisualStyleBackColor = true;
            this.button123.Click += new System.EventHandler(this.button123_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFiltro.Location = new System.Drawing.Point(353, 71);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(133, 21);
            this.tbFiltro.TabIndex = 18;
            // 
            // bProcurar12
            // 
            this.bProcurar12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bProcurar12.Location = new System.Drawing.Point(557, 54);
            this.bProcurar12.Name = "bProcurar12";
            this.bProcurar12.Size = new System.Drawing.Size(125, 57);
            this.bProcurar12.TabIndex = 16;
            this.bProcurar12.Text = "Procurar";
            this.bProcurar12.UseVisualStyleBackColor = true;
            this.bProcurar12.Click += new System.EventHandler(this.bProcurar12_Click);
            // 
            // rbCódigo
            // 
            this.rbCódigo.AutoSize = true;
            this.rbCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCódigo.Location = new System.Drawing.Point(233, 96);
            this.rbCódigo.Name = "rbCódigo";
            this.rbCódigo.Size = new System.Drawing.Size(77, 24);
            this.rbCódigo.TabIndex = 15;
            this.rbCódigo.TabStop = true;
            this.rbCódigo.Text = "Código";
            this.rbCódigo.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbNome.Location = new System.Drawing.Point(233, 44);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(65, 24);
            this.rbNome.TabIndex = 14;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Título";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Procurar produto por:";
            // 
            // btBusca12
            // 
            this.btBusca12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBusca12.Location = new System.Drawing.Point(29, 389);
            this.btBusca12.Name = "btBusca12";
            this.btBusca12.Size = new System.Drawing.Size(155, 72);
            this.btBusca12.TabIndex = 11;
            this.btBusca12.Text = "Exibir tudo";
            this.btBusca12.UseVisualStyleBackColor = true;
            this.btBusca12.Click += new System.EventHandler(this.btBusca12_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Título,
            this.Código,
            this.Publicação,
            this.Editora,
            this.Preço,
            this.Quantidade,
            this.Column1});
            this.dataGridView6.Location = new System.Drawing.Point(29, 158);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(840, 172);
            this.dataGridView6.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(592, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total:";
            // 
            // button48
            // 
            this.button48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button48.Location = new System.Drawing.Point(596, 421);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(161, 37);
            this.button48.TabIndex = 21;
            this.button48.Text = "Adicionar ao carrinho";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button31.Location = new System.Drawing.Point(596, 507);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(161, 37);
            this.button31.TabIndex = 23;
            this.button31.Text = "Finalizar compra";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Total.Location = new System.Drawing.Point(657, 373);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 21);
            this.Total.TabIndex = 24;
            // 
            // button145
            // 
            this.button145.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button145.Location = new System.Drawing.Point(596, 464);
            this.button145.Name = "button145";
            this.button145.Size = new System.Drawing.Size(161, 37);
            this.button145.TabIndex = 25;
            this.button145.Text = "Cancelar compra";
            this.button145.UseVisualStyleBackColor = true;
            this.button145.Click += new System.EventHandler(this.button145_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(894, 545);
            this.ControlBox = false;
            this.Controls.Add(this.button145);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button123);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.bProcurar12);
            this.Controls.Add(this.rbCódigo);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBusca12);
            this.Controls.Add(this.dataGridView6);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button123;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button bProcurar12;
        private System.Windows.Forms.RadioButton rbCódigo;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBusca12;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button145;
    }
}
