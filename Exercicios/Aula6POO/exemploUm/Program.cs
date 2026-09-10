using System;
namespace Empresax
{
    class Program
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

            Administrativo adm = new()
            {
                Nome="Felipe",
                CPF="123.123.45.22",
                Matricula="ADM-001",
                Salario=7500,
                Setor="Financeiro"
            };
            Console.WriteLine(" ");
            adm.Apresentar();
            adm.Trabalhar();

            Operacional op = new()
            {
                Nome="Spader",
                CPF="123.456.789.11",
                Matricula="OP123",
                Area="Assistente de IA"
            };
            Console.WriteLine(" ");
            op.Apresentar();
            op.Trabalhar();

            Cliente cli = new()
            {
                Nome="Luisinho",
                CPF="0987678456",
                CodigoCliente="Cliente123",
            };
            Console.WriteLine(" ");
            cli.Apresentar();
            cli.comprar();

            Fornecedor forn = new()
            {
                Nome="Lipe",
                CPF="8887776665554",
                Empresa="PositivoLabs"  
            };
            Console.WriteLine(" ");
            forn.Apresentar();
            forn.Fornecer();
        }
    }
}