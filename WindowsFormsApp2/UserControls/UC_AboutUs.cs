using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_AboutUs : UserControl
    {
        //Ініціалізація
        public UC_AboutUs()
        {
            InitializeComponent();
        }
        //Закриття програми
        private void button_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
