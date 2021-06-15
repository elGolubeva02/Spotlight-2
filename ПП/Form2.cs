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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "kitchen") && (gunaTextBox2.Text == "bedroom")) gunaLabel7.Text = "You are right!";
            else gunaLabel7.Text = "You are not right!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox3.Text == "c") && (gunaTextBox4.Text == "b") && (gunaTextBox5.Text == "d") && (gunaTextBox6.Text == "a")) gunaLabel18.Text = "You are right!";
            else gunaLabel18.Text = "You are not right!";

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
