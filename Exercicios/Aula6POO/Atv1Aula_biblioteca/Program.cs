using System;
namespace Biblioteca
{
    public static void Main()
    {
        Pessoa p1 = new()
            {
                //Forma de passar valores
                Nome="Luís",
                CPF="5432112345"
            };
            //objeto.método();
            p1.Apresentar();

            Cliente cli = new()
            {
                Nome="Felipe",
                CPF="123.123.45.22",
                Matricula="ADM-001",
                Salario=7500,
                Setor="Financeiro"
            };
            Console.WriteLine(" ");
            cli.Apresentar();
            cli.Trabalhar();

            Funcionário fu = new()
            {
                Nome="Spader",
                CPF="123.456.789.11",
                Matricula="OP123",
                Area="Assistente de IA"
            };
            Console.WriteLine(" ");
            fu.Apresentar();
            fu.Trabalhar();

            Autor au = new()
            {
                Nome="Luisinho",
                CPF="0987678456",
                CodigoCliente="Cliente123",
            };
            Console.WriteLine(" ");
            au.Apresentar();
            au.comprar();

            Auxiliar aux = new()
            {
                Nome="Lipe",
                CPF="8887776665554",
                Empresa="PositivoLabs"  
            };
            Console.WriteLine(" ");
            aux.Apresentar();
            aux.Fornecer();

            bibliotecario bib = new()
            {
                Nome="Lipe",
                CPF="8887776665554",
                Empresa="PositivoLabs"  
            };
            Console.WriteLine(" ");
            bib.Apresentar();
            bib.Fornecer();
    }
}