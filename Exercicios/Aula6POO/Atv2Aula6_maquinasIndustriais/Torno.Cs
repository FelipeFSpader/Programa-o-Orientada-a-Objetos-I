using System;
namespace Parque
{
    public class Torno : MaquinaProducao 
    {
        public int nSerie{ get; set; }
        public int anoFabricacao{ get; set; }

        public void Ligar()
        {
            Console.WriteLine($"A máquina de produção nº de série {nSerie} de {anoFabricacao} foi LIGADA");
        }
        public void Desligar()
        {
            Console.WriteLine($"A máquina de produção nº de série {nSerie} de {anoFabricacao} foi DESLIGADA");
        }

         public override void ProduzirPeca()
        {
            Console.WriteLine($"O torno nº de série {nSerie} de {anoFabricacao} produz peças");
        }
    }
}
