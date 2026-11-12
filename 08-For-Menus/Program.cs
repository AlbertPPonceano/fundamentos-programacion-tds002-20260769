
using System;

int opcion;

do
{
    Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Mostrar tablas del 1 al 10");
    Console.WriteLine("2. Dibujar triángulo");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Ingrese una opción válida.");
        opcion = -1;
        continue;
    }

    switch (opcion)
    {
        case 1:
            MostrarTablas();
            break;

        case 2:
            DibujarTriangulo();
            break;

        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción incorrecta. Intente nuevamente.");
            break;
    }

} while (opcion != 0);


// Ejercicio 1: Mostrar las tablas del 1 al 10 en columnas.
void MostrarTablas()
{
    Console.WriteLine("\n===== TABLAS DE MULTIPLICAR =====");

    Console.Write(" x  |");

    for (int tabla = 1; tabla <= 10; tabla++)
    {
        Console.Write($"{tabla,4}");
    }

    Console.WriteLine("\n----------------------------------------------");

    // Ciclos anidados para mostrar las multiplicaciones.
    for (int fila = 1; fila <= 10; fila++)
    {
        Console.Write($"{fila,3} |");

        for (int columna = 1; columna <= 10; columna++)
        {
            int resultado = fila * columna;
            Console.Write($"{resultado,4}");
        }

        Console.WriteLine();
    }
}


// Ejercicio 2: Dibujar un triángulo de asteriscos.
void DibujarTriangulo()
{
    int filas;

    do
    {
        Console.Write("\nIngrese la cantidad de filas: ");

        if (!int.TryParse(Console.ReadLine(), out filas) || filas < 1)
        {
            Console.WriteLine("Ingrese un número entero mayor que 0.");
            filas = 0;
        }

    } while (filas < 1);

    Console.WriteLine("\n===== TRIÁNGULO =====");

    for (int i = 1; i <= filas; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

