using System;
namespace Biblioteca
{
    public class Bibliotecario:Funcionario
    {
        public string Secao{ get; set; }
        
        public override void Executar()
        {
            Console.WriteLine($"Blibliotecário {Nome}, organiza livros na seção de {Secao} e atende clientes");
        }
    }
}