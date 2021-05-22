using System;

namespace Flujo_de_datos___C2_Ej20
{
    class Program
    {
        static void Main(string[] args)
        {
            int ventas;
            int suma = 0;

            Console.WriteLine("Escribe el numero de ventas:");
            ventas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ventas; i++)
            {
                Console.WriteLine("Introduzca la venta "+ i);
                suma = suma + Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("La suma total de las ventas es: "+ suma);
        }
    }
}
