
using System;

decimal subtotal = 0;
int cantidadProductos = 0;
decimal precio;

do
{
    Console.Write("Ingrese el precio del producto (0 para terminar): ");

    if (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
    {
        Console.WriteLine("Ingrese un precio válido.");
        precio = -1;
        continue;
    }

    if (precio > 0)
    {
        subtotal += precio;
        cantidadProductos++;
    }

} while (precio != 0);

decimal itbis = subtotal * 0.18m;
decimal total = subtotal + itbis;

Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal:N2}");
Console.WriteLine($"ITBIS (18%): {itbis:N2}");
Console.WriteLine($"Total: {total:N2}");

