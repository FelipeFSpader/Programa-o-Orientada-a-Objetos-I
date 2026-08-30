class usoForeach
{
    static void Main()
    {
        List<string> nomespossiveis = new List<string>{"Luis","Felipe","Spader"};
        Console.WriteLine("Meus nomes: ");
        foreach(string nomeindividual in nomespossiveis)
        {
            if (nomeindividual.StartsWith("L"))
            {
            Console.WriteLine(nomeindividual);    
            }
            
        }
    }
}
