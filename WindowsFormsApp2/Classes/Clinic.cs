using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    public class Clinic
    {
        private static Clinic instance;

        public static string NameNow;
        public static string Password;
        public static string PhoneNumber;

        public static Clinic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Clinic();
                }
                return instance;
            }
        }
        public List<Service> Services { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<User> Users { get; set; }


        public static List<Appointment> RemainingAppointments { get; set; }

        public Clinic()
        {
            Services = new List<Service>();
            Appointments = new List<Appointment>();
            Users = new List<User>();
        }

        public void AddService(Service service)
        {
            Services.Add(service);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public string PrintServices()
        {
            StringBuilder servicesInfo = new StringBuilder();

            foreach (var service in Services)
            {
                servicesInfo.AppendLine($"{service.Name},{service.Description},{service.Price}");
            }

            return servicesInfo.ToString();
        }
        public List<Appointment> GetUserAppointments(string userName)
        {
            return Appointments.Where(appointment => appointment.User.Name == userName).ToList();
        }

        public void DefaultService()
        {
            Clinic clinic = Clinic.Instance;

            clinic.AddService(new Service { Name = "Стоматологія", Description = "Пломбування", Price = 150 });
            clinic.AddService(new Service { Name = "Стоматологія", Description = "Професійне чищення", Price = 250 });
            clinic.AddService(new Service { Name = "Стоматологія", Description = "Видалення зуба", Price = 1500 });
            clinic.AddService(new Service { Name = "Стоматологія", Description = "Ендодонтичне лікування", Price = 2000 });
            clinic.AddService(new Service { Name = "Стоматологія", Description = "Імплантація", Price = 3000 });

            clinic.AddService(new Service { Name = "Терапія", Description = "Прийом лікаря-терапевта", Price = 200 });
            clinic.AddService(new Service { Name = "Терапія", Description = "УЗД", Price = 300 });
            clinic.AddService(new Service { Name = "Терапія", Description = "ЕКГ", Price = 100 });
            clinic.AddService(new Service { Name = "Терапія", Description = "Консультація кардіолога", Price = 250 });
            clinic.AddService(new Service { Name = "Терапія", Description = "Аналіз крові", Price = 50 });

            clinic.AddService(new Service { Name = "Офтальмологія", Description = "Прийом офтальмолога", Price = 300 });
            clinic.AddService(new Service { Name = "Офтальмологія", Description = "Огляд зору", Price = 150 });
            clinic.AddService(new Service { Name = "Офтальмологія", Description = "Діагностика захворювань очей", Price = 400 });
            clinic.AddService(new Service { Name = "Офтальмологія", Description = "Рецепт окулярів", Price = 50 });
            clinic.AddService(new Service { Name = "Офтальмологія", Description = "Лікування захворювань очей", Price = 1000 });

            clinic.AddService(new Service { Name = "Дерматологія", Description = "Прийом дерматолога", Price = 250 });
            clinic.AddService(new Service { Name = "Дерматологія", Description = "Лазерне видалення пігментних плям", Price = 500 });
            clinic.AddService(new Service { Name = "Дерматологія", Description = "Лікування акне", Price = 300 });
            clinic.AddService(new Service { Name = "Дерматологія", Description = "Косметологічні процедури", Price = 400 });
            clinic.AddService(new Service { Name = "Дерматологія", Description = "Діагностика шкіри", Price = 200 });

            clinic.AddService(new Service { Name = "Педіатрія", Description = "Прийом педіатра", Price = 150 });
            clinic.AddService(new Service { Name = "Педіатрія", Description = "Вакцинація", Price = 200 });
            clinic.AddService(new Service { Name = "Педіатрія", Description = "Діагностика захворювань дитячого віку", Price = 300 });
            clinic.AddService(new Service { Name = "Педіатрія", Description = "Лікування ГРВІ", Price = 100 });
            clinic.AddService(new Service { Name = "Педіатрія", Description = "Консультація щодо годування", Price = 100 });



        }
    }
}
