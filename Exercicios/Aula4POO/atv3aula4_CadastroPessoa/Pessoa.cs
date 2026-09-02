using System;
namespace TerceiraAtividade;
public class Pessoa (string nome, int idade, double altura) //método construtor - mesmo nome da classe, não tem tipo de retorno, recebe parâmetros
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public double Altura { get; set; } = altura;
    public string Apresentar()
    {
        return $"Oi, meu nome é {Nome}, tenho {Idade} anos e {Altura}M de altura";
    }   
}
