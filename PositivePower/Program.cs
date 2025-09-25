class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine() ?? "0");

        if (num >= 10 && num <= 20)
        {
            Console.WriteLine("Está en el rango.");
        }
        else
        {
            Console.WriteLine("Fuera del rango.");
        }
    }
}