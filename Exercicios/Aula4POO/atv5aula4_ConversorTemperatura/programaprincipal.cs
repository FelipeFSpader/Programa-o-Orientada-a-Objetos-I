using System;
namespace QuintaAtividade;

class Program
{
    static void Main()
    {
        
        ConversorTemperatura conversorAmbos = new();

        Console.Write("Diga uma temperatura em ºC: ");
        double TempCelsius = double.Parse(Console.ReadLine());

        Console.Write("Diga uma temperatura em ºF: ");
        double TempFar = double.Parse(Console.ReadLine());

        double casoum = conversorAmbos.CparaF(TempCelsius);
        Console.WriteLine($"A temperatura {TempCelsius:F2}ºC, se converte para {casoum:F2}ºF");

        double casodois = conversorAmbos.FparaC(TempFar);
        Console.Write($"A temperatura {TempFar:F2}ºF se converte em {casodois:F2}ºC");
        
        //0 celcius = 32 farenheit... vice-versa 

    }
}