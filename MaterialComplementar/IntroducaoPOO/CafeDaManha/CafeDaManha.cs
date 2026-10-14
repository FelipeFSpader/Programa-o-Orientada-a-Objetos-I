using System;

class CafeDaManha
{
    public string hora;
    public string alimento;
    public int quantidade;

    public void preparar()
    {
        Console.WriteLine($"Acordando as {hora} da manhã, prepara {alimento}, cortando pão e passando chimia");
    }

    public void consumir()
    {
        Console.WriteLine($"Depois de preparar {quantidade} deles, pode comer {alimento}");
    }
}