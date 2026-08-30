using System;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nomeVar, double precoVar, int quantidadeVar)
    {
        Nome = nomeVar;
        Preco = precoVar;
        Quantidade = quantidadeVar;
    }

    public string ExibirInfos()
    {
        return $"Produto: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
    }

    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }

    public void AddEstoque(int quantidadeVar)
    {
        Quantidade += quantidadeVar;
    }

    public void RemoverEstoque(int quantidadeVar)
    {
        if (quantidadeVar > Quantidade)
        {
            throw new InvalidOperationException("Quantidade insuficiente de estoque.");
        }

        Quantidade -= quantidadeVar;
    }
}
