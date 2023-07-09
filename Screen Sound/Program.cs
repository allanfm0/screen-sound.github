string messageDeBoasVindas = "Bem vindo ao Screen Sound.";
List<string> listaDasBandas = new List<string> { "Linkin Park", "Queen"};   

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═════╝░
    
");
    Console.WriteLine(messageDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibit a media de uma banda.");
    Console.WriteLine("Digite -1 para sair do programa.");

    Console.Write("\nEscolha uma opcao: ");
    string input = Console.ReadLine();
    int inputNumber = int.Parse(input);

    switch (inputNumber)
    {
        case 1: 
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opcao: " + inputNumber);
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opcao: " + inputNumber);
            break;
        case -1:
            Console.WriteLine("Voce saiu do programa!");
            break;
        default:
            Console.WriteLine("[ERRO] opcao invalida!");
            break;
    }

}

void ExibirBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registradas:\n");
    Console.WriteLine("------------------------------");
    /*
     *   for(int i = 0; i < listaDasBandas.Count; i++)
     *   {
     *      Console.WriteLine($"Banda: {listaDasBandas[i]}.");
     *   }
     */

    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}.");
    }
    Console.WriteLine("\nPressione enter para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registra uma banda:");
    Console.WriteLine("-------------------");

    Console.Write("Digite o nome da banda que voce deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"Voce registrou a banda: {nomeDaBanda.ToUpper()}.");
    Console.WriteLine("REGISTRADA COM SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
