
using System;

// Generar un número secreto entre 1 y 100.
int numeroSecreto = Random.Shared.Next(1, 101);

int numeroUsuario = 0;
int intentos = 0;

Console.WriteLine("Adivina el número secreto entre 1 y 100.");

while (numeroUsuario != numeroSecreto)
{
    Console.Write("Introduce tu número: ");

    if (!int.TryParse(Console.ReadLine(), out numeroUsuario) ||
        numeroUsuario < 1 || numeroUsuario > 100)
    {
        Console.WriteLine("Ingresa un número válido entre 1 y 100.");
        continue;
    }

    intentos++;

    if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("El número secreto es MAYOR.");
    }
    else if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El número secreto es MENOR.");
    }
}

Console.WriteLine("\n¡Felicidades! Adivinaste el número.");
Console.WriteLine($"Cantidad de intentos: {intentos}");

