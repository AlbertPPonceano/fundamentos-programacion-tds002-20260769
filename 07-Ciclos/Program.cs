using System;

int numero = 0;
bool esValido = false;

// 1. Pide un número entre 1 y 12 y valídalo con do-while
do
{
    Console.Write("Ingresa un número entero entre 1 y 12: ");
    string? entrada = Console.ReadLine();

    if (int.TryParse(entrada, out numero) && numero >= 1 && numero <= 12)
    {
        esValido = true;
    }
    else
    {
        Console.WriteLine("Error: Entrada no válida. Debe ser un número entre 1 y 12.");
    }
} while (!esValido);

Console.WriteLine($"\n--- Tabla de Multiplicar del {numero} ---");

int contador = 1;
int acumuladorSuma = 0;

// 2. Muestra la tabla del 1 al 12 con while y 3. Acumula la suma
while (contador <= 12)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");
    
    acumuladorSuma += resultado; // Acumulando el total
    contador++;                  // Incrementando el contador
}

Console.WriteLine($"\nLa suma de todos los resultados de la tabla es: {acumuladorSuma}");
