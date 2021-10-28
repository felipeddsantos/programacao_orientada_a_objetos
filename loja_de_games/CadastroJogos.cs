/*

Programação Orientada a Objetos - Loja de Games (Classe Cadastro de Jogos)
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

    public partial class CadastroJogos : Form{

        private static CadastroJogos _instance;

        public static CadastroJogos Instance{

            get{

                if(_instance == null)

                    _instance = new CadastroJogos();

                return _instance;
            }
        }

        private void CadastroLivros_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;

        public CadastroJogos(){

            InitializeComponent();
        }

        private void connectionTest2(){
        
            try{

                connection = new NpgsqlConnection("Server = 127.0.0.1; User Id = postgres; Password = loja_de_games; " +
                    "Database = postgres");

                connection.Open();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar conexão");
            }
        }
        
        private void bInsertl_Click_1(object sender, EventArgs e){

            connectionTest2();

            try{

                command = new NpgsqlCommand("Insert Into jogos(titulo, codigo, plataforma, genero, desenvolvedora, preco, " +
                    "quantidade) " + "values('" + tbTitulo.Text.ToString() + "','" + tbCodigo.Text.ToString() + "','" + 
                    tbPlataforma.Text.ToString() + "','" + tbGenero.Text.ToString() + "','" + tbDesenvolvedora.Text.ToString() + 
                    "','" + tbPreco.Text.ToString() + "','" + tbQuantidade.Text.ToString() + "')", connection);

                command.ExecuteReader();

                Limpar();

                MessageBox.Show("Cadastro realizado com sucesso");
            }

            catch(FormatException){

                MessageBox.Show("Insira dados válidos");
            }

            catch(ArgumentNullException){

                MessageBox.Show("Não deixe título nem código em branco");
            }

            catch(Exception ex){

                MessageBox.Show("Impossível realizar cadastro" + ex);
            }
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

            tbTitulo.Text = "";
            tbCodigo.Text = "";
            tbPlataforma.Text = "";
            tbGenero.Text = "";
            tbDesenvolvedora.Text = "";
            tbPreco.Text = "";
            tbQuantidade.Text = "";
        }
    }
}
