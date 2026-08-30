int soma=0;
int valor;

Console.WriteLine("Diga números - Zero faz parar: ");
do
{
   valor=int.Parse(Console.ReadLine());
   soma+=valor;
}
while(valor!=0);

Console.WriteLine($"Soma total: {soma}");
