using System;
namespace septmarefeita;

public class Aluno
{
    
    public string Nome { get; set; }
    public double[] Notas{ get; set; }

    public Aluno(string nomevar, double[] notasvar) //construtor 
    {
        Nome = nomevar;
        Notas = notasvar;
    }

    public double CalcularMedia()
    {
        //verifica se o array de notas está vazio - usa .Length pra isso
        if(Notas.Length == 0) return 0;
        double soma = 0;
        foreach (var nota in Notas) soma += nota;
        return (soma / Notas.Length);
    }

    public string VerificarAprovar()
    {
        //jeito esperto de verificar se a média é maior ou igual a 6 e retornar "aprovado" ou "reprovado" 
        // sem if/else
        return CalcularMedia() >= 6 ?"aprovado" : "reprovado";
    }


}