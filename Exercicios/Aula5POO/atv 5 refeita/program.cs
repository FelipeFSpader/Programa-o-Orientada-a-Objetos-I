using System;
namespace quintarefeita;
public class Program
{
    
    public static void Main()
    {

    ConverterTemperatura converteAmbos = new ();
    Console.WriteLine($"30ºC em Fahrenheit é: {ConverterTemperatura.CparaF(30)}");
    Console.WriteLine($"86ºF em Celsius é: {ConverterTemperatura.FparaC(86)}"); 
 
    }
    
}