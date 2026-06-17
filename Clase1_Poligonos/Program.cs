using System;

class Program
{
    // Funcion para seleccionar el poligono
    static int SeleccionarPoligono()
    {
        int opcion;
        Console.WriteLine("=== Selecciona un polígono ===");
        Console.WriteLine("1. Pentagono");
        Console.WriteLine("2. Hexagono");
        Console.WriteLine("3. Heptagono");
        Console.WriteLine("4. Octagono");
        Console.Write("Opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                return 5;
            case 2:
                return 6;
            case 3:
                return 7;
            case 4:
                return 8;
            default:
                Console.WriteLine("Opcion invalida");
                return 0;
        }
    }

    // Funcion para pedir los datos del poligono
    static void PedirDatos(out double lado, out double apotema)
    {
        Console.Write("Ingrese la medida del lado: ");
        lado = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el apotema del polígono: ");
        apotema = Convert.ToDouble(Console.ReadLine());
    }

    // Funcion para calcular el area del poligono
    static double CalcularArea(int lados, double lado, double apotema)
    {
        double perimetro = lados * lado;
        double area = (perimetro * apotema) / 2;
        return area;
    }

    // Programa principal
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int lados = SeleccionarPoligono();
        if (lados > 0)
        {
            double lado, apotema;
            PedirDatos(out lado, out apotema);
            double area = CalcularArea(lados, lado, apotema);
            Console.WriteLine("El área del polígono es: " + area);
        }
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}