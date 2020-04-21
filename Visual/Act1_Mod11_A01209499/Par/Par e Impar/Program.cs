using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Par_e_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 A;
            Console.WriteLine("Da un número");
            A = Convert.ToInt32(Console.ReadLine());
            if (A % 2 == 0)
                Console.WriteLine("El número dado ({0}) es un número par.", A);
            else
                Console.WriteLine("El número dado ({0}) es un número impar.", A);
            Console.ReadLine();
        }
    }
}
