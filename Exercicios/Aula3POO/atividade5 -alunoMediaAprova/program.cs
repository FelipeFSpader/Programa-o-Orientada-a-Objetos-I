using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        // CADASTRO DE ALUNOS
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Diga o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Diga a nota 1 do aluno: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Diga a nota 2 do aluno: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Diga a nota 3 do aluno: ");
            double n3 = double.Parse(Console.ReadLine());

            //atribuir todas as notas ao novo objeto Aluno
            //Leia isso como:
            //"Crie um novo objeto Aluno e coloque nome na propriedade
            // Nome e nota na propriedade Nota."
            //| | | | 
            //V V V V
            alunos.Add(new Aluno
            {
                Nome = nome,
                N1 = n1, 
                N2 = n2, 
                N3 = n3
            });
        }

        // EXIBIR RESULTADOS
        Console.WriteLine("\nResultados:");

        foreach (Aluno aluno in alunos)
        {
            //chama aluno.media() pra pegar o valor
            double mediaCalculada = aluno.Media();

            if (aluno.Aprovado())
            {
                Console.WriteLine($"{aluno.Nome} foi aprovado com nota {mediaCalculada}");
            }
            else
            {
                Console.WriteLine($"{aluno.Nome} foi reprovado com nota {mediaCalculada}");
            }
        }
    }
}
