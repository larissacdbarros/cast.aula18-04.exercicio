using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesExercicio
{
  public class Cliente
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Funcao { get; set; }
        public string Email{ get; set; }

        public List<Cliente> todosClientes = new List<Cliente>();
        public Cliente() { }
        
        public Cliente(string nome, double salario, string funcao, string email)
        {
           
            this.Nome = nome;
            this.Salario = salario;
            this.Funcao = funcao;
            this.Email = email; 

        }
        public void Listar()
        {
            
            foreach(Cliente cliente in todosClientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}    Salario:{cliente.Salario}    Função{cliente.Funcao}     Email:{cliente.Email}");
            }

        }

     
        public void Cadastrar()
        {
            Console.Write("Informe o nome do cliente:");
            string nome = Console.ReadLine();
            Console.Write("Informe o salário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Inform a função:");
            string funcao = Console.ReadLine();
            Console.Write("Inform o email:");
            string email = Console.ReadLine();
            
            todosClientes.Add(new Cliente(nome, salario, funcao, email));

           
    }

        public void Remover()
        {
            Listar();
            
            foreach (Cliente cliente in todosClientes)
            {
                Console.WriteLine("Informe o nome do cliente que deseja remover");
                string nome = Console.ReadLine();
                if (nome.Equals(cliente.Nome))
                {
                    
                    todosClientes.Remove(cliente);
                    break;
                }
            }
        }
    }
}
