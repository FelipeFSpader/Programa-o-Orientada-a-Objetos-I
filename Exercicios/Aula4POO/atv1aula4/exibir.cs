public class Exibir 
{
    public static void Main() 
    {
        Calculadora calc=new Calculadora();
        Console.WriteLine($"Somar: {calc.Somar(10,5)}");
        Console.WriteLine($"Subtrair: {calc.Subtrair(10,5)}");
        Console.WriteLine($"Multiplicar: {calc.Multiplicar(10,5)}");
        Console.WriteLine($"Dividir: {calc.Dividir(10,5)}");
        Console.WriteLine($"Dividir: {calc.Dividir(10,3)}");
        Console.WriteLine($"Dividir: {calc.Dividir(10,0)}");
        
        // Usando try-catch para tratar a exceção da divisão por zero
        try
        {
            console.WriteLine($"Dividir: {calc.Dividir(10, 0)}");
        }
        catch (DivideByZeroException ex)
        {
            console.WriteLine($"Inválido - {ex.Message}");
        }


    }
}