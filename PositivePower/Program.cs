class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera fracción (ejemplo: 1/2): ");
        string frac1 = Console.ReadLine() ?? "0/1";

        Console.WriteLine("Ingrese la segunda fracción (ejemplo: 1/3): ");
        string frac2 = Console.ReadLine() ?? "0/1";

        // Separar numerador y denominador
        string[] partes1 = frac1.Split('/');
        string[] partes2 = frac2.Split('/');

        int num1 = int.Parse(partes1[0]);
        int den1 = int.Parse(partes1[1]);

        int num2 = int.Parse(partes2[0]);
        int den2 = int.Parse(partes2[1]);

        // Hallar denominador común y diferencia
        int numerador = (num1 * den2) - (num2 * den1);
        int denominador = den1 * den2;

        // Simplificar fracción
        int mcd = MCD(Math.Abs(numerador), Math.Abs(denominador));
        numerador /= mcd;
        denominador /= mcd;

        if (numerador == 0)
        {
            Console.WriteLine("Resultado: 0");
        }
        else
        {
            Console.WriteLine($"Resultado: {numerador}/{denominador}");
        }
    }

    // Función para calcular Máximo Común Divisor
    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
