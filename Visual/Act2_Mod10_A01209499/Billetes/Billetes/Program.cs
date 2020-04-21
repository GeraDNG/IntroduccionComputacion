using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Cantidad, Residuo, Billetes_200, Billetes_50, Billetes_20, Billetes_1;
            Console.WriteLine("Introducir la cantidad deseada");
            Cantidad = Convert.ToInt32(Console.ReadLine());
            Billetes_200 = (Cantidad / 200);
            Residuo = Cantidad % 200;
            Billetes_50 = (Residuo / 50);
            Residuo = Cantidad % 50;
            Billetes_20 = (Residuo / 20);
            Residuo = Cantidad % 20;
            Billetes_1 = Residuo;
            Console.WriteLine("Serían {0} billetes de $200", Billetes_200);
            Console.WriteLine("Serían {0} billetes de $50", Billetes_50);
            Console.WriteLine("Serían {0} billetes de $20", Billetes_20);
            Console.WriteLine("Serían {0} billetes de $1", Billetes_1);
            Console.ReadLine();
        }

    }
}
