using System;
using System.Collections.Generic;

namespace DisplayRoutesExercicio
{
    /*
     MENU DE OPÇÕES
    1 -  CADASTRO DE CLIENTES
    2- LISTAR
    3 - REMOVER
    4 - SAIR
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cliente clientes = new Cliente();

            bool sistema = true;

            while (sistema)
            {
                switch (Menu())
                {
                    case 1:
                        clientes.Cadastrar();
                        break;
                    case 2:
                        
                        clientes.Listar();
                        break;
                    case 3:
                        clientes.Remover();
                        break;
                    case 4:
                        Console.WriteLine("Sistema encerrado");
                        sistema = false;
                        break;
                        
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                        
                }
            }
         
        
        }

        public static int Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES \n------------------------ " +
                "\n|1- CADASTRAR CLIENTES " +
                "\n|2- LISTAR CLEINTES" +
                "\n|3- REMOVER CLIENTES " +
                "\n|4 - SAIR " +
                "\n------------------------ " +
                "\n ESCOLHA SUA OPÇÃO");

            int opcaoSelecionada = int.Parse(Console.ReadLine());
            return opcaoSelecionada;
        } 

    }
}
