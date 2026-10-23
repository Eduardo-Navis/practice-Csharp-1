// Screen Sound
string mensagemDeBoasVindas = "Bem-vindo ao Screen Sound!";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDeUmaBanda();
            break;
        case -1:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }
}

// Opção 1 - Registrar uma banda
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

// Opção 2 - Mostrar todas as bandas registradas
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    // for (int i = 0; i < ListaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    // digite qual banda deseja avaliar
    // se a banda existir, pergunte a nota e adicione na lista de notas da banda


    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nDigite a nota que deseja dar para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir a média de uma banda");
    Console.Write("\nDigite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        if (notasDaBanda.Count > 0)
        {
            double media = notasDaBanda.Average();
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {media:F2}");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} ainda não possui avaliações.");
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

// Otimiza a exibição do título da opção escolhida
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    //Empty.PadLeft pega uma string vazia e preenche com * até a quantidade da string acima
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();


