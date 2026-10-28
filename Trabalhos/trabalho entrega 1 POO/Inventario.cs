using trabalho_entrega_1_POO;

public class Inventario
{
    private List<Item> bolsa = new List<Item>();
    private int proximoCodigo = 1;
    
    //mostrar quantos estao guardados
    //public int Quantidade; //mostrar quantos estao guardados
    public int ObterQuantidade()
    {
        return bolsa.Count; //adelcio disse pra setar assim. igual os outros metodos de pegar valor privado
    }

    public void Adicionar(Item item) //recebe qualquer coisa que seja um Item
    {
        item.DefinirCodigo(proximoCodigo); //tipo o proximo no de Estrutura de dados 
        proximoCodigo++;
        bolsa.Add(item);
    }

    public Item BuscarPorCodigo(int codigo)
    {
        foreach (Item item in bolsa)
        {
            if (item.LerCodigo() == codigo)
                return item; 
        }
        throw new ArgumentException("não há nenhum item com o código {codigo} na bolsa.");
    }

    public void ListarItens()
    {
        if (bolsa.Count == 0)
        {
            Console.WriteLine("Bolsainventario Vazia");
            return;
        }

        foreach (Item item in bolsa)
        {
            Console.WriteLine(item);
        }
    }
}
