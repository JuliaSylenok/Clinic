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

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Editing : UserControl
    {
        //Ініціалізація
        public UC_Editing()
        {
            InitializeComponent();
        }
        //Перехід на форму Form_EditingPatient
        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            using (Form_EditingPatient fw = new Form_EditingPatient())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }
        
        //Закриття програми
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Перехід на форму Form_EditingServices
        private void btnService_Click(object sender, EventArgs e)
        {
            using (Form_EditingServices fw = new Form_EditingServices())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
