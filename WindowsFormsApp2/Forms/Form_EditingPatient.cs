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
            List<Appointment> appointments = Clinic.Instance.Appointments;

            // Очистити DataGridView перед заповненням
            dgvAppointmentsOfPatients.Rows.Clear();

            // Додати стовпці у DataGridView
            dgvAppointmentsOfPatients.Columns.Add("Name", "ПІБ пацієнта");
            dgvAppointmentsOfPatients.Columns.Add("PhoneNumber", "Номер телефону пацієнта");
            dgvAppointmentsOfPatients.Columns.Add("Category", "Категорія запису");
            dgvAppointmentsOfPatients.Columns.Add("Description", "Опис послуги");
            dgvAppointmentsOfPatients.Columns.Add("Price", "Ціна послуги");

            // Заповнити DataGridView інформацією про записи пацієнтів
            foreach (var appointment in appointments)
            {
                string[] rowData = {
                    appointment.User.Name,
                    appointment.User.PhoneNumber,
                    appointment.Service.Name,
                    appointment.Service.Description,
                    appointment.Service.Price.ToString()
                };
                dgvAppointmentsOfPatients.Rows.Add(rowData);
            }
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
