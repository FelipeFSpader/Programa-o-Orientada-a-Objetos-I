using System;
namespace Parque
{
    public abstract class MaquinaProducao : Maquina
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

         public virtual void ProduzirPeca()
        {
            Console.WriteLine($"A máquina de produção nº de série {nSerie} de {anoFabricacao} produz peças");
        }
        public virtual void ImprimirModelo()
        {
            Console.WriteLine($"A máquina de produção nº de série {nSerie} de {anoFabricacao} imprimi modelos");
        }
    }
}
