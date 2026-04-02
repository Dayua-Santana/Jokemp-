using System;

class Computador
{
    private static readonly string[] Opcoes = ["Pedra", "Papel", "Tesoura"];

    public static string Escolher()
    {
        Random rnd = new Random();
        return Opcoes[rnd.Next(Opcoes.Length)];
    }
}