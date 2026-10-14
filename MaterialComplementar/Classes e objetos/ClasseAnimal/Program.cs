namespace ClasseAnimal;

public class Program
{
    static void Main()
    {
        Animal estimacao = new();
        Console.WriteLine("Qual nome do seu animal de estimacao?");
        estimacao.nome = Console.ReadLine();
        
        Console.WriteLine("Qual a raca do seu animal de estimacao?");
        estimacao.especie = Console.ReadLine();
        
        Console.WriteLine("Qual a idade do seu animal de estimacao?");
        estimacao.idade = int.Parse(Console.ReadLine());

        Console.WriteLine(estimacao.EmitirSom());
    }
}