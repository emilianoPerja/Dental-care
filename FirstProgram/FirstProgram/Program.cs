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
            WriteLine("********************************************");
            WriteLine("* PROGRAMA PARA CALCULAR ax^2 + bx + c = 0 *");
            WriteLine("********************************************");
            WriteLine("\nIntroduce los valores");

            Write("a: ");
            int a = Convert.ToInt32(ReadLine());
        }
    }
}
