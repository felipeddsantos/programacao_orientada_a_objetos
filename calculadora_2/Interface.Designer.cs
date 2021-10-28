/*

Programação Orientada a Objetos - Calculadora II (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace Calculadora2{

    partial class Interface{
    
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.btmais = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.bdivisao = new System.Windows.Forms.Button();
            this.bproduto = new System.Windows.Forms.Button();
            this.bmenos = new System.Windows.Forms.Button();
            this.blimpar = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bpotencia = new System.Windows.Forms.Button();
            this.braiz = new System.Windows.Forms.Button();
            this.be = new System.Windows.Forms.Button();
            this.bpi = new System.Windows.Forms.Button();
            this.blog = new System.Windows.Forms.Button();
            this.bln = new System.Windows.Forms.Button();
            this.bexp = new System.Windows.Forms.Button();
            this.bcossec = new System.Windows.Forms.Button();
            this.bsec = new System.Windows.Forms.Button();
            this.bcotg = new System.Windows.Forms.Button();
            this.btg = new System.Windows.Forms.Button();
            this.bcos = new System.Windows.Forms.Button();
            this.bsen = new System.Windows.Forms.Button();
            this.bcossech = new System.Windows.Forms.Button();
            this.bsech = new System.Windows.Forms.Button();
            this.bcotgh = new System.Windows.Forms.Button();
            this.btgh = new System.Windows.Forms.Button();
            this.cosh = new System.Windows.Forms.Button();
            this.bsenh = new System.Windows.Forms.Button();
            this.barcsenh = new System.Windows.Forms.Button();
            this.barccosh = new System.Windows.Forms.Button();
            this.barctgh = new System.Windows.Forms.Button();
            this.barccotgh = new System.Windows.Forms.Button();
            this.barcsech = new System.Windows.Forms.Button();
            this.barccossech = new System.Windows.Forms.Button();
            this.barccossec = new System.Windows.Forms.Button();
            this.barcsec = new System.Windows.Forms.Button();
            this.barccotg = new System.Windows.Forms.Button();
            this.barctg = new System.Windows.Forms.Button();
            this.barccos = new System.Windows.Forms.Button();
            this.barcsen = new System.Windows.Forms.Button();
            this.bgrau = new System.Windows.Forms.Button();
            this.brad = new System.Windows.Forms.Button();
            this.ba = new System.Windows.Forms.Button();
            this.bphi = new System.Windows.Forms.Button();
            this.bfatorial = new System.Windows.Forms.Button();
            this.bporcento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(118, 202);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(199, 202);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(237, 85);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(320, 22);
            this.number.TabIndex = 2;
            // 
            // btmais
            // 
            this.btmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmais.Location = new System.Drawing.Point(442, 144);
            this.btmais.Name = "btmais";
            this.btmais.Size = new System.Drawing.Size(75, 23);
            this.btmais.TabIndex = 3;
            this.btmais.Text = "+";
            this.btmais.UseVisualStyleBackColor = true;
            this.btmais.Click += new System.EventHandler(this.btmais_Click);
            // 
            // btigual
            // 
            this.btigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btigual.Location = new System.Drawing.Point(604, 231);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(75, 23);
            this.btigual.TabIndex = 4;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // bdivisao
            // 
            this.bdivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdivisao.Location = new System.Drawing.Point(442, 231);
            this.bdivisao.Name = "bdivisao";
            this.bdivisao.Size = new System.Drawing.Size(75, 23);
            this.bdivisao.TabIndex = 5;
            this.bdivisao.Text = "/";
            this.bdivisao.UseVisualStyleBackColor = true;
            this.bdivisao.Click += new System.EventHandler(this.bdivisao_Click);
            // 
            // bproduto
            // 
            this.bproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bproduto.Location = new System.Drawing.Point(442, 202);
            this.bproduto.Name = "bproduto";
            this.bproduto.Size = new System.Drawing.Size(75, 23);
            this.bproduto.TabIndex = 6;
            this.bproduto.Text = "*";
            this.bproduto.UseVisualStyleBackColor = true;
            this.bproduto.Click += new System.EventHandler(this.bproduto_Click);
            // 
            // bmenos
            // 
            this.bmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenos.Location = new System.Drawing.Point(442, 173);
            this.bmenos.Name = "bmenos";
            this.bmenos.Size = new System.Drawing.Size(75, 23);
            this.bmenos.TabIndex = 7;
            this.bmenos.Text = "-";
            this.bmenos.UseVisualStyleBackColor = true;
            this.bmenos.Click += new System.EventHandler(this.bmenos_Click);
            // 
            // blimpar
            // 
            this.blimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blimpar.Location = new System.Drawing.Point(199, 231);
            this.blimpar.Name = "blimpar";
            this.blimpar.Size = new System.Drawing.Size(75, 23);
            this.blimpar.TabIndex = 8;
            this.blimpar.Text = "C";
            this.blimpar.UseVisualStyleBackColor = true;
            this.blimpar.Click += new System.EventHandler(this.blimpar_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(280, 144);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(199, 144);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 10;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(280, 173);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(118, 144);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(118, 173);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 13;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(280, 202);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 14;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(118, 231);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 23);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(199, 173);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 16;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // bdot
            // 
            this.bdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdot.Location = new System.Drawing.Point(280, 231);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 23);
            this.bdot.TabIndex = 17;
            this.bdot.Text = ",";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // bpotencia
            // 
            this.bpotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpotencia.Location = new System.Drawing.Point(523, 144);
            this.bpotencia.Name = "bpotencia";
            this.bpotencia.Size = new System.Drawing.Size(75, 23);
            this.bpotencia.TabIndex = 18;
            this.bpotencia.Text = "^";
            this.bpotencia.UseVisualStyleBackColor = true;
            this.bpotencia.Click += new System.EventHandler(this.bpotencia_Click);
            // 
            // braiz
            // 
            this.braiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braiz.Location = new System.Drawing.Point(523, 173);
            this.braiz.Name = "braiz";
            this.braiz.Size = new System.Drawing.Size(75, 23);
            this.braiz.TabIndex = 19;
            this.braiz.Text = "Sqrt";
            this.braiz.UseVisualStyleBackColor = true;
            this.braiz.Click += new System.EventHandler(this.braiz_Click);
            // 
            // be
            // 
            this.be.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.be.Location = new System.Drawing.Point(361, 173);
            this.be.Name = "be";
            this.be.Size = new System.Drawing.Size(75, 23);
            this.be.TabIndex = 20;
            this.be.Text = "e";
            this.be.UseVisualStyleBackColor = true;
            this.be.Click += new System.EventHandler(this.be_Click);
            // 
            // bpi
            // 
            this.bpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpi.Location = new System.Drawing.Point(361, 144);
            this.bpi.Name = "bpi";
            this.bpi.Size = new System.Drawing.Size(75, 23);
            this.bpi.TabIndex = 21;
            this.bpi.Text = "Pi";
            this.bpi.UseVisualStyleBackColor = true;
            this.bpi.Click += new System.EventHandler(this.bpi_Click);
            // 
            // blog
            // 
            this.blog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blog.Location = new System.Drawing.Point(523, 202);
            this.blog.Name = "blog";
            this.blog.Size = new System.Drawing.Size(75, 23);
            this.blog.TabIndex = 22;
            this.blog.Text = "Log";
            this.blog.UseVisualStyleBackColor = true;
            this.blog.Click += new System.EventHandler(this.blog_Click);
            // 
            // bln
            // 
            this.bln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bln.Location = new System.Drawing.Point(523, 231);
            this.bln.Name = "bln";
            this.bln.Size = new System.Drawing.Size(75, 23);
            this.bln.TabIndex = 23;
            this.bln.Text = "Ln";
            this.bln.UseVisualStyleBackColor = true;
            this.bln.Click += new System.EventHandler(this.bln_Click);
            // 
            // bexp
            // 
            this.bexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexp.Location = new System.Drawing.Point(604, 144);
            this.bexp.Name = "bexp";
            this.bexp.Size = new System.Drawing.Size(75, 23);
            this.bexp.TabIndex = 24;
            this.bexp.Text = "Exp";
            this.bexp.UseVisualStyleBackColor = true;
            this.bexp.Click += new System.EventHandler(this.bexp_Click);
            // 
            // bcossec
            // 
            this.bcossec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcossec.Location = new System.Drawing.Point(118, 423);
            this.bcossec.Name = "bcossec";
            this.bcossec.Size = new System.Drawing.Size(75, 23);
            this.bcossec.TabIndex = 25;
            this.bcossec.Text = "Cossec";
            this.bcossec.UseVisualStyleBackColor = true;
            this.bcossec.Click += new System.EventHandler(this.bcossec_Click_1);
            // 
            // bsec
            // 
            this.bsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsec.Location = new System.Drawing.Point(118, 394);
            this.bsec.Name = "bsec";
            this.bsec.Size = new System.Drawing.Size(75, 23);
            this.bsec.TabIndex = 26;
            this.bsec.Text = "Sec";
            this.bsec.UseVisualStyleBackColor = true;
            this.bsec.Click += new System.EventHandler(this.bsec_Click);
            // 
            // bcotg
            // 
            this.bcotg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcotg.Location = new System.Drawing.Point(118, 365);
            this.bcotg.Name = "bcotg";
            this.bcotg.Size = new System.Drawing.Size(75, 23);
            this.bcotg.TabIndex = 27;
            this.bcotg.Text = "Cotg";
            this.bcotg.UseVisualStyleBackColor = true;
            this.bcotg.Click += new System.EventHandler(this.bcotg_Click);
            // 
            // btg
            // 
            this.btg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btg.Location = new System.Drawing.Point(118, 336);
            this.btg.Name = "btg";
            this.btg.Size = new System.Drawing.Size(75, 23);
            this.btg.TabIndex = 28;
            this.btg.Text = "Tg";
            this.btg.UseVisualStyleBackColor = true;
            this.btg.Click += new System.EventHandler(this.btg_Click);
            // 
            // bcos
            // 
            this.bcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcos.Location = new System.Drawing.Point(118, 307);
            this.bcos.Name = "bcos";
            this.bcos.Size = new System.Drawing.Size(75, 23);
            this.bcos.TabIndex = 29;
            this.bcos.Text = "Cos";
            this.bcos.UseVisualStyleBackColor = true;
            this.bcos.Click += new System.EventHandler(this.bcos_Click_1);
            // 
            // bsen
            // 
            this.bsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsen.Location = new System.Drawing.Point(118, 278);
            this.bsen.Name = "bsen";
            this.bsen.Size = new System.Drawing.Size(75, 23);
            this.bsen.TabIndex = 30;
            this.bsen.Text = "Sen";
            this.bsen.UseVisualStyleBackColor = true;
            this.bsen.Click += new System.EventHandler(this.bsen_Click);
            // 
            // bcossech
            // 
            this.bcossech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcossech.Location = new System.Drawing.Point(280, 423);
            this.bcossech.Name = "bcossech";
            this.bcossech.Size = new System.Drawing.Size(75, 23);
            this.bcossech.TabIndex = 31;
            this.bcossech.Text = "Cossech";
            this.bcossech.UseVisualStyleBackColor = true;
            this.bcossech.Click += new System.EventHandler(this.bcossech_Click_1);
            // 
            // bsech
            // 
            this.bsech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsech.Location = new System.Drawing.Point(280, 394);
            this.bsech.Name = "bsech";
            this.bsech.Size = new System.Drawing.Size(75, 23);
            this.bsech.TabIndex = 32;
            this.bsech.Text = "Sech";
            this.bsech.UseVisualStyleBackColor = true;
            this.bsech.Click += new System.EventHandler(this.bsech_Click_1);
            // 
            // bcotgh
            // 
            this.bcotgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcotgh.Location = new System.Drawing.Point(280, 365);
            this.bcotgh.Name = "bcotgh";
            this.bcotgh.Size = new System.Drawing.Size(75, 23);
            this.bcotgh.TabIndex = 33;
            this.bcotgh.Text = "Cotgh";
            this.bcotgh.UseVisualStyleBackColor = true;
            this.bcotgh.Click += new System.EventHandler(this.bcotgh_Click_1);
            // 
            // btgh
            // 
            this.btgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgh.Location = new System.Drawing.Point(280, 336);
            this.btgh.Name = "btgh";
            this.btgh.Size = new System.Drawing.Size(75, 23);
            this.btgh.TabIndex = 34;
            this.btgh.Text = "Tgh";
            this.btgh.UseVisualStyleBackColor = true;
            this.btgh.Click += new System.EventHandler(this.btgh_Click_1);
            // 
            // cosh
            // 
            this.cosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosh.Location = new System.Drawing.Point(280, 307);
            this.cosh.Name = "cosh";
            this.cosh.Size = new System.Drawing.Size(75, 23);
            this.cosh.TabIndex = 35;
            this.cosh.Text = "Cosh";
            this.cosh.UseVisualStyleBackColor = true;
            this.cosh.Click += new System.EventHandler(this.cosh_Click);
            // 
            // bsenh
            // 
            this.bsenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsenh.Location = new System.Drawing.Point(280, 278);
            this.bsenh.Name = "bsenh";
            this.bsenh.Size = new System.Drawing.Size(75, 23);
            this.bsenh.TabIndex = 36;
            this.bsenh.Text = "Senh";
            this.bsenh.UseVisualStyleBackColor = true;
            this.bsenh.Click += new System.EventHandler(this.bsenh_Click_1);
            // 
            // barcsenh
            // 
            this.barcsenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcsenh.Location = new System.Drawing.Point(604, 278);
            this.barcsenh.Name = "barcsenh";
            this.barcsenh.Size = new System.Drawing.Size(75, 23);
            this.barcsenh.TabIndex = 37;
            this.barcsenh.Text = "Arcsenh";
            this.barcsenh.UseVisualStyleBackColor = true;
            this.barcsenh.Click += new System.EventHandler(this.barcsenh_Click);
            // 
            // barccosh
            // 
            this.barccosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccosh.Location = new System.Drawing.Point(604, 307);
            this.barccosh.Name = "barccosh";
            this.barccosh.Size = new System.Drawing.Size(75, 23);
            this.barccosh.TabIndex = 38;
            this.barccosh.Text = "Arccosh";
            this.barccosh.UseVisualStyleBackColor = true;
            this.barccosh.Click += new System.EventHandler(this.barccosh_Click);
            // 
            // barctgh
            // 
            this.barctgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barctgh.Location = new System.Drawing.Point(604, 336);
            this.barctgh.Name = "barctgh";
            this.barctgh.Size = new System.Drawing.Size(75, 23);
            this.barctgh.TabIndex = 39;
            this.barctgh.Text = "Arctgh";
            this.barctgh.UseVisualStyleBackColor = true;
            this.barctgh.Click += new System.EventHandler(this.barctgh_Click);
            // 
            // barccotgh
            // 
            this.barccotgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccotgh.Location = new System.Drawing.Point(604, 365);
            this.barccotgh.Name = "barccotgh";
            this.barccotgh.Size = new System.Drawing.Size(75, 23);
            this.barccotgh.TabIndex = 40;
            this.barccotgh.Text = "Arccotgh";
            this.barccotgh.UseVisualStyleBackColor = true;
            this.barccotgh.Click += new System.EventHandler(this.barccotgh_Click);
            // 
            // barcsech
            // 
            this.barcsech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcsech.Location = new System.Drawing.Point(604, 394);
            this.barcsech.Name = "barcsech";
            this.barcsech.Size = new System.Drawing.Size(75, 23);
            this.barcsech.TabIndex = 41;
            this.barcsech.Text = "Arcsech";
            this.barcsech.UseVisualStyleBackColor = true;
            this.barcsech.Click += new System.EventHandler(this.barcsech_Click);
            // 
            // barccossech
            // 
            this.barccossech.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccossech.Location = new System.Drawing.Point(604, 423);
            this.barccossech.Name = "barccossech";
            this.barccossech.Size = new System.Drawing.Size(75, 23);
            this.barccossech.TabIndex = 42;
            this.barccossech.Text = "Arccossech";
            this.barccossech.UseVisualStyleBackColor = true;
            this.barccossech.Click += new System.EventHandler(this.barccossech_Click);
            // 
            // barccossec
            // 
            this.barccossec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccossec.Location = new System.Drawing.Point(442, 423);
            this.barccossec.Name = "barccossec";
            this.barccossec.Size = new System.Drawing.Size(75, 23);
            this.barccossec.TabIndex = 43;
            this.barccossec.Text = "Arccossec";
            this.barccossec.UseVisualStyleBackColor = true;
            this.barccossec.Click += new System.EventHandler(this.barccossec_Click_1);
            // 
            // barcsec
            // 
            this.barcsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcsec.Location = new System.Drawing.Point(442, 394);
            this.barcsec.Name = "barcsec";
            this.barcsec.Size = new System.Drawing.Size(75, 23);
            this.barcsec.TabIndex = 44;
            this.barcsec.Text = "Arcsec";
            this.barcsec.UseVisualStyleBackColor = true;
            this.barcsec.Click += new System.EventHandler(this.barcsec_Click_1);
            // 
            // barccotg
            // 
            this.barccotg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccotg.Location = new System.Drawing.Point(442, 365);
            this.barccotg.Name = "barccotg";
            this.barccotg.Size = new System.Drawing.Size(75, 23);
            this.barccotg.TabIndex = 45;
            this.barccotg.Text = "Arccotg";
            this.barccotg.UseVisualStyleBackColor = true;
            this.barccotg.Click += new System.EventHandler(this.barccotg_Click_1);
            // 
            // barctg
            // 
            this.barctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barctg.Location = new System.Drawing.Point(442, 336);
            this.barctg.Name = "barctg";
            this.barctg.Size = new System.Drawing.Size(75, 23);
            this.barctg.TabIndex = 46;
            this.barctg.Text = "Arctg";
            this.barctg.UseVisualStyleBackColor = true;
            this.barctg.Click += new System.EventHandler(this.barctg_Click);
            // 
            // barccos
            // 
            this.barccos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barccos.Location = new System.Drawing.Point(442, 307);
            this.barccos.Name = "barccos";
            this.barccos.Size = new System.Drawing.Size(75, 23);
            this.barccos.TabIndex = 47;
            this.barccos.Text = "Arccos";
            this.barccos.UseVisualStyleBackColor = true;
            this.barccos.Click += new System.EventHandler(this.barccos_Click);
            // 
            // barcsen
            // 
            this.barcsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcsen.Location = new System.Drawing.Point(442, 278);
            this.barcsen.Name = "barcsen";
            this.barcsen.Size = new System.Drawing.Size(75, 23);
            this.barcsen.TabIndex = 48;
            this.barcsen.Text = "Arcsen";
            this.barcsen.UseVisualStyleBackColor = true;
            this.barcsen.Click += new System.EventHandler(this.barcsen_Click);
            // 
            // bgrau
            // 
            this.bgrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgrau.Location = new System.Drawing.Point(604, 173);
            this.bgrau.Name = "bgrau";
            this.bgrau.Size = new System.Drawing.Size(75, 23);
            this.bgrau.TabIndex = 49;
            this.bgrau.Text = "Grau";
            this.bgrau.UseVisualStyleBackColor = true;
            this.bgrau.Click += new System.EventHandler(this.bgrau_Click);
            // 
            // brad
            // 
            this.brad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brad.Location = new System.Drawing.Point(604, 202);
            this.brad.Name = "brad";
            this.brad.Size = new System.Drawing.Size(75, 23);
            this.brad.TabIndex = 50;
            this.brad.Text = "Rad";
            this.brad.UseVisualStyleBackColor = true;
            this.brad.Click += new System.EventHandler(this.brad_Click);
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba.Location = new System.Drawing.Point(361, 202);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(75, 23);
            this.ba.TabIndex = 51;
            this.ba.Text = "Phi";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // bphi
            // 
            this.bphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bphi.Location = new System.Drawing.Point(361, 231);
            this.bphi.Name = "bphi";
            this.bphi.Size = new System.Drawing.Size(75, 23);
            this.bphi.TabIndex = 52;
            this.bphi.Text = "C10";
            this.bphi.UseVisualStyleBackColor = true;
            this.bphi.Click += new System.EventHandler(this.bphi_Click_1);
            // 
            // bfatorial
            // 
            this.bfatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfatorial.Location = new System.Drawing.Point(685, 173);
            this.bfatorial.Name = "bfatorial";
            this.bfatorial.Size = new System.Drawing.Size(75, 23);
            this.bfatorial.TabIndex = 53;
            this.bfatorial.Text = "!";
            this.bfatorial.UseVisualStyleBackColor = true;
            this.bfatorial.Click += new System.EventHandler(this.bfatorial_Click_1);
            // 
            // bporcento
            // 
            this.bporcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bporcento.Location = new System.Drawing.Point(685, 144);
            this.bporcento.Name = "bporcento";
            this.bporcento.Size = new System.Drawing.Size(75, 23);
            this.bporcento.TabIndex = 54;
            this.bporcento.Text = "%";
            this.bporcento.UseVisualStyleBackColor = true;
            this.bporcento.Click += new System.EventHandler(this.bporcento_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bporcento);
            this.Controls.Add(this.bfatorial);
            this.Controls.Add(this.bphi);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.brad);
            this.Controls.Add(this.bgrau);
            this.Controls.Add(this.barcsen);
            this.Controls.Add(this.barccos);
            this.Controls.Add(this.barctg);
            this.Controls.Add(this.barccotg);
            this.Controls.Add(this.barcsec);
            this.Controls.Add(this.barccossec);
            this.Controls.Add(this.barccossech);
            this.Controls.Add(this.barcsech);
            this.Controls.Add(this.barccotgh);
            this.Controls.Add(this.barctgh);
            this.Controls.Add(this.barccosh);
            this.Controls.Add(this.barcsenh);
            this.Controls.Add(this.bsenh);
            this.Controls.Add(this.cosh);
            this.Controls.Add(this.btgh);
            this.Controls.Add(this.bcotgh);
            this.Controls.Add(this.bsech);
            this.Controls.Add(this.bcossech);
            this.Controls.Add(this.bsen);
            this.Controls.Add(this.bcos);
            this.Controls.Add(this.btg);
            this.Controls.Add(this.bcotg);
            this.Controls.Add(this.bsec);
            this.Controls.Add(this.bcossec);
            this.Controls.Add(this.bexp);
            this.Controls.Add(this.bln);
            this.Controls.Add(this.blog);
            this.Controls.Add(this.bpi);
            this.Controls.Add(this.be);
            this.Controls.Add(this.braiz);
            this.Controls.Add(this.bpotencia);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.blimpar);
            this.Controls.Add(this.bmenos);
            this.Controls.Add(this.bproduto);
            this.Controls.Add(this.bdivisao);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btmais);
            this.Controls.Add(this.number);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Interface";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button btmais;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button bdivisao;
        private System.Windows.Forms.Button bproduto;
        private System.Windows.Forms.Button bmenos;
        private System.Windows.Forms.Button blimpar;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bpotencia;
        private System.Windows.Forms.Button braiz;
        private System.Windows.Forms.Button be;
        private System.Windows.Forms.Button bpi;
        private System.Windows.Forms.Button blog;
        private System.Windows.Forms.Button bln;
        private System.Windows.Forms.Button bexp;
        private System.Windows.Forms.Button bcossec;
        private System.Windows.Forms.Button bsec;
        private System.Windows.Forms.Button bcotg;
        private System.Windows.Forms.Button btg;
        private System.Windows.Forms.Button bcos;
        private System.Windows.Forms.Button bsen;
        private System.Windows.Forms.Button bcossech;
        private System.Windows.Forms.Button bsech;
        private System.Windows.Forms.Button bcotgh;
        private System.Windows.Forms.Button btgh;
        private System.Windows.Forms.Button cosh;
        private System.Windows.Forms.Button bsenh;
        private System.Windows.Forms.Button barcsenh;
        private System.Windows.Forms.Button barccosh;
        private System.Windows.Forms.Button barctgh;
        private System.Windows.Forms.Button barccotgh;
        private System.Windows.Forms.Button barcsech;
        private System.Windows.Forms.Button barccossech;
        private System.Windows.Forms.Button barccossec;
        private System.Windows.Forms.Button barcsec;
        private System.Windows.Forms.Button barccotg;
        private System.Windows.Forms.Button barctg;
        private System.Windows.Forms.Button barccos;
        private System.Windows.Forms.Button barcsen;
        private System.Windows.Forms.Button bgrau;
        private System.Windows.Forms.Button brad;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Button bphi;
        private System.Windows.Forms.Button bfatorial;
        private System.Windows.Forms.Button bporcento;
    }
}
