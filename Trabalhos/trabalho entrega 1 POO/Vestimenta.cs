namespace trabalho_entrega_1_POO;

public class Vestimenta : Item
{
    private int defesa;
    private bool equipada; // começa como false que não é equipado 

    public Vestimenta(string nomeVar, int nivelVar, int defesaVar) : base(nomeVar, nivelVar)
    {
        DefinirDefesa(defesaVar);
    }

    public int LerDefesa()
    {
        return defesa;
    }
    public void DefinirDefesa(int novaDefesa)
    {
        if (novaDefesa < 1 || novaDefesa > 100)
            throw new ArgumentException("A defesa deve estar entre 1 e 100.");

        defesa = novaDefesa;
    }
    
    public bool EstaEquipada()
    {
        return equipada;
    }

    public override string SaberTipo()
    {
        return "Vestimenta";
    }
    
    public override void VerPropridades()
    {
        base.VerPropridades(); // reaproveita o código da classe Item
        Console.WriteLine($"Defesa  : +{defesa}");
        Console.WriteLine($"Equipada: {(equipada ? "Sim" : "Não")}");
    }

    //Usar uma vestimenta = vestir ou tirar. daí tem que saber se tá ou não equipada
    public override string UsarItem()
    {
        equipada = !equipada;

        if (equipada)
            return $"Veste {LerNome()}. Defesa +{defesa}.";

        return $"Tira {LerNome()} e guarda na bolsa.";
    }
}
