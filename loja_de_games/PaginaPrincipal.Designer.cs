/*

Programação Orientada a Objetos - Loja de Games (Interface Página Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace LojaDeGames{

    partial class PaginaPrincipal{

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PáginaPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tclientes1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tfuncionarios1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlivros1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tclientes2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcompras = new System.Windows.Forms.ToolStripMenuItem();
            this.tnovidades = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tclientes1,
            this.tfuncionarios1,
            this.tlivros1});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(91, 25);
            this.fileMenu.Text = "Cadastros";
            // 
            // tclientes1
            // 
            this.tclientes1.ImageTransparentColor = System.Drawing.Color.Black;
            this.tclientes1.Name = "tclientes1";
            this.tclientes1.Size = new System.Drawing.Size(204, 26);
            this.tclientes1.Text = "Novo cliente";
            this.tclientes1.Click += new System.EventHandler(this.tclientes1_Click_1);
            // 
            // tfuncionarios1
            // 
            this.tfuncionarios1.ImageTransparentColor = System.Drawing.Color.Black;
            this.tfuncionarios1.Name = "tfuncionarios1";
            this.tfuncionarios1.Size = new System.Drawing.Size(204, 26);
            this.tfuncionarios1.Text = "Novo funcionário";
            this.tfuncionarios1.Click += new System.EventHandler(this.tfuncionarios1_Click);
            // 
            // tlivros1
            // 
            this.tlivros1.Name = "tlivros1";
            this.tlivros1.Size = new System.Drawing.Size(204, 26);
            this.tlivros1.Text = "Novo produto";
            this.tlivros1.Click += new System.EventHandler(this.tlivros1_Click_1);
            // 
            // tclientes2
            // 
            this.tclientes2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.tclientes2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tclientes2.Name = "tclientes2";
            this.tclientes2.Size = new System.Drawing.Size(90, 25);
            this.tclientes2.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // tcompras
            // 
            this.tcompras.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tcompras.Name = "tcompras";
            this.tcompras.Size = new System.Drawing.Size(85, 25);
            this.tcompras.Text = "Compras";
            this.tcompras.Click += new System.EventHandler(this.tcompras_Click);
            // 
            // tnovidades
            // 
            this.tnovidades.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tnovidades.Name = "tnovidades";
            this.tnovidades.Size = new System.Drawing.Size(193, 25);
            this.tnovidades.Text = "Sugestões para o cliente";
            this.tnovidades.Click += new System.EventHandler(this.tnovidades_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tclientes2,
            this.tcompras,
            this.tnovidades});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // PáginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PáginaPrincipal";
            this.Text = "Game Zone";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem tclientes1;
        private System.Windows.Forms.ToolStripMenuItem tfuncionarios1;
        private System.Windows.Forms.ToolStripMenuItem tlivros1;
        private System.Windows.Forms.ToolStripMenuItem tclientes2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcompras;
        private System.Windows.Forms.ToolStripMenuItem tnovidades;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}
