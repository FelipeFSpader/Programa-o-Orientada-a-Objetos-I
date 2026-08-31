using System;
namespace TerceiraAtividade;
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }
    public string Apresentar()
    {
        return $"Oi, meu nome é {Nome}, tenho {Idade} anos e {Altura}M de altura";
    }   
}
