using System;
namespace Parque
{
    public class Impressora3D : MaquinaProducao 
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
        public override void ImprimirModelo()
        {
            Console.WriteLine($"A impressora 3D nº de série {nSerie} de {anoFabricacao} imprimi modelos");
        }
    }
}
