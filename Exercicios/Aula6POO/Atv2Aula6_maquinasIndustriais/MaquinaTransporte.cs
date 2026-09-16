using System;
namespace Parque
{

 public class MaquinaTransporte : Maquina
    {
        public int nSerie{ get; set; }
        public int anoFabricacao{ get; set; }

        public void Ligar()
        {
            Console.WriteLine($"A máquina de transporte nº de série {nSerie} de {anoFabricacao} foi LIGADA");
        }
        public void Desligar()
        {
            Console.WriteLine($"A máquina de transporte nº de série {nSerie} de {anoFabricacao} foi DESLIGADA");
        }

         public void TransportarCarga()
        {
            Console.WriteLine($"A máquina de transporte nº de série {nSerie} de {anoFabricacao} transporta carga");
        }
    }

}