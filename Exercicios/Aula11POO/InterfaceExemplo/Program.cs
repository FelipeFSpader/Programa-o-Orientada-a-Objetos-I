//capacidade de rastreamento 
public interface IRastreavel
{
    void Rastreavel();
}

//capacidade de notificação
public interface INotificavel
{
    void NotificarCliente();
}

//capacidade de calcular frete
public interface ICalcularFrete
{
    decimal CalcularFrete(decimal peso);
}

//CLASSE PRINCIPAL DA APLICAÇÃO
public class Entrega : IRastreavel, INotificavel, ICalcularFrete
{
    public string Codigo { get; set; }
    public string Cliente { get; set; }

    public Entrega(string codigovar, string clientevar)
    {
        this.Codigo = codigovar;
        this.Cliente = clientevar;
    }

    public void Rastreavel()
    {
        Console.WriteLine($"Pedido {Codigo} localizado em CXS");
    }

    public void NotificarCliente()
    {
        Console.WriteLine($"Notificação envidada para {Cliente}");
    }

    public decimal CalcularFrete(decimal peso)
    {
        return peso * (decimal)12.5;
    }
}

public class Program
{
    static void Main()
    {
        Entrega entregaUm = new Entrega("RS1234", "Luís");
        entregaUm.Rastreavel();
        entregaUm.NotificarCliente();
        decimal frete = entregaUm.CalcularFrete(4);
        Console.WriteLine($"Frete calculado: R$ {frete}");
    }  
}  