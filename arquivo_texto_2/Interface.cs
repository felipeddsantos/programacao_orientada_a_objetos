/*

Programação Orientada a Objetos - Arquivo Texto II (Programa Principal)
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
using System.IO; 

namespace ArquivoTexto{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        //Obtem informação sobre arquivo ou diretório
        private string obtemInformacaoArquivo(string nomeArquivo){
            
            string informacao;

            //Saída dizendo que o arquivo ou diretório existe
            informacao = nomeArquivo + " existe\r\n\r\n";

            //Saída dizendo quando o arquivo ou diretório foi criado
            informacao += "Criado em : " + File.GetCreationTime(nomeArquivo) + "\r\n";

            //Saída dizendo quando o arquivo ou diretório foi modificado pela última vez
            informacao += "Última modificação: " + File.GetLastWriteTime(nomeArquivo) + "\r\n";

            //Saída dizendo quando o arquivo ou diretório foi acessado pela última vez
            informacao += "Último acesso: " + File.GetLastAccessTime(nomeArquivo) + "\r\n" + "\r\n";

            return informacao;
        }

        //Chamado quando o usuário pressiona uma tecla
        private void tbEntrada_KeyDown(object sender, KeyEventArgs e){
        
            //Determina se o usuário pressionou a tecla Enter
            if(e.KeyCode == Keys.Enter){
            
                // nome do arquivo ou diretório
                string nomeArquivo;

                //Pega arquivo ou diretório especificado pelo usuário
                nomeArquivo = tbEntrada.Text;

                //Determina se nomeArquivo é um arquivo
                if(File.Exists( nomeArquivo )){
                
                    //Obtenha a data de criação do arquivo, data de modificação, etc.
                    tbSaida.Text = obtemInformacaoArquivo(nomeArquivo);

                    //Exibe o conteúdo do arquivo por meio de StreamReader
                    try{
                    
                        //Obtém o Reader e o conteúdo do arquivo
                        StreamReader stream = new StreamReader(nomeArquivo);
                        tbSaida.Text += stream.ReadToEnd();
                    }
                    
                    //Trata exceção se StreamReader está indisponível
                    catch(IOException){
                     
                        MessageBox.Show("Erro de Arquivo", "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Determine se nomeArquivo é um diretório
                else if(Directory.Exists(nomeArquivo)){
                    
                    //Array para diretórios
                    string[] directoryList;

                    //Obtém data de criação do diretório, data de modificação, etc.
                    tbSaida.Text = obtemInformacaoArquivo(nomeArquivo);

                    //Obtém a lista de arquivos e diretórios
                    directoryList = Directory.GetDirectories(nomeArquivo);

                    tbSaida.Text += "\r\n\r\nConteúdo do diretório:\r\n";

                    //Exibe conteúdo de directoryList 
                    for(int i = 0; i < directoryList.Length; i++)
                       
                        tbSaida.Text += directoryList[i] + "\r\n";
                }
             
                else
             
                    //Notifica usuário quando não existe arquivo ou diretório
                    MessageBox.Show(tbEntrada.Text + " não existe", "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
