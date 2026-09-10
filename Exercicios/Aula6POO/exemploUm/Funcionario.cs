using System;
namespace Empresax
{
    public  abstract class Funcionário:Pessoa 
    {
        public string Matricula{ get; set; }
        public decimal Salario{ get; set;}

        public virtual void Trabalhar() //Posso sobreescrever esse método nas demais classes filhas override
        {
            Console.WriteLine($"Funcionário {Nome} está trabalhando");
        }
    }        
}