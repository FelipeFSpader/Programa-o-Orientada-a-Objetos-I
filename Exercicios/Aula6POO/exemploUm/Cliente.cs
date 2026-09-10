using System;
namespace Empresax
{
    public class Cliente:Pessoa 
    {
        public string CodigoCliente{ get; set; }
        
        public void comprar()
            {
                Console.WriteLine($"O cliente {Nome} realizou a compra");
            }
    }        
}