namespace ClassificarIdade;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"--Classificar Idade--

Qual sua idade?");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 0 && idade <= 12)
            Console.WriteLine("Criança");
        else if (idade < 18)
            Console.WriteLine("Adolescente");
        else if (idade <=  65)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Idoso"); 
    }
}