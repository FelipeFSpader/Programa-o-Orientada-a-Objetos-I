using System;
namespace Empresax
{
    public class Administrativo : Funcionário 
    {
        public string Setor{ get; set; }
        
        public override void Trabalhar()
            {
                Console.WriteLine($"O funcionário {Nome} está administrando o {Setor}");
            }
    }        
}