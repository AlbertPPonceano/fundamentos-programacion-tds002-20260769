// Constante de conversión de libras a kilogramos
const double FACTOR_LIBRAS_A_KG = 0.453592;

Console.WriteLine("========================================");
Console.WriteLine("      CONVERSOR DE UNIDADES (04)        ");
Console.WriteLine("========================================\n");

// 1. Solicitar el peso en libras
Console.Write("Ingrese el peso en libras (lb): ");
if (double.TryParse(Console.ReadLine(), out double libras))
{
    // 2. Solicitar la temperatura en Fahrenheit
    Console.Write("Ingrese la temperatura en Fahrenheit (°F): ");
    if (double.TryParse(Console.ReadLine(), out double fahrenheit))
    {
        // 3. Realizar conversiones
        double kilogramos = libras * FACTOR_LIBRAS_A_KG;
        double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;

        // 4. Mostrar resultados formateados a 2 decimales
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("               RESULTADOS               ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"• Peso ingresado: {libras:F2} lb");
        Console.WriteLine($"• Equivalente en kg: {kilogramos:F2} kg");
        Console.WriteLine($"• Temperatura ingresada: {fahrenheit:F2} °F");
        Console.WriteLine($"• Equivalente en °C: {celsius:F2} °C");
        Console.WriteLine("----------------------------------------");
    }
    else
    {
        Console.WriteLine("❌ Error: Debe ingresar un valor numérico válido para la temperatura.");
    }
}
else
{
    Console.WriteLine("❌ Error: Debe ingresar un valor numérico válido para el peso.");
}
