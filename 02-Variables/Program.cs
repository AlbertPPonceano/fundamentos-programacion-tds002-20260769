using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AÑO_ACTUAL = 2026;

            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu estatura en metros (ej. 1.75): ");
            double estatura = double.Parse(Console.ReadLine());

            int añoNacimiento = AÑO_ACTUAL - edad;

            Console.WriteLine("\n--- Resumen ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} m");
            Console.WriteLine($"Año aproximado de nacimiento: {añoNacimiento}");
        }
    }
}