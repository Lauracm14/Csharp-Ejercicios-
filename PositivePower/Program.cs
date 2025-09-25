class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine() ?? "1"); // evitamos división por 0

        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }
        else
        {
            int residuo = num1 % num2;
            Console.WriteLine($"Resultado: {residuo}");
        }
    }
}
