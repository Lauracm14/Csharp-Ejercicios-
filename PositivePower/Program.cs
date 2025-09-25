class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el tercer número:");
        int num3 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el cuarto número:");
        int num4 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el quinto número:");
        int num5 = int.Parse(Console.ReadLine() ?? "0");

        // Encontrar el más pequeño usando Math.Min
        int menor = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));

        Console.WriteLine($"Resultado: {menor}");
    }
}