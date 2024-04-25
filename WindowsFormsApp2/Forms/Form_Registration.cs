using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string password = tbPassword.Text;
            string phoneNumber = tbPhone.Text;
            if (name1.Length < 1 || name1.Length > 20)
            {
                MessageBox.Show("Прізвище не може бути менше 1 символу або більше 20 символів!");
                tbName.Text = "Введіть";
                return;
            }
            if (name2.Length < 1 || name2.Length > 20)
            {
                MessageBox.Show("Ім’я не може бути менше 1 символу або більше 20 символів!");
                tbPatronymic.Text = "Введіть ";
                return;
            }
            if (name3.Length < 1 || name3.Length > 20)
            {
                MessageBox.Show("По батькові не може бути менше 1 символу або більше 20 символів!");
                tbSurname.Text = "Введіть ";
                return;
            }
            if (name1 == "Введіть" || name2 == "Введіть" || name3 == "Введіть" || password == "Введіть" || phoneNumber == "+38(0ХХ)-ХХХХХХХ")
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[0-9])(?=.*[a-zA-Z]).{6,}$"))
            {
                MessageBox.Show("Пароль має містити цифри та латинські літери!");
                tbPassword.Text = "Введіть";
                return;
            }
            string name = name1 + "_" + name2 +"_"+ name3;
            

            // Викликати метод Register
            try
            {
                Guest guest = new Guest();
                guest.Register(name, password, phoneNumber);
                MessageBox.Show("Реєстрація пройшла успішно!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Реєстрація не пройшла успішно! {ex.Message}");
                if (ex.Message == "Пароль не може бути менше 6 символів або більше 20 символів.") tbPassword.Text = "Введіть";
                if (ex.Message == "Номера телефону не існує.") tbPhone.Text = "+38(0ХХ)-ХХХХХХХ";
                return;
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

        private void tbName_Click(object sender, EventArgs e)
        {
            tbName.Text = null;
        }

        private void tbPatronymic_Click(object sender, EventArgs e)
        {
            tbPatronymic.Text = null;
        }

        private void tbSurname_Click(object sender, EventArgs e)
        {
            tbSurname.Text = null;
        }

        private void tbPhone_Click(object sender, EventArgs e)
        {
            tbPhone.Text = null;
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = null;
        }
    }
}
