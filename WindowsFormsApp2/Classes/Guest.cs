using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    // Клас Guest
    public class Guest
    {
        public string PrintServices()
        {
            StringBuilder servicesInfo = new StringBuilder();
            foreach (var service in Clinic.Instance.Services)
            {
                servicesInfo.AppendLine($"Назва: {service.Name}, Опис: {service.Description}, Ціна: {service.Price}");
            }

            return servicesInfo.ToString();
        }

        public bool Register(string name, string password, string phoneNumber)
        {
            
            if (password.Length < 6 || password.Length > 20)
            {
                throw new ArgumentException("Пароль не може бути менше 6 символів або більше 20 символів.");
            }
            if (phoneNumber.Length != 10 || phoneNumber[0] != '0')
            {
                throw new ArgumentException("Номера телефону не існує.");
            }
            string userData = $"{name},{password},{phoneNumber}";
            AppendToFile(@"C:\VARIANT 19\2 course\Curse\WindowsFormsApp2\WindowsFormsApp2\users.txt", userData);
            return true;
        }

        private void AppendToFile(string filePath, string data)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(data);
            }
        }

        private List<string> LoadUsers(string filePath)
        {
            List<string> users = new List<string>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        users.Add(line);
                    }
                }
            }
            return users;
        }

        

        public string AuthenticateUser(string name, string password)
        {
            var adminUsers = LoadAdminUsers();
            foreach (var adminUser in adminUsers)
            {
                if (adminUser.Name == name && adminUser.Password == password)
                {
                    return "admin";
                }
            }

            var users = LoadUsers(@"C:\VARIANT 19\2 course\Curse\WindowsFormsApp2\WindowsFormsApp2\users.txt");

            foreach (var userData in users)
            {
                string[] userParts = userData.Split(',');
                string userName = userParts[0].Replace("_", " ");
                string userPassword = userParts[1];
                string userPhone = userParts[2];
                if (userName == name && userPassword == password)
                {
                    Clinic.NameNow = userName;
                    Clinic.Password = userPassword;
                    Clinic.PhoneNumber = userPhone;
                    return "registered";
                }
            }
            return "not registered";
        }


        private List<ClinicUser> LoadAdminUsers()
        {
            string jsonFilePath = @"C:\VARIANT 19\2 course\Curse\WindowsFormsApp2\WindowsFormsApp2\AdminUser.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonSerializer.Deserialize<List<ClinicUser>>(jsonData);
            }
            else
            {
                return new List<ClinicUser>();
            }
        }

    }
}

