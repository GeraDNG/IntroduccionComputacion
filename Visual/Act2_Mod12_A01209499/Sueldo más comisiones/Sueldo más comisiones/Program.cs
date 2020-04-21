using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sueldo_más_comisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cv;
            Double s, v, c, t;
            Console.WriteLine("¿Cuántos vendedores hay?");
            n = Convert.ToInt32(Console.ReadLine());
            cv = 0;
            do
            {
                Console.WriteLine("Introducir el sueldo");
                s = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introducir las ventas");
                v = Convert.ToDouble(Console.ReadLine());
                if (v < 1000)
                    c = 0;
                if (v <= 2000)
                    c = v * 0.1;
                else
                    c = v * 0.15;
                t = c + v;
                Console.WriteLine("El sueldo es de {0:C}, las comisiones son de {1:C} y el total a pagar es de {2:C}", s, c, t);
                cv++;


            }
            while (n == cv);
            Console.ReadLine();
        }
    }
}
