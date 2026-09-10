using System;
namespace Empresax
{
    public class Pessoa
    {
        public string Nome{ get; set; }
        public string CPF{ get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, CPF: {CPF}");
        }
    }
}