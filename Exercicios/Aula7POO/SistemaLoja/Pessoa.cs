using System;
namespace SistemaLoja;

public abstract class Pessoa
{
    //visivel apenas nessa classe
    private string cpf;
    protected string nome;

    public Pessoa(string varCpf, string varNome)
    {
        if(string.IsNullOrWhiteSpace(varNome))
            throw new ArgumentNullException("Nome não pode ser vazio ou nulo");    //exceção de argumento
        if(varCpf.Length!=11)
            throw new ArgumentException("CPF precisa de 11 digitos");
        this.cpf=varCpf;
        this.nome=varNome;
    }

    private string ObterPrimeiroDigitoCPF()
    {
        return cpf.Substring(0,3); //vai retornar os três primeiros elementos 
    } 

    protected string IdentificacaoBase()
    {
        return $"nome: {nome}, CPF(parcial): {ObterPrimeiroDigitoCPF()}";
    }

    public virtual void Apresentar()
    {
        Console.WriteLine(IdentificacaoBase());
    }
}