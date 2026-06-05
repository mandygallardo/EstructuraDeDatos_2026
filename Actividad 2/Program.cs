using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Inicialización de variables
        int numero = 20;
        int[] miArreglo = { 1, 2, 3 };

        Console.WriteLine("--- VALORES INICIALES ---");
        Console.WriteLine($"Entero original: {numero}");
        Console.WriteLine($"Primer elemento del arreglo original: {miArreglo[0]}");
        Console.WriteLine();

        // 2. Llamada a las funciones
        CambiarValor(numero);
        CambiarReferencia(miArreglo);

        Console.WriteLine("--- VALORES DESPUÉS DE LAS FUNCIONES ---");
        Console.WriteLine($"Entero final: {numero} (¡No cambió!)");
        Console.WriteLine($"Primer elemento del arreglo final: {miArreglo[0]} (¡Sí cambió!)");
    }

    // 1. Intenta cambiar el valor de un entero
    // Se pasa una COPIA del valor, por lo que el cambio no afecta a la variable original.
    static void CambiarValor(int x)
    {
        x = 100;
    }

    // 2. Intenta cambiar el primer elemento de un arreglo
    // Se pasa una COPIA de la referencia (dirección de memoria), por lo que apunta al mismo arreglo original.
    static void CambiarReferencia(int[] arr)
    {
        if (arr != null && arr.Length > 0)
        {
            arr[0] = 100;
        }
    }
}