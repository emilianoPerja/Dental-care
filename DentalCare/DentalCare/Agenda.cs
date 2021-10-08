using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DentalCare
{
    class Agenda
    {
        private List<Day> days;
        private List<Time> times;
        private List<Schedule> schedules;
        private List<Patient> patients;
        private List<Appointment> appointments;

        public Agenda()
        {
            // 1. Abrir archivo
            // 2. Leer (for) cada línea del archivo => "0|Lunes"
            // 3. ---- Separar datos por el caracter '|'
            //         y forma arreglo de strings => ["0", "Lunes"]
            // 4. Proporcionar función para convertir arreglo de strings
            //    en clase deseada (Day, Time, etc.)
            days = EasyFile<Day>.LoadDataFromFile("days.txt",
                            t => new Day(Convert.ToInt32(t[0]), t[1]));
            days.Sort((x, y) => x.Id.CompareTo(y.Id));

            times = EasyFile<Time>.LoadDataFromFile("time.txt",
                            t => new Time(Convert.ToInt32(t[0]), t[1]));

            schedules = EasyFile<Schedule>.LoadDataFromFile("schedule.txt",
                            t => new Schedule(Convert.ToInt32(t[0]),
                                              Convert.ToInt32(t[1])));

            patients = EasyFile<Patient>.LoadDataFromFile("patients.txt",
                            t => new Patient(Convert.ToInt32(t[0]), t[1], t[2]));

            appointments = EasyFile<Appointment>.LoadDataFromFile("appointments.txt",
                            t => new Appointment(Convert.ToInt32(t[0]),
                                                 Convert.ToInt32(t[1]),
                                                 Convert.ToInt32(t[2])));
        }

        public List<FullAppointment> GetCitasPorPaciente()
        {
            var fullAppointments = new List<FullAppointment>();
            appointments.ForEach(a =>
                fullAppointments.Add(new FullAppointment(
                    patients.Find(p => p.Id == a.PatientId),
                    days.Find(d => d.Id == a.DayId),
                    times.Find(t => t.Id == a.TimeId))));

            fullAppointments.Sort((x, y) => x.Patient.FullName.CompareTo(y.Patient.FullName));

            return fullAppointments;
        }

        public List<Day> GetDays() => new List<Day>(days);

        public List<FullAppointment> GetCitasPorDia(int dayId)
        {
            var fullAppointments = new List<FullAppointment>();
            appointments.FindAll(a => a.DayId == dayId)
                .ForEach(a =>
                    fullAppointments.Add(new FullAppointment(
                        patients.Find(p => p.Id == a.PatientId),
                        days.Find(d => d.Id == a.DayId),
                        times.Find(t => t.Id == a.TimeId))));

            fullAppointments.Sort((x, y) => x.Time.Id.CompareTo(y.Time.Id));

            return fullAppointments;
        }
    }
}
