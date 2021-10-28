/*

Programação Orientada a Objetos - Loja de Games (Classe Novidades)
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

    public partial class Novidades : Form{

        private static Novidades _instance;

        public static Novidades Instance{

            get{

                if(_instance == null)

                    _instance = new Novidades();

                return _instance;
            }
        }

        private void Novidades_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        String b;
        List<String> a = new List<String>();

        int k = 0, j;

        public Novidades(){

            InitializeComponent();
        }

        private void connectionTest(){

            try{

                connection = new NpgsqlConnection("Server = 127.0.0.1; User Id = postgres; Password = loja_de_games; " +
                    "Database = postgres");

                connection.Open();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar conexão");

            }
        }

        private void selectRecordsFiltro(){

            connectionTest();

            dataGridView4.Rows.Clear();

            try{

                if(rbNome1.Checked){

                    command = new NpgsqlCommand("SELECT * FROM clientes order by numero", connection);

                    result = command.ExecuteReader();

                    dataGridView4.Rows.Clear();

                    while(result.Read()){

                        if(tbFiltro4.Text.ToString() == result.GetValue(1).ToString()){

                            j = (int)result.GetValue(0);
                        }
                    }

                    connectionTest();

                    command = new NpgsqlCommand("SELECT * FROM generos order by numero", connection);

                    result = command.ExecuteReader();

                    while(result.Read()){

                        if(j == (int)result.GetValue(0)){

                            for(int i = 1; i <= 15; i++){

                                if(result.GetValue(i).ToString() == "True"){

                                    if(i == 1)

                                        a.Add("Ação");
                                        
                                    if(i == 2)

                                        a.Add("Arcade");
                                        
                                    if(i == 3)

                                        a.Add("Aventura");
                                        
                                    if(i == 4)

                                        a.Add("Casual");
                                        
                                    if(i == 5)

                                        a.Add("Corrida");
                                        
                                    if(i == 6)

                                        a.Add("Esporte");
                                        
                                    if(i == 7)

                                        a.Add("Estratégia");
                                        
                                    if(i == 8)

                                        a.Add("FPS");
                                        
                                    if(i == 9)

                                        a.Add("Horror");
                                        
                                    if(i == 10)

                                        a.Add("Luta");
                                        
                                    if(i == 11)

                                        a.Add("Musical");
                                        
                                    if(i == 12)

                                        a.Add("Plataforma");
                                        
                                    if(i == 13)

                                        a.Add("Puzzle");
                                        
                                    if(i == 14)

                                        a.Add("RPG");
                                        
                                    if(i == 15)

                                        a.Add("Simulação");
                                }
                            }
                        }
                    }

                    a.Add("");

                    connectionTest();
                    command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);
                    result = command.ExecuteReader();

                    while(result.Read()){

                        k = 0;

                        for(int i = 0; i < a.Count; i++){

                            if(result.GetValue(4).ToString() == a[k]){

                                dataGridView4.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                                result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                                result.GetValue(6), result.GetValue(7)});
                            }

                            k++;
                        }
                    }
                    
                    a.Clear();
                }

                if(rbCPF1.Checked){

                    command = new NpgsqlCommand("SELECT * FROM clientes order by numero", connection);

                    result = command.ExecuteReader();

                    dataGridView4.Rows.Clear();

                    while(result.Read()){

                        if(tbFiltro4.Text.ToString() == result.GetValue(2).ToString())
                       
                            j = (int)result.GetValue(0);
                    }

                    connectionTest();

                    command = new NpgsqlCommand("SELECT * FROM generos order by numero", connection);

                    result = command.ExecuteReader();

                    while(result.Read()){

                        if(j == (int)result.GetValue(0)){

                            for(int i = 1; i <= 15; i++){

                                if(result.GetValue(i).ToString() == "True"){

                                    if(i == 1)

                                        a.Add("Ação");
                                        
                                    if(i == 2)

                                        a.Add("Arcade");
                                        
                                    if(i == 3)

                                        a.Add("Aventura");
                                        
                                    if(i == 4)

                                        a.Add("Casual");
                                        
                                    if(i == 5)

                                        a.Add("Corrida");
                                        
                                    if(i == 6)

                                        a.Add("Esporte");
                                        
                                    if(i == 7)

                                        a.Add("Estratégia");
                                        
                                    if(i == 8)

                                        a.Add("FPS");
                                        
                                    if(i == 9)

                                        a.Add("Horror");
                                        
                                    if(i == 10)

                                        a.Add("Luta");
                                        
                                    if(i == 11)

                                        a.Add("Musical");
                                        
                                    if(i == 12)

                                        a.Add("Plataforma");
                                        
                                    if(i == 13)

                                        a.Add("Puzzle");
                                    
                                    if(i == 14)

                                        a.Add("RPG");
                                    
                                    if(i == 15)

                                        a.Add("Simulação");
                                }
                            }
                        }
                    }

                    a.Add("");

                    connectionTest();
                    command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);
                    result = command.ExecuteReader();

                    while(result.Read()){

                        k = 0;

                        for(int i = 0; i < a.Count; i++){

                            if(result.GetValue(4).ToString() == a[k]){

                                dataGridView4.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                                result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                                result.GetValue(6), result.GetValue(7)});
                            }

                            k++;
                        }
                    }

                    a.Clear();
                }

                connection.Close();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
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

        private void btFiltro4_Click(object sender, EventArgs e){

            selectRecordsFiltro();
        }

        void Limpar(){

            dataGridView4.Rows.Clear();
            rbNome1.Checked = false;
            rbCPF1.Checked = false;
            tbFiltro4.Text = "";
        }
    }
}
