using System;
namespace Biblioteca
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public string CPF {get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Se chama {Nome}");
        }
    }
}