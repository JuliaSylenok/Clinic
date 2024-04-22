using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classes
{
    // Клас Appointment
    public class Appointment
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public Service Service { get; set; }
        public RegisteredUser User { get; set; }
    }
}
