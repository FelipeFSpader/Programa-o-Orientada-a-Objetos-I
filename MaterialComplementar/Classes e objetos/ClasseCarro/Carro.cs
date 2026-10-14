namespace ClasseCarro;

public class Carro
{
    public string modelo;
    public double velocidadeAtual;

    public void ExibirVelocidade()
    {
        Console.WriteLine($"O carro {modelo} anda na velocidade de {velocidadeAtual} Km/h");
    }

    public double Acelerar()
    {
        velocidadeAtual += 10;
        return velocidadeAtual;
    }
    public double Freiar()
    {
        velocidadeAtual -= 10;
        return velocidadeAtual;
    }
    
}