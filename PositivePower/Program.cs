class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine() ?? "";

        // Contador de vocales
        int contador = 0;
        string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";

        foreach (char letra in palabra)
        {
            if (vocales.Contains(letra))
            {
                contador++;
            }
        }

        Console.WriteLine($"Número de vocales: {contador}");
    }
}
