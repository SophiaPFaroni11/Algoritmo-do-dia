// See https://aka.ms/new-console-template for more information
    string texto, escolha;
    Console.Write("Digite um texto que deseje colorir: ");

    texto = Console.ReadLine() ?? "";

    Console.WriteLine("\nEscolha a cor do texto:");

    Console.WriteLine("1 - Vermelho");

    Console.WriteLine("2 - Azul");

    Console.WriteLine("3 - Verde");

    Console.WriteLine("4 - Amarelo");

    Console.WriteLine("5 - Ciano");

    Console.Write("Digite o número da cor: ");

    escolha = Console.ReadLine() ?? "0";

    // Salva a cor original para restaurar depois

    ConsoleColor original = Console.ForegroundColor;


    if (escolha == "1")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (escolha == "2")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if (escolha == "3")
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (escolha == "4")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if (escolha == "5")
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        Console.WriteLine("Opção inválida! Usando cor padrão.");
    }
        Console.WriteLine($"\n{texto}");
        Console.ForegroundColor = original;