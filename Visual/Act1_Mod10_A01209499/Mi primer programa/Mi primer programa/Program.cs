using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_primer_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Num, Num2, Suma;
            Console.WriteLine("Mi nombre es Gerardo Daniel Naranjo Gallegos");
            Console.Write("Da el primer número  ");
            Num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Da el segundo número   ");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Suma = Num + Num2;
            Console.WriteLine("La suma de los dos números es de {0;C}", Suma);
            Console.ReadLine();
        }
    }
}
