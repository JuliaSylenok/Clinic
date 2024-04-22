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
            
        }
        private void PopulateDataGridView()
        {
            
            // Отримати список всіх записів пацієнтів
           // List<Appointment> appointments = Clinic.Instance.Appointments;

            // Очистити DataGridView перед заповненням
            dgvAppointmentsOfPatients.Rows.Clear();

            // Додати стовпці у DataGridView
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
            // Заповнити DataGridView інформацією про записи пацієнтів
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
            // Перевірка, чи користувач обрав рядок для видалення
            if (dgvAppointmentsOfPatients.SelectedRows.Count > 0)
            {
                // Отримання обраного рядка
                DataGridViewRow selectedRow = dgvAppointmentsOfPatients.SelectedRows[0];

                // Отримання значень з обраного рядка
                string userName = selectedRow.Cells["Name"].Value.ToString();
                string date = selectedRow.Cells["Date"].Value.ToString();
                string time = selectedRow.Cells["Time"].Value.ToString();

                // Видалення запису про прийом за обраними датою та часом
                try
                {
                    Administrator admin = new Administrator("Admin", "admin", "0000000000"); // Потрібно вказати дані адміністратора
                    bool success = admin.DeleteAppointment(date, time);

                    if (success)
                    {
                        // Отримання інформації про видалений запис
                        string deletedAppointmentInfo = $"Видалено запис: {userName}, {date}, {time}\n";

                        // Отримання інформації про залишені записи
                        StringBuilder remainingAppointmentsInfo = new StringBuilder("Залишені записи:\n");
                        Clinic.RemainingAppointments = Clinic.Instance.Appointments; // Присвоєння значення Clinic.RemainingAppointments
                        foreach (var appointment in Clinic.RemainingAppointments)
                        {
                            remainingAppointmentsInfo.AppendLine($"{appointment.User.Name}, {appointment.Date}, {appointment.Time}");
                        }

                        // Виведення повідомлення у MessageBox
                        MessageBox.Show($"Запис про прийом успішно видалено.\n\n{deletedAppointmentInfo}\n{remainingAppointmentsInfo}");

                        ShowInfo(); // Оновлення DataGridView після видалення запису
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

    }
}
