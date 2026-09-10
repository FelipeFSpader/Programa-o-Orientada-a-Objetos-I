using System;
namespace Biblioteca
{
    public class Auxiliar:Funcionario
    {
        public int Prateleiras{ get; set; }
        
        public override void Executar()
        {
            Console.WriteLine($"Auxiliar {Nome}, repõe livros na prateleira de {Prateleiras}");
        }
    }
}