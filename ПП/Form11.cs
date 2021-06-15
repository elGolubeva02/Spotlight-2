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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            gunaTextBox5.Enabled = false;
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "8") && (gunaTextBox2.Text == "1") &&
                (gunaTextBox6.Text == "3") && (gunaTextBox4.Text == "5") &&
                (gunaTextBox3.Text == "7") && (gunaTextBox9.Text == "4") &&
                (gunaTextBox8.Text == "6") && (gunaTextBox7.Text == "2"))
            { gunaLabel7.Text = "You are right!"; gunaLabel23.Text = "The eng of Module5"; }
            else gunaLabel7.Text = "You are not right!";
        }
    }
}
