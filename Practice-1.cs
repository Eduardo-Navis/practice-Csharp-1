internal static class Practice1
{
    public static void Executar()
    {
        SaudacaoAluno();
        CapturarNota();
    }

    private static void SaudacaoAluno()
    {
        Console.Write("Digite seu nome: ");
        string nomeAluno = Console.ReadLine()!;

        Console.WriteLine(
            $"\nOlá {nomeAluno}, seja bem-vindo(a)!"
        );
    }

    private static void CapturarNota()
    {
        Console.Write("\nDigite sua nota: ");
        string notaLida = Console.ReadLine()!;

        int notaMedia = int.Parse(notaLida);

        if (notaMedia >= 5)
        {
            Console.WriteLine(
                "\nAprovado!"
            );
        }
        else if (notaMedia < 5)
        {
            Console.WriteLine("\nReprovado!");
        }
        else
        {
            Console.WriteLine("\nNota inválida!");
        }
    }
}


