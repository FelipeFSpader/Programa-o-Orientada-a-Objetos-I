using System;
namespace SextaAtividade;

class Program
{
    static void Main()
    {
        
        metodosIMC calculos = new();

        Console.Write("Insira tua altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Insira tua massa: ");
        double massa = double.Parse(Console.ReadLine());
        
        //objeto.metodo(argumentovar)

        double calcular = calculos.calcularIMC(massa, altura);
        string classificar = calculos.faixas(calcular);
        Console.WriteLine($"Teu IMC é de {calcular:F2}, o que te classifica como {classificar}"); 


    }
}