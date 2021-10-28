/*

Programação Orientada a Objetos - Loja de Games (Classe Cadastro de Funcionários)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeGames{

    public partial class CadastroFuncionarios: Form{

        private static CadastroFuncionarios _instance;

        public static CadastroFuncionarios Instance{

            get{

                if(_instance == null)

                    _instance = new CadastroFuncionarios();

                return _instance;
            }
        }

        private void CadastroFuncionarios_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;

        public CadastroFuncionarios(){

            InitializeComponent();
        }

        private void connectionTest1(){

            try{

                connection = new NpgsqlConnection("Server = 127.0.0.1; User Id = postgres; Password = loja_de_games; " +
                    "Database = postgres");

                connection.Open();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar conexão");
            }
        }

        private void bInsertf_Click_1(object sender, EventArgs e){

            connectionTest1();

            try{

                command = new NpgsqlCommand("Insert Into funcionarios(nomef, CPFf, nascimentof, CEPf, telefonef, emailf, " +
                    "funcao, salario) " + "values('" + tbNomef.Text.ToString() + "','" + tbCPFf.Text.ToString() + "','" +
                    tbDataf.Text.ToString() + "','" + tbCEPf.Text.ToString() + "','" + tbTelefonef.Text.ToString() + "','" + 
                    tbEmailf.Text.ToString() + "','" + tbFuncao.Text.ToString() + "','" + tbSalario.Text.ToString() + 
                    "')", connection);

                command.ExecuteReader();

                MessageBox.Show("Cadastro realizado com sucesso");
            }

            catch(FormatException){

                MessageBox.Show("Insira dados válidos");
            }

            catch(ArgumentNullException){

                MessageBox.Show("Não deixe nome nem CPF em branco");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar cadastro");
            }

            Limpar();
        }

        private void button1_Click(object sender, EventArgs e){

            Limpar();

            for(int i = Application.OpenForms.Count - 1; i >= 0; i--){
                
                if(Application.OpenForms[i].IsMdiChild){
                
                    Application.OpenForms[i].Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e){

            Limpar();
        }

        void Limpar(){

            tbNomef.Text = "";
            tbCPFf.Text = "";
            tbDataf.Text = "";
            tbCEPf.Text = "";
            tbTelefonef.Text = "";
            tbEmailf.Text = "";
            tbFuncao.Text = "";
            tbSalario.Text = "";
        }
    }
}
