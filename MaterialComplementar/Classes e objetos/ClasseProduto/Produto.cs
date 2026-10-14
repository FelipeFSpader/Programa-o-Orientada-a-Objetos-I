namespace ClasseProduto;

public class Produto
{
    public string nome;
    public double preco;
    public int quantidade; 

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O produto {nome} custa R${preco}");
    }

    public double CalcularTotal()
    {
        return preco*quantidade;
   }
}