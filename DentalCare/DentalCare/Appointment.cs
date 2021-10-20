using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Appointment
    {
        public int PatientId { get; } // read-only
        public int DayId { get; set; } // read-write
        public int TimeId { get; set; } // read-write

        public Appointment(int patientId, int dayId, int timeId)
        {
            PatientId = patientId;
            DayId = dayId;
            TimeId = timeId;
        }
    }
}
