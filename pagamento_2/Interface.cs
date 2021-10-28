/*

Programação Orientada a Objetos - Pagamento II (Programa Principal)
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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Pagamento{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        private FileStream arquivoe;
        private FileStream arquivos;
        private FileStream arquivoea;

        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();

        string nomearquivo, a, b;

        private void btrelatorio_Click(object sender, EventArgs e){
        
            arquivoe.Close();
            a = b = "";
            OpenFileDialog fileChooser = new OpenFileDialog();
            List<Registro> registro = new List<Registro>();
            DialogResult result = fileChooser.ShowDialog();
            string fileName, total;

            if(result == DialogResult.Cancel)
            
                return;

            fileName = fileChooser.FileName;

            if(fileName == "" || fileName == null)
               
                MessageBox.Show("Nome do arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            else
              
                arquivoea = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            
            try{
               
                while(1 > 0)

                    registro.Add((Registro)reader.Deserialize(arquivoea));
            }

            catch(SerializationException){

                for(int i = 0; i < registro.Count; i++){
                   
                    if(registro[i].getCodigo() == 1) 

                        a = "Nome: " + registro[i].getNome() + "CPF: " + registro[i].getCPF() + "Valor: " + 
                        registro[i].getValor() + Environment.NewLine + "Área: Saúde" + a;

                    if(registro[i].getCodigo() == 2)

                        b = "Nome: " + registro[i].getNome() + "\nCPF: " + registro[i].getCPF() + "\nValor: " +
                        registro[i].getValor() + "\nÁrea: Alimentação" + b;
                }

                total = a + b;
            }
            
            string o = Directory.GetCurrentDirectory();

            o = o + "\\Relatório.txt";

            StreamWriter output = new StreamWriter(o);

            output.Write(total);

            MessageBox.Show("Relatório criado com sucesso", "Aviso", MessageBoxButtons.OK);

            output.Close();
        }
        
        private void btcadastro_Click(object sender, EventArgs e){
           
            Registro cliente = new Registro();
            cliente.setNome((string)(tbnome.ToString() + Environment.NewLine));
            cliente.setCPF(tbCPF.ToString()+ Environment.NewLine);
            cliente.setValor(Double.Parse(tbValor.Text));

            if(rbsaude.Checked){
            
                cliente.setCodigo(1);
                cliente.setValor(cliente.getValor() + cliente.getValor()*0.12);
            }

            if(rbalimento.Checked){
            
                cliente.setCodigo(2);
                cliente.setValor(cliente.getValor() + cliente.getValor() * 0.05);
            }

            formatter.Serialize(arquivoe, cliente);

            MessageBox.Show("Registro criado com sucesso", "Aviso", MessageBoxButtons.OK);
        }

        private void btcriar_Click(object sender, EventArgs e){
            
            SaveFileDialog fileChooser = new SaveFileDialog();
            DialogResult resultado = fileChooser.ShowDialog();
            string nomeArquivo; 

            fileChooser.CheckFileExists = false;

            if(resultado == DialogResult.Cancel)
            
                return;

            nomeArquivo = fileChooser.FileName;

            if(nomeArquivo == "" || nomeArquivo == null)
            
                MessageBox.Show("Nome de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            else{
        
                try{
                
                    arquivoe = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write);
                }

                catch(FileNotFoundException){
                  
                    MessageBox.Show("Arquivo não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
