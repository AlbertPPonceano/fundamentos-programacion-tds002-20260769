using System;

namespace Evaluacion03
{
    class GeometriaProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAMA 3: CÁLCULOS GEOMÉTRICOS ===");

            // 1. Entrada
            Console.Write("Ingrese el radio del círculo: ");
            if (!double.TryParse(Console.ReadLine(), out double radio))
            {
                radio = 0;
            }

            Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double catetoA))
            {
                catetoA = 0;
            }

            Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double catetoB))
            {
                catetoB = 0;
            }

            // 2. Proceso - Círculo
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;

            // 2. Proceso - Triángulo Rectángulo (Teorema de Pitágoras: c = sqrt(a^2 + b^2))
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // 3. Salida
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