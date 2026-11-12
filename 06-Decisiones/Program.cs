using System;

Console.WriteLine("=== PARTE 1: CALIFICACIÓN ===");
Console.Write("Ingresa la nota (0 - 100): ");
string? entradaNota = Console.ReadLine();

if (int.TryParse(entradaNota, out int nota) && nota >= 0 && nota <= 100)
{
    if (nota >= 90)
    {
        Console.WriteLine("Calificación: A");
    }
    else if (nota >= 80)
    {
        Console.WriteLine("Calificación: B");
    }
    else if (nota >= 70)
    {
        Console.WriteLine("Calificación: C");
    }
    else
    {
        Console.WriteLine("Calificación: F");
    }
}
else
{
    Console.WriteLine("Error: Debes ingresar un número entero válido entre 0 y 100.");
}

Console.WriteLine("\n=== PARTE 2: CALCULADORA ===");
Console.Write("Ingresa el primer número: ");
bool num1Valido = double.TryParse(Console.ReadLine(), out double num1);

Console.Write("Ingresa el segundo número: ");
bool num2Valido = double.TryParse(Console.ReadLine(), out double num2);

if (num1Valido && num2Valido)
{
    Console.WriteLine("Elige una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Opción: ");
    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine($"Resultado: {num1 + num2}");
            break;
        case "2":
            Console.WriteLine($"Resultado: {num1 - num2}");
            break;
        case "3":
            Console.WriteLine($"Resultado: {num1 * num2}");
            break;
        case "4":
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
            }
            else
            {
                Console.WriteLine($"Resultado: {num1 / num2}");
            }
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
else
{
    Console.WriteLine("Error: Uno o ambos números ingresados no son válidos.");
}
