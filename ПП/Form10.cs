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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            gunaTextBox4.Enabled = false;
            gunaTextBox5.Enabled = false;
            gunaTextBox6.Enabled = false;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "hot") && (gunaTextBox2.Text == "windy") && (gunaTextBox2.Text == "cold")) gunaLabel7.Text = "You are right!";
            else gunaLabel7.Text = "You are not right!";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            this.Hide();
            f11.Show();
        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox16.Text == "i") && (gunaTextBox15.Text == "n") && (gunaTextBox14.Text == "r") &&
                (gunaTextBox7.Text == "u") && (gunaTextBox9.Text == "e") && (gunaTextBox8.Text == "r") &&
                (gunaTextBox11.Text == "p") && (gunaTextBox10.Text == "r"))
                gunaLabel13.Text = "You are right!";
            else gunaLabel13.Text = "You are not right!";
        }
    }
}
