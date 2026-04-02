using System;

class Verificacao
{
    public static bool DesejaContinuar()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Deseja Continuar?(S/N): ");
        Console.ResetColor();

        string opcao = (Console.ReadLine() ?? "").ToUpper();

        return opcao == "S";
    }
}