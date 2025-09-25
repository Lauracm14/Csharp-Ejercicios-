class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            int resultado = numero * numero; // elevar al cuadrado
            Console.WriteLine("Resultado: " + resultado);
        }
        else if (numero < 0)
        {
            Console.WriteLine("Resultado: Número negativo.");
        }
        else // cuando es 0
        {
            Console.WriteLine("Resultado: 0");
        }
    }
}