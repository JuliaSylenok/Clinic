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
        private RegisteredUser currentUser;
        // Оголошуємо дані для комбо-боксів
        private Dictionary<string, List<string>> servicesByCategory = new Dictionary<string, List<string>>
        {
            { "Стоматологія", new List<string> { "Пломбування, 150 грн", "Професійне чищення, 250 грн", "Видалення зуба, 1500 грн", "Ендодонтичне лікування, 2000 грн", "Імплантація, 3000 грн" } },
            { "Терапія", new List<string> { "Прийом лікаря-терапевта, 200 грн", "УЗД, 300 грн", "ЕКГ, 100 грн", "Консультація кардіолога, 250 грн", "Аналіз крові, 50 грн" } },
            { "Офтальмологія", new List<string> { "Прийом офтальмолога, 300 грн", "Огляд зору, 150 грн", "Діагностика захворювань очей, 400 грн", "Рецепт окулярів, 50 грн", "Лікування захворювань очей, 1000 грн" } },
            { "Дерматологія", new List<string> { "Прийом дерматолога, 250 грн", "Лазерне видалення пігментних плям, 500 грн", "Лікування акне, 300 грн", "Косметологічні процедури, 400 грн", "Діагностика шкіри, 200 грн" } },
            { "Педіатрія", new List<string> { "Прийом педіатра, 150 грн", "Вакцинація, 200 грн", "Діагностика захворювань дитячого віку, 300 грн", "Лікування ГРВІ, 100 грн", "Консультація щодо годування, 100 грн" } }
        };

        private Dictionary<string, List<string>> timesByHour = new Dictionary<string, List<string>>
        {
            { "08:00", new List<string> { "00", "15", "30", "45" } },
            { "09:00", new List<string> { "00", "15", "30", "45" } },
            { "10:00", new List<string> { "00", "15", "30", "45" } },
            { "11:00", new List<string> { "00", "15", "30", "45" } },
            { "12:00", new List<string> { "00", "15", "30", "45" } },
            { "13:00", new List<string> { "00", "15", "30", "45" } },
            { "14:00", new List<string> { "00", "15", "30", "45" } },
            { "15:00", new List<string> { "00", "15", "30", "45" } },
            { "16:00", new List<string> { "00", "15", "30", "45" } },
            { "17:00", new List<string> { "00", "15", "30", "45" } }
        };

        public Form_MakeAppointment()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            // Заповнюємо комбо-бокс категорій
            comboBox_Category.Items.AddRange(servicesByCategory.Keys.ToArray());

            // Обробник події при зміні вибору категорії
            comboBox_Category.SelectedIndexChanged += (sender, e) =>
            {
                string selectedCategory = comboBox_Category.SelectedItem.ToString();
                // Заповнюємо комбо-бокс послуг відповідно до вибраної категорії
                comboBox_Service.Items.Clear();
                comboBox_Service.Items.AddRange(servicesByCategory[selectedCategory].ToArray());
            };

            // Заповнюємо комбо-бокс з часами
            comboBox_Time.Items.AddRange(timesByHour.Keys.ToArray());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Appoinment_Click(object sender, EventArgs e)
        {
            // Отримайте дані з комбо-боксів і dateTimePicker
            string category = comboBox_Category.Text;
            string description = comboBox_Service.Text;
            string appointmentDate = dateTimePicker_Date.Value.ToShortDateString();
            string appointmentTime = comboBox_Time.Text;
            RegisteredUser currentUser = new RegisteredUser(Clinic.NameNow, Clinic.Password, Clinic.PhoneNumber);

            // Вибір списку записів на прийоми залежно від наявності залишених записів
            List<Appointment> appointments;
            if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
            {
                appointments = Clinic.RemainingAppointments;
            }
            else
            {
                appointments = Clinic.Instance.Appointments;
            }

            // Виклик методу BookAppointment поточного користувача
            bool success = currentUser.BookAppointment(category, description, appointmentDate, appointmentTime, appointments);

            if (success)
            {
                MessageBox.Show("Appointment booked successfully.");
                this.Hide();
                using (Form1 fw = new Form1()) // інша форма, на якій є кнопка button1
                {
                    fw.DisableButtonForRegisteredUser();
                    fw.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Appointment booking failed. Please choose a different date or time.");
            }
        }


        
    }
}
