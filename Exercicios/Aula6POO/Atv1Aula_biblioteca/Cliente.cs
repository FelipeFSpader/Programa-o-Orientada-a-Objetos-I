using System;
namespace Biblioteca
{
    public class Cliente:Pessoa
    {
        public int RegistroC{ get; set; }
        
        public void EmprestarLivros()
        {
            Console.WriteLine($"O Cliente {Nome}, de registro {RegistroC} quer emprestar livros");
        }
    }
}