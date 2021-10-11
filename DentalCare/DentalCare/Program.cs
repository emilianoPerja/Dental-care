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
                        OpcionCitasPorDia();
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
            appointments.ForEach(a => WriteLine($"{a.Patient.FullName,20}. {a.Day.Name,-9} - {a.Time.Description,10}"));
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

        private static void OpcionCitasPorDia()
        {
            Clear();
            WriteLine("*****************************************");
            WriteLine("*            -Citas por dia-            *");
            WriteLine("*****************************************");
            WriteLine("");

            var days = agenda.GetDays();
            days.ForEach(d =>
            {
                WriteLine(d.Name);

                var appointments = agenda.GetCitasPorDia(d.Id);
                if (appointments.Count > 0)
                {
                    appointments.ForEach(a => WriteLine($"    {a.Time.Description} - {a.Patient.FullName}."));
                }
                else
                {
                    WriteLine("    -- No hay citas pendientes --");
                }
            });
            ReadKey();
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
                        OpcionAgendar();
                        break;

                    case 2:
                        OpcionCancelar();
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

        private static void OpcionAgendar()
        {
            Clear();
            WriteLine("*****************************************");
            WriteLine("*               -Agendar-               *");
            WriteLine("*****************************************");
            WriteLine("");

            Write("Clave de paciente: ");
            int clave = Convert.ToInt32(ReadLine());

            if (agenda.ValidateClavePaciente(clave)) // 422086
            {
                if (agenda.HasCitaPendiente(clave))
                {
                    WriteLine("\n¡El paciente ya tiene una cita asignada!");
                }
                else
                {
                    List<Day> days = agenda.GetAvailableDays();
                    if (days.Count > 0)
                    {
                        WriteLine("\n***** Dias disponibles *****");
                        for (int i = 0; i < days.Count; ++i)
                        {
                            WriteLine($"{i} - {days[i].Name}");
                        }

                        Write("\nElige un día: ");
                        int dayIndex = Convert.ToInt32(ReadLine());
                        if (dayIndex >= 0 && dayIndex < days.Count)
                        {
                            List<Time> times = agenda.GetAvailableTimes(days[dayIndex]);
                            
                            WriteLine("\n***** Horas disponibles *****");
                            for (int i = 0; i < times.Count; ++i)
                            {
                                WriteLine($"{i} - {times[i].Description}");
                            }
                            WriteLine($"{times.Count} - No asignar horario");

                            Write("\nElige una hora: ");
                            int timeIndex = Convert.ToInt32(ReadLine());
                            if (timeIndex >= 0 && timeIndex < times.Count)
                            {
                                agenda.AssignCita(clave, days[dayIndex], times[timeIndex]);
                                
                                WriteLine("¡CITA ASIGNADA!");
                            }
                            else if (timeIndex == times.Count)
                            {
                                WriteLine("\n¡No se asignó cita!");
                            }
                            else
                            {
                                WriteLine("\n¡La hora seleccionada no es válida, no se asignó cita!");
                            }
                        }
                        else
                        {
                            WriteLine("\n¡El día seleccionado no es válido, no se asignó cita!");
                        }
                    }
                    else
                    {
                        WriteLine("\n¡No hay días disponibles para asignación de citas!");
                    }
                }
            }
            else
            {
                WriteLine("\n¡La clave del paciente no es válida!");
            }

            ReadKey();
        }

        private static void OpcionCancelar()
        {
            Clear();
            WriteLine("*****************************************");
            WriteLine("*              -Cancelar-               *");
            WriteLine("*****************************************");
            WriteLine("");


            ReadKey();
        }
    }
}
