using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 V, D5, D8, D12, T;
            Console.WriteLine("¿Cuál es la velocidad a la que viaja el vehículo (km/h)?");
            V = Convert.ToInt32(Console.ReadLine());
            D5 = V * 5;
            D8 = V * 8;
            D12 = V * 12;
            Console.WriteLine("La distancia recorrida con esa velocidad, después de 5 horas, es de: {0}", D5);
            Console.WriteLine("La distancia recorrida con esa velocidad, después de 8 horas, es de: {0}", D8);
            Console.WriteLine("La distancia recorrida con esa velocidad, después de 12 horas, es de: {0}", D12);
            Console.ReadLine();
        }
    }
}
