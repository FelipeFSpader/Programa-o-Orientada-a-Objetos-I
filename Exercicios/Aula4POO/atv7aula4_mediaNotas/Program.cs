using System;
namespace SetimaAtividade;

class Program
{
    static void Main()
    {
        //classe objeto = operador classe
        Aluno aluno1 = new();

        aluno1.Nome = "Luís";
        aluno1.Notas = new double[] { 7.5, 8.0, 8.5, 9.0 };

        //obj.metodo(argumentos)
        double mediaCalculada = aluno1.CalcularMedia();
        bool estaAprovado = aluno1.VerificarAprovado();

                                    //propriedade nome do obj aluno obj.propriedade 
        Console.WriteLine($"Aluno: {aluno1.Nome}");
        Console.WriteLine($"Média: {mediaCalculada:F1}");

        if (estaAprovado)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}