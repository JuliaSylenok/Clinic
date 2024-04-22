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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addControls(UserControl uc)
        {
            panelConteiner.Controls.Clear();
            uc.Dock= DockStyle.Fill;
            panelConteiner.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uh = new UC_Home();
            addControls(uh);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UC_AboutUs ua = new UC_AboutUs();
            addControls(ua);
        }

        private void btnMyReception_Click(object sender, EventArgs e)
        {
            UC_MyReception ur = new UC_MyReception();
            addControls(ur);
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            UC_Editing ue = new UC_Editing();
            addControls(ue);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Увійти")
            {
                this.Hide();
                using (Form_Login fw = new Form_Login())
                {
                    fw.ShowDialog();
                    //this.Close();
                }
            }
            else 
            {
                
                Form1 fm1= new Form1();
                fm1.btnLogin.Text = "Увійти";
                fm1.btnRegistration.Visible = true;
                fm1.btnHome.Visible = true;
                fm1.btnAbout.Visible = true;
                fm1.btnMyReception.Visible = false;
                fm1.btnEditing.Visible = false;
                fm1.ShowDialog();
                
            }

            
            
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            using (Form_Registration fw = new Form_Registration())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }
        public void DisableButtonForRegisteredUser()
        {
            btnLogin.Visible = false;
            btnRegistration.Visible = false;
            btnEditing.Visible = false;
            btnLogin.Text = "Вихід";
            btnLogin.Visible = true;
        }

        public void DisableButtonForAdmin ()
        {
            btnAbout.Visible = false;
            btnMyReception.Visible = false;
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnHome.Visible = false;
        }


    }
}
