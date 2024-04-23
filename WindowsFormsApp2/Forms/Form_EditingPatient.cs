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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2.Forms
{
    public partial class Form_EditingPatient : Form
    {
        public Form_EditingPatient()
        {
            InitializeComponent();
            PopulateDataGridView();
            PopulateComboBoxes();


        }


        private void PopulateComboBoxes()
        {
            // Заповнення комбобокса comboBox_Category
            List<string> categories = Clinic.Instance.Services
                .Select(service => service.Name)
                .Distinct()
                .ToList();
            comboBox_Category.DataSource = categories;

            // Подія вибору категорії
            comboBox_Category.SelectedIndexChanged += (sender, e) =>
            {
                // Отримання вибраної категорії
                string selectedCategory = comboBox_Category.SelectedItem.ToString();

                // Фільтрація послуг за обраною категорією
                List<string> services = Clinic.Instance.Services
                    .Where(service => service.Name == selectedCategory)
                    .Select(service => service.Description)
                    .ToList();

                // Заповнення комбобокса comboBox_Service знайденими послугами
                comboBox_Service.DataSource = services;
            };

            // Заповнення комбобокса comboBox_Time
            // Цей код припускає, що у вас є список часів, які ви хочете відобразити у комбобоксі
            List<string> times = new List<string> { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };
            comboBox_Time.DataSource = times;
        }

        private void PopulateDataGridView()
        {
            
            
            dgvAppointmentsOfPatients.Rows.Clear();

            dgvAppointmentsOfPatients.Columns.Add("Name", "ПІБ пацієнта");
            dgvAppointmentsOfPatients.Columns.Add("PhoneNumber", "Номер телефону пацієнта");
            dgvAppointmentsOfPatients.Columns.Add("Category", "Категорія запису");
            dgvAppointmentsOfPatients.Columns.Add("Description", "Опис послуги");
            dgvAppointmentsOfPatients.Columns.Add("Date", "Дата запису");
            dgvAppointmentsOfPatients.Columns.Add("Time", "Час запису");

            //dgvAppointmentsOfPatients.Columns.Add("Price", "Ціна послуги");
            ShowInfo();
            
        }

        private void ShowInfo()
        {
            dgvAppointmentsOfPatients.Rows.Clear();

            List<Appointment> appointments;

            if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
            {
                appointments = Clinic.RemainingAppointments;
            }
            else
            {
                appointments = Clinic.Instance.Appointments;
            }
            foreach (var appointment in appointments)
            {
                string[] rowData = {
                    appointment.User.Name,
                    appointment.User.PhoneNumber,
                    appointment.Service.Name,
                    appointment.Service.Description,
                    appointment.Date,
                    appointment.Time
                    //appointment.Service.Price.ToString()
                };
                dgvAppointmentsOfPatients.Rows.Add(rowData);
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_DeleteAppointment_Click(object sender, EventArgs e)
        {
            
            if (dgvAppointmentsOfPatients.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dgvAppointmentsOfPatients.SelectedRows[0];

                
                string userName = selectedRow.Cells["Name"].Value.ToString();
                string date = selectedRow.Cells["Date"].Value.ToString();
                string time = selectedRow.Cells["Time"].Value.ToString();

                
                try
                {
                    Administrator admin = new Administrator("Admin", "admin", "0000000000"); // Потрібно вказати дані адміністратора
                    bool success = admin.DeleteAppointment(date, time);

                    if (success)
                    {
                        
                        string deletedAppointmentInfo = $"Видалено запис: {userName}, {date}, {time}\n";

                        
                        StringBuilder remainingAppointmentsInfo = new StringBuilder("Залишені записи:\n");
                        Clinic.RemainingAppointments = Clinic.Instance.Appointments; 
                        foreach (var appointment in Clinic.RemainingAppointments)
                        {
                            remainingAppointmentsInfo.AppendLine($"{appointment.User.Name}, {appointment.Date}, {appointment.Time}");
                        }

                        
                        MessageBox.Show($"Запис про прийом успішно видалено.\n\n{deletedAppointmentInfo}\n{remainingAppointmentsInfo}");

                        ShowInfo(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Оберіть запис про прийом для видалення.");
            }
        }

        private void btn_AddPatientWithAppointment_Click(object sender, EventArgs e)
        {
            // Отримання введених даних з елементів керування
            string userName = textBox_Name.Text;
            string category = comboBox_Category.SelectedItem.ToString();
            string description = comboBox_Service.SelectedItem.ToString();
            string time = comboBox_Time.SelectedItem.ToString();
            string date = dateTimePicker_Date.Value.ToString("yyyy-MM-dd");

            // Перевірка на введення усіх необхідних даних
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Будь ласка, введіть всі необхідні дані.");
                return;
            }

            try
            {
                Administrator admin = new Administrator("Admin", "admin", "0000000000"); // Потрібно вказати дані адміністратора
                bool success = admin.AddAppointment(userName, category, date, time);

                if (success)
                {
                    MessageBox.Show($"Призначення успішно додано для користувача {userName}.");
                    ShowInfo(); // Оновлення DataGridView після додавання запису
                }
                else
                {
                    MessageBox.Show("Помилка при додаванні призначення.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
