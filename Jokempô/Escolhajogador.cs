using System;

class EscolhaJogador
{
    public static string PegarEscolha()
    {
        Console.WriteLine("\n1. Pedra | 2. Papel | 3. Tesoura");
        string? input = Console.ReadLine();
        return input ?? "0";
    }
}