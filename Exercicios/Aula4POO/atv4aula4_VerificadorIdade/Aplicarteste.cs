using System;
namespace QuartaAtividade;

class Aplicarteste
{
    static void Main()
    {
        VerificadorIdade verificadorI = new();

        bool resposta = verificadorI.Verificador(20);

        Console.WriteLine($"É maior de idade?\n {resposta}");
    }
}