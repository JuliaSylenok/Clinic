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
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            try
            {
                Guest guest = new Guest();
                string result = guest.AuthenticateUser(name, password);

                // Обробка результату аутентифікації
                switch (result)
                {
                    case "admin":
                        MessageBox.Show("Ви успішно увійшли як адміністратор.");
                        this.Hide();
                        using (Form1 fw = new Form1()) // інша форма, на якій є кнопка button1
                        {
                            //Clinic.NameNow = name;
                            fw.DisableButtonForAdmin();
                            fw.ShowDialog();
                            //потрібно зробити кновпку button1 недоступною для натискання
                        }
                        break;
                    case "registered":
                        MessageBox.Show("Ви успішно увійшли як зареєстрований користувач.");

                        this.Hide();
                        using (Form1 fw = new Form1()) // інша форма, на якій є кнопка button1
                        {

                            fw.DisableButtonForRegisteredUser();
                            fw.ShowDialog();
                            //потрібно зробити кновпку button1 недоступною для натискання
                        }
                        break;
                    case "not registered":
                        MessageBox.Show("Користувача з таким логіном та паролем не знайдено.");
                        break;
                    default:
                        MessageBox.Show("Невідома помилка під час аутентифікації.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        
        }
    }
}
