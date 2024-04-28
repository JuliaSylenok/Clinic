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
        //Ініціалізація
        public Form_Login()
        {
            InitializeComponent();
        }

        //Закриття форми
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Реалізує метод AuthenticateUser класу Gueat - вхід користувача в систему
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            try
            {
                Guest guest = new Guest();
                string result = guest.AuthenticateUser(name, password);
                switch (result)
                {
                    case "admin":
                        MessageBox.Show("Ви успішно увійшли як адміністратор.");
                        this.Hide();
                        using (FormMain fw = new FormMain()) 
                        {
                            fw.DisableButtonForAdmin();
                            fw.ShowDialog();
                        }
                        break;
                    case "registered":
                        MessageBox.Show("Ви успішно увійшли як зареєстрований користувач.");

                        this.Hide();
                        using (FormMain fw = new FormMain()) 
                        {

                            fw.DisableButtonForRegisteredUser();
                            fw.ShowDialog();
                        }
                        break;
                    case "not registered":
                        MessageBox.Show("Користувача з таким логіном та паролем не знайдено.");
                        textBoxLogin.Text = "ПІБ";
                        textBoxPassword.Text = "Введіть пароль";
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

        //Очищення полів
        private void textBoxLogin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = null;
        }
        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = null;
        }

        
    }
}
