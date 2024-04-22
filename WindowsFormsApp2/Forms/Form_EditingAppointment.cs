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

namespace WindowsFormsApp2.Forms
{
    public partial class Form_EditingAppointment : Form
    {
        private int selectedRowIndex = -1;

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
        public Form_EditingAppointment()
        {
            InitializeComponent();
            this.Load += UC_MyReception_Load;
            dgwMyAppointments.CellContentClick += dgwMyAppointments_CellContentClick;
            comboBox_Time.Items.AddRange(timesByHour.Keys.ToArray());
        }
        private void UC_MyReception_Load(object sender, EventArgs e)
        {
            dgwMyAppointments.Refresh();
            // Отримуємо ім'я поточного користувача зі статичних полів класу Clinic
            string userName = Clinic.NameNow;

            // Отримуємо список записів на прийоми для поточного користувача
            List<Appointment> userAppointments;

            if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
            {
                userAppointments = Clinic.RemainingAppointments;
            }
            else
            {
                userAppointments = Clinic.Instance.GetUserAppointments(userName);
            }

            // Очищаємо DataGridView
            dgwMyAppointments.Rows.Clear();

            dgwMyAppointments.Columns.Add("Data", "Дата");
            dgwMyAppointments.Columns.Add("Time", "Час");
            dgwMyAppointments.Columns.Add("Name", "Назва");
            dgwMyAppointments.Columns.Add("Description", "Опис");

            // Додаємо записи на прийоми у DataGridView
            foreach (Appointment appointment in userAppointments)
            {
                dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            using (Form1 fw = new Form1()) // інша форма, на якій є кнопка button1
            {

                fw.DisableButtonForRegisteredUser();
                fw.ShowDialog();
            }

        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            // Перевірка, чи користувач обрав рядок
            if (selectedRowIndex >= 0)
            {
                // Отримання імені поточного користувача зі статичних полів класу Clinic
                string userName = Clinic.NameNow;

                // Отримання списку записів на прийоми для поточного користувача
                List<Appointment> userAppointments = Clinic.Instance.GetUserAppointments(userName);

                // Отримання обраного запису
                Appointment selectedAppointment = userAppointments[selectedRowIndex];
                // Створення екземпляру класу RegisteredUser
                RegisteredUser user = new RegisteredUser(userName, Clinic.Password, Clinic.PhoneNumber);

                // Виклик методу видалення запису на прийом
                bool result = user.CancelAppointment(selectedAppointment, userAppointments);

                // Перевірка результату видалення та оновлення DataGridView
                if (result)
                {
                    userAppointments.Remove(selectedAppointment);
                    // Видалення запису з DataGridView
                    dgwMyAppointments.Rows.RemoveAt(selectedRowIndex);

                    // Оновлення залишених записів
                    Clinic.RemainingAppointments = userAppointments;

                    // Очищення DataGridView
                    dgwMyAppointments.Rows.Clear();

                    // Додавання залишених записів у DataGridView
                    foreach (Appointment appointment in userAppointments)
                    {
                        dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
                    }
                    
                    // Формування рядка з інформацією про скасований запис
                    string cancelledAppointmentInfo = $"Запис на прийом {selectedAppointment.Service.Name} на {selectedAppointment.Date} о {selectedAppointment.Time} скасовано успішно.";

                    // Формування рядка з інформацією про залишені записи після скасування
                    StringBuilder remainingAppointmentsInfo = new StringBuilder();
                    remainingAppointmentsInfo.AppendLine("Записи на прийом, які залишилися:");

                    foreach (var appointment in Clinic.RemainingAppointments)
                    {
                        remainingAppointmentsInfo.AppendLine($"Дата: {appointment.Date}, Послуга: {appointment.Service.Name}, Час: {appointment.Time}");

                    }

                    // Виведення інформації у MessageBox
                    MessageBox.Show($"{cancelledAppointmentInfo}\n\n{remainingAppointmentsInfo}");
                }
                else
                {
                    MessageBox.Show("Не вдалося скасувати запис на прийом.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть запис на прийом для скасування.");
            }
        }


        private void dgwMyAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            MessageBox.Show("e =", selectedRowIndex.ToString());

        }

        

        private void btnRescheduleAppointment_Click(object sender, EventArgs e)
        {
            // Перевірка, чи обрано запис на прийом
            if (selectedRowIndex >= 0)
            {
                // Отримання обраного запису з DataGridView
                DataGridViewRow selectedRow = dgwMyAppointments.Rows[selectedRowIndex];
                string selectedDate = selectedRow.Cells["Data"].Value.ToString();
                string selectedTime = selectedRow.Cells["Time"].Value.ToString();

                // Отримання нової дати з dateTimePickerData
                string newDate = dateTimePickerData.Value.ToString("yyyy-MM-dd");

                // Отримання нового часу з comboBox_Time
                string newTime = comboBox_Time.SelectedItem.ToString();

                // Перевірка, чи обрані дата та час
                if (!string.IsNullOrEmpty(newDate) && !string.IsNullOrEmpty(newTime))
                {
                    try
                    {
                        // Створення екземпляру класу RegisteredUser
                        RegisteredUser user = new RegisteredUser(Clinic.NameNow, Clinic.Password, Clinic.PhoneNumber);

                        // Отримання списку всіх записів на прийом для поточного користувача
                        List<Appointment> userAppointments;

                        if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
                        {
                            userAppointments = Clinic.RemainingAppointments;
                        }
                        else
                        {
                            userAppointments = Clinic.Instance.GetUserAppointments(Clinic.NameNow);
                        }

                        // Отримання обраного запису
                        Appointment selectedAppointment = userAppointments[selectedRowIndex];

                        // Виклик методу для перенесення запису на нову дату та час
                        bool result = user.RescheduleAppointment(selectedAppointment, newDate, newTime, userAppointments);

                        // Перевірка результату перенесення запису
                        if (result)
                        {
                            // Оновлення залишених записів
                            Clinic.RemainingAppointments = userAppointments;

                            // Очищення DataGridView
                            dgwMyAppointments.Rows.Clear();

                            // Додавання залишених записів у DataGridView
                            foreach (Appointment appointment in userAppointments)
                            {
                                dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
                            }

                            // Виведення повідомлення про успішне перенесення запису
                            MessageBox.Show($"Запис на прийом перенесено на {newDate} о {newTime}.");
                        }
                        else
                        {
                            // Виведення повідомлення про невдале перенесення запису
                            MessageBox.Show("Не вдалося перенести запис на прийом.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Виведення повідомлення про помилку
                        MessageBox.Show($"Сталася помилка: {ex.Message}");
                    }
                }
                else
                {
                    // Виведення повідомлення про обрання дати та часу
                    MessageBox.Show("Будь ласка, оберіть дату та час для перенесення запису.");
                }
            }
            else
            {
                // Виведення повідомлення про відсутність обраного запису
                MessageBox.Show("Будь ласка, виберіть запис на прийом для перенесення.");
            }
        }
    }

}
