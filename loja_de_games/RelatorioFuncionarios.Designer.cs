/*

Programação Orientada a Objetos - Loja de Games (Interface Relatório de Funcionários)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class RelatorioFuncionários{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.tbFiltro2 = new System.Windows.Forms.TextBox();
            this.bAtualizar2 = new System.Windows.Forms.Button();
            this.btFiltro2 = new System.Windows.Forms.Button();
            this.rbCPF1 = new System.Windows.Forms.RadioButton();
            this.rbNome1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeletar2 = new System.Windows.Forms.Button();
            this.btProcurar2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFiltro2
            // 
            this.tbFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFiltro2.Location = new System.Drawing.Point(352, 80);
            this.tbFiltro2.Name = "tbFiltro2";
            this.tbFiltro2.Size = new System.Drawing.Size(130, 21);
            this.tbFiltro2.TabIndex = 26;
            // 
            // bAtualizar2
            // 
            this.bAtualizar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAtualizar2.Location = new System.Drawing.Point(384, 414);
            this.bAtualizar2.Name = "bAtualizar2";
            this.bAtualizar2.Size = new System.Drawing.Size(127, 58);
            this.bAtualizar2.TabIndex = 25;
            this.bAtualizar2.Text = "Editar";
            this.bAtualizar2.UseVisualStyleBackColor = true;
            this.bAtualizar2.Click += new System.EventHandler(this.bAtualizar2_Click);
            // 
            // btFiltro2
            // 
            this.btFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btFiltro2.Location = new System.Drawing.Point(565, 63);
            this.btFiltro2.Name = "btFiltro2";
            this.btFiltro2.Size = new System.Drawing.Size(120, 53);
            this.btFiltro2.TabIndex = 24;
            this.btFiltro2.Text = "Procurar";
            this.btFiltro2.UseVisualStyleBackColor = true;
            this.btFiltro2.Click += new System.EventHandler(this.btFiltro2_Click);
            // 
            // rbCPF1
            // 
            this.rbCPF1.AutoSize = true;
            this.rbCPF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCPF1.Location = new System.Drawing.Point(239, 104);
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
            this.rbNome1.Location = new System.Drawing.Point(239, 49);
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
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = " Procurar funcionário por:";
            // 
            // btDeletar2
            // 
            this.btDeletar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDeletar2.Location = new System.Drawing.Point(189, 414);
            this.btDeletar2.Name = "btDeletar2";
            this.btDeletar2.Size = new System.Drawing.Size(131, 58);
            this.btDeletar2.TabIndex = 20;
            this.btDeletar2.Text = "Deletar";
            this.btDeletar2.UseVisualStyleBackColor = true;
            this.btDeletar2.Click += new System.EventHandler(this.btDeletar2_Click);
            // 
            // btProcurar2
            // 
            this.btProcurar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btProcurar2.Location = new System.Drawing.Point(12, 414);
            this.btProcurar2.Name = "btProcurar2";
            this.btProcurar2.Size = new System.Drawing.Size(111, 58);
            this.btProcurar2.TabIndex = 19;
            this.btProcurar2.Text = "Exibir tudo";
            this.btProcurar2.UseVisualStyleBackColor = true;
            this.btProcurar2.Click += new System.EventHandler(this.btProcurar2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Título,
            this.Código,
            this.Publicação,
            this.Editora,
            this.Preço,
            this.Quantidade,
            this.Column1,
            this.Column2});
            this.dataGridView3.Location = new System.Drawing.Point(11, 185);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(904, 150);
            this.dataGridView3.TabIndex = 18;
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
            this.Publicação.HeaderText = "Data de nascimento";
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
            // Column1
            // 
            this.Column1.HeaderText = "Cargo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Salário";
            this.Column2.Name = "Column2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(769, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 58);
            this.button1.TabIndex = 27;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(579, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 58);
            this.button2.TabIndex = 28;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RelatorioFuncionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 543);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFiltro2);
            this.Controls.Add(this.bAtualizar2);
            this.Controls.Add(this.btFiltro2);
            this.Controls.Add(this.rbCPF1);
            this.Controls.Add(this.rbNome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeletar2);
            this.Controls.Add(this.btProcurar2);
            this.Controls.Add(this.dataGridView3);
            this.Name = "RelatorioFuncionários";
            this.Text = "Consulta de funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFiltro2;
        private System.Windows.Forms.Button bAtualizar2;
        private System.Windows.Forms.Button btFiltro2;
        private System.Windows.Forms.RadioButton rbCPF1;
        private System.Windows.Forms.RadioButton rbNome1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeletar2;
        private System.Windows.Forms.Button btProcurar2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
