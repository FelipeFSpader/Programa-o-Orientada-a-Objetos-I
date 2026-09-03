using System;
namespace sextarefeita;

public class IMC
{
    public static double CalcularIMC(double peso, double altura) //metodo construtor 
    {
        //tratamento de excessão - impede usuários de por altura < 0
        if (altura <= 0) throw new ArgumentException("A altura deve ser maior que zero.");
        return peso / (altura * altura);
    }

    public string ClassificarIMC(double imc) //metodo construtor 
    {
       if(imc<18.5) return "Abaixo do peso";
       else if(imc<24.9) return "Peso normal";
       else if(imc<29.9) return "Sobrepeso";
       else if (imc < 34.9) return "Obesidade grau I";
       else if (imc < 39.9) return "Obesidade grau II";
       else return "Obesidade grau III";
    }
}