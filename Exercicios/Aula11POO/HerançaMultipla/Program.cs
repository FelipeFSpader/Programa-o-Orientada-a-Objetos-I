using System.Data;

public interface IAuditavel
{
    
    DateTime DataCriacao { get; set; }
    string UsuarioCriacao { get; set; }
}

//Contrato para exclusão lógica
public interface IsoftDelete
{
    bool Excluido { get; set; }
    void Excluir();
}

//herda metodo e atributo dessas anteriores
public class Pedido : IAuditavel, IsoftDelete
{
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string UsuarioCriacao { get; set; }
    public bool Excluido { get; set; }

    public void Excluir()
    {
        Excluido = true;
        Console.WriteLine($"Pedido {Id} excluído");
    }
}

//cliente só precisa de auditoria
public class Cliente : IAuditavel
{
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string UsuarioCriacao { get; set; }
}

//metodo de 
public class ServicoAuditoria
{
    public void Auditoria(IAuditavel entidade)
    {
        Console.WriteLine(
            $"Criado por {entidade.UsuarioCriacao} em {entidade.DataCriacao:dd/MM/yyyy HH:mm}"
            );
    }
}

public class Program
{
    static void Main()
    {
        Pedido pedidoUm = new()
        {
            Id = 1,
            UsuarioCriacao = "admin",
            DataCriacao = DateTime.Now
        };

        Cliente clienteUm = new()
        {
            Id = 101,
            UsuarioCriacao = "Sistema",
            DataCriacao = DateTime.Now
        };

        ServicoAuditoria auditoriaUm = new();
        auditoriaUm.Auditoria(pedidoUm);  //puxa objeto
        auditoriaUm.Auditoria(clienteUm); //puxa objeto
        pedidoUm.Excluir();
        // clienteUm.excluir(); esse não existe, cliente 
        Console.WriteLine($"Pedido excluido? {pedidoUm.Excluido}");
    }
}