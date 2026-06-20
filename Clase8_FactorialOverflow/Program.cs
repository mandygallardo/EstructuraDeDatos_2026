using System;
using System.Numerics;

class Program
{
    // Función recursiva usando int
    static int FactorialInt(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * FactorialInt(n - 1);
    }

    // Función iterativa usando int
    static int FactorialIterativo(int n)
    {
        int resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }

    // Función profesional usando BigInteger
    static BigInteger FactorialProfesional(BigInteger n)
    {
        // Caso base
        if (n == 0 || n == 1)
            return BigInteger.One;

        // Caso recursivo
        return n * FactorialProfesional(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== FACTORIAL: RECURSIVO VS ITERATIVO ===\n");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(
                $"n={i:D2} | Recursivo: {FactorialInt(i),15} | Iterativo: {FactorialIterativo(i),15}"
            );
        }

        /*
         * PUNTO DE QUIEBRE (OVERFLOW)
         *
         * El tipo int puede almacenar valores entre:
         * -2,147,483,648 y 2,147,483,647
         *
         * El overflow ocurre a partir de n = 13.
         *
         * 13! = 6,227,020,800
         *
         * Este valor supera el límite máximo de int,
         * por lo que C# produce resultados incorrectos
         * debido al desbordamiento aritmético.
         */

        Console.WriteLine("\n=== PRUEBA CON BIGINTEGER ===\n");

        BigInteger resultado = FactorialProfesional(100);

        Console.WriteLine($"100! = {resultado}");

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}