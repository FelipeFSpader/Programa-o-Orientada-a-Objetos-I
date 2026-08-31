using System;
using classeProduto;
class Program
{
    static void Main()
    {
        Produto p = new Produto("Bala de café", 6.66, 10);
        Console.WriteLine(p.ExibirInformacoes());
    }
}