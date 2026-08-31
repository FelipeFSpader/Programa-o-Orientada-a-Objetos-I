using System;
namespace TerceiraAtividade;

class InfosPessoa
{
    static void Main()
    {
        Pessoa luis = new Pessoa();
        luis.Nome= "Luís";
        luis.Idade= 19;
        luis.Altura= 1.55;

        Console.WriteLine(luis.Apresentar());
    }
}