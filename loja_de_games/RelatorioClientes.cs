/*

Programação Orientada a Objetos - Loja de Games (Classe Relatório de Clientes)
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

    public partial class RelatorioClientes : Form{

        private static RelatorioClientes _instance;

        public static RelatorioClientes Instance{

            get{

                if(_instance == null)

                    _instance = new RelatorioClientes();

                return _instance;
            }
        }

        private void RelatorioClientes_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        public RelatorioClientes(){

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

            dataGridView2.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM clientes order by numero", connection);

                result = command.ExecuteReader();

                dataGridView2.Rows.Clear();

                while(result.Read()){
                    
                    dataGridView2.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                    result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5), result.GetValue(6)});
                }
                
                connection.Close();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }

        private void selectRecordsFiltro(){

            connectionTest();

            dataGridView2.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM clientes order by numero", connection);

                result = command.ExecuteReader();

                dataGridView2.Rows.Clear();

                while(result.Read()){

                    if(rbNome1.Checked){

                        if(tbFiltro1.Text.ToString() == result.GetValue(1).ToString()){
                            
                            dataGridView2.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5), result.GetValue(6)});
                        }
                    }

                    if(rbCPF1.Checked){

                        if(tbFiltro1.Text.ToString() == result.GetValue(2).ToString()){
                           
                            dataGridView2.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5), result.GetValue(6)});
                        }
                    }
                }
                
                connection.Close();
            }

            catch(ArgumentNullException){

                MessageBox.Show("Insira nome ou CPF");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }

        private void btFiltro1_Click(object sender, EventArgs e){

            selectRecordsFiltro();
        }

        private void btProcurar1_Click(object sender, EventArgs e){

            selectRecords();
        }

        private void btDeletar1_Click(object sender, EventArgs e){

            connectionTest();

            try{

                command = new NpgsqlCommand("DELETE from clientes where numero= " +
                    dataGridView2.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                connectionTest();

                command = new NpgsqlCommand("UPDATE clientes SET nome='" +
                        dataGridView2.CurrentRow.Cells[1].Value.ToString() + "', CPF='" +
                        dataGridView2.CurrentRow.Cells[2].Value.ToString() + "', nascimento='" +
                        dataGridView2.CurrentRow.Cells[3].Value.ToString() + "', CEP='" +
                        dataGridView2.CurrentRow.Cells[4].Value.ToString() + "', telefone='" +
                        dataGridView2.CurrentRow.Cells[5].Value.ToString() + "', email='" +
                        dataGridView2.CurrentRow.Cells[6].Value.ToString() + "' WHERE numero=" +
                        dataGridView2.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                connectionTest();

                command = new NpgsqlCommand("DELETE from generos where numero= " +
                    dataGridView2.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                selectRecords();

                MessageBox.Show("Exclusão realizada com sucesso");

            }

            catch(Exception){

                MessageBox.Show("Impossível realizar exclusão");
            }
        }

        private void bAtualizar1_Click(object sender, EventArgs e){

            connectionTest();

            try{

                int k = 0;

                while(k < dataGridView2.Rows.Count - 1){

                    connectionTest();
                    command = new NpgsqlCommand("UPDATE clientes SET nome='" +
                    dataGridView2.Rows[k].Cells[1].Value.ToString() + "', CPF='" +
                    dataGridView2.Rows[k].Cells[2].Value.ToString() + "', nascimento='" +
                    dataGridView2.Rows[k].Cells[3].Value.ToString() + "', CEP='" +
                    dataGridView2.Rows[k].Cells[4].Value.ToString() + "', telefone='" +
                    dataGridView2.Rows[k].Cells[5].Value.ToString() + "', email='" +
                    dataGridView2.Rows[k].Cells[6].Value.ToString() + "' WHERE numero=" +
                    dataGridView2.Rows[k].Cells[0].Value.ToString(), connection);

                    command.ExecuteReader();

                    k++;
                }

                selectRecords();

                MessageBox.Show("Atualização realizada com sucesso");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar atualização");
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

            dataGridView2.Rows.Clear();
            rbCPF1.Checked = false;
            rbNome1.Checked = false;
            tbFiltro1.Text = "";
        }
    }
}
