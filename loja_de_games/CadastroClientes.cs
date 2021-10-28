/*

Programação Orientada a Objetos - Loja de Games (Classe Cadastro de Clientes)
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

    public partial class CadastroClientes : Form{

        public CadastroClientes(){

            InitializeComponent();
        }

        private static CadastroClientes _instance;

        public static CadastroClientes Instance{

            get{

                if(_instance == null)

                    _instance = new CadastroClientes();

                return _instance;
            }
        }

        private void CadastroClientes_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }


        private NpgsqlConnection connection;
        private NpgsqlCommand command;

        private void connectionTest(){
       
            try{

                connection = new NpgsqlConnection("Server = 127.0.0.1; User Id = postgres; Password = loja_de_games; " +
                    "Database = postgres");

                connection.Open();
            }

            catch (Exception){

                MessageBox.Show("Impossível realizar conexão");
            }
        }

        private void bInsert_Click(object sender, EventArgs e){

            connectionTest();

            try{

               command = new NpgsqlCommand("Insert Into clientes(nome, CPF, nascimento, CEP, telefone, email) " +
                   "values('" + tbNome.Text.ToString() + "','" + tbCPF.Text.ToString() + "','" +
                   tbData.Text.ToString() + "','" + tbCEP.Text.ToString() + "','"+
                   tbTelefone.Text.ToString() + "','" + tbEmail.Text.ToString() + "')", connection);

                command.ExecuteReader();

                connectionTest();

                command = new NpgsqlCommand("Insert Into generos(acao, arcade, aventura, casual, corrida, esporte, estrategia, " +
                    "fps, horror, luta, musical, plataforma, puzzle, rpg, simulacao)" + "values('" + cb1.Checked.ToString() + 
                    "','" + cb2.Checked.ToString() + "','" + cb3.Checked.ToString() + "','" + cb4.Checked.ToString() + 
                    "','" +cb5.Checked.ToString() + "','" + cb6.Checked.ToString() + "','" + cb7.Checked.ToString() + 
                    "','" + cb8.Checked.ToString() + "','" + cb9.Checked.ToString() + "','" + cb10.Checked.ToString() + "','" + 
                    cb11.Checked.ToString() + "','" + cb12.Checked.ToString() + "','" + cb13.Checked.ToString() + "','" + 
                    cb14.Checked.ToString() + "','" + cb15.Checked.ToString() + "')", connection);

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

            tbNome.Text = "";
            tbCPF.Text = "";
            tbData.Text = "";
            tbCEP.Text = "";
            tbTelefone.Text = "";
            tbEmail.Text = "";
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
            cb8.Checked = false;
            cb9.Checked = false;
            cb10.Checked = false;
            cb11.Checked = false;
            cb12.Checked = false;
            cb13.Checked = false;
            cb14.Checked = false;
            cb15.Checked = false;
        }
    }
}
