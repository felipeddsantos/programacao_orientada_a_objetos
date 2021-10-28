/*

Programação Orientada a Objetos - Registro Aluno I (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAluno{

    class Program{
        
        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos){
        
            Aluno achei_aluno = null;
            
            for(int i = 0; i < alunos.Count(); i++){
                
                if(nome_aluno == alunos[i].getNome()){
                
                        achei_aluno = alunos[i];
                        
                        break;
                    }
                }
                
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias){
        
            Materia achei_materia = null;

            for(int i = 0; i < materias.Count(); i++){
               
                if(nome_materia == materias[i].Nome){
                   
                    achei_materia = materias[i];
                   
                    break;
                }
            }
            
            return achei_materia;
        }

        static void Main(string[] args){
        
            //Dados para aluno
            String nome_aluno, matricula;
            int periodo;

            //Dados para matéria
            String nome_materia, codigo_materia;

            //Dados para associar aluno e matéria
            Aluno aL;
            Materia mL;

            //Para armazenar os alunos e as matérias criadas
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Materia> listaDisciplinas = new List<Materia>();

            int aux = 1;
            
            while(aux != 0){
            
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Cadastrar um aluno");
                Console.WriteLine(" [2] - Cadastrar uma disciplina");
                Console.WriteLine(" [3] - Associar uma disciplina a um aluno");
                Console.WriteLine(" [4] - Imprimir relatório");
                Console.WriteLine(" [5] - Sair");

                string op = Console.ReadLine();

                switch(op){
                
                    case "1":
                    
                        Console.Write("Cadastrar um aluno\n");
                        Console.Write("Entre o nome do aluno:");
                        nome_aluno = Console.ReadLine();
                        Console.Write("Entre a matrícula do aluno:");
                        matricula = Console.ReadLine();
                        Console.Write("Entre o período do aluno:");
                        periodo = int.Parse(Console.ReadLine());
                        Aluno a = new Aluno(nome_aluno, matricula, periodo);
                        listaAlunos.Add(a);
                        
                        Console.ReadLine();
                        Console.Clear();
                        
                        break;

                    case "2":
                    
                        Console.Write("Cadastrar uma matéria");
                        Console.Write("Entre o nome da matéria:");
                        nome_materia = Console.ReadLine();
                        Console.Write("Entre o código da matéria:");
                        codigo_materia = Console.ReadLine();
                        Materia m = new Materia(nome_materia, codigo_materia);
                        listaDisciplinas.Add(m);
                        
                        Console.ReadLine();
                        Console.Clear();
                        
                        break;

                    case "3":
                    
                        Console.Write("Associar uma disciplina a um aluno\n");
                        Console.WriteLine("Escolha um aluno:\n");
                        
                        //Apresentar lista de alunos:
                        for(int i = 0; i < listaAlunos.Count; i++)
                        
                            Console.WriteLine("Aluno = " + listaAlunos[i].getNome());
                       
                        nome_aluno = Console.ReadLine();
                        aL = achaAluno(nome_aluno, listaAlunos);
                        Console.WriteLine("Escolha uma matéria:\n");
                        
                        //Apresentar lista de matérias:
                        for(int i = 0; i < listaDisciplinas.Count; i++)
                        
                            Console.WriteLine("Matéria = " + listaDisciplinas[i].Nome);
                        
                        nome_materia = Console.ReadLine();
                        mL = achaMateria(nome_materia, listaDisciplinas);
                        
                        //Associa Aluno à matéria
                        aL.associaMateria(mL);
                        
                        Console.ReadLine();
                        Console.Clear();
                        
                        break;

                    case "4":
                    
                        Console.Write("Imprimir relatório :\n");
                        Console.ReadLine();
                        Console.Clear();
                        
                        break;

                    case "5":
                    
                        aux = 0;
                        Console.Clear();
                        
                        break;
                        
                    default:
                    
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        Console.ReadLine();
                        
                        break;
                }
            } 
        }
    }
}
