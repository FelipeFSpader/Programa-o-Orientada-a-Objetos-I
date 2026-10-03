using System.Collections;
using FormasGeometrica;

public class Program
{
    static void Main()
    {
        ArrayList formas = new ArrayList();
        formas.Add(new Retangulo(10, 4));
        formas.Add(new Circulo(100));
        formas.Add(new Triangulo(3, 9));
        formas.Add(new Retangulo(10, 3));
        formas.Add(new Retangulo(7));

        foreach (FormaGeometrica forma in formas)
        {
            forma.Exibir();
            Console.WriteLine($"Forma: {forma.CalcularArea()}");
            Console.WriteLine($"Forma: {forma.CalcularArea(5)}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}