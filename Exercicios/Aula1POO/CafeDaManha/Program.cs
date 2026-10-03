using System;

class Program
{

    static void Main()
    {
        CafeDaManha hoje = new();

        hoje.hora = "seis e meia";
        hoje.alimento = "Pão com chimia";
        hoje.quantidade = 2;
        
        hoje.preparar();
        hoje.consumir();
    }
}