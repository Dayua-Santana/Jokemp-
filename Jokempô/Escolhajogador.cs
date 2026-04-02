using System;

class EscolhaJogador
{
    public static string PegarEscolha()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n1. Pedra | 2. Papel | 3. Tesoura");
        Console.ResetColor();

        string? input = Console.ReadLine();
        return input ?? "0";
    }
}