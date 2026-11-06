using System;

namespace Evaluacion03
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       EVALUACIÓN 03 - MENÚ PRINCIPAL   ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Programa de Nómina");
                Console.WriteLine("2. Programa de Factura");
                Console.WriteLine("3. Programa de Geometría");
                Console.WriteLine("4. Salir");
                Console.WriteLine("========================================");
                Console.Write("Seleccione una opción (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        EjecutarNomina();
                        break;
                    case 2:
                        EjecutarFactura();
                        break;
                    case 3:
                        EjecutarGeometria();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        static void EjecutarNomina()
        {
            const decimal TASA_AFP = 0.0287m;
            const decimal TASA_SFS = 0.0304m;

            Console.WriteLine("=== PROGRAMA 1: CÁLCULO DE NÓMINA ===");
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese las horas trabajadas: ");
            double.TryParse(Console.ReadLine(), out double horasTrabajadas);

            Console.Write("Ingrese el pago por hora: ");
            decimal.TryParse(Console.ReadLine(), out decimal pagoPorHora);

            decimal salarioBruto = (decimal)horasTrabajadas * pagoPorHora;
            decimal montoAfp = salarioBruto * TASA_AFP;
            decimal montoSfs = salarioBruto * TASA_SFS;
            decimal salarioNeto = salarioBruto - (montoAfp + montoSfs);

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("          VOLANTE DE PAGO               ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Empleado      : {nombre.ToUpper()}");
            Console.WriteLine($"Salario Bruto : {salarioBruto:N2}");
            Console.WriteLine($"Descuento AFP : {montoAfp:N2}");
            Console.WriteLine($"Descuento SFS : {montoSfs:N2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Salario Neto  : {salarioNeto:N2}");
            Console.WriteLine("----------------------------------------");
        }

        static void EjecutarFactura()
        {
            const decimal TASA_ITBIS = 0.18m;

            Console.WriteLine("=== PROGRAMA 2: FACTURACIÓN ===");
            Console.Write("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine() ?? "Artículo";

            Console.Write("Ingrese la cantidad: ");
            int.TryParse(Console.ReadLine(), out int cantidad);

            Console.Write("Ingrese el precio unitario: ");
            decimal.TryParse(Console.ReadLine(), out decimal precioUnitario);

            decimal subtotal = cantidad * precioUnitario;
            decimal itbis = subtotal * TASA_ITBIS;
            decimal total = subtotal + itbis;

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

        static void EjecutarGeometria()
        {
            Console.WriteLine("=== PROGRAMA 3: CÁLCULOS GEOMÉTRICOS ===");
            Console.Write("Ingrese el radio del círculo: ");
            double.TryParse(Console.ReadLine(), out double radio);

            Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
            double.TryParse(Console.ReadLine(), out double catetoA);

            Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
            double.TryParse(Console.ReadLine(), out double catetoB);

            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("         RESULTADOS GEOMÉTRICOS         ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Círculo:");
            Console.WriteLine($"  Radio          : {radio:N2}");
            Console.WriteLine($"  Área           : {areaCirculo:N2}");
            Console.WriteLine($"  Circunferencia : {circunferencia:N2}");
            Console.WriteLine("\nTriángulo Rectángulo:");
            Console.WriteLine($"  Cateto A       : {catetoA:N2}");
            Console.WriteLine($"  Cateto B       : {catetoB:N2}");
            Console.WriteLine($"  Hipotenusa     : {hipotenusa:N2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
