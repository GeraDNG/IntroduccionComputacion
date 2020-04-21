using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, opcion, contador, factorial;

            Console.Write("Dar el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Dar el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            while (num1 >= num2);
            do
            {
                Console.WriteLine("    Opciones de Operaciones para dos números");
                Console.WriteLine(" 1. Suma de los números de N1 a N2");
                Console.WriteLine(" 2. Suma de los números pares de N1 a N2");
                Console.WriteLine(" 3. Listar los números múltiplos de 5 que hay de N1 y N2");
                Console.WriteLine(" 4. Factorial del primer número N1");
                Console.WriteLine(" 5. Salir");
                Console.WriteLine(" ");
                Console.Write("Qué opción deseas=>");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            contador = num1;
                            suma = num1;
                            do
                            {
                                contador++;
                                suma += contador;
                            }
                            while (contador != num2);
                        }
                        Console.WriteLine("La sumatoria de los números entre {0} y {1} sería de: {2}.", num1, num2, suma);
                        Console.ReadLine();
                        //Introducir código para Suma de los números de N1 a N2                  
                        break;
                    case 2:
                        {
                            contador = num1;
                            suma = 0;
                            do
                            {
                                if (contador % 2 == 0)
                                    suma = suma + contador;
                                contador++;
                                
                            }
                            while (contador < num2);
                        }
                        Console.WriteLine("La sumatoria de los números entre {0} y {1} sería de: {2}.", num1, num2, suma);
                        Console.ReadLine();
                        ///Introducir código para Suma de los números pares de N1 a N2

                        break;
                    case 3:
                        {
                            contador = num1;
                            do
                            {
                                if (contador % 5 == 0)
                                    Console.WriteLine("El número {0} es múltiplo de 5.", contador);
                                contador++;
                            }
                            while(contador < num2);
                            Console.ReadLine();
                        }
                        ///Introducir código para Listar los números múltiplos de 5 que hay entre N1 y N2

                        break;
                    case 4:
                        {
                            factorial = num1;
                            contador = num1;
                            if (num1 == 0 || num1 == 1)
                                Console.WriteLine("factorial = 1");
                            else
                                do
                                {
                                    contador--;
                                    factorial = factorial * contador;
                                }
                                while(contador != 1);
                            Console.WriteLine("El factorial de {0} es: {1}.", num1, factorial); 
                        }
                        Console.ReadLine();
                        ///Introducir código para Factorial del primer número N1

                        break;
                    default:
                        Console.WriteLine(" FIN ");
                        break;
                }

            } while (opcion != 5);
            Console.ReadLine();
        }
    }
}
