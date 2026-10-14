using System;
namespace CalculadoraSimples;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"---CALCULADORA---

Diga o primeiro número da operação");
        int nUm = int.Parse(Console.ReadLine());

        Console.WriteLine(@"1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão");
        string escolha = Console.ReadLine();
        
        Console.WriteLine("Diga o segundo número da operação");
        int nDois = int.Parse(Console.ReadLine());

        int resposta = 0;
        
        switch (escolha)
        {
            case "1":
                resposta = nUm + nDois;
                break;
            case "2":
                resposta = nUm - nDois;
                break;
            case "3":
                resposta = nUm * nDois;
                break;
            case "4":
                if (nDois != 0)
                    resposta = nUm / nDois;
                else
                    Console.WriteLine("Não");
                break;
            default:
                Console.WriteLine("inválido");
                break;
        }

        Console.WriteLine($"Resultado: {resposta}");
    }
}