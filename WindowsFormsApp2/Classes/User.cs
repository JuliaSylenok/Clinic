using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    // Абстрактний клас User
    public abstract class User
    {
        private string name;
        private string password;
        private string phoneNumber;
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 6 || value.Length > 20
                    ||!value.Any(char.IsDigit) || !value.Any(char.IsLetter)
                    )
                {
                    throw new ArgumentException("Пароль має містити цифри, латинські літери та бути від 6 до 20 символів!");
                }
                password = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length != 10 || !value.All(char.IsDigit) || value[0] != '0')
                {
                    throw new ArgumentException("Номера телефону не існує.");
                }
                phoneNumber = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string name, string password, string phoneNumber)
        {
            Name = name;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
