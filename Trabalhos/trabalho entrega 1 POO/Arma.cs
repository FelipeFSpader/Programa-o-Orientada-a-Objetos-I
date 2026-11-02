namespace trabalho_entrega_1_POO;

public class Arma : Item
{
    private int dano;
    private int municao;

    // base(varNome, varPreco)
    public Arma(string nomeVar, int nivelVar, int danoVar, int municaoVar) : base(nomeVar, nivelVar)
    {
        DefinirDano(danoVar);
        DefinirMunicao(municaoVar);
    }
    
    public int LerDano()
    {
        return dano;
    }
    public void DefinirDano(int novoDano)
    {
        if (novoDano < 1 || novoDano > 100)
            throw new ArgumentException("O dano deve ser de 1 até 100.");

        dano = novoDano;
    }
    
    public int LerMunicao()
    {
        return municao;
    }
    public void DefinirMunicao(int novaMunicao)
    {
        if (novaMunicao < 0)
            throw new ArgumentException("A munição não pode ser negativa.");

        municao = novaMunicao;
    }
    
    public override string SaberTipo()
    {
        return "Arma";
    }
    
    public override void VerPropridades()
    {
        base.VerPropridades(); //reaproveitar o código da classe Item
        Console.WriteLine($"Dano    : {dano}");
        Console.WriteLine($"Munição : {municao} balas");
    }

    //usar = disparar. lembrar de fazer gastar bala.
    public override string UsarItem()
    {
        if (municao == 0)
            return $"{LerNome()} está sem munição !!vamos pro algo mais bonitinho!";

        municao--;
        return $"{LerNome()} causa {dano} de dano. Restam {municao} balas. !!vamos pro algo mais bonitinho!!";
    }
}
