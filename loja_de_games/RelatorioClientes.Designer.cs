/*

Programação Orientada a Objetos - Loja de Games (Interface Relatório de Clientes)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class RelatorioClientes{

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbFiltro1 = new System.Windows.Forms.TextBox();
            this.bAtualizar1 = new System.Windows.Forms.Button();
            this.btFiltro1 = new System.Windows.Forms.Button();
            this.rbCPF1 = new System.Windows.Forms.RadioButton();
            this.rbNome1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeletar1 = new System.Windows.Forms.Button();
            this.btProcurar1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFiltro1
            // 
            this.tbFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFiltro1.Location = new System.Drawing.Point(318, 82);
            this.tbFiltro1.Name = "tbFiltro1";
            this.tbFiltro1.Size = new System.Drawing.Size(141, 21);
            this.tbFiltro1.TabIndex = 17;
            // 
            // bAtualizar1
            // 
            this.bAtualizar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAtualizar1.Location = new System.Drawing.Point(386, 387);
            this.bAtualizar1.Name = "bAtualizar1";
            this.bAtualizar1.Size = new System.Drawing.Size(129, 58);
            this.bAtualizar1.TabIndex = 16;
            this.bAtualizar1.Text = "Editar";
            this.bAtualizar1.UseVisualStyleBackColor = true;
            this.bAtualizar1.Click += new System.EventHandler(this.bAtualizar1_Click);
            // 
            // btFiltro1
            // 
            this.btFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btFiltro1.Location = new System.Drawing.Point(528, 64);
            this.btFiltro1.Name = "btFiltro1";
            this.btFiltro1.Size = new System.Drawing.Size(115, 57);
            this.btFiltro1.TabIndex = 15;
            this.btFiltro1.Text = "Procurar";
            this.btFiltro1.UseVisualStyleBackColor = true;
            this.btFiltro1.Click += new System.EventHandler(this.btFiltro1_Click);
            // 
            // rbCPF1
            // 
            this.rbCPF1.AutoSize = true;
            this.rbCPF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCPF1.Location = new System.Drawing.Point(208, 105);
            this.rbCPF1.Name = "rbCPF1";
            this.rbCPF1.Size = new System.Drawing.Size(58, 24);
            this.rbCPF1.TabIndex = 14;
            this.rbCPF1.TabStop = true;
            this.rbCPF1.Text = "CPF";
            this.rbCPF1.UseVisualStyleBackColor = true;
            // 
            // rbNome1
            // 
            this.rbNome1.AutoSize = true;
            this.rbNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbNome1.Location = new System.Drawing.Point(208, 53);
            this.rbNome1.Name = "rbNome1";
            this.rbNome1.Size = new System.Drawing.Size(69, 24);
            this.rbNome1.TabIndex = 13;
            this.rbNome1.TabStop = true;
            this.rbNome1.Text = "Nome";
            this.rbNome1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Procurar cliente por:";
            // 
            // btDeletar1
            // 
            this.btDeletar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDeletar1.Location = new System.Drawing.Point(208, 387);
            this.btDeletar1.Name = "btDeletar1";
            this.btDeletar1.Size = new System.Drawing.Size(119, 58);
            this.btDeletar1.TabIndex = 11;
            this.btDeletar1.Text = "Deletar";
            this.btDeletar1.UseVisualStyleBackColor = true;
            this.btDeletar1.Click += new System.EventHandler(this.btDeletar1_Click);
            // 
            // btProcurar1
            // 
            this.btProcurar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btProcurar1.Location = new System.Drawing.Point(31, 387);
            this.btProcurar1.Name = "btProcurar1";
            this.btProcurar1.Size = new System.Drawing.Size(127, 58);
            this.btProcurar1.TabIndex = 10;
            this.btProcurar1.Text = "Exibir Tudo";
            this.btProcurar1.UseVisualStyleBackColor = true;
            this.btProcurar1.Click += new System.EventHandler(this.btProcurar1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Título,
            this.Código,
            this.Publicação,
            this.Editora,
            this.Preço,
            this.Quantidade});
            this.dataGridView2.Location = new System.Drawing.Point(66, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Título
            // 
            this.Título.HeaderText = "Nome";
            this.Título.Name = "Título";
            // 
            // Código
            // 
            this.Código.HeaderText = "CPF";
            this.Código.Name = "Código";
            // 
            // Publicação
            // 
            this.Publicação.HeaderText = "Data de Nascimento";
            this.Publicação.Name = "Publicação";
            // 
            // Editora
            // 
            this.Editora.HeaderText = "CEP";
            this.Editora.Name = "Editora";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Telefone";
            this.Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Email";
            this.Quantidade.Name = "Quantidade";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(738, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(568, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(893, 535);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFiltro1);
            this.Controls.Add(this.bAtualizar1);
            this.Controls.Add(this.btFiltro1);
            this.Controls.Add(this.rbCPF1);
            this.Controls.Add(this.rbNome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeletar1);
            this.Controls.Add(this.btProcurar1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "RelatorioClientes";
            this.Text = "Consulta de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFiltro1;
        private System.Windows.Forms.Button bAtualizar1;
        private System.Windows.Forms.Button btFiltro1;
        private System.Windows.Forms.RadioButton rbCPF1;
        private System.Windows.Forms.RadioButton rbNome1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeletar1;
        private System.Windows.Forms.Button btProcurar1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
