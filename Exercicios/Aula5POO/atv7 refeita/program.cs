using System;
namespace septmarefeita;

public class Program
{
    public static void Main()
    {
        //passa os parametros do construtor da classe Aluno, que são o nome e um array de notas
        Aluno felipe = new Aluno("Felipe", new double[] { 7.5, 8.0, 9.5 });

        Console.WriteLine($"Média: {felipe.CalcularMedia():F2}");
        Console.WriteLine("Situação: "+felipe.VerificarAprovar());       
    }
}