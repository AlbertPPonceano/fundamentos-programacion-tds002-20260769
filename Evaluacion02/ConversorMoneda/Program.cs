using System;

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tasa del día fijada en constante
            const double TASA_USD = 60.50;

            // Lectura del monto en DOP
            Console.Write("Ingresa el monto en pesos (DOP): ");
            double montoPesos = double.Parse(Console.ReadLine());

            // Conversión de pesos a dólares
            double montoDolares = montoPesos / TASA_USD;

            // Muestreo con interpolación y formato de 2 decimales
            Console.WriteLine("\n=== CONVERSIÓN DE MONEDA ===");
            Console.WriteLine($"Monto ingresado: RD$ {montoPesos:N2}");
            Console.WriteLine($"Tasa de cambio: RD$ {TASA_USD:N2} por USD");
            Console.WriteLine($"Equivalente en dólares: $ {montoDolares:N2} USD");
        }
    }
}
