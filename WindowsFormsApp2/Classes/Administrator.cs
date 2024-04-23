using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    // Клас Administrator
    public class Administrator : User
    {
        public Administrator(string name, string password, string phoneNumber) : base(name, password, phoneNumber)
        {
        }

        public bool AddService(string name, string description, decimal price)
        {
            bool serviceExists = Clinic.Instance.Services.Any(s =>
                s.Name == name &&
                s.Description == description &&
                s.Price == price);

            if (serviceExists)
            {
                throw new Exception("Послуга з такими параметрами вже існує.");
            }
            var service = new Service
            {
                Name = name,
                Description = description,
                Price = price
            };

            Clinic.Instance.Services.Add(service);
            return true;
        }

        public bool EditService(int serviceIndex, string newName, string newDescription, decimal newPrice)
        {
            // Перевірка чи є записи на прийом для цієї послуги
            bool appointmentsExist = Clinic.Instance.Appointments.Any(a => a.Service.Description == Clinic.Instance.Services[serviceIndex].Description);

            if (appointmentsExist)
            {
                throw new Exception("Неможливо редагувати послугу, на яку є записи на прийом.");
            }

            // Редагування обраної послуги
            if (serviceIndex >= 0 && serviceIndex < Clinic.Instance.Services.Count)
            {
                var service = Clinic.Instance.Services[serviceIndex];
                service.Name = newName;
                service.Description = newDescription;
                service.Price = newPrice;
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool DeleteService(int serviceIndex)
        {
            // Перевірка чи є записи на прийом для цієї послуги
            bool appointmentsExist = Clinic.Instance.Appointments.Any(a => a.Service.Name == Clinic.Instance.Services[serviceIndex].Name);

            if (appointmentsExist)
            {
                throw new Exception("Неможливо видалити послугу, на яку є записи на прийом.");
            }

            if (serviceIndex >= 0 && serviceIndex < Clinic.Instance.Services.Count)
            {
                Clinic.Instance.Services.RemoveAt(serviceIndex);
                return true; 
            }
            else
            {
                return false;
            }
        }

        //public bool AddAppointment(string userName, string serviceName, string date, string time)
        //{
        //    // Перевірка, чи час вже заброньований
        //    if (Clinic.Instance.Appointments.Any(appointment => appointment.Date == date && appointment.Time == time))
        //    {
        //        throw new InvalidOperationException("Неможливо додати запис, час вже заброньовано!");
        //    }

        //    // Створення нового запису на прийом та додавання його до списку
        //    var service = Clinic.Instance.Services.FirstOrDefault(s => s.Name == serviceName);
        //    var user = Clinic.Instance.Users.FirstOrDefault(u => u.Name == userName);

        //    if (service != null && user != null)
        //    {
        //        var appointment = new Appointment
        //        {
        //            Date = date,
        //            Time = time,
        //            Service = service,
        //            User = user as RegisteredUser
        //        };

        //        Clinic.Instance.Appointments.Add(appointment);
        //        return true;
        //    }
        //    else
        //    {
        //        return false; 
        //    }
        //}
        public bool AddAppointment(string userName, string serviceName, string date, string time)
        {
            // Перевірка, чи час вже заброньований
            if (Clinic.RemainingAppointments.Any(appointment => appointment.Date == date && appointment.Time == time))
            {
                throw new InvalidOperationException("Неможливо додати запис, час вже заброньовано!");
            }

            // Знаходження користувача з ім'ям userName у залишених записах
            var user = Clinic.RemainingAppointments.FirstOrDefault(appointment => appointment.User.Name == userName)?.User;

            if (user != null)
            {
                // Створення нового запису на прийом та додавання його до списку
                var appointment = new Appointment
                {
                    Date = date,
                    Time = time,
                    Service = Clinic.Instance.Services.First(s => s.Name == serviceName),
                    User = user
                };

                Clinic.RemainingAppointments.Add(appointment);
                return true;
            }
            else
            {
                throw new Exception($"Користувач з ім'ям {userName} не знайдений.");
            }
        }


        public bool DeleteAppointment(string date, string time)
        {
            // Перевірка, чи дата не минула
            if (DateTime.Parse(date) < DateTime.Today)
            {
                throw new InvalidOperationException("Не вдалося додати зустріч. Вибрана дата вже минула.");
            }
            // Видалення запису на прийом за вказаною датою та часом
            var appointmentToRemove = Clinic.Instance.Appointments.FirstOrDefault(a => a.Date == date && a.Time == time);

            if (appointmentToRemove != null)
            {
                Clinic.Instance.Appointments.Remove(appointmentToRemove);
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
