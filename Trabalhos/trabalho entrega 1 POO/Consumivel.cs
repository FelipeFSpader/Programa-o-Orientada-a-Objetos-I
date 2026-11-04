namespace trabalho_entrega_1_POO;

public class Consumivel : Item
{
    private int vidaRecuperada;
    private int quantidade;

    public Consumivel(string nomeVar, int nivelVar, int varVidaRecuperada, int quantidadeVar) : base(nomeVar, nivelVar)
    {
        DefinirRecuperacao(varVidaRecuperada);
        DefinirQuantidadeConsumivel(quantidadeVar);
    }
    
    public int LerRecuperacao()
    {
        return vidaRecuperada;
    }
    public void DefinirRecuperacao(int novaRecuperacao)
    {
        if (novaRecuperacao < 1 || novaRecuperacao > 100)
            throw new ArgumentException("A defesa deve estar entre 1 e 100.");

        vidaRecuperada = novaRecuperacao;
    }
    
    public int LerQuantidadeConsumivel()
    {
        return quantidade;
    }
    public void DefinirQuantidadeConsumivel(int novaQuantidade)
    {
        if (novaQuantidade < 0)
            throw new ArgumentException("A quantidade não pode ser negativa");

        quantidade = novaQuantidade;
    }

    public override string SaberTipo()
    {
        return "Consumível";
    }

    public override void VerPropridades()
    {
        base.VerPropridades(); // reaproveita o código da classe Item
        Console.WriteLine($"Recupera: {vidaRecuperada} de vida");
        Console.WriteLine($"Quantiadade: {quantidade} unidade(s)");
    }

    public override string UsarItem()
    {
        if (quantidade == 0)
            return $"Acabou o estoque de {LerNome()}.";

        quantidade--;
        return $"Consome {LerNome()} e recupera {vidaRecuperada} de vida. Restam {quantidade}.";
    }
}
