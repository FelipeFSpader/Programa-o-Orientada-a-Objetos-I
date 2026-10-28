public class Program
{
    public static void Main()
    {
        string escolhaMenu = ""; 

        while (escolhaMenu != "5")
        {
            Console.WriteLine(@"================================

            MENU PRINCIPAL

    ================================

    1 - Cadastrar Item

    2 - Consultar Item

    3 - Alterar Item

    4 - Listar Itens Cadastrados

    5 - Sair

    ================================");

            escolhaMenu = Console.ReadLine();
            
            switch (escolhaMenu)
            {    
                case "1":
                    Console.WriteLine("Seu chapeu foi adicionado ao inventário.");
                    break;
                case "2":
                    // código para consultar item
                    break;
                case "3":
                    // código para alterar um item
                    break;
                case "4":
                    // código para abrir inventário
                    break;
                case "5":
                    Console.WriteLine("Saindo do jogo");
                    break;

                default: 
                    Console.WriteLine("opção inválida.");
                    break;
            }     
        }
    }
}
