using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lectura de un número decimal
            Console.Write("Ingresa un número con decimales (ej. 15.78): ");
            double numeroDecimal = double.Parse(Console.ReadLine());

            // 1. Casting explícito de double a int (se pierde la parte decimal)
            int parteEntera = (int)numeroDecimal;

            // 2. Casting implícito de int a double (sin pérdida de precisión)
            int numeroEnteroBase = 100;
            double numeroConvertidoImplicitamente = numeroEnteroBase;

            // Salida de resultados demostrativos
            Console.WriteLine("\n=== DEMOSTRACIÓN DE CASTING ===");
            Console.WriteLine($"Número original (double): {numeroDecimal}");
            Console.WriteLine($"Parte entera mediante casting explícito (int): {parteEntera}");
            Console.WriteLine($"Valor entero original (int): {numeroEnteroBase}");
            Console.WriteLine($"Convertido mediante casting implícito (double): {numeroConvertidoImplicitamente}");
        }
    }
}
