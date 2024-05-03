using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classes;
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2.Forms
{
    public partial class Form_MakeAppointment : Form
    {
        //Ініціалізація
        public Form_MakeAppointment()
        {
            InitializeComponent();
            FillComboBoxes();
            dateTimePicker_Date.Text = null;
        }

        //Заповнення полів даними 
        private void FillComboBoxes()
        {
            List<string> categories = Clinic.Instance.Services
                .Select(service => service.Name)
                .Distinct()
                .ToList();
            comboBox_Category.DataSource = categories;
            comboBox_Category.Text = null;
            comboBox_Category.SelectedIndexChanged += (sender, e) =>
            {
                string selectedCategory = comboBox_Category.SelectedItem.ToString();

                List<Service> filteredServices = Clinic.Instance.Services
                    .Where(service => service.Name == selectedCategory)
                    .ToList();
                List<string> bookedDescriptions = Clinic.Instance.Appointments
                    .Where(appointment => appointment.User.Name == Clinic.NameNow)
                    .Select(appointment => appointment.Service.Description)
                    .ToList();
                List<string> servicesWithPrice = filteredServices
                    .Where(service => !bookedDescriptions.Contains(service.Description))
                    .Select(service => $"{service.Description}, {service.Price} грн")
                    .ToList();
                comboBox_Service.DataSource = servicesWithPrice;

            };
            List<string> times = new List<string> { "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };
            comboBox_Time.DataSource = times;
        }

        //Закриття форми
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (FormMain fw = new FormMain())
            {

                fw.DisableButtonForRegisteredUser();
                fw.ShowDialog();
            }
        }

        //Реалізує метод BookAppointment класу RegisteredUser - запис на прийом
        private void btn_Appoinment_Click(object sender, EventArgs e)
        {
            string category = comboBox_Category.Text;
            string description = comboBox_Service.Text;
            string appointmentDate = dateTimePicker_Date.Value.ToShortDateString();
            string appointmentTime = comboBox_Time.Text;
            RegisteredUser currentUser = new RegisteredUser(Clinic.NameNow, Clinic.Password, Clinic.PhoneNumber);
            List<Appointment> appointments;
            if (dateTimePicker_Date.Value < DateTime.Today)
            {
                MessageBox.Show("Запис не пройшов успішно! Обрана дата вже минула.");
                dateTimePicker_Date.Text = null;
                return;
            }
            DateTime selectedDateTime = dateTimePicker_Date.Value.Date.Add(TimeSpan.Parse(appointmentTime));
            if (selectedDateTime < DateTime.Now)
            {
                MessageBox.Show("Запис на прийом не пройшов успішно! Обраний час вже минув.");
                return;
            }
            if (description.Length <2)
            {
                MessageBox.Show("Запис на прийом не пройшов! Заповіть всі поля!");
                return;
            }
            if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
            {
                appointments = Clinic.RemainingAppointments;
            }
            else
            {
                appointments = Clinic.Instance.Appointments;
            }

            bool success = currentUser.BookAppointment(category, description, appointmentDate, appointmentTime, appointments);

            if (success)
            {
                MessageBox.Show("Успішний запис на прийом.");
                this.Hide();
                using (FormMain fw = new FormMain()) 
                {
                    fw.DisableButtonForRegisteredUser();
                    fw.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Запис на прийом не пройшов успішно! Оберіть іншу дату або час.");
            }
        }

        
    }
}
