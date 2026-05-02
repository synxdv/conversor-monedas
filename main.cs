using System;
using System.Numerics;

//Conversor de monedas, Bolivares a dolares
int tasaBolivares = 467;
double TasaDolares = 0.002;
bool estado = true;

while (estado)
{
    Console.WriteLine("Ingresa la moneda que quieres convertir..  \n 1. Dolares a Bolivares \n 2. Bolivares a Dolares \n 3.Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            DolaresABolivares();
            break;
        case 2:
            BolivaresADolares();
            break;
        case 3:
            estado = false;
            Console.WriteLine("Saliendo del programa.... (presiona cualquier tecla luego de este mensaje)");
            break;
    }

    void DolaresABolivares()
    {
        Console.WriteLine("Ingrese la cantidad de dolares que quieras convertir en Bolivares....");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser positiva, no 0 o menor....");
        }
        else
        {
            int total = cantidad * tasaBolivares;
            Console.WriteLine($"{cantidad}$ En Bolivares son {total} ");
        }

    }

    void BolivaresADolares()
    {
        Console.WriteLine("Ingresa la cantidad de Bolivares que quieras convertir a dolares....");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= 0)
        {
            Console.WriteLine("El numero debe ser positivo, no puede ser 0");
        }
        else
        {
            double total = cantidad * TasaDolares;
            Console.WriteLine($"{cantidad} Bolivares en Dolares son {total}");
        }
    }

}





Console.ReadKey();