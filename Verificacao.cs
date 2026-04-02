using System;

class Verificacao
{
    public static bool DesejaContinuar()
    {
        Console.WriteLine("Deseja Continuar?(S/N): ");
        string opcao = (Console.ReadLine() ?? "").ToUpper();

        return opcao == "S";
    }
}