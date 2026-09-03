using System;
namespace quartarefeita;

public class TesteVerificarIdade
{
    public static void Main()
    {
        VerificadorIdade v = new VerificadorIdade();

        int idadeTeste = 20;

        // Uso do Ternário dentro da Interpolação de Strings ($""):
        // Estrutura: (condicao ? "Texto se verdadeiro" : "Texto se falso")
        Console.WriteLine($"A pessoa com {idadeTeste} anos {(v.EhMaiorDeIdade(idadeTeste) ? "é maior de idade." : "não é maior de idade.")}");
    }
}