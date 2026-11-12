
using System;

decimal suma = 0;
decimal notaMayor = 0;
decimal notaMenor = 0;
int cantidadNotas = 0;

while (true)
{
    Console.Write("Ingrese una nota (0-100) o -1 para terminar: ");

    if (!decimal.TryParse(Console.ReadLine(), out decimal nota))
    {
        Console.WriteLine("Debe ingresar un número válido.");
        continue;
    }

    // -1 finaliza el programa.
    if (nota == -1)
    {
        break;
    }

    // Validar que la nota esté entre 0 y 100.
    if (nota < 0 || nota > 100)
    {
        Console.WriteLine("La nota debe estar entre 0 y 100.");
        continue;
    }

    if (cantidadNotas == 0)
    {
        notaMayor = nota;
        notaMenor = nota;
    }
    else
    {
        if (nota > notaMayor)
            notaMayor = nota;

        if (nota < notaMenor)
            notaMenor = nota;
    }

    suma += nota;
    cantidadNotas++;
}

Console.WriteLine("\n--- RESULTADOS ---");

if (cantidadNotas == 0)
{
    Console.WriteLine("No se ingresaron notas.");
}
else
{
    decimal promedio = suma / cantidadNotas;

    Console.WriteLine($"Cantidad de notas: {cantidadNotas}");
    Console.WriteLine($"Promedio: {promedio:N2}");
    Console.WriteLine($"Nota mayor: {notaMayor:N2}");
    Console.WriteLine($"Nota menor: {notaMenor:N2}");
}
