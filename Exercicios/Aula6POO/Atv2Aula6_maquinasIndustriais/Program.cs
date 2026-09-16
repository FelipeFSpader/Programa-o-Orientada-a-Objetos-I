using System;
namespace Parque
{
    class Program
    {
        public static void Main()
        {
            Maquina mq = new()
            {
                //Forma de passar valores
                nSerie=001,
                anoFabricacao=1999
            };
            //objeto.método();
            mq.Ligar();

       }
    }
}