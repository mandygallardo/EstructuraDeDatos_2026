using System;

namespace ArbolBinarioBusqueda
{
    // ==========================================
    // 1. EL MODELO DE DATOS: LA CLASE NODO
    // ==========================================
    public class Nodo
    {
        public int ID { get; set; }
        public string Dato { get; set; } = string.Empty;
        public Nodo? HijoIzquierdo { get; set; }
        public Nodo? HijoDerecho { get; set; }

        public Nodo(int id, string dato)
        {
            ID = id;
            Dato = dato;
        }
    }

    // ==========================================
    // 2. OPERACIONES DEL ÁRBOL
    // ==========================================
    public static class ArbolBinario
    {
        public static Nodo InsertarNodo(Nodo? raiz, Nodo nuevoNodo)
        {
            if (raiz == null)
            {
                return nuevoNodo;
            }

            if (nuevoNodo.ID < raiz.ID)
            {
                raiz.HijoIzquierdo = InsertarNodo(raiz.HijoIzquierdo, nuevoNodo);
            }
            else if (nuevoNodo.ID > raiz.ID)
            {
                raiz.HijoDerecho = InsertarNodo(raiz.HijoDerecho, nuevoNodo);
            }

            return raiz;
        }

        public static string? BuscarNodo(Nodo? raiz, int idTarget)
        {
            if (raiz == null)
            {
                return null;
            }

            if (idTarget == raiz.ID)
            {
                return raiz.Dato;
            }

            if (idTarget < raiz.ID)
            {
                return BuscarNodo(raiz.HijoIzquierdo, idTarget);
            }
            else
            {
                return BuscarNodo(raiz.HijoDerecho, idTarget);
            }
        }
    }

    // ==========================================
    // 3. PUNTO DE ENTRADA PRINCIPAL (MÉTODO MAIN)
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE ÁRBOL BINARIO DE BÚSQUEDA ===");

            // Crear el nodo raíz inicial
            Nodo raiz = new Nodo(10, "Director General");
            Console.WriteLine($"\nRaíz del árbol creada: ID {raiz.ID} - {raiz.Dato}");

            // Insertar múltiples nodos
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(5, "Gerente de Finanzas"));
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(15, "Gerente de Tecnología"));
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(3, "Analista Contable"));
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(7, "Coordinador de Recursos Humanos"));
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(12, "Líder Técnico C#"));
            raiz = ArbolBinario.InsertarNodo(raiz, new Nodo(20, "Arquitecto de Software"));

            Console.WriteLine("Nodos insertados correctamente en el árbol.");

            // Realizar Búsquedas
            Console.WriteLine("\n--- Realizando Búsquedas ---");
            
            int idABuscar = 12;
            Console.WriteLine($"Buscando ID {idABuscar}...");
            string? resultado1 = ArbolBinario.BuscarNodo(raiz, idABuscar);
            Console.WriteLine(resultado1 != null ? $"¡Éxito! Encontrado: {resultado1}" : "No encontrado.");

            idABuscar = 99;
            Console.WriteLine($"\nBuscando ID {idABuscar} (Inexistente)...");
            string? resultado3 = ArbolBinario.BuscarNodo(raiz, idABuscar);
            Console.WriteLine(resultado3 != null ? $"¡Éxito! Encontrado: {resultado3}" : "Resultado: Null (ID No existe en el árbol).");

            Console.WriteLine("\n============================================");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}