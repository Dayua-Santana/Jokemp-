class Comparacao
{
    public static void Comparando(string NumeroJogador, string opcaoComputador)
    {
        // Proteção contra null
        NumeroJogador = NumeroJogador ?? "";
        opcaoComputador = opcaoComputador ?? "";

        if (string.IsNullOrEmpty(NumeroJogador) || string.IsNullOrEmpty(opcaoComputador))
            return;

        string nomeJogador = NumeroJogador switch
        {
            "1" => "Pedra",
            "2" => "Papel",
            "3" => "Tesoura",
            _ => "Inválido"
        };

        while (true)
        {
            if (NumeroJogador.Length > 0 || opcaoComputador.Length > 0)
            {
                if (NumeroJogador == "1")
                {
                    if (opcaoComputador == "Tesoura")
                    {
                        Console.WriteLine($"-----Jogador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else if (opcaoComputador == "Papel")
                    {
                        Console.WriteLine($"-----Computador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-----Empate----- \n pressione Enter para continuar...........");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                }
                else if (NumeroJogador == "2")
                {
                    if (opcaoComputador == "Pedra")
                    {
                        Console.WriteLine($"-----Jogador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else if (opcaoComputador == "Tesoura")
                    {
                        Console.WriteLine($"-----Computador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-----Empate----- \n pressione Enter para continuar...........");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                }
                else if (NumeroJogador == "3")
                {
                    if (opcaoComputador == "Papel")
                    {
                        Console.WriteLine($"-----Jogador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else if (opcaoComputador == "Pedra")
                    {
                        Console.WriteLine($"-----Computador Venceu a partida------");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-----Empate----- \n pressione Enter para continuar...........");
                        Console.WriteLine($"{opcaoComputador} vs {nomeJogador}");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}