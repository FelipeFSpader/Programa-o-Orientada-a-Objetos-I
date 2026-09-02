using System;
namespace TerceiraAtividade;

class InfosPessoa
{
    public static void Main()
    {
        Pessoa luis = new Pessoa("Luís", 19, 1.55);

        Console.WriteLine(luis.Apresentar());
    }
}