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
        public UC_Editing()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            using (Form_EditingServices fw = new Form_EditingServices())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            using (Form_EditingPatient fw = new Form_EditingPatient())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
