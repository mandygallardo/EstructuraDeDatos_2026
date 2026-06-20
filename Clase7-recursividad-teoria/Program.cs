using System;

namespace EntregableBimestral7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENTREGABLE BIMESTRAL 7: LÓGICA DE RECURSIVIDAD ===");

            // El arreglo DEBE estar ordenado para que la Búsqueda Binaria funcione
            int[] arregloOrdenado = { 3, 8, 12, 15, 21, 28, 34, 45, 50, 63, 72, 88, 91 };
            
            Console.WriteLine("\nArreglo de prueba ordenado:");
            Console.WriteLine("[ " + string.Join(", ", arregloOrdenado) + " ]");

            // Caso de prueba 1: Buscar un elemento que SÍ existe
            int elementoBuscar1 = 28;
            Console.WriteLine($"\n--- Prueba 1: Buscando el número {elementoBuscar1} ---");
            int resultado1 = BusquedaBinariaRecursiva(arregloOrdenado, elementoBuscar1, 0, arregloOrdenado.Length - 1);
            
            if (resultado1 != -1)
                Console.WriteLine($"¡Éxito! El elemento {elementoBuscar1} se encuentra en el índice: {resultado1}");
            else
                Console.WriteLine($"El elemento {elementoBuscar1} no existe en el arreglo.");

            // Caso de prueba 2: Buscar un elemento que NO existe
            int elementoBuscar2 = 40;
            Console.WriteLine($"\n--- Prueba 2: Buscando el número {elementoBuscar2} (No existente) ---");
            int resultado2 = BusquedaBinariaRecursiva(arregloOrdenado, elementoBuscar2, 0, arregloOrdenado.Length - 1);
            
            if (resultado2 != -1)
                Console.WriteLine($"¡Éxito! El elemento {elementoBuscar2} se encuentra en el índice: {resultado2}");
            else
                Console.WriteLine($"Resultado: El elemento {elementoBuscar2} no se encontró en el arreglo (-1).");

            Console.WriteLine("\n========================================================");
            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Algoritmo de Búsqueda Binaria implementado de forma puramente recursiva.
        /// </summary>
        public static int BusquedaBinariaRecursiva(int[] arreglo, int objetivo, int izquierda, int derecha)
        {
            // CASO BASE 1: El subarreglo es inválido (el elemento no existe)
            if (izquierda > derecha)
            {
                return -1; 
            }

            // Calculamos el punto medio para dividir el problema en dos mitades
            int medio = izquierda + (derecha - izquierda) / 2;

            // CASO BASE 2: Encontramos el elemento en el punto medio
            if (arreglo[medio] == objetivo)
            {
                return medio;
            }

            // CASO RECURSIVO 1: El objetivo es menor, buscamos en la mitad IZQUIERDA
            if (arreglo[medio] > objetivo)
            {
                return BusquedaBinariaRecursiva(arreglo, objetivo, izquierda, medio - 1);
            }

            // CASO RECURSIVO 2: El objetivo es mayor, buscamos en la mitad DERECHA
            return BusquedaBinariaRecursiva(arreglo, objetivo, medio + 1, derecha);
        }
    }
}