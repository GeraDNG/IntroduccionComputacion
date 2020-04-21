using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, m;
            do
            {
                Console.WriteLine("Ingresa el número deseado para obtener su tabla de multiplicar");
                n = Convert.ToInt32(Console.ReadLine());
                if (n != 0)
                {
                    c = 1;
                    do
                    {
                        m = n * c;
                        Console.WriteLine("{0}x{1}={2}", n, c, m);
                        c++;
                    }
                    while (c <= 10);
                }
                else
                   Console.WriteLine("El número dado es cero.");
            }
            while (n != 0);
            
        }
    }
}
