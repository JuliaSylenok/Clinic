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
    public partial class Form_Registration : Form
    {
        public Form_Registration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // Отримати дані з текстових полів форми
            string name1 = tbSurname.Text;
            string name2 = tbName.Text;
            string name3 = tbPatronymic.Text;
            string name = name1 + "_" + name2 +"_"+ name3;
            string password = tbPassword.Text;
            string phoneNumber = tbPhone.Text;

            // Викликати метод Register
            try
            {
                Guest guest = new Guest();
                guest.Register(name, password, phoneNumber);
                MessageBox.Show("Registration successful.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}");
            }
            // Зберігаємо ім'я користувача у статичних полях класу Clinic
            Clinic.NameNow = name.Replace("_", " "); ;
            Clinic.Password = password;
            Clinic.PhoneNumber = phoneNumber;

            ClearTextBoxes();
            this.Hide();
            using (Form1 fw = new Form1()) // інша форма, на якій є кнопка button1
            {

                fw.DisableButtonForRegisteredUser();
                fw.ShowDialog();
                //потрібно зробити кновпку button1 недоступною для натискання
            }
            
        }

        private void ClearTextBoxes()
        {
            tbSurname.Text = "";
            tbName.Text = "";
            tbPatronymic.Text = "";
            tbPassword.Text = "";
            tbPhone.Text = "";
        }
    }
}
