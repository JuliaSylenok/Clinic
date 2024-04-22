using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

using WindowsFormsApp2.Classes;
using System.Text.Json.Serialization;
using System.Xml;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Home : UserControl
    {
        Clinic clinic = Clinic.Instance;

        public UC_Home()
        {
            InitializeComponent();

            dataGridViewServices.Rows.Clear();
            
            LoadServices();
        }
       


        private void LoadServices()
        {
            
            
            string servicesInfo = clinic.PrintServices();
            string[] rows = servicesInfo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            dataGridViewServices.Columns.Clear(); 

            dataGridViewServices.Columns.Add("Name", "Назва");
            dataGridViewServices.Columns.Add("Description", "Опис");
            dataGridViewServices.Columns.Add("Price", "Ціна");

            foreach (var row in rows)
            {
                string[] data = row.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                dataGridViewServices.Rows.Add(data); 
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
