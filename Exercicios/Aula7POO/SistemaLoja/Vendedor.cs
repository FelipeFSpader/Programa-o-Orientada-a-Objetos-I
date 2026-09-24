using System;
namespace SistemaLoja;

public class Vendedor : Funcionario
{
    private int vendasRealizadas;
    // O construtor do Vendedor recebe os dados e repassa para a classe Funcionario
    public Vendedor(string nome, string cpf, double salario) : base(nome, cpf, salario, "vendedor")
    {
       vendasRealizadas=0; 
    }

    public void registrarVendas()
    {
        vendasRealizadas++;
    if (vendasRealizadas % 10 == 0)
        {
            AjustarSalario(5);
        }
    }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Vendas realizadas: {vendasRealizadas}");
    }
}