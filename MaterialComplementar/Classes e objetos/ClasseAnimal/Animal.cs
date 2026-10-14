namespace ClasseAnimal;

public class Animal
{
    public string nome;
    public string especie;
    public int idade;

    public string EmitirSom()
    {
        if (especie == "cachorro")
            return "AU AU";
        else if (especie == "gato")
            return "MIAU";
        else
            return "som desconhecido.";
    }
}