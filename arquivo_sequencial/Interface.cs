/*

Programação Orientada a Objetos - Arquivo Sequencial (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO; 

namespace ArquivoSequencial{

    public partial class Interface : Form{

        private int textBoxCount = 4;

        //Constantes de enumeração para especificar índices do TextBox 
        public enum TextBoxIndices{
        
            CONTA,
            PRIMEIRO,
            ULTIMO,
            SALDO
        }

        //Serializar Registro em formato binário
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();

        //Arquivo onde os dados serão gravados
        private FileStream arquivo_saida;
        private FileStream arquivo_entrada; 

        public Interface(){
        
            InitializeComponent();
        }

        //Limpar TextBoxes
        public void ClearTextBoxes(){
        
            //Iteração através de cada Control no Form
            for(int i = 0; i < Controls.Count; i++){
            
                Control myControl = Controls[i];

                //Determina se Control é TextBox
                if(myControl is TextBox)
                
                    //Limpa a propriedade Text (seta para string vazia)
                    myControl.Text = "";
            }
        }

        //Seta os valores dos TextBox para valores num array de string
        public void SetTextBoxValues(string[] values){
        
            //Determina se array de string tem comprimento correto
            if(values.Length != textBoxCount)
               
                //Lança exceção se o comprimento não for correto
                throw(new ArgumentException("Deve existir " + (textBoxCount + 1) + " strings no array"));

            //Seta o array de valores se o array tiver comprimento correto
            else{
               
                tbConta.Text = values[(int)TextBoxIndices.CONTA];
                tbPrimeiroNome.Text = values[(int)TextBoxIndices.PRIMEIRO];
                tbUltimoNome.Text = values[(int)TextBoxIndices.ULTIMO];
                tbSaldo.Text = values[(int)TextBoxIndices.SALDO];
            }
        }

        //Retorna os valores dos TextBox num array de string
        public string[] GetTextBoxValues(){
        
            string[] values = new string[textBoxCount];

            //Copia os campos dos TextBox para array de string
            values[(int)TextBoxIndices.CONTA] = tbConta.Text;
            values[(int)TextBoxIndices.PRIMEIRO] = tbPrimeiroNome.Text;
            values[(int)TextBoxIndices.ULTIMO] = tbUltimoNome.Text;
            values[(int)TextBoxIndices.SALDO] = tbSaldo.Text;

            return values;
        }

        private void btCriarArquivo_MouseClick(object sender, MouseEventArgs e){
        
            //Cria uma caixa de diálogo para salvar arquivo
            SaveFileDialog fileChooser = new SaveFileDialog();
            DialogResult resultado = fileChooser.ShowDialog();
            string nomeArquivo;

            fileChooser.CheckFileExists = false;

            if(resultado == DialogResult.Cancel)
               
                return;
                
            nomeArquivo = fileChooser.FileName;

            if(nomeArquivo == "" || nomeArquivo == null)
                
                MessageBox.Show("Nome de Arquivo Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else{
           
                try{
           
                    arquivo_saida = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write);

                    btCriarArquivo.Enabled = false;
                    btGravarRegistro.Enabled = true;
                }
              
                catch(FileNotFoundException){
                   
                    MessageBox.Show("Arquivo não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btGravarRegistro_MouseClick(object sender, MouseEventArgs e){
        
            //Armazena valores dos TextBox  num array de string
            string[] values = GetTextBoxValues();

            //Registro contendo os valores dos TextBox para serializar
            Registro registro = new Registro();

            //Determina se TextBox campo CONTA não está vazio
            if(values[(int)TextBoxIndices.CONTA] != ""){
            
                //Armazena valores dos TextBox no Registro e serializa o Registro
                try{
                    
                    // pega o valor da CONTA
                    int numeroConta = Int32.Parse(values[(int)TextBoxIndices.CONTA]);

                    //Determina se o valor da conta é válido
                    if(numeroConta > 0){
                      
                        registro.setConta(numeroConta);
                        registro.setPrimeiroNome(values[(int)TextBoxIndices.PRIMEIRO]);
                        registro.setUltimoNome(values[(int)TextBoxIndices.ULTIMO]);
                        registro.setSaldo(Double.Parse(values[(int)TextBoxIndices.SALDO]));

                        //Grava o Registro no Arquivo Sequencial (serializa o objeto Registro no Arquivo)
                        formatter.Serialize(arquivo_saida, registro);
                    }
                    
                    else
                    
                        //Notifica o usuário de número de conta errado
                        MessageBox.Show("Número de Conta Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Notifica o usuário se ocorre erro na serialização
                catch(SerializationException){
                   
                    MessageBox.Show("Erro ao escrever no arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //Notifica o usuário sobre erro de formato
                catch(FormatException){
                
                    MessageBox.Show("Formato Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearTextBoxes();
        }

        private void btSair_MouseClick(object sender, MouseEventArgs e){
        
            //Determina se arquivo existe
            if(arquivo_saida != null){
            
                //Fecha o arquivo
                try{
                
                    arquivo_saida.Close();
                }

                //Notifica o usuário se teve erro ao fechar o arquivo
                catch (IOException){
                   
                    MessageBox.Show("Não consigo fechar o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAbrirArquivo_MouseClick(object sender, MouseEventArgs e){
        
            //Cria caixa de diálogo para usuário abrir arquivo
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName;

            //Sai do evento se o usuário clicar Cancel
            if(result == DialogResult.Cancel)
                
                return;

            //Obtém o nome do arquivo para leitura
            fileName = fileChooser.FileName;
            ClearTextBoxes();

            //Mostra erro se o usuário digitou arquivo inválido
            if(fileName == "" || fileName == null)
               
                MessageBox.Show("Nome de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else{
            
                //Cria FileStream para obter acesso de leitura ao arquivo 
                arquivo_entrada = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                btProximoRegistro.Enabled = true;
            }
        }

        private void btProximoRegistro_MouseClick(object sender, MouseEventArgs e){
        
            //Deserializa objetos da classe Registro e armazena os dados nas TextBoxes
            try{
         
                Registro registro = (Registro)reader.Deserialize(arquivo_entrada);

                //Armazena valores de Registro num array de string 
                string[] values = new string[]{
                                              registro.getConta().ToString(), 
                                              registro.getPrimeiroNome().ToString(),
                                              registro.getUltimoNome().ToString(),
                                              registro.getSaldo().ToString()
                                              };

                //Copia os valores do array de string nos valores dos TextBox 
                SetTextBoxValues(values);
            }

            //Trata excecção, quando não existe Registro no arquivo
            catch(SerializationException){
                
                //Fecha FileStream se não houver Registro no arquivo
                arquivo_entrada.Close();

                //Habilita o botão para abrir arquivo 
                btAbrirArquivo.Enabled = true;

                //Desabilita botão de próximo Registro
                btProximoRegistro.Enabled = false;

                ClearTextBoxes();

                //Notifica o usuário se não existe Registro em arquivo
                MessageBox.Show("Não existem mais registros no arquivo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
