using System;

class Proximarodada
{
    public static bool DesejoContinuar() // ✅ RETORNA bool
    {
        Console.WriteLine("Deseja Jogar? (s/N)?: ");
        string? opcaoInput = Console.ReadLine();
        string opcaoContinuar = (opcaoInput ?? "").ToUpper();
        string strcontinua = Convert.ToString(opcaoContinuar);

        if (opcaoContinuar == "S")
        {
            Console.WriteLine(strcontinua);
            return true; // ✅ Continua
        }
        else
        {
            Console.WriteLine("-----------------------------------");
            return false; // ✅ PARA
        }
    }
}