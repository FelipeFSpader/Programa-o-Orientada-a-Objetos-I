using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ReescreverPessoa;

public class Pessoa
{
    
    private string nome;    
    public string lerNome()
    {
        return nome;
    }
    public void escreverNome(string texto)
    {
        if (!string.IsNullOrEmpty(texto))
            nome = texto;
    }
    
    private int idade;
    public int lerIdade()
    {
        return idade;
    }
    public void escreverIdade(int valor)
    {
        if (valor >= 0)
            idade = valor;
    }
    
    private string email;
    public string lerEmail()
    {
        return email;
    }
    public void escreveEmail(string textoUm)
    {
        if (!string.IsNullOrEmpty(textoUm))
            email = textoUm;
    }
    
    public Pessoa(string varNome, int varIdade, string varEmail)
    {
        if(string.IsNullOrWhiteSpace(varNome))
            throw new ArgumentNullException("Nome não pode ser vazio ou nulo"); 
        if(varIdade < 0)
            throw new ArgumentOutOfRangeException("Tu não nasceu");
        if (!varEmail.Contains("@"))
            throw new ArgumentException("Isso não é email");
        this.email=varEmail;
        this.idade=varIdade;
        this.nome=varNome;
    }

    private bool MaiorIdade()
    {
        return idade >= 18;
    }

    protected string IdentificacaoBase()
    {
        return $"nome: {nome} " +
               $"Idade: {idade} "+
               $"Adulto: {MaiorIdade()} "+
               $"Contato: {email}";
    }

    public virtual void Apresentar()
    {
        Console.WriteLine(IdentificacaoBase());
    }
}