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
            if (name.Length < 1 || name.Length > 50)
            {
                throw new ArgumentException("Name must be between 1 and 50 characters long. {name.Length}");
            }

            if (password.Length < 1 || password.Length > 20)
            {
                throw new ArgumentException("Password must be between 1 and 20 characters long and contain only alphanumeric characters.");
            }
            if (phoneNumber.Length != 10 || phoneNumber[0] != '0')
            {
                throw new ArgumentException("Phone number must be 10 characters long and start with '0'.");
            }
            if (!phoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Phone number must contain only digits.");
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

            // Завантаження користувачів з файлу
            var users = LoadUsers(@"C:\VARIANT 19\2 course\Curse\WindowsFormsApp2\WindowsFormsApp2\users.txt");

            // Перевірка наявності користувача в списку
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


//public bool Register(string name, string password, string phoneNumber)
//{
//    if (name.Length < 1 || name.Length > 20)
//    {
//        throw new ArgumentException("Назва має містити від 1 до 20 символів.");
//    }

//    if (password.Length < 1 || password.Length > 20)
//    {
//        throw new ArgumentException("Пароль має містити від 1 до 20 символів і містити лише буквено-цифрові символи.");
//    }

//    if (phoneNumber.Length != 10 || phoneNumber[0] != '0')
//    {
//        throw new ArgumentException("Номер телефону має містити 10 символів і починатися з «0».");
//    }

//    if (!phoneNumber.All(char.IsDigit))
//    {
//        throw new ArgumentException("Номер телефону має містити лише цифри.");
//    }
//    RegisteredUser newUser = new RegisteredUser(name, password, phoneNumber);
//    Clinic.Instance.AddUser(newUser);

//    SerializeUsers("users.json", Clinic.Instance.Users);

//    return true; 
//}

//private string SerializeUsers(string filePath, List<User> users)
//{
//    try
//    {
//        string jsonData = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

//        File.WriteAllText(filePath, jsonData);

//        return "Users serialized successfully.";
//    }
//    catch (Exception ex)
//    {
//        return $"Під час серіалізації сталася помилка: {ex.Message}";
//    }
//}

//public string AuthenticateUser(string name, string password)
//{
//    var adminUsers = LoadAdminUsers();
//    foreach (var adminUser in adminUsers)
//    {
//        if (adminUser.Name == name && adminUser.Password == password)
//        {
//            return "admin";
//        }
//    }

//    foreach (var user in Clinic.Instance.Users)
//    {
//        if (user is RegisteredUser registeredUser && registeredUser.Name == name && registeredUser.Password == password)
//        {
//            return "registered";
//        }
//    }
//    return "not registered";
//}