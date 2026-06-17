using System;

namespace AlgoritmosRecursivosUnitec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bucle principal para permitir al usuario probar múltiples veces sin reiniciar la consola
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("   ENTREGABLE 4: ALGORITMOS RECURSIVOS      ");
                Console.WriteLine("=============================================\n");
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular Factorial (n!)");
                Console.WriteLine("2. Generar término de Fibonacci (n)");
                Console.WriteLine("3. Salir del programa");
                Console.Write("\nOpción seleccionada: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ProcesarFactorial();
                        break;
                    case "2":
                        ProcesarFibonacci();
                        break;
                    case "3":
                        continuar = false;
                        Console.WriteLine("\n¡Gracias por utilizar el programa! Saliendo...");
                        break;
                    default:
                        Console.WriteLine("\n[ERROR] Opción no válida. Presiona cualquier tecla para intentar de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        /// <summary>
        /// Solicita los datos y maneja las excepciones para el cálculo del Factorial.
        /// </summary>
        static void ProcesarFactorial()
        {
            Console.Write("\nIngresa un número entero para calcular su factorial: ");
            if (int.TryParse(Console.ReadLine(), out int numFactorial))
            {
                try
                {
                    // Intentamos calcular el factorial recursivamente
                    long resultado = CalcularFactorial(numFactorial);
                    Console.WriteLine($"\n[ÉXITO] El factorial de {numFactorial} ({numFactorial}!) es: {resultado}");
                }
                catch (ArgumentException ex)
                {
                    // Captura el error si el número es negativo
                    Console.WriteLine($"\n[ERROR] {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\n[ERROR] Entrada no válida. Debes ingresar un número entero.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /// <summary>
        /// Solicita los datos y maneja las excepciones para la secuencia de Fibonacci.
        /// </summary>
        static void ProcesarFibonacci()
        {
            Console.Write("\nIngresa la posición de Fibonacci (n) a generar: ");
            if (int.TryParse(Console.ReadLine(), out int numFib))
            {
                try
                {
                    // Intentamos calcular el término de Fibonacci recursivamente
                    long resultado = GenerarFibonacci(numFib);
                    Console.WriteLine($"\n[ÉXITO] El término Fibonacci en la posición {numFib} es: {resultado}");
                }
                catch (ArgumentException ex)
                {
                    // Captura el error si la posición es negativa
                    Console.WriteLine($"\n[ERROR] {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\n[ERROR] Entrada no válida. Debes ingresar un número entero.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /// <summary>
        /// Calcula el factorial de un número de manera recursiva.
        /// Complejidad temporal: O(n)
        /// </summary>
        static long CalcularFactorial(int n)
        {
            // Validación de entrada para evitar números negativos
            if (n < 0)
            {
                throw new ArgumentException("No existe el factorial de números negativos.");
            }

            // CASO BASE: Si n es 0 o 1, el factorial es 1. Rompe la recursión.
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // CASO RECURSIVO: Se llama a sí misma con un problema más pequeño (n - 1)
            return n * CalcularFactorial(n - 1);
        }

        /// <summary>
        /// Genera el término n-ésimo de la secuencia de Fibonacci de manera recursiva.
        /// Complejidad temporal: O(2^n)
        /// </summary>
        static long GenerarFibonacci(int n)
        {
            // Validación de entrada para evitar números negativos
            if (n < 0)
            {
                throw new ArgumentException("La posición de Fibonacci debe ser un entero positivo.");
            }

            // CASO BASE 1: Si n es 0, el término es 0.
            if (n == 0)
            {
                return 0;
            }

            // CASO BASE 2: Si n es 1, el término es 1.
            if (n == 1)
            {
                return 1;
            }

            // CASO RECURSIVO DOBLE: Suma de los dos términos anteriores
            return GenerarFibonacci(n - 1) + GenerarFibonacci(n - 2);
        }
    }
}