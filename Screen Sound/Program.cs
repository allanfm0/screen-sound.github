string messageDeBoasVindas = "Bem vindo ao Screen Sound.";
//List<string> listaDasBandas = new List<string> { "Linkin Park", "Queen"};   
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//bandasRegistradas.Add("Linkin Park", new List<int>());
//bandasRegistradas.Add("The beatles", new List<int>());

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
    Console.WriteLine("Digite 4 para exibir a media de uma banda.");
    Console.WriteLine("Digite -1 para sair do programa.");

    Console.Write("\nEscolha uma opcao: ");
    string input = Console.ReadLine()!;
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
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
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
    ExibirTitulo("Bandas registradas no Screen Sound:");
    /*
     *   for(int i = 0; i < listaDasBandas.Count; i++)
     *   {
     *      Console.WriteLine($"Banda: {listaDasBandas[i]}.");
     *   }
     */

    foreach (var item in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {item}");
    }
    Console.WriteLine("\nPressione enter para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Regitrar uma banda:");

    Console.Write("Digite o nome da banda que voce deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Voce registrou a banda: {nomeDaBanda.ToUpper()}.");
    Console.WriteLine("REGISTRADA COM SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTitulo(string titulo)
{
    string character = string.Empty.PadLeft(titulo.Length, '-');    
    Console.WriteLine(character);
    Console.WriteLine(titulo);
    Console.WriteLine(character);
    Console.WriteLine();
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avalie uma banda:");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual a nota que a banda: {nomeDaBanda} -> ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Media da banda:");
    Console.Write("Digite o nome da banda que voce deseja ver a media: ");
    string input = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(input))
    {
        List<int> notaDaBanda = bandasRegistradas[input];
        Console.WriteLine($"\nA nota da banda {input} eh: {notaDaBanda.Average()}.");
        Console.WriteLine("Pressione ENTER para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {input} nao existe!");
        Console.WriteLine("Pressione ENTER para voltar ao menu principal...");
        Console.ReadKey(); 
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

ExibirOpcoesDoMenu();
