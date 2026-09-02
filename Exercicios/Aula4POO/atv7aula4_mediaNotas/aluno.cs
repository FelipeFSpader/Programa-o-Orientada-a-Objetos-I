using System;
namespace SetimaAtividade;
public class Aluno
{
    public string Nome;
    public double[] Notas;
    public double CalcularMedia()
    {
        double soma = 0;

        foreach (double nota in Notas)
        {
            soma += nota;
        }

        return soma / Notas.Length;
    }
    public bool VerificarAprovado()
    {
        double media = CalcularMedia();

        if (media >= 6.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}