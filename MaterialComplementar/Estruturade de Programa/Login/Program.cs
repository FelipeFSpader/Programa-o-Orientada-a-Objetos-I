namespace Login;

class Program
{
    static void Main()
    {
        Console.Write("Digite o seu login de usuário: ");
        string usuario = Console.ReadLine();
        
        Console.Write($"Olá, {usuario}. Digite sua senha: ");
        string senha = Console.ReadLine();
        
        if (usuario == "admin" && senha == "1234")
            Console.WriteLine("Administrador realizou login");
        else
            Console.WriteLine("Usuário ou senha incorretos");
    }
}