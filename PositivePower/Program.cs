class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        Console.WriteLine($"Resultado: {suma}");
    }
}
