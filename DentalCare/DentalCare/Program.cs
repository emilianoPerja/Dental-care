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
        /*
        static int Suma(int a, int b)
        {
            return a + b;
        }

        delegate int SumaFunc(int a, int b);

        static void Main()
        {
            SumaFunc Suma2 = (a, b) => a + b;

            int res = Suma2(14, 3); // Suma(14, 3);
            WriteLine($"{res}");
        }
        */

        private static Agenda agenda;

        static void Main(string[] args)
        {
            agenda = new Agenda();

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
                        SubmenuConsultas();
                        break;

                    case 2:
                        SubmenuCitas();
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

        private static void SubmenuConsultas()
        {
            int option = 0;
            do
            {
                Clear();
                WriteLine("*****************************************");
                WriteLine("*              DENTAL CARE              *");
                WriteLine("*          -Submenú consultas-          *");
                WriteLine("*****************************************");
                WriteLine("");
                WriteLine("1. Citas por paciente");
                WriteLine("2. Citas por día");
                WriteLine("0. Volver");

                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());

                switch (option)
                {
                    case 1:
                        OpcionCitasPorPaciente();
                        break;

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
        }

        private static void OpcionCitasPorPaciente()
        {
            Clear();
            WriteLine("*****************************************");
            WriteLine("*         -Citas por paciente-          *");
            WriteLine("*****************************************");
            WriteLine("");

            var appointments = agenda.GetCitasPorPaciente();
            appointments.ForEach(a => WriteLine($"{a.Patient.FullName}. {a.Day.Name} - {a.Time.Description}"));
            ReadKey();

            //foreach (var ap in appointments)
            //{
            //    WriteLine($"{ap.Patient.FullName}. {ap.Day.Name} - {ap.Time.Description}");
            //}

            //for (int i = 0; i < appointments.Count; ++i)
            //{
            //    WriteLine($"{appointments[i].Patient.FullName}. {appointments[i].Day.Name} - {appointments[i].Time.Description}");
            //}
        }

        private static void SubmenuCitas()
        {
            int option = 0;
            do
            {
                Clear();
                WriteLine("*****************************************");
                WriteLine("*              DENTAL CARE              *");
                WriteLine("*            -Submenú citas-            *");
                WriteLine("*****************************************");
                WriteLine("");
                WriteLine("1. Agendar");
                WriteLine("2. Cancelar");
                WriteLine("0. Volver");

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
        }
    }
}
