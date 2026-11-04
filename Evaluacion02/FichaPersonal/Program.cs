using System;

namespace FichaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ANIO_ACTUAL = 2026;

            // Lectura de datos personales usando camelCase
            Console.Write("Ingresa tu nombre: ");
            string nombrePersona = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edadPersona = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu estatura en metros (ej. 1.75): ");
            double estaturaPersona = double.Parse(Console.ReadLine());

            Console.Write("¿Trabajas actualmente? (true/false): ");
            bool trabajaPersona = bool.Parse(Console.ReadLine());

            // Cálculo del año en que cumplirá 30 años
            int anioCumpleTreinta = ANIO_ACTUAL + (30 - edadPersona);

            // Presentación del resultado con interpolación
            Console.WriteLine("\n=== FICHA PERSONAL ===");
            Console.WriteLine($"Nombre: {nombrePersona}");
            Console.WriteLine($"Edad: {edadPersona} años");
            Console.WriteLine($"Estatura: {estaturaPersona} m");
            Console.WriteLine($"¿Trabaja?: {(trabajaPersona ? "Sí" : "No")}");
            Console.WriteLine($"Año en que cumplirá (o cumplió) 30 años: {anioCumpleTreinta}");
        }
    }
}