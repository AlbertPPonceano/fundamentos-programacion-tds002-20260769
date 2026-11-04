using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lectura de dos números enteros
            Console.Write("Ingresa el primer número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número entero: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Operaciones requeridas
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int producto = numero1 * numero2;
            
            // División real (haciendo casting explícito a double para no perder decimales)
            double divisionReal = (double)numero1 / numero2;
            
            // División entera y residuo (módulo)
            int divisionEntera = numero1 / numero2;
            int residuo = numero1 % numero2;

            // Verificación si el primer número es par
            bool esPar = (numero1 % 2 == 0);

            // Muestra de resultados utilizando interpolación de cadenas
            Console.WriteLine("\n=== RESULTADOS DE OPERACIONES ===");
            Console.WriteLine($"Suma: {numero1} + {numero2} = {suma}");
            Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");
            Console.WriteLine($"Producto: {numero1} * {numero2} = {producto}");
            Console.WriteLine($"División real: {numero1} / {numero2} = {divisionReal}");
            Console.WriteLine($"División entera: {numero1} / {numero2} = {divisionEntera}");
            Console.WriteLine($"Residuo (módulo): {numero1} % {numero2} = {residuo}");
            Console.WriteLine($"¿El primer número ({numero1}) es par?: {esPar}");
        }
    }
}

/*
========================================================================
PRUEBA DE ESCRITORIO (x = 10, y = 3)
========================================================================
Valores de entrada:
- numero1 (x) = 10
- numero2 (y) = 3

Evaluación de operaciones:
- suma = 10 + 3 = 13
- resta = 10 - 3 = 7
- producto = 10 * 3 = 30
- divisionReal = (double)10 / 3 = 3.3333333333333335
- divisionEntera = 10 / 3 = 3
- residuo = 10 % 3 = 1
- esPar = (10 % 2 == 0) -> (0 == 0) -> true
========================================================================
*/