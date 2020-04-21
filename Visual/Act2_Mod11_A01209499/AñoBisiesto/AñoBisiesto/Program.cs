using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Ano;
            Console.WriteLine("Ingresar un año");
            Ano = Convert.ToDouble(Console.ReadLine());
            if(Ano % 100 != 0 && Ano % 4 == 0)
                Console.WriteLine("El año dado ({0}) es un año bisiesto.", Ano);
            else
                if(Ano%400==0)
                    Console.WriteLine("El año dado ({0}) es un año bisiesto.", Ano);
                else
                    Console.WriteLine("El año dado ({0}) no es un año bisiesto.", Ano);
            Console.ReadLine();


        }
    }
}
