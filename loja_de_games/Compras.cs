/*

Programação Orientada a Objetos - Loja de Games (Classe Compras)
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

    public partial class Compras : Form{

        private static Compras _instance;

        public static Compras Instance{
        
            get{

                if(_instance == null)

                    _instance = new Compras();

                return _instance;
            }
        }

        private void Compras_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        double saldo = 0;

        public Compras(){

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


        private void selectRecords(){

            connectionTest();

            dataGridView6.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);

                result = command.ExecuteReader();

                dataGridView6.Rows.Clear();

                while(result.Read()){

                    dataGridView6.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                    result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                    result.GetValue(6), result.GetValue(7)});
                }
                
                connection.Close();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }

        private void selectRecordsFiltro(){

            connectionTest();

            dataGridView6.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);

                result = command.ExecuteReader();

                dataGridView6.Rows.Clear();

                while(result.Read()){

                    if(rbNome.Checked){

                        if(tbFiltro.Text.ToString() == result.GetValue(1).ToString()){

                            dataGridView6.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7)});
                        }
                    }

                    if(rbCódigo.Checked){

                        if(tbFiltro.Text.ToString() == result.GetValue(1).ToString()){

                            dataGridView6.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7)});
                        }
                    }
                }
                
                connection.Close();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }
        
        private void bProcurar12_Click(object sender, EventArgs e){

            selectRecordsFiltro();
        }

        private void btBusca12_Click(object sender, EventArgs e){

            selectRecords();
        }

        private void button123_Click(object sender, EventArgs e){

            Limpar();

            for(int i = Application.OpenForms.Count - 1; i >= 0; i--){

                if(Application.OpenForms[i].IsMdiChild){

                    Application.OpenForms[i].Hide();
                }
            }

        }

        private void button48_Click(object sender, EventArgs e){

            connectionTest();

            try{

                if((int)dataGridView6.CurrentRow.Cells[7].Value == 0){

                    MessageBox.Show("Produto indisponível");
                }

                else{

                    saldo = saldo + System.Convert.ToDouble(dataGridView6.CurrentRow.Cells[6].Value);

                    int i = System.Convert.ToInt32(dataGridView6.CurrentRow.Cells[7].Value);

                    i--;

                    dataGridView6.CurrentRow.Cells[7].Value = i;

                    Total.Text = saldo.ToString();
                }
            }

            catch(ArgumentNullException){

                MessageBox.Show("Selecione um produto");
            }

            catch(Exception){

                MessageBox.Show("Impossível adicionar produto");
            }
        }

        private void button31_Click(object sender, EventArgs e){

            connectionTest();

            try{

                int k = 0;

                while(k < dataGridView6.Rows.Count - 1){

                    connectionTest();
                    command = new NpgsqlCommand("UPDATE jogos SET titulo='" +
                    dataGridView6.Rows[k].Cells[1].Value.ToString() + "', codigo='" +
                    dataGridView6.Rows[k].Cells[2].Value.ToString() + "', plataforma='" +
                    dataGridView6.Rows[k].Cells[3].Value.ToString() + "', genero='" +
                    dataGridView6.Rows[k].Cells[4].Value.ToString() + "', desenvolvedora='" +
                    dataGridView6.Rows[k].Cells[5].Value.ToString() + "', preco='" +
                    dataGridView6.Rows[k].Cells[6].Value.ToString() + "', quantidade='" +
                    dataGridView6.Rows[k].Cells[7].Value.ToString() + "'WHERE num=" +
                    dataGridView6.Rows[k].Cells[0].Value.ToString(), connection);

                    command.ExecuteReader();

                    k++;
                }

                selectRecords();

                MessageBox.Show("Compra finalizada. Total a pagar: " + saldo.ToString());

                saldo = 0;

                dataGridView6.Rows.Clear();

                Total.Text = "";
            }

            catch(Exception){

                MessageBox.Show("Impossível finalizar compra");
            }
        }

        private void button145_Click(object sender, EventArgs e){

            Limpar();

            MessageBox.Show("Compra cancelada");
        }

        void Limpar(){

            dataGridView6.Rows.Clear();

            rbNome.Checked = false;

            rbCódigo.Checked = false;

            tbFiltro.Text = "";

            Total.Text = "";

            saldo = 0;
        }
    }
}
