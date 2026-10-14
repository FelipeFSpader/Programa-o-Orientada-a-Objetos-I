namespace ClasseCarro;

public class Program
{
    static void Main()
    {
        Carro sandero = new();
        sandero.modelo = "Renout Sandero";
        sandero.velocidadeAtual = 40.00;
        
        Carro argo = new();
        argo.modelo = "Fiat Argo";
        argo.velocidadeAtual = 45.00;
        
        sandero.ExibirVelocidade();
        argo.ExibirVelocidade();

        sandero.Acelerar();
        argo.Freiar();
        
        // sandero 50 e argo 35
        sandero.ExibirVelocidade();
        argo.ExibirVelocidade();
    } 
}