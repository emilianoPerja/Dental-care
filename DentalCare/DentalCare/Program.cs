using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DentalCare
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            int option = 0;
            do
            {
                Clear();
                WriteLine("*****************************************");
                WriteLine("*              DENTAL CARE              *");
                WriteLine("*            -Menú principal-           *");
                WriteLine("*****************************************");
                WriteLine("");
                WriteLine("1. Consultas");
                WriteLine("2. Citas");
                WriteLine("0. Salir");

                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());
                
                switch (option)
                {
                    case 1:
                    case 2:
                        WriteLine("\n¡Opción NO implementada!");
                        ReadKey();
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("\n¡Opción NO válida!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);

            WriteLine("\n¡Gracias por usar el programa!");
        }
    }
}
