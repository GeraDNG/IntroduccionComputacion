using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NúmerosOrdenados
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, G, I, P;
            Console.WriteLine("Dar un número");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dar un segundo número");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dar un tercer número");
            C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C)
            {
                G = A;
                if (B > C)
                {
                    I = B;
                    P = C;
                }
                else
                {
                    I = C;
                    P = B;
                }
            }
            else
            {
                if (A > C)
                {
                    G = B;
                    I = A;
                    P = C;
                }
                if (C > B)
                {
                    G = C;
                    I = B;
                    P = A;
                }
                else
                {
                    G = B;
                    I = A;
                    P = C;
                }
            Console.WriteLine("El número más grande es {0}, el número con valor intermedio es el {1} y el menor de todos es el {2}.", G, I, P);
            Console.ReadLine();

            }
                               
        }
    }
}
