using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        if (num1 > num2)
        {
            Console.WriteLine($"Resultado: {num1 * 2}");
        }
        else
        {
            Console.WriteLine($"Resultado: {num2 * 3}");
        }
    }
}