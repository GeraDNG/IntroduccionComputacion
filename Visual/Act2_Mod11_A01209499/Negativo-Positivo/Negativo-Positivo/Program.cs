using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negativo_Positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n;
            Console.WriteLine("Ingresar un número");
            n = Convert.ToDouble(Console.ReadLine());
            if (n >= 0)
                Console.WriteLine("El número dado ({0}) es un número positivo.", n);
            else
                Console.WriteLine("El número dado ({0}) es un número negativo.", n);
            Console.ReadLine();
        }
    }
}
