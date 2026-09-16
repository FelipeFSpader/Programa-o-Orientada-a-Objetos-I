using System;
namespace Parque
{
    public class Maquina
    {
        public int nSerie{ get; set; }
        public int anoFabricacao{ get; set; }
        public void Ligar()
        {
            Console.WriteLine($"A máquina nº de série {nSerie} de {anoFabricacao} foi LIGADA");
        }
        public void Desligar()
        {
            Console.WriteLine($"A máquina nº de série {nSerie} de {anoFabricacao} foi DESLIGADA");
        }
    }
}

//MaquinaProducao, MaquinaTransporte e MaquinaControle
//Torno Impressora3D