using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cambio_de_divisas
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pesos, dolares, tipoCambio;
            Console.WriteLine("¿Cuánto vale el dólar hoy?");
            tipoCambio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cuántos pesos deseas convertir?");
            pesos = Convert.ToDouble(Console.ReadLine());
            dolares = pesos / tipoCambio;
            Console.WriteLine("La cantidad de dólares es de {0:C}", dolares);
            Console.ReadLine();

        }
    }
}
