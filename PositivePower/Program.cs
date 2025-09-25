class Program
{
    static void Main()
    {
        Console.Write("Ingrese su salario anual: ");
        double salario = double.Parse(Console.ReadLine() ?? "0");

        if (salario > 12000)
        {
            double excedente = salario - 12000;
            double impuesto = excedente * 0.15;
            Console.WriteLine($"Resultado: {impuesto}");
        }
        else
        {
            Console.WriteLine("No debe impuestos.");
        }
    }
}
