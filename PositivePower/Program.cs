class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el tercer número:");
        double num3 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el cuarto número:");
        double num4 = double.Parse(Console.ReadLine() ?? "0");

        double promedio = (num1 + num2 + num3 + num4) / 4;

        Console.WriteLine($"Resultado: {promedio}");
    }
}