using System;

namespace EntregableBimestral7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENTREGABLE BIMESTRAL 7: LÓGICA DE RECURSIVIDAD ===");

            // ==========================================================
            // EJERCICIO A: Cuenta Regresiva (Mapeo del Call Stack)
            // ==========================================================
            Console.WriteLine("\n--- EJERCICIO A: ImprimirCuentaRegresiva ---");
            // Iniciamos la cuenta regresiva desde 3 como lo pide la rúbrica
            ImprimirCuentaRegresiva(3);


            // ==========================================================
            // EJERCICIO B: Suma Acumulada con Validación Defensiva
            // ==========================================================
            Console.WriteLine("\n--- EJERCICIO B: Suma Acumulada con Validación ---");
            
            // EJECUCIÓN 1: Entrada Válida (Ejemplo obligatorio: 5 → resultado 15)
            Console.WriteLine("\n[Ejecución 1] Probando con número válido (5):");
            ProcesarSumaAcumulada("5");

            // EJECUCIÓN 2: Entrada Inválida (Ejemplo obligatorio: "abc" o número negativo)
            Console.WriteLine("\n[Ejecución 2] Probando con entrada inválida ('abc'):");
            ProcesarSumaAcumulada("abc");

            Console.WriteLine("\n========================================================");
            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        // ==========================================================
        // LÓGICA DEL EJERCICIO A (Debe mostrar Apilando/Liberando y Despegue)
        // ==========================================================
        public static void ImprimirCuentaRegresiva(int n)
        {
            // Caso Base: Detiene la recursión cuando llega a menor que cero
            if (n < 0)
            {
                Console.WriteLine("¡Despegue! 🚀");
                return;
            }

            // Fase de Ida: Se ejecuta mientras los marcos se acumulan en el Call Stack
            Console.WriteLine($"[APILANDO] Marco de memoria con n = {n}");
            
            // Llamada Recursiva hacia el caso base
            ImprimirCuentaRegresiva(n - 1);

            // Fase de Retorno: Se ejecuta en orden inverso conforme se destruyen los marcos
            Console.WriteLine($"[LIBERANDO] Retornando al marco con n = {n}");
        }

        // ==========================================================
        // LÓGICA DEL EJERCICIO B (Validación externa y Suma Acumulada)
        // ==========================================================
        public static void ProcesarSumaAcumulada(string entrada)
        {
            // Validación estricta con int.TryParse para evitar excepciones no controladas
            if (!int.TryParse(entrada, out int numero) || numero < 0)
            {
                // Cambiar el color de la consola a ROJO para el mensaje de error de la rúbrica
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR: '{entrada}' no es un número entero válido o es menor a cero.");
                Console.ResetColor(); // Regresar la consola a su color original
                return;
            }

            // Si es válido, se calcula de forma recursiva seguro
            int resultado = CalcularSumaAcumulada(numero);
            Console.WriteLine($"Resultado de la suma acumulada de {numero} es: {resultado}");
        }

        public static int CalcularSumaAcumulada(int n)
        {
            // Caso Base
            if (n <= 0) 
                return 0;

            // Caso Recursivo
            return n + CalcularSumaAcumulada(n - 1);
        }
    }
}