using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
            {
                int i, suma, N, entero;
                i = 0;
                suma = 0;
                Console.WriteLine("¿Cuántos números deseas ingresar?");
                N = Convert.ToInt32 (Console.ReadLine());
                do
                {
                    Console.WriteLine("Introduce un número entero.");
                    entero =Convert.ToInt32 (Console.ReadLine());
                    if (entero % 2 == 0)
                        suma += entero;
                    i++;
                } 
                while (i < N);
                Console.WriteLine("La suma de pares es de: " + suma);
                Console.ReadLine();
            }
        }
    }

