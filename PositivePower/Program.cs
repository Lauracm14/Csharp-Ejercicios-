class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine() ?? "0");

        long factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Resultado: {factorial}");
    }
}