using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicWFA
{
    public class Clinic
    {
        public List<Service> Services { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<User> Users { get; set; }

        public Clinic()
        {
            Services = new List<Service>();
            Appointments = new List<Appointment>();
            Users = new List<User>();
        }

        public void AddService(Service service)
        {
            // Реалізація додавання послуги до клініки
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            // Реалізація додавання користувача до клініки
            throw new NotImplementedException();
        }

        public void PrintServices(List<Service> services)
        {
            // Реалізація виведення послуг клініки
            throw new NotImplementedException();
        }
    }

    // Абстрактний клас User
    public abstract class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }

    // Клас Service
    public class Service
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    // Інтерфейс для зареєстрованих користувачів
    public interface IRegisteredUser
    {
        string ViewAppointments(List<Appointment> appointments);
        bool BookAppointment(string category, string description, DateTime appointmentDate, TimeSpan appointmentTime, List<Appointment> existingAppointments);
        bool RescheduleAppointment(Appointment appointment, DateTime newDate, TimeSpan newTime, List<Appointment> appointments);
        bool CancelAppointment(Appointment appointment, List<Appointment> appointments);
    }

    // Клас RegisteredUser
    public class RegisteredUser : User, IRegisteredUser
    {
        public string ViewAppointments(List<Appointment> appointments)
        {
            // Реалізація відображення записів на прийом для зареєстрованого користувача
            throw new NotImplementedException();
        }

        public bool BookAppointment(string category, string description, DateTime appointmentDate, TimeSpan appointmentTime, List<Appointment> existingAppointments)
        {
            // Реалізація бронювання прийому для зареєстрованого користувача
            throw new NotImplementedException();
        }

        public bool RescheduleAppointment(Appointment appointment, DateTime newDate, TimeSpan newTime, List<Appointment> appointments)
        {
            // Реалізація перенесення прийому для зареєстрованого користувача
            throw new NotImplementedException();
        }

        public bool CancelAppointment(Appointment appointment, List<Appointment> appointments)
        {
            // Реалізація скасування прийому для зареєстрованого користувача
            throw new NotImplementedException();
        }
    }

    // Клас Appointment
    public class Appointment
    {
        public DateTime Date { get; set; }
        public Service Service { get; set; }
        public RegisteredUser User { get; set; }
    }

   
    
    // Клас Guest
    public class Guest
    {
        public void PrintServices(List<Service> services)
        {
            // Реалізація виведення послуг для гостя
            throw new NotImplementedException();
        }

        public bool Register(string name, string password, string phoneNumber)
        {
            // Реалізація реєстрації нового користувача (гостя)
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(string name, string password)
        {
            // Реалізація аутентифікації користувача (гостя)
            throw new NotImplementedException();
        }
    }

    // Клас Administrator
    public class Administrator : User
    {
        public bool AddService(string name, string description, int id, decimal price)
        {
            // Реалізація додавання нової послуги адміністратором
            throw new NotImplementedException();
        }

        public bool EditService(string name, string description, int id, decimal price)
        {
            // Реалізація редагування послуги адміністратором
            throw new NotImplementedException();
        }

        public bool DeleteService(int id)
        {
            // Реалізація видалення послуги адміністратором
            throw new NotImplementedException();
        }

        public bool AddAppointment(string userName, string serviceName, string serviceDescription, DateTime date, TimeSpan time)
        {
            // Реалізація додавання нового запису на прийом адміністратором
            throw new NotImplementedException();
        }

        public bool DeleteAppointment(string userName, string serviceName, string serviceDescription, DateTime date, TimeSpan time)
        {
            // Реалізація видалення запису на прийом адміністратором
            throw new NotImplementedException();
        }
    }
}
