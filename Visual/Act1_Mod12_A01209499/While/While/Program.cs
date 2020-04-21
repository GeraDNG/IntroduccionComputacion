using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, suma, N, entero;
            i = 0;
            suma = 0;
            Console.WriteLine("¿Cuántos números deseas capturar?");
            N = Convert.ToInt32(Console.ReadLine());
            while (i < N)
            {
                Console.WriteLine("Introduce un número entero.");
                entero = Convert.ToInt32(Console.ReadLine());
                if (entero % 2 == 0)
                    suma += entero;
                i++;
            }
            Console.WriteLine("La suma de pares es: " + suma);
            Console.ReadLine();

        }
        }
    }

