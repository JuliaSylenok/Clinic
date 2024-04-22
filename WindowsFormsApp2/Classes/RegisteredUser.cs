using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    // Клас RegisteredUser
    public class RegisteredUser : User, IRegisteredUser
    {
        public RegisteredUser(string name, string password, string phoneNumber) : base(name, password, phoneNumber)
        {
        }

        public string ViewAppointments(List<Appointment> appointments)
        {
            StringBuilder appointmentInfo = new StringBuilder();
            foreach (var appointment in appointments)
            {
                if (appointment.User == this)
                {
                    appointmentInfo.AppendLine($"{appointment.Date},{appointment.Service.Name},{appointment.Time}");
                }
            }

            return appointmentInfo.ToString();
        }

        public bool BookAppointment(string category, string description, string appointmentDate, string appointmentTime, List<Appointment> existingAppointments)
        {
            // Перевірка наявності вільного часу для запису на прийом
            bool isAvailable = existingAppointments.All(appointment =>
                appointment.Date != appointmentDate || appointment.Time != appointmentTime);

            if (isAvailable)
            {
                existingAppointments.Add(new Appointment
                {
                    Date = appointmentDate,
                    Time = appointmentTime,
                    Service = new Service { Name = category, Description = description },
                    User = this
                });

                return true;
            }

            return false;
        }

        


        public bool RescheduleAppointment(Appointment appointment, string newDate, string newTime, List<Appointment> appointments)
        {
            DateTime newAppointmentDateTime = DateTime.Parse($"{newDate} {newTime}");
            if (newAppointmentDateTime < DateTime.Now)
            {
                throw new InvalidOperationException("Не вдалося перенести зустріч. Вибрані дата та час уже минули.");
            }

            bool isAvailable = true;

            foreach (var otherAppointment in appointments)
            {
                if (otherAppointment.User == appointment.User && otherAppointment != appointment)
                {
                    DateTime otherAppointmentDateTime = DateTime.Parse($"{otherAppointment.Date} {otherAppointment.Time}");
                    if (otherAppointmentDateTime == newAppointmentDateTime)
                    {
                        isAvailable = false;
                        break;
                    }
                }
            }

            if (isAvailable)
            {
                appointment.Date = newDate;
                appointment.Time = newTime;
                return true;
            }

            return false;
        }


        public bool CancelAppointment(Appointment appointment, List<Appointment> appointments)
        {
            DateTime appointmentDateTime = DateTime.Parse($"{appointment.Date} {appointment.Time}");
            if (appointmentDateTime >= DateTime.Now)
            {
                
                return appointments.Remove(appointment);
            }
            else
            {
                return false;
            }
        }
    }
}
