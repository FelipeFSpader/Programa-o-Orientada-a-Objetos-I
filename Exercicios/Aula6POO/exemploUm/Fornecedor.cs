using System;
namespace Empresax
{
    public class Fornecedor:Pessoa 
    {
        public string Empresa{ get; set; }
        public void Fornecer()
            {
                Console.WriteLine($"O fornecedor {Nome} entregou a mercadoria");
            }
    }        
}