    Console.WriteLine("Digite um número: ");
    int numero =  int.Parse(Console.ReadLine());
    
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero*i}");
    }
       