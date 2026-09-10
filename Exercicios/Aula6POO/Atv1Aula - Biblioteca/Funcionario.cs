using System;
namespace Biblioteca
{
    public class Funcionario:Pessoa
    {
        public int Salario{ get; set; }
        
        public virtual void Executar()
        {
            Console.WriteLine($"Funcionário {Nome} está executando suas tarefas para ganhar {Salario} no fim do mês");
        }
    }
}