using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Char servicio, factura;
            Double metros, presupuesto, IVA, Total;
            Console.WriteLine("¿Qué tipo de servicio requiere? (Ingrese la letra e (para estopear) o t (para tapizar), según la opción deseada)");
            servicio = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("¿Cuántos metros requiere?");
            metros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Requiere factura? (Ingrese la letra s (para si) o n (para no), según la opción deseada)");
            factura = Convert.ToChar(Console.ReadLine());

            if (servicio == 't')
                presupuesto = 350.0 / 12 * metros;
            else
                presupuesto = 300.0 / 10 * metros;
            if (factura == 's')
                IVA = presupuesto * .16;
            else
                IVA = 0;
            Total = presupuesto + IVA;
            Console.WriteLine("El total del presupuesto sería de: {0:C}", Total);
            Console.ReadLine();
        }
    }
}
