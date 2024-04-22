using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    public interface IRegisteredUser
    {
        string ViewAppointments(List<Appointment> appointments);
        bool BookAppointment(string category, string description, string appointmentDate, string appointmentTime, List<Appointment> existingAppointments);
        bool RescheduleAppointment(Appointment appointment, string newDate, string newTime, List<Appointment> appointments);
        bool CancelAppointment(Appointment appointment, List<Appointment> appointments);
    }
}
