namespace ClasseProduto;

public class Program
{
    static void Main()
    {
        List<Produto> listaProdutos = new();
        
        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("MENU DE PRODUTOS");
            Console.WriteLine(@"1 - Cadastrar
2 - Listar
3 - sair");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Produto novoProduto = new Produto();
                Console.WriteLine("Nome produto: ");   
                novoProduto.nome = Console.ReadLine();
                Console.WriteLine("Valor produto: ");
                novoProduto.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade produto: ");
                novoProduto.quantidade = int.Parse(Console.ReadLine());
                
                listaProdutos.Add(novoProduto);
                
            }else if (escolha == 2)
            {
                foreach (Produto item in listaProdutos)
                {
                    item.ExibirDetalhes();
                    Console.WriteLine(item.CalcularTotal());
                }
            }else 
                break;
        }
    }
}