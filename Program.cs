using System;

class Program
{
    static void Main(string[] args)
    {
        while (Proximarodada.DesejoContinuar())
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Iniciando Paritida de Jokempô!!!");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Escolha uma opção: \n1. Pedra , 2. Papel, 3. Tesoura");

            string? opcaoJogadorInput = Console.ReadLine();
            string opcaoJogador = opcaoJogadorInput ?? "";

            string[] opcoesComputador = ["Pedra", "Papel", "Tesoura"];
            Random random = new Random();
            int indiceAleatorio = random.Next(opcoesComputador.Length);
            string opcaoComputador = opcoesComputador[indiceAleatorio];

            Comparacao.Comparando(opcaoJogador, opcaoComputador);
        }

        Console.WriteLine("Fim do jogo!");
    }
}