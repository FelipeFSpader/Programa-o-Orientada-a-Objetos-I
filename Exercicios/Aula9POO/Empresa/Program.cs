using System.Collections;
using Empresa;

public class Program
{
    static void Main()
    {
        ArrayList funcionario = new ArrayList();
        funcionario.Add(new Gerente("Luis",7500.00, 5));
        funcionario.Add(new Vendedor("Felipe",7500.00,25000.00));
        funcionario.Add(new Desenvolvedor("Spader",7500.00, "C#"));
        funcionario.Add(new Vendedor("Luisinho",7500.00, 25000.00 ));
        funcionario.Add(new Desenvolvedor("Felipao",7500.00, "Java"));


        foreach (Funcionario func in funcionario)
        {
            func.Exibir();
            Console.WriteLine($"Bônus padrão: R$ {func.CalcularBonus():F2}");
            Console.WriteLine($"Bônus de 15%: R$ {func.CalcularBonus(15):F2}");
        }
    }
}