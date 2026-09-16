using System;
namespace Parque
{

 public class MaquinaControle : Maquina
    {
        public int nSerie{ get; set; }
        public int anoFabricacao{ get; set; }

        public void Ligar()
        {
            Console.WriteLine($"A máquina de controle nº de série {nSerie} de {anoFabricacao} foi LIGADA");
        }
        public void Desligar()
        {
            Console.WriteLine($"A máquina de controle nº de série {nSerie} de {anoFabricacao} foi DESLIGADA");
        }

         public void MonitorarTemperatura()
        {
            Console.WriteLine($"A máquina de controle nº de série {nSerie} de {anoFabricacao} mede e monitora");
        }
    }

}