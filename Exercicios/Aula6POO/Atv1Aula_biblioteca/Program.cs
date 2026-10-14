using System;

namespace Biblioteca
{
    class Program
    {
        static void Main()
        {
            Pessoa p1 = new()
            {
                Nome = "Luís",
                CPF = "5432112345"
            };
            p1.Apresentar();

            Cliente cli = new()
            {
                Nome = "Felipe",
                CPF = "123.123.45.22",
                RegistroC = 1001 // Corrigido: Usando a propriedade real da classe Cliente
            };
            Console.WriteLine(" ");
            cli.Apresentar();
            cli.EmprestarLivros(); // Corrigido: Método correto da classe Cliente

            Funcionario fu = new() // Corrigido: Sem acento, nome exato da classe
            {
                Nome = "Spader",
                CPF = "123.456.789.11",
                Salario = 4500 // Corrigido: Funcionario só tem a propriedade Salario
            };
            Console.WriteLine(" ");
            fu.Apresentar();
            fu.Executar(); // Corrigido: Método correto

            Autor au = new()
            {
                Nome = "Luisinho",
                CPF = "0987678456",
                Editora = "Editora Tech" // Corrigido: Propriedade real de Autor
            };
            Console.WriteLine(" ");
            au.Apresentar();
            au.RegistrarObras(); // Corrigido: Método correto

            Auxiliar aux = new()
            {
                Nome = "Lipe",
                CPF = "8887776665554",
                Salario = 2000,     // Herdado de Funcionario
                Prateleiras = 5     // Propriedade real de Auxiliar (int)
            };
            Console.WriteLine(" ");
            aux.Apresentar();
            aux.Executar(); // Corrigido: Executa o override de Auxiliar

            Bibliotecario bib = new() // Corrigido: Letra maiúscula
            {
                Nome = "Lipe",
                CPF = "8887776665554",
                Salario = 5500,     // Herdado de Funcionario
                Secao = "Ficção Científica" // Corrigido: Propriedade real de Bibliotecario
            };
            Console.WriteLine(" ");
            bib.Apresentar();
            bib.Executar(); // Corrigido: Executa o override de Bibliotecario
        }
    }
}