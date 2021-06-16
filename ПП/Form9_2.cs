using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПП
{
    public partial class Form9_2 : Form
    {
        public Form9_2()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            bool z34;
            if ((gunaMediumCheckBox5.Checked == true) && (gunaMediumCheckBox6.Checked == false) &&
               (gunaMediumCheckBox9.Checked == true) && (gunaMediumCheckBox10.Checked == false) &&
               (gunaMediumCheckBox4.Checked == true) && (gunaMediumCheckBox3.Checked == false)
               )
                z34 = true;
            else z34 = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
