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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "Ice cream") && (gunaTextBox2.Text == "Pizza")) gunaLabel7.Text = "You are right!";
            else gunaLabel7.Text = "You are not right!";
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox5.Text == "1") && (gunaTextBox3.Text == "2") &&
                (gunaTextBox4.Text == "3") && (gunaTextBox7.Text == "4") &&
                (gunaTextBox6.Text == "5") && (gunaTextBox12.Text == "6") &&
                (gunaTextBox11.Text == "7") && (gunaTextBox10.Text == "8") &&
                (gunaTextBox9.Text == "9") && (gunaTextBox8.Text == "10")
                ) gunaLabel18.Text = "You are right!";
            else gunaLabel18.Text = "You are not right!";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
