using System;

readonly struct CoordenadaGPS
{
    public double Latitud { get; }

    public double Longitud { get; }

    public CoordenadaGPS(double lat, double lon)
    {
        if (lat < -90 || lat > 90)
        {
            throw new ArgumentOutOfRangeException(
                nameof(lat),
                "Latitud fuera de rango [-90, 90]");
        }

        if (lon < -180 || lon > 180)
        {
            throw new ArgumentOutOfRangeException(
                nameof(lon),
                "Longitud fuera de rango [-180, 180]");
        }

        Latitud = lat;
        Longitud = lon;
    }

    public void ImprimirUbicacion()
    {
        Console.WriteLine(
            $"Latitud: {Latitud}, Longitud: {Longitud}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE COPIA POR VALOR ===\n");

        CoordenadaGPS c1 =
            new CoordenadaGPS(19.4326, -99.1332);

        CoordenadaGPS c2 = c1;

        c2 = new CoordenadaGPS(52.5200, 13.4050);

        Console.WriteLine("--- c1 ---");
        c1.ImprimirUbicacion();

        Console.WriteLine("\n--- c2 ---");
        c2.ImprimirUbicacion();

        Console.WriteLine(
            "\n=== VALIDACIÓN DE COORDENADAS ===\n");

        try
        {
            Console.Write("Latitud: ");

            double lat = double.Parse(
                Console.ReadLine() ?? "");

            Console.Write("Longitud: ");

            double lon = double.Parse(
                Console.ReadLine() ?? "");

            CoordenadaGPS coord =
                new CoordenadaGPS(lat, lon);

            Console.WriteLine("\nCoordenada válida:");

            coord.ImprimirUbicacion();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(
                $"\nError de rango: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "\nError: debes ingresar números válidos.");
        }

        Console.WriteLine(
            "\nPresione una tecla para salir...");

        Console.ReadKey();
    }
}