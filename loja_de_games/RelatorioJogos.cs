/*

Programação Orientada a Objetos - Loja de Games (Classe Relatório de Jogos)
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

    public partial class RelatorioJogos: Form{

        private static RelatorioJogos _instance;

        public static RelatorioJogos Instance{

            get{

                if(_instance == null)

                    _instance = new RelatorioJogos();

                return _instance;
            }
        }

        private void RelatorioJogos_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        public RelatorioJogos(){

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

        private void btBusca_Click(object sender, EventArgs e){

            selectRecords();
        }


        private void selectRecords(){

            connectionTest();

            dataGridView1.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);

                result = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while(result.Read()){

                    dataGridView1.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
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

            dataGridView1.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM jogos order by num", connection);

                result = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while(result.Read()){

                    if(rbNome.Checked){

                        if(tbFiltro.Text.ToString() == result.GetValue(1).ToString()){
                            
                            dataGridView1.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7)});
                        }
                    }
                    
                    if(rbCódigo.Checked){

                        if(tbFiltro.Text.ToString() == result.GetValue(2).ToString()){
                            
                            dataGridView1.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7)});
                        }
                    }
                }
                
                connection.Close();
            }

            catch(ArgumentNullException){

                MessageBox.Show("Insira título ou código");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }

        private void bProcurar_Click(object sender, EventArgs e){

            selectRecordsFiltro();
        }

        private void bAtualizar_Click(object sender, EventArgs e){
   
            connectionTest();

            try{

                int k = 0;

                while(k < dataGridView1.Rows.Count - 1){

                    connectionTest();
                    command = new NpgsqlCommand("UPDATE jogos SET titulo='" +
                    dataGridView1.Rows[k].Cells[1].Value.ToString() + "', codigo='" +
                    dataGridView1.Rows[k].Cells[2].Value.ToString() + "', plataforma='" +
                    dataGridView1.Rows[k].Cells[3].Value.ToString() + "', genero='" +
                    dataGridView1.Rows[k].Cells[4].Value.ToString() + "', desenvolvedora='" +
                    dataGridView1.Rows[k].Cells[5].Value.ToString() + "', preco='" +
                    dataGridView1.Rows[k].Cells[6].Value.ToString() + "', quantidade='" +
                    dataGridView1.Rows[k].Cells[7].Value.ToString() + "' WHERE num=" +
                    dataGridView1.Rows[k].Cells[0].Value.ToString(), connection);

                    command.ExecuteReader();

                    k++;
                }

                selectRecords();

                MessageBox.Show("Atualização realizada com sucesso");
            }

            catch(Exception ex){

                MessageBox.Show("Impossível realizar atualização" + ex);
            }
        }

        private void bDeletar_Click(object sender, EventArgs e){

            connectionTest();

            try{

                command = new NpgsqlCommand("DELETE from jogos where num= " +
                    dataGridView1.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                connectionTest();

                command = new NpgsqlCommand("UPDATE jogos SET titulo='" +
                    dataGridView1.CurrentRow.Cells[1].Value.ToString() + "', codigo='" +
                    dataGridView1.CurrentRow.Cells[2].Value.ToString() + "', plataforma='" +
                    dataGridView1.CurrentRow.Cells[3].Value.ToString() + "', genero='" +
                    dataGridView1.CurrentRow.Cells[4].Value.ToString() + "', desenvolvedora='" +
                    dataGridView1.CurrentRow.Cells[5].Value.ToString() + "', preco='" +
                    dataGridView1.CurrentRow.Cells[6].Value.ToString() + "', quantidade='" +
                    dataGridView1.CurrentRow.Cells[7].Value.ToString() + "' WHERE num=" +
                    dataGridView1.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                selectRecords();

                MessageBox.Show("Exclusão realizada com sucesso");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar exclusão");
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

            dataGridView1.Rows.Clear();
            rbCódigo.Checked = false;
            rbNome.Checked = false;
            tbFiltro.Text = "";
        }
    }
}
