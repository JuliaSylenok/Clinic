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
    public partial class Form_EditingServices : Form
    {
        public Form_EditingServices()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            
            dataGridView_Services.Rows.Clear();

            dataGridView_Services.Columns.Add("Category", "Категорія");
            dataGridView_Services.Columns.Add("Description", "Опис послуги");
            dataGridView_Services.Columns.Add("Price", "Ціна");

            foreach (var service in Clinic.Instance.Services)
            {
                string[] rowData = {
                    service.Name,
                    service.Description,
                    service.Price.ToString()
                };
                dataGridView_Services.Rows.Add(rowData);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
