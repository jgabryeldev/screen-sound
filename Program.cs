//screen sound
//List<string> listaDasBandas = new List<string>();
Dictionary<string, List<int>> listaDasBandas = new Dictionary<string, List<int>>();
void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}
void ExibirMenu()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Dgite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("\nDigite sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);


    switch(opcaoNumerica)
    {
        case 1:
        RegistroBanda();
            break;
        case 2: 
            ExibicaoDeBanda();
            break;
        case 3:
            AvaliacaoBanda();
            break;
        case 4:
            MediaDasBandas();
            break;
        case 0:
            break;
    }
}
void RegistroBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de todas as bandas");
    Console.Write("Registre sua banda: ");
    string Banda = Console.ReadLine()!;
    listaDasBandas.Add(Banda, new List<int>());
    Console.WriteLine($"A banda {Banda} foi registradsa com sucesso");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirMenu();
}
void ExibicaoDeBanda()
{
    Console.Clear();
    ExibirTitulo("Todas as bandas registradas:");
    /*for (int i = 0; i<listaDasBandas.Count; i++)
    {
        Console.WriteLine($"{listaDasBandas[i]}");
    }*/
    foreach (string Banda in listaDasBandas.Keys)
    {
        Console.WriteLine($"° {Banda}");
    }
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
}
void ExibirTitulo(string Titulo)
{
    int numeroLetras = Titulo.Length;
    string aparencia = string.Empty.PadLeft(numeroLetras, '-');
    Console.WriteLine(aparencia);
    Console.WriteLine(Titulo);
    Console.WriteLine(aparencia + "\n");
}
void AvaliacaoBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliação das bandas cadastradas:");
    Console.Write("Digite a banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(listaDasBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Avalie a banda {nomeDaBanda} de 0 a 10: ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);
        listaDasBandas[nomeDaBanda].Add(notaDaBanda);
        Console.WriteLine($"\nBanda {nomeDaBanda} avaliada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }
        else
        {
            Console.WriteLine($"\nBanda {nomeDaBanda} não encontrada no sistema!");
            Console.WriteLine("Digite uma tecla para voltar ao menu:");
            Console.ReadKey();
            Console.Clear();
            ExibirMenu();
        }
   
}
void MediaDasBandas()
{
    Console.Clear();
    ExibirTitulo("Consulta de média de uma banda cadastrada");
    Console.Write("Informe a banda para a colsulta da média: ");
    string consultaBanda = Console.ReadLine()!;
    if(listaDasBandas.ContainsKey (consultaBanda)) 
    {
        double mediaDaBanda = listaDasBandas[consultaBanda].Average();
        Console.WriteLine($"A média da banda {consultaBanda} é: {mediaDaBanda}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
        else
        {
        Console.WriteLine($"Banda {consultaBanda} não encontrada no sistema!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu ();
        }
}

ExibirMenu();