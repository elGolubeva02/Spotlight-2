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
    public partial class Form3_2 : Form
    {
        Query controller;
        public Form3_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool z31;
            if ((gunaTextBox5.Text == "b") && (gunaTextBox4.Text == "5") &&
               (gunaTextBox3.Text == "a") && (gunaTextBox6.Text == "3") &&
               (gunaTextBox8.Text == "e") && (gunaTextBox2.Text == "2") &&
               (gunaTextBox7.Text == "d") && (gunaTextBox1.Text == "1") &&
               (gunaTextBox12.Text == "c") && (gunaTextBox10.Text == "4"))
                z31 = true;
            else z31 = false ;
            controller.Modul1(CheckIn.KodY,Form2_2.z11, Form2_2.z21, z31);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }
    }
}
