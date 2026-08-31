using System;
using System.Collections.Generic;
using System.Text;

namespace classeProduto
{
    internal class Produto
    {
        // Propriedades reais do objeto (existem durante toda a vida do produto)
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor: recebe temporariamente as variáveis com 'Var'
        public Produto(string nomeVar, double precoVar, int quantidadeVar)
        {
            Nome = nomeVar;
            Preco = precoVar;
            Quantidade = quantidadeVar;
        }

        // CORREÇÃO AQUI: usa as propriedades reais Nome, Preco e Quantidade
        public string ExibirInformacoes() => $"Produto: {Nome}\nPreço: {Preco}\nQuantidade: {Quantidade}";
        
        public double CalcularValorTotal() => Preco * Quantidade;
        
        public void AdicionarEstoque(int quantidadeVar) => Quantidade += quantidadeVar;
        
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > Quantidade)
            {
                throw new InvalidOperationException("Quantidade insuficiente em estoque");
            }

            Quantidade -= quantidade;
        }
    }
}