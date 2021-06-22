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
        Query controller;
        public Form9_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            gunaMediumCheckBox2.Checked = true;
            gunaMediumCheckBox2.Enabled = false;
            gunaMediumCheckBox1.Checked = false;
            gunaMediumCheckBox1.Enabled = false;
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
            controller.Modul4(CheckIn.KodY, Form8_2.z14, Form8_2.z24, z34);
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }
    }
}
