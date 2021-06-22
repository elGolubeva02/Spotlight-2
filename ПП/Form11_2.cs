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
    public partial class Form11_2 : Form
    {
        Query controller;
        static public bool z35;
        static public int kol5 = -1;
        public Form11_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "8") && (gunaTextBox2.Text == "1") &&
               (gunaTextBox6.Text == "3") && (gunaTextBox4.Text == "5") &&
               (gunaTextBox3.Text == "7") && (gunaTextBox9.Text == "4") &&
               (gunaTextBox8.Text == "6") && (gunaTextBox7.Text == "2"))
                z35 = true;
            else z35 = false;
            controller.Modul5(CheckIn.KodY, Form10_2.z15, Form10_2.z25, z35);
            if (Form10_2.z15 == true) kol5 = kol5 + 1;
            if (Form10_2.z25 == true) kol5 = kol5 + 1;
            if (z35 == true) kol5 = kol5 + 1;
            kol5 = kol5 + 1;
            Mark5 m5 = new Mark5();
            this.Hide();
            m5.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
