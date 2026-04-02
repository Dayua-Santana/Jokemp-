using System;
using System.Net;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🎮 JOKENPÔ - Bem-vindo!");
        Console.ResetColor();

        bool condicao = 0 == 0;
        while (condicao)
        {
            string jogadaJogador = EscolhaJogador.PegarEscolha();
            string jogadaPC = Computador.Escolher();

            Resultado.Avaliar(jogadaJogador, jogadaPC);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("👋 Fim de jogo!");
            Console.ResetColor();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            if (!Verificacao.DesejaContinuar()) break;
        }
    }
}