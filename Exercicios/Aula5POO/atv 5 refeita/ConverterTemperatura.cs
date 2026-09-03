using System;
namespace quintarefeita;

public class ConverterTemperatura
{
    public static double CparaF(double celsius)=>(celsius * 9 / 5) + 32;
    
    public static double FparaC(double fahrenheit)=>(fahrenheit - 32) * 5 / 9;
    
}