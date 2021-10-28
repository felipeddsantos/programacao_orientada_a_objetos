/*

Programação Orientada a Objetos - Média Aritmética (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace MediaAritimetica{

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
            this.tb_Numero1 = new System.Windows.Forms.TextBox();
            this.tb_Numero2 = new System.Windows.Forms.TextBox();
            this.tb_MediaAritmetica = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Media aritmetica:";
            // 
            // tb_Numero1
            // 
            this.tb_Numero1.Location = new System.Drawing.Point(226, 28);
            this.tb_Numero1.Name = "tb_Numero1";
            this.tb_Numero1.Size = new System.Drawing.Size(100, 20);
            this.tb_Numero1.TabIndex = 3;
            // 
            // tb_Numero2
            // 
            this.tb_Numero2.Location = new System.Drawing.Point(226, 79);
            this.tb_Numero2.Name = "tb_Numero2";
            this.tb_Numero2.Size = new System.Drawing.Size(100, 20);
            this.tb_Numero2.TabIndex = 4;
            // 
            // tb_MediaAritmetica
            // 
            this.tb_MediaAritmetica.Location = new System.Drawing.Point(226, 184);
            this.tb_MediaAritmetica.Name = "tb_MediaAritmetica";
            this.tb_MediaAritmetica.Size = new System.Drawing.Size(100, 20);
            this.tb_MediaAritmetica.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(656, 366);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_OK_MouseClick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tb_MediaAritmetica);
            this.Controls.Add(this.tb_Numero2);
            this.Controls.Add(this.tb_Numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Interface";
            this.Text = "Media aritmetica";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Numero1;
        private System.Windows.Forms.TextBox tb_Numero2;
        private System.Windows.Forms.TextBox tb_MediaAritmetica;
        private System.Windows.Forms.Button button_OK;
    }
}
