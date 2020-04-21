using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuestraIntermediosA01209499
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 A, B, C;
            Console.WriteLine("Escribir un número");
            A = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Escribir un segundo número, que sea mayor al primero");
                B = Convert.ToInt32(Console.ReadLine());
            }
            while (A > B);
            C = A + 1;
            Console.Write("Los números intermedios son: ");
            do
            {
                Console.Write(C + ", ");
                C = C + 1;
            }
            while (C < B);
            Console.WriteLine("Gracias por usar este programa.");
            Console.ReadLine();

        }

    }
}
