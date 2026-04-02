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

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"\n{pc}");
        Console.ResetColor();
        Console.Write(" vs ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{nomeJogador}");
        Console.ResetColor();
        Console.Write(" → ");

        if (resultado == "Jogador venceu!")
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (resultado == "PC venceu!")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine(resultado);
        Console.ResetColor();
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