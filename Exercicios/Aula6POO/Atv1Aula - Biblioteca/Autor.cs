using System;
namespace Biblioteca
{
    public class Autor:Pessoa
    {
        public string Editora{ get; set; }
        
        public void RegistrarObras()
        {
            Console.WriteLine($"O autor {Nome}, da editora {Editora} quer registrar suas obra");
        }
    }
}