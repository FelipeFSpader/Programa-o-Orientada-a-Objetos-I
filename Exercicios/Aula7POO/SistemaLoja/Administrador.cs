using System;
namespace SistemaLoja;

public class Administrador : Funcionario
{
    private string setor;
    private int chamadosAtendidos;
    // O construtor do Administrador recebe os dados e repassa para a classe Funcionario
    public Administrador(string nome, string cpf, double salario, string Setor) : base(nome, cpf, salario, "administrador")
    {
       chamadosAtendidos=0; 
       this.setor=Setor;
    }

    public void resolverChamado(double percentual)
    {
        chamadosAtendidos++;
    if (chamadosAtendidos % 10 == 0)
        {
            AjustarSalario(5);
        }
    }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Setor: {setor}");
        Console.WriteLine($"Chamados atendidos: {chamadosAtendidos}");
    }

}