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
    public partial class Form7_2 : Form
    {
        Query controller;
        public static bool z23, z33;
        public static int kol3 = 0;
        public Form7_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "Yes, I can") && (gunaTextBox2.Text == "No, I can't") &&
               ((gunaTextBox3.Text == "Yes, I can") || (gunaTextBox3.Text == "No, I can't")) &&
               (gunaTextBox4.Text == "Yes, I can"))
                z23 = true;
            else z23 = false;
            if ((gunaTextBox5.Text == "yes") && (gunaTextBox5.Text == "yes")
               &&
               (gunaTextBox5.Text == "yes"))
                z33 = true;
            else z33 = false;
            controller.Modul3(CheckIn.KodY, Form6_2.z13, z23, z33);
            if (Form6_2.z13 == true) kol3 = kol3 + 1;
            if (z23 == true) kol3 = kol3 + 1;
            if (z33 == true) kol3 = kol3 + 1;
            Mark3 m3 = new Mark3();
            this.Hide();
            m3.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
