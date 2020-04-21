using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace División
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, resultado, n1;
            Console.WriteLine("Ingresar un número (dividendo)");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar un segundo número (divisor)");
            n1 = Convert.ToDouble(Console.ReadLine());
            if (n1 == 0)
                Console.WriteLine("El número dado ({0}) es un número cero, por lo tanto no se puede realizar la operación.", n1);
            else
                resultado = Convert.ToDouble(n / n1);
                Console.WriteLine("El número que se obtiene como resultado es: {0}", resultado);
            Console.ReadLine();
        }
    }
}
