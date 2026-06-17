using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 5;
        int[] arreglo = { 1, 2, 3 };

        Console.WriteLine("ANTES: ");
        Console.WriteLine("Número = " + numero);
        Console.WriteLine("Arreglo[0] = " + arreglo[0]);

        CambiarValor(numero);
        CambiarReferencia(arreglo);

        Console.WriteLine("DESPUÉS: ");
        Console.WriteLine("Número = " + numero);
        Console.WriteLine("Arreglo[0] = " + arreglo[0]);
    }

    static void CambiarValor(int x)
    {
        x = 100;
    }

    static void CambiarReferencia(int[] arr)
    {
        arr[0] = 100;
    }
}