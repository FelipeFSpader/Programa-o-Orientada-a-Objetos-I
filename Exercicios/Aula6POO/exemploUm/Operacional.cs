using System;
namespace Empresax
{
    public class Operacional : Funcionário
    {
        public string Area{ get; set; }
        
        public override void Trabalhar()
        {
            Console.WriteLine($"Funcionário {Nome} está operando em {Area}");
        }


    }
}