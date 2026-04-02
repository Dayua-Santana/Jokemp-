using System;

class Resultado
{
    public static void Avaliar(string jogador, string pc)
    {
        string nomeJogador = jogador switch
        {
            "1" => "Pedra",
            "2" => "Papel",
            "3" => "Tesoura",
            _ => "Inválido"
        };

        string resultado = CalcularVencedor(jogador, pc, nomeJogador);
        Console.WriteLine($"\n{pc} vs {nomeJogador} → {resultado}");
    }

    private static string CalcularVencedor(string jogador, string pc, string nome)
    {

        return (jogador, pc) switch
        {
            ("1", "Tesoura") or ("2", "Pedra") or ("3", "Papel") => "Jogador venceu!",
            ("1", "Papel") or ("2", "Tesoura") or ("3", "Pedra") => "PC venceu!",
            _ => "Empate!"
        };
    }
}