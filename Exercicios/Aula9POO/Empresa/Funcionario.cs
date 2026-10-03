/*
 * sobreescrita overrdide
 * é para classes diferentes
 *
 * sobrecarga
 * é para mesma classe
 */


namespace Empresa;

public class Funcionario
{
    public string Nome {get;set;}
    public double Salario { get; set; }

    public Funcionario(string nomevar, double salariovar)
    {
        Nome = nomevar;
        Salario = salariovar;
    }
    
    public virtual void Exibir()
    {
        Console.WriteLine($"Funcionário: {Nome}");
        Console.WriteLine($"Salário: {Salario}");
    }

    public virtual double CalcularBonus()
    {
        return Salario * 0.1;
    }

    //sobrecarga
    //mesmo objeto
    public virtual double CalcularBonus(double percentual)//esse tem parametro - assinatura
    {
        return Salario * percentual / 100;
    }
}

public class Gerente : Funcionario
{
    public int QuantidadedeFuncionario { get; set; }

    public Gerente(string nome, double salario, int quantidadedeFuncionario)
        : base (nome,salario)
    {
        QuantidadedeFuncionario = quantidadedeFuncionario;
    }

    public override void Exibir()
    {
        Console.WriteLine("---Gerente---");
        Console.WriteLine($"Nome: {Nome}, /nSalario: {Salario:F2}");
    } 
}

public class Vendedor : Funcionario
{
    public double totalVendas { get; set; }

    public Vendedor(string nome, double salario, double totalvendas)
        : base(nome, salario)
    {
        totalVendas = totalvendas;
    }
    
    public override void Exibir() 
    {
        Console.WriteLine("---Vendedor---");
        Console.WriteLine($"Nome: {Nome}, /nSalario: {Salario:F2}");
    }
}

public class Desenvolvedor : Funcionario
{
    
    public string Linguagem { get; set; }
    
    public Desenvolvedor(string nome, double salario, string linguagem)
        : base(nome, salario)
    {
        Linguagem = linguagem;
    }
    
    public override void Exibir() 
    {
        Console.WriteLine("---Desenvolvedor---");
        Console.WriteLine($"Nome: {Nome}, /nSalario: {Salario:F2}/nLinguagem: {Linguagem}");
    }
    
}