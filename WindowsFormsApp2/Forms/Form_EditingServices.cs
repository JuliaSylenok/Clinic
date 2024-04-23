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

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
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

        private void btnEditingService_Click(object sender, EventArgs e)
        {
            if (dataGridView_Services.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Services.SelectedRows[0];
                int serviceIndex = selectedRow.Index;

                // Зчитання нових значень з текстових полів
                string newName = tb_EditingCategory.Text;
                string newDescription = tb_EditingDescription.Text;
                decimal newPrice = Convert.ToDecimal(tb_EditingPrice.Text);

                try
                {
                    Administrator admin = new Administrator("Admin", "admin", "0000000000");
                    bool success = admin.EditService(serviceIndex, newName, newDescription, newPrice);

                    if (success)
                    {
                        MessageBox.Show("Послугу успішно відредаговано.");
                        dataGridView_Services.Rows.Clear();
                        InitializeDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Оберіть послугу для редагування.");
            }
        }

        private void dataGridView_Services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Services.Rows[e.RowIndex];

                tb_EditingCategory.Text = row.Cells["Category"].Value.ToString();
                tb_EditingDescription.Text = row.Cells["Description"].Value.ToString();
                tb_EditingPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }


    }
}
