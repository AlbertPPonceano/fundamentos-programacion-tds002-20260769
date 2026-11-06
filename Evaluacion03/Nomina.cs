using System;

namespace Evaluacion03
{
    class NominaProgram
    {
        static void Main(string[] args)
        {
            // Constantes de deducciones de ley
            const decimal TASA_AFP = 0.0287m;
            const decimal TASA_SFS = 0.0304m;

            Console.WriteLine("=== PROGRAMA 1: CÁLCULO DE NÓMINA ===");

            // 1. Entrada
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese las horas trabajadas: ");
            if (!double.TryParse(Console.ReadLine(), out double horasTrabajadas))
            {
                horasTrabajadas = 0;
            }

            Console.Write("Ingrese el pago por hora: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal pagoPorHora))
            {
                pagoPorHora = 0m;
            }

            // 2. Proceso
            decimal salarioBruto = (decimal)horasTrabajadas * pagoPorHora;
            decimal montoAfp = salarioBruto * TASA_AFP;
            decimal montoSfs = salarioBruto * TASA_SFS;
            decimal salarioNeto = salarioBruto - (montoAfp + montoSfs);

            // 3. Salida
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
    }
}