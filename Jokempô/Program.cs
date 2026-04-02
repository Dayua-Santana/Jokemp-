using System;
using System.Net;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎮 JOKENPÔ - Bem-vindo!");
        bool condicao = 0 == 0;
        while (condicao)
        {
            string jogadaJogador = EscolhaJogador.PegarEscolha();
            string jogadaPC = Computador.Escolher();

            Resultado.Avaliar(jogadaJogador, jogadaPC);
            Console.WriteLine("👋 Fim de jogo!");
            Console.ReadLine();

            Console.WriteLine("------------------------------------");
            if (!Verificacao.DesejaContinuar()) break;
        }
    }
}