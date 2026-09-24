using System;
namespace SistemaLoja;

public class Program
{
    static void Main()
    {
        try //código arriscado 
        {
            Vendedor instanciaVendedor = new ("Luís","98765432123",4000 );
            for(int i = 0; i < 10; i++)
                instanciaVendedor.registrarVendas();
            Administrador instanciaAdministrador = new ("Felipe", "12345678909", 2000, "Informática");
            instanciaAdministrador.AjustarSalario(10);

            Console.WriteLine("-----Vendedor-----");
            instanciaVendedor.Apresentar();
            Console.WriteLine("-----Administrador-----");
            instanciaAdministrador.Apresentar();
        }
        catch (ArgumentException e)//se alguma exceção acontecer cai pra cá - tratamento de exceção
        {
            Console.WriteLine("Erro: " + e.Message);
        }
    }
}