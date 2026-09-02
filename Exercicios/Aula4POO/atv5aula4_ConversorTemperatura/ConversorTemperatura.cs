using System;
namespace QuintaAtividade;

public class ConversorTemperatura
{

    // Celsius para Fahrenheit F=(C×1.8)+32
    public double CparaF(double TempCelsius)
    {
        return (TempCelsius * 1.8) + 32;
    }
    
    //Fahrenheit para Celsius C = (F-32)/1.8
    public double FparaC(double TempFar)
    {
        return (TempFar - 32)/1.8;
    }
}
