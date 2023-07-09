string messageDeBoasVindas = "Bem vindo ao Screen Sound.";

void ExibirMensagemDeBoasVindas()
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
            Console.WriteLine("Voce escolheu a opcao: " + inputNumber);
            break;
        case 2:
            Console.WriteLine("Voce escolheu a opcao: " + inputNumber);
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
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
