namespace ClasseAluno;

public class Aluno
{
    public string nome;
    public int notaUm;
    public int notaDois;
    public double media = 0;

    public double CalcularMedia()
    { 
        media = (notaUm + notaDois) / 2.0;
        return media;
    }

    public string VerificarSituacao()
    {
        if (media >= 7.0)
            return "Aprovado";
        if (media <= 6.9 && media >= 5.0)
            return "Recuperação";
        if (media < 5)
            return "Reprovado";
        else
            return "invalido";
    }

}