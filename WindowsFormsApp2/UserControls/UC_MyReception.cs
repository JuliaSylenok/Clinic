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
        
        //Ініціалізація компонента
        public UC_MyReception()
        {
            InitializeComponent();
            this.Load += UC_MyReception_Load;
            
        }

        //Заповнення DataGridView при ініціалізаціїї компонента
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

        //Перехід на форму Form_MakeAppointment
        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm(); 
            parentForm.Close();
            Form_MakeAppointment formMakeAppointment = new Form_MakeAppointment();
            formMakeAppointment.ShowDialog();
            
        }
        
        //Перехід на форму Form_EditingAppointment
        private void btnEditAppiontment_Click(object sender, EventArgs e)
        {
            
            Form parentForm = this.FindForm(); 
            parentForm.Close();
            Form_EditingAppointment formEditingAppointment = new Form_EditingAppointment();
            formEditingAppointment.ShowDialog();
        }
        
        //Закриття програми
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
