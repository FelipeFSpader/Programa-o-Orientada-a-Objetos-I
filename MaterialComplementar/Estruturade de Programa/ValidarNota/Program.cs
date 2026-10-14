namespace ValidarNota;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"--Validar Nota--

Qual sua nota? (entre 0 e 10)");
        double nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Não");
        }
        else if (nota >= 7)
            Console.WriteLine("Aprovado");
        else if (nota < 6.9 && nota > 5)
            Console.WriteLine("Recuperação");
        else
            Console.WriteLine("Reprovado");
    }
}