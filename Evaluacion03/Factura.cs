using System;

namespace Evaluacion03
{
    class FacturaProgram
    {
        static void Main(string[] args)
        {
            // Constante del ITBIS en la República Dominicana
            const decimal TASA_ITBIS = 0.18m;

            Console.WriteLine("=== PROGRAMA 2: FACTURACIÓN ===");

            // 1. Entrada
            Console.Write("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine() ?? "Artículo";

            Console.Write("Ingrese la cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                cantidad = 1;
            }

            Console.Write("Ingrese el precio unitario: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precioUnitario))
            {
                precioUnitario = 0m;
            }

            // 2. Proceso
            decimal subtotal = cantidad * precioUnitario;
            decimal itbis = subtotal * TASA_ITBIS;
            decimal total = subtotal + itbis;

            // 3. Salida con columnas alineadas
            Console.WriteLine("\n========================================");
            Console.WriteLine("           FACTURA DE COMPRA            ");
            Console.WriteLine("========================================");
            Console.WriteLine($"{"Producto:",-15} {producto}");
            Console.WriteLine($"{"Cantidad:",-15} {cantidad,10}");
            Console.WriteLine($"{"Precio Unit.:",-15} {precioUnitario,10:N2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{"Subtotal:",-15} {subtotal,10:N2}");
            Console.WriteLine($"{"ITBIS (18%):",-15} {itbis,10:N2}");
            Console.WriteLine("========================================");
            Console.WriteLine($"{"TOTAL A PAGAR:",-15} {total,10:N2}");
            Console.WriteLine("========================================");
        }
    }
}