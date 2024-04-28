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
        
        //Ініціалізація
        public Form_EditingAppointment()
        {
            InitializeComponent();
            this.Load += UC_MyReception_Load;
            //dgwMyAppointments.CellContentClick += dgwMyAppointments_CellContentClick;
            comboBox_Time.Items.AddRange(timesByHour.Keys.ToArray());
        }
        
        //Заповлення DаtaGridView при ініціалізаціїї форми
        private void UC_MyReception_Load(object sender, EventArgs e)
        {
            dgwMyAppointments.Refresh();
            string userName = Clinic.NameNow;

            List<Appointment> userAppointments;

            if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
            {
                userAppointments = Clinic.RemainingAppointments;
            }
            else
            {
                userAppointments = Clinic.Instance.GetUserAppointments(userName);
            }

            dgwMyAppointments.Rows.Clear();

            dgwMyAppointments.Columns.Add("Data", "Дата");
            dgwMyAppointments.Columns.Add("Time", "Час");
            dgwMyAppointments.Columns.Add("Name", "Назва");
            dgwMyAppointments.Columns.Add("Description", "Опис");

            foreach (Appointment appointment in userAppointments)
            {
                dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
            }
        }

        //Закриття програми
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            using (FormMain fw = new FormMain()) 
            {

                fw.DisableButtonForRegisteredUser();
                fw.ShowDialog();
            }

        }
        //Реалізація видалення запису користувача
        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                string userName = Clinic.NameNow;
                List<Appointment> userAppointments = Clinic.Instance.GetUserAppointments(userName);
                Appointment selectedAppointment = userAppointments[selectedRowIndex];
                RegisteredUser user = new RegisteredUser(userName, Clinic.Password, Clinic.PhoneNumber);
                bool result = user.CancelAppointment(selectedAppointment, userAppointments);
                if (result)
                {
                    userAppointments.Remove(selectedAppointment);
                    dgwMyAppointments.Rows.RemoveAt(selectedRowIndex);
                    Clinic.RemainingAppointments = userAppointments;
                    dgwMyAppointments.Rows.Clear();
                    foreach (Appointment appointment in userAppointments)
                    {
                        dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
                    }
                    
                    string cancelledAppointmentInfo = $"Запис на прийом {selectedAppointment.Service.Name} на {selectedAppointment.Date} о {selectedAppointment.Time} скасовано успішно.";

                    //// Формування рядка з інформацією про залишені записи після скасування
                    //StringBuilder remainingAppointmentsInfo = new StringBuilder();
                    //remainingAppointmentsInfo.AppendLine("Записи на прийом, які залишилися:");

                    //foreach (var appointment in Clinic.RemainingAppointments)
                    //{
                    //    remainingAppointmentsInfo.AppendLine($"Дата: {appointment.Date}, Послуга: {appointment.Service.Name}, Час: {appointment.Time}");

                    //}

                    // Виведення інформації у MessageBox
                    //MessageBox.Show($"{cancelledAppointmentInfo}\n\n{remainingAppointmentsInfo}");
                    MessageBox.Show($"{cancelledAppointmentInfo}");

                    Clinic.Instance.Appointments = Clinic.RemainingAppointments;
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

        //Подія обранння поля в таблиці
        private void dgwMyAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            MessageBox.Show($"Обрано рядок: {selectedRowIndex+1}");

        }
        
        //Реалізація перенесення запису користувача на іншу дату та/або час
        private void btnRescheduleAppointment_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgwMyAppointments.Rows[selectedRowIndex];
                string selectedDate = selectedRow.Cells["Data"].Value.ToString();
                string selectedTime = selectedRow.Cells["Time"].Value.ToString();

                string newDate = dateTimePickerData.Value.ToString("dd.MM.yyyy");
                string newTime = comboBox_Time.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(newDate) && !string.IsNullOrEmpty(newTime))
                {
                    try
                    {
                        RegisteredUser user = new RegisteredUser(Clinic.NameNow, Clinic.Password, Clinic.PhoneNumber);
                        List<Appointment> userAppointments;

                        if (Clinic.RemainingAppointments != null && Clinic.RemainingAppointments.Any())
                        {
                            userAppointments = Clinic.RemainingAppointments;
                        }
                        else
                        {
                            userAppointments = Clinic.Instance.GetUserAppointments(Clinic.NameNow);
                        }
                        if (userAppointments.Any(appointment => appointment.Date == newDate && appointment.Time == newTime))
                        {
                            MessageBox.Show($"Час {newTime} вже заброньований на обрану дату {newDate}.");
                            return; 
                        }
                        Appointment selectedAppointment = userAppointments[selectedRowIndex];
                        bool result = user.RescheduleAppointment(selectedAppointment, newDate, newTime, userAppointments);

                        if (result)
                        {
                            Clinic.RemainingAppointments = userAppointments;
                            dgwMyAppointments.Rows.Clear();
                            foreach (Appointment appointment in userAppointments)
                            {
                                dgwMyAppointments.Rows.Add(appointment.Date, appointment.Time, appointment.Service.Name, appointment.Service.Description);
                            }
                            MessageBox.Show($"Запис на прийом перенесено на {newDate} о {newTime}.");
                           
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося перенести запис на прийом.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Будь ласка, оберіть дату та час для перенесення запису.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть запис на прийом для перенесення.");
            }
        }

       
    }

}
