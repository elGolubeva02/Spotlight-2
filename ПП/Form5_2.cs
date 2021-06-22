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
    public partial class Form5_2 : Form
    {
        Query controller;
        public static bool z32;
        public static int kol2 = -1;
        public Form5_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            gunaMediumCheckBox1.Checked = true;
            gunaMediumCheckBox1.Enabled = false;
            gunaMediumCheckBox2.Checked = false;
            gunaMediumCheckBox2.Enabled = false;
        }

        private void Form5_2_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaMediumCheckBox3.Checked == false) && (gunaMediumCheckBox4.Checked == true)
                &&
                (gunaMediumCheckBox5.Checked == false) && (gunaMediumCheckBox6.Checked == false))
                z32 = true;
            else z32 = false;
            controller.Modul2(CheckIn.KodY, Form4_2.z12, Form4_2.z22, z32);
            if (Form4_2.z12 == true) kol2 = kol2 + 1;
            if (Form4_2.z22 == true) kol2 = kol2 + 1;
            if (z32 == true) kol2 = kol2 + 1;
            kol2 = kol2 + 1;
            Mark2 m2 = new Mark2();
            this.Hide();
            m2.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
