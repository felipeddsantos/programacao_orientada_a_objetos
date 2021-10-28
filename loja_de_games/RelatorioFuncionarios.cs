/*

Programação Orientada a Objetos - Loja de Games (Classe Relatório de Funcionários)
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

    public partial class RelatorioFuncionários : Form{

        private static RelatorioFuncionários _instance;

        public static RelatorioFuncionários Instance{

            get{

                if (_instance == null)

                    _instance = new RelatorioFuncionários();

                return _instance;
            }
        }

        private void RelatorioFuncionários_FormClosed(object sender, FormClosedEventArgs e){

            _instance = null;
        }

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        public RelatorioFuncionários(){

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

            dataGridView3.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM funcionarios order by numero2", connection);

                result = command.ExecuteReader();

                dataGridView3.Rows.Clear();

                while(result.Read()){
                    
                    dataGridView3.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                    result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                    result.GetValue(6), result.GetValue(7), result.GetValue(8)});
                }
                
                connection.Close();
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar consulta");
            }
        }

        private void selectRecordsFiltro(){

            connectionTest();

            dataGridView3.Rows.Clear();

            try{

                command = new NpgsqlCommand("SELECT * FROM funcionarios order by numero2", connection);

                result = command.ExecuteReader();

                dataGridView3.Rows.Clear();

                while(result.Read()){

                    if(rbNome1.Checked){

                        if(tbFiltro2.Text.ToString() == result.GetValue(1).ToString()){
                            
                            dataGridView3.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7), result.GetValue(8)});
                        }
                    }

                    if(rbCPF1.Checked){

                        if(tbFiltro2.Text.ToString() == result.GetValue(2).ToString()){
                            
                            dataGridView3.Rows.Add(new object[] {result.GetValue(0), result.GetValue(1),
                            result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5),
                            result.GetValue(6), result.GetValue(7), result.GetValue(8)});
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

        private void btFiltro2_Click(object sender, EventArgs e){

            selectRecordsFiltro();
        }

        private void btProcurar2_Click(object sender, EventArgs e){

            selectRecords();
        }

        private void btDeletar2_Click(object sender, EventArgs e){

            connectionTest();

            try{

                command = new NpgsqlCommand("DELETE from funcionarios where numero2= " +
                dataGridView3.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                connectionTest();

                command = new NpgsqlCommand("UPDATE funcionarios SET nomef='" +
                        dataGridView3.CurrentRow.Cells[1].Value.ToString() + "', CPFf='" +
                        dataGridView3.CurrentRow.Cells[2].Value.ToString() + "', nascimentof='" +
                        dataGridView3.CurrentRow.Cells[3].Value.ToString() + "', CEPf='" +
                        dataGridView3.CurrentRow.Cells[4].Value.ToString() + "', telefonef='" +
                        dataGridView3.CurrentRow.Cells[5].Value.ToString() + "', emailf='" +
                        dataGridView3.CurrentRow.Cells[6].Value.ToString() + "', funcao='" +
                        dataGridView3.CurrentRow.Cells[7].Value.ToString() + "', salario='" +
                        dataGridView3.CurrentRow.Cells[8].Value.ToString() + "' WHERE numero2=" +
                        dataGridView3.CurrentRow.Cells[0].Value.ToString(), connection);

                command.ExecuteReader();

                selectRecords();

                MessageBox.Show("Exclusão realizada com sucesso");
            }

            catch(Exception){

                MessageBox.Show("Impossível realizar exclusão");
            }
        }

        private void bAtualizar2_Click(object sender, EventArgs e){

            connectionTest();

            try{

                int k = 0;

                while(k < dataGridView3.Rows.Count - 1){

                    connectionTest();

                    command = new NpgsqlCommand("UPDATE funcionarios SET nomef='" +
                    dataGridView3.Rows[k].Cells[1].Value.ToString() + "', CPFf='" +
                    dataGridView3.Rows[k].Cells[2].Value.ToString() + "', nascimentof='" +
                    dataGridView3.Rows[k].Cells[3].Value.ToString() + "', CEPf='" +
                    dataGridView3.Rows[k].Cells[4].Value.ToString() + "', telefonef='" +
                    dataGridView3.Rows[k].Cells[5].Value.ToString() + "', emailf='" +
                    dataGridView3.Rows[k].Cells[6].Value.ToString() + "', funcao='" +
                    dataGridView3.Rows[k].Cells[7].Value.ToString() + "', salario='" +
                    dataGridView3.Rows[k].Cells[8].Value.ToString() + "' WHERE numero2=" +
                    dataGridView3.Rows[k].Cells[0].Value.ToString(), connection);

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

                if(Application.OpenForms[i].IsMdiChild)

                    Application.OpenForms[i].Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e){

            Limpar();
        }

        void Limpar(){

            dataGridView3.Rows.Clear();
            rbCPF1.Checked = false;
            rbNome1.Checked = false;
            tbFiltro2.Text = "";
        }
    }
}
