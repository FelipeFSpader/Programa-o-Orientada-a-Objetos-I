class Senha
{
   static void Main()
   {
        
        string senhaCorreta="1234";
        string senhaDigitada;

        do
        {
            Console.WriteLine("Digite senha: ");
            senhaDigitada = Console.ReadLine();
            if(senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Incorreto! Tente de novo");
            }
        }
        while (senhaDigitada != senhaCorreta);
        Console.WriteLine("Liberado");
        
   } 
}