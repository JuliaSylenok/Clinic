using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2
{
        public partial class FormMain : Form
    {
        //Ініціалізація елементів форми
        public FormMain()
        {
            InitializeComponent();
            UC_Home uh = new UC_Home();
            addControls(uh);
            btnMyReception.Visible = false;
            btnEditing.Visible = false;
        }

        //Додає UserControls до панелі panelConteiner
        private void addControls(UserControl uc)
        {
            panelConteiner.Controls.Clear();
            uc.Dock= DockStyle.Fill;
            panelConteiner.Controls.Add(uc);
            uc.BringToFront();
        }
        
        //Поява Usercontrol - UC_Home на панелі panelConteiner
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uh = new UC_Home();
            addControls(uh);
        }
        
        //Поява Usercontrol - UC_About на панелі panelConteiner
        private void btnAbout_Click(object sender, EventArgs e)
        {
            UC_AboutUs ua = new UC_AboutUs();
            addControls(ua);
        }
        
        //Поява Usercontrol - UC_MyReception на панелі panelConteiner
        private void btnMyReception_Click(object sender, EventArgs e)
        {
            UC_MyReception ur = new UC_MyReception();
            addControls(ur);
        }
        
        //Поява Usercontrol - UC_Editing на панелі panelConteiner
        private void btnEditing_Click(object sender, EventArgs e)
        {
            UC_Editing ue = new UC_Editing();
            addControls(ue);
        }
        
        //Перехід на форму Form_Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Увійти")
            {
                //this.Hide();
                using (Form_Login fw = new Form_Login())
                {
                    fw.ShowDialog();
                }
            }
            else 
            {
                
                FormMain fm1= new FormMain();
                fm1.btnLogin.Text = "Увійти";
                fm1.btnRegistration.Visible = true;
                fm1.btnHome.Visible = true;
                fm1.btnAbout.Visible = true;
                fm1.btnMyReception.Visible = false;
                fm1.btnEditing.Visible = false;
                fm1.ShowDialog();
                
            }

            
            
        }
        
        //Перехід на форму Form_Registration
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            using (Form_Registration fw = new Form_Registration())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }
        
        //Обмежує показ елементів керування для зареєстрованого користувача
        public void DisableButtonForRegisteredUser()
        {
            btnLogin.Visible = false;
            btnRegistration.Visible = false;
            btnEditing.Visible = false;
            btnLogin.Text = "Вихід";
            btnLogin.Visible = true;
            btnMyReception.Visible = true;
        }

        //Обмежує показ елементів керування для адміністратора
        public void DisableButtonForAdmin ()
        {
            btnEditing.Visible = true;
            btnAbout.Visible = false;
            btnMyReception.Visible = false;
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnHome.Visible = true;
        }


    }
}
