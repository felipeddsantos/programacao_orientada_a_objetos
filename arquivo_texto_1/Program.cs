/*

Programação Orientada a Objetos - Arquivo Texto I
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArquivoTexto{

    class Program{
    
        static void Main(string[] args){
        
            //Declarando a variável do tipo StreamWriter para manipular arquivos
            StreamWriter x;

            //Colocando o caminho físico e o nome do arquivo a ser criado
            string Caminho = "C:\\Users\\marcio\\Desktop\\arquivo.txt";

            //Utilizando um método para criar um arquivo texto e associar o caminho ao método
            x = File.CreateText(Caminho);

            Console.ReadKey();

            //Escrevendo no arquivo texto
            x.WriteLine("Recibo de Pagamento");

            //Pulando linha sem escrita
            x.WriteLine();
            x.WriteLine();

            //Escrevendo conteúdo do recibo
            x.WriteLine("Recebi do Sr: Fulano de Tal");
            x.WriteLine("a quantia de VALOR DO RECIBO (VALOR POR EXTENSO),");
            x.WriteLine("referente a DESCRIÇÃO DO QUE FOI PAGO... ");
            x.WriteLine("CIDADE, DATA");
            x.WriteLine();
            x.WriteLine("______________________________________________________________________");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF do pagador: CPF");
            x.WriteLine();

            //Fechando o arquivo
            x.Close();

            //Abrir e continuar escrevendo no arquivo: 
            x = File.AppendText(Caminho);

            //Continuando escrevendo no arquivo a partir da última linha
            x.WriteLine("");
            x.WriteLine("__________________________________________________________________");
            x.WriteLine("Recebedor");
            x.WriteLine("CPF do recebedor: CPF");

            //Fechando o arquivo novamente
            x.Close();
        }
    }
}
