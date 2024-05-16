using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    public class ClinicUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public ClinicUser(string name, string password, string phoneNumber)
        {
            Name = name;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
