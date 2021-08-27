using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            char option = 'n';
            do
            {
                Clear();
                WriteLine("********************************************");
                WriteLine("* PROGRAMA PARA CALCULAR ax^2 + bx + c = 0 *");
                WriteLine("********************************************");
                WriteLine("\nIntroduce los valores");

                Write("a: ");
                int a = Convert.ToInt32(ReadLine());

                Write("b: ");
                int b = Convert.ToInt32(ReadLine());

                Write("c: ");
                int c = Convert.ToInt32(ReadLine());

                if (a == 0 && b == 0)
                {
                    WriteLine("¡No es una ecuación válida!");
                }
                else if (a == 0) // && b != 0
                {
                    WriteLine("\n¡Es una ecuación lineal!");

                    double x = -c / (double)b;
                    WriteLine($"x = {x}");
                }
                else
                {
                    int D = b * b - 4 * a * c;
                    if (D > 0)
                    {
                        WriteLine("\n¡Raíces reales y diferentes!");

                        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        WriteLine($"x1 = {x1}");
                        WriteLine($"x2 = {x2}");
                    }
                    else if (D == 0)
                    {
                        WriteLine("\n¡Raíces reales e iguales!");

                        double x = -b / (2.0 * a);
                        WriteLine($"x1 = x2 = {x}");
                    }
                    else
                    {
                        WriteLine("\n¡Raíces complejas conjugadas!");

                        double real = -b / (2.0 * a);
                        double imag = Math.Sqrt(-D) / (2 * a);

                        WriteLine($"x1 = {real} + {imag} i");
                        WriteLine($"x2 = {real} - {imag} i");
                    }
                }

                Write("\n¿Deseas resolver otra ecuación? [s/n]: ");
                option = ReadLine().ToLower().Trim()[0];
            } while (option == 's');

            WriteLine("\n¡Gracias por utilizar el programa!");
        }
    }
}
