namespace Paridade;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"--VERIFICADOR DE PAR--

Diz um número:");
        int nUm = int.Parse(Console.ReadLine());

        if (nUm % 2 == 0)
            Console.WriteLine("É par!");
        else 
            Console.WriteLine("É ímpar!");
    }
}