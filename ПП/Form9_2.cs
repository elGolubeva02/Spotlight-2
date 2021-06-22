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
        public static bool z34; 
        public static int kol4 = 0;
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
            if ((gunaMediumCheckBox5.Checked == true) && (gunaMediumCheckBox6.Checked == false) &&
               (gunaMediumCheckBox9.Checked == true) && (gunaMediumCheckBox10.Checked == false) &&
               (gunaMediumCheckBox4.Checked == true) && (gunaMediumCheckBox3.Checked == false)
               )
                z34 = true;
            else z34 = false;
            controller.Modul4(CheckIn.KodY, Form8_2.z14, Form8_2.z24, z34);
            if (Form8_2.z14 == true) kol4 = kol4 + 1;
            if (Form8_2.z24 == true) kol4 = kol4 + 1;
            if (z34 == true) kol4 = kol4 + 1;
            Mark4 m4 = new Mark4();
            this.Hide();
            m4.Show();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
