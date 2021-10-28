/*

Programação Orientada a Objetos - Loja de Games (Interface Relatório de Jogos)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class RelatorioJogos{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
                   
            base.Dispose(disposing);
        }
        
        private void InitializeComponent(){
        
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBusca = new System.Windows.Forms.Button();
            this.bDeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCódigo = new System.Windows.Forms.RadioButton();
            this.bProcurar = new System.Windows.Forms.Button();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Título,
            this.Código,
            this.Publicação,
            this.Editora,
            this.Preço,
            this.Quantidade,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(22, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Publicação
            // 
            this.Publicação.HeaderText = "Plataforma";
            this.Publicação.Name = "Publicação";
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Gênero";
            this.Editora.Name = "Editora";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Desenvolvedora";
            this.Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Preço";
            this.Quantidade.Name = "Quantidade";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantidade";
            this.Column1.Name = "Column1";
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBusca.Location = new System.Drawing.Point(22, 406);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(116, 53);
            this.btBusca.TabIndex = 1;
            this.btBusca.Text = "Exibir tudo";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // bDeletar
            // 
            this.bDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bDeletar.Location = new System.Drawing.Point(199, 406);
            this.bDeletar.Name = "bDeletar";
            this.bDeletar.Size = new System.Drawing.Size(122, 53);
            this.bDeletar.TabIndex = 2;
            this.bDeletar.Text = "Deletar";
            this.bDeletar.UseVisualStyleBackColor = true;
            this.bDeletar.Click += new System.EventHandler(this.bDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procurar produto por:";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbNome.Location = new System.Drawing.Point(226, 43);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(65, 24);
            this.rbNome.TabIndex = 4;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Título";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCódigo
            // 
            this.rbCódigo.AutoSize = true;
            this.rbCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCódigo.Location = new System.Drawing.Point(226, 99);
            this.rbCódigo.Name = "rbCódigo";
            this.rbCódigo.Size = new System.Drawing.Size(77, 24);
            this.rbCódigo.TabIndex = 5;
            this.rbCódigo.TabStop = true;
            this.rbCódigo.Text = "Código";
            this.rbCódigo.UseVisualStyleBackColor = true;
            // 
            // bProcurar
            // 
            this.bProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bProcurar.Location = new System.Drawing.Point(569, 57);
            this.bProcurar.Name = "bProcurar";
            this.bProcurar.Size = new System.Drawing.Size(123, 53);
            this.bProcurar.TabIndex = 6;
            this.bProcurar.Text = "Procurar";
            this.bProcurar.UseVisualStyleBackColor = true;
            this.bProcurar.Click += new System.EventHandler(this.bProcurar_Click);
            // 
            // bAtualizar
            // 
            this.bAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAtualizar.Location = new System.Drawing.Point(394, 406);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(117, 53);
            this.bAtualizar.TabIndex = 7;
            this.bAtualizar.Text = "Editar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFiltro.Location = new System.Drawing.Point(366, 74);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(119, 21);
            this.tbFiltro.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(752, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(578, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RelatórioJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(918, 508);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.bAtualizar);
            this.Controls.Add(this.bProcurar);
            this.Controls.Add(this.rbCódigo);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeletar);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelatorioJogos";
            this.Text = "Consulta de produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Button bDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCódigo;
        private System.Windows.Forms.Button bProcurar;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.TextBox tbFiltro;
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
