using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Double IVA, Ticket, TotalC;
            Console.WriteLine("¿De cuánto es su ticket?");
            Ticket = Convert.ToDouble(Console.ReadLine());
            IVA = Ticket * 0.16;
            TotalC = Ticket - IVA;
            Console.WriteLine("El total de la compra, sin IVA es de: {0:C}", TotalC);
            Console.WriteLine("El total del IVA aplicado es de: {0:C}", IVA);
            Console.ReadLine();
        }
    }
}
