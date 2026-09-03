using System;
namespace sextarefeita;

public class Programa
{
    public static void Main()
    {

     IMC meuimc = new();
     double valor = IMC.CalcularIMC(60, 1.68);
     Console.WriteLine($"Classificação: "+ meuimc.ClassificarIMC(valor)+$" - Valor do IMC: {valor:F2}");
    }


}