namespace trabalho_entrega_1_POO;

public class Item
{
    private int codigo;
    private string nome = "";
    private int nivel;

    public Item(string nomeVar, int nivelvar)
    {
        this.nome = nomeVar;
        this.nivel = nivelvar;
    }
    
    //COISAS DA VARIAVEL CÓDIGO
    public int LerCodigo()
    {
        return codigo;
    }
    public void DefinirCodigo(int novoCodigo)
    {
        if (codigo != 0)
            throw new InvalidOperationException("Este item já possui um código.");

        if (novoCodigo <= 0)
            throw new ArgumentException("O código deve ser maior que zero.");

        codigo = novoCodigo;
    }
    //COISAS DA VARIAVEL CÓDIGO
    
    //-----------------------------------------------------------------------------
    
    //COISAS DA VARIAVEL NOME
    public string LerNome()
    {
        return nome;
    }
    public void MudarNome(string NovoNome)
    {
        if (string.IsNullOrWhiteSpace(NovoNome))
            throw new ArgumentException("Nome é obrigatório");
        nome = NovoNome;
    }
    //COISAS DA VARIAVEL NOME
    
    //-----------------------------------------------------------------------------

    //COISAS DA VARIAVEL NIVEL
    public int LerNivel()
    {
        return nivel;
    }
    public void MudarNivel(int NovoNivel)
    {
        if (NovoNivel <= 0)
            throw new ArgumentException("Nível deve ser maior que zero");
        nivel = NovoNivel;
    }
    //COISAS DA VARIAVEL NIVEL
    
    //-----------------------------------------------------------------------------
    
    //METODOS DO ITEM - USAR VIRTUAL PRA PODER SOBRESCREVER 

    public virtual string SaberTipo()
    {
        return "Item";
    }

    public virtual void VerPropridades() // : super()
    {
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Tipo    : {SaberTipo()}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Nível: {nivel}");
    }

    public virtual string UsarItem()
    {
        return $"{nome} é usado, tal coisa acontece";
    }
}