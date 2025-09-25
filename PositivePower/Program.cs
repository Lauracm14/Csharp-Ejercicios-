class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine() ?? "0");

        if (num > 0)
        {
            double raiz = Math.Sqrt(num);
            Console.WriteLine($"Resultado: {raiz}");
        }
        else
        {
            int cuadrado = num * num;
            Console.WriteLine($"Resultado: {cuadrado}");
        }
    }
}