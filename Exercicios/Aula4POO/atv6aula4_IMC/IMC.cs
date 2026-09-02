using System;
namespace SextaAtividade;

public class metodosIMC
{
    //imc = peso / alutra*altura
    public double calcularIMC(double massa, double altura)
    {
        return massa / (altura*altura);
    }

    //magreza, normal, sobrepeso, obesidade I, II, III
    public string faixas(double valorIMC)
    {
        if (valorIMC <= 18.5)
        {
            return "magreza";
        }
        else if (valorIMC > 18.5 && valorIMC <= 24.9)
        {
            return "normal";
        }
        else if (valorIMC > 25.0 && valorIMC <= 29.9)
        {
            return "sobrepeso";
        }
        else if (valorIMC > 30.0 && valorIMC <= 34.9)
        {
            return "obeso I";
        }else if (valorIMC > 35.0 && valorIMC < 39.9)
        {
            return "obeso II severo";
        }else 
        {
            return "obeso III mórbido";
        }
    }
}