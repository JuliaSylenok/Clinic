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
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_MyReception : UserControl
    {
        Clinic clinic = Clinic.Instance;
        
        public UC_MyReception()
        {
            InitializeComponent();
            // Додайте обробник події Load для UserControl
            this.Load += UC_MyReception_Load;
            
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

       
        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm(); // Знаходимо батьківську форму
            parentForm.Close();
            Form_MakeAppointment formMakeAppointment = new Form_MakeAppointment();
            formMakeAppointment.ShowDialog();
            
        }

        private void btnEditAppiontment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (Form_EditingAppointment fw = new Form_EditingAppointment())
            //{
            //    fw.ShowDialog();

            //}
            Form parentForm = this.FindForm(); // Знаходимо батьківську форму
            parentForm.Close();
            Form_EditingAppointment formEditingAppointment = new Form_EditingAppointment();
            formEditingAppointment.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
