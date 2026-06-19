using System;

namespace EntregableBimestral6
{
    // Clase de prueba para el Módulo 3 (Demostración de referencias)
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Calificacion { get; set; }

        public Estudiante(string nombre, int calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENTREGABLE BIMESTRAL 6: MANEJO DE MEMORIA EN C# ===");

            // ==========================================================
            // MÓDULO 1: MUTACIÓN DIRECTA CON 'ref' (Intercambiar Valores)
            // ==========================================================
            Console.WriteLine("\n--- Módulo 1: Modificador 'ref' ---");
            int numeroA = 10;
            int numeroB = 99;

            Console.WriteLine($"Valores originales en Main -> A: {numeroA}, B: {numeroB}");
            
            // Llamada al método pasando las direcciones de memoria
            Intercambiar(ref numeroA, ref numeroB);
            
            Console.WriteLine($"Valores después de Intercambiar -> A: {numeroA}, B: {numeroB}");


            // ==========================================================
            // MÓDULO 2: MÚLTIPLES RETORNOS CON 'out' (Calcular y Validar)
            // ==========================================================
            Console.WriteLine("\n--- Módulo 2: Modificador 'out' ---");
            int dividendo = 23;
            int divisor = 5;
            
            // Las variables 'out' no necesitan inicializarse previamente
            int resultadoCociente;
            int resultadoResiduo;
            bool esDivisionExacta;

            esDivisionExacta = CalcularYValidar(dividendo, divisor, out resultadoCociente, out resultadoResiduo);

            Console.WriteLine($"Operación: {dividendo} entre {divisor}");
            Console.WriteLine($"Cociente obtenido (out): {resultadoCociente}");
            Console.WriteLine($"Residuo obtenido (out): {resultadoResiduo}");
            Console.WriteLine($"¿La división es exacta?: {esDivisionExacta}");


            // ==========================================================
            // MÓDULO 3: COMPORTAMIENTO DEL HEAP (Referencias de Objetos)
            // ==========================================================
            Console.WriteLine("\n--- Módulo 3: Referencias en el Heap ---");
            
            // Instancia original (Estudiante 1)
            Estudiante estudiante1 = new Estudiante("Mandy", 85);
            Console.WriteLine($"Estudiante 1 original -> Nombre: {estudiante1.Nombre}, Calificación: {estudiante1.Calificacion}");

            // Asignación de referencia (Estudiante 2 NO es una copia, apunta al mismo espacio)
            Estudiante estudiante2 = estudiante1;
            Console.WriteLine("Se asignó 'estudiante2 = estudiante1'.");

            // Modificamos estudiante2
            estudiante2.Calificacion = 100;
            Console.WriteLine("\nSe modificó la calificación de Estudiante 2 a 100.");

            // Demostración del impacto en el Heap
            Console.WriteLine($"Estudiante 1 actual -> Nombre: {estudiante1.Nombre}, Calificación: {estudiante1.Calificacion}");
            Console.WriteLine($"Estudiante 2 actual -> Nombre: {estudiante2.Nombre}, Calificación: {estudiante2.Calificacion}");
            Console.WriteLine("\n[Explicación]: Ambas variables cambiaron porque apuntan a la misma dirección de memoria en el Heap.");

            Console.WriteLine("\n========================================================");
            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        // METODO MÓDULO 1: Usa 'ref' para alterar las variables originales del Main
        public static void Intercambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;
        }

        // METODO MÓDULO 2: Usa 'out' para devolver múltiples salidas obligatorias
        public static bool CalcularYValidar(int dividendo, int divisor, out int cociente, out int residuo)
        {
            // Nota obligatoria: Los parámetros 'out' DEBEN asignarse antes de que termine el método
            cociente = dividendo / divisor;
            residuo = dividendo % divisor;

            // Retorna un booleano indicando si el residuo es cero (división exacta)
            return residuo == 0;
        }
    }
}