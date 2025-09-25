class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine() ?? "0");

        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Resultado: {perimetro:F2}");
    }
}
