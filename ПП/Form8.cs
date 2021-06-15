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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            gunaTextBox3.Text = "e";
            gunaTextBox3.Enabled = false;
            gunaTextBox4.Text = "d";
            gunaTextBox4.Enabled = false;
            gunaTextBox7.Text = "e";
            gunaTextBox7.Enabled = false;
            gunaTextBox9.Text = "r";
            gunaTextBox9.Enabled = false;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "on") && (gunaTextBox2.Text == "under") 
               ) gunaLabel11.Text = "You are right!";
            else gunaLabel11.Text = "You are not right!";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox6.Text == "a") && (gunaTextBox5.Text == "l") &&
                (gunaTextBox8.Text == "e") && (gunaTextBox10.Text == "r") &&
                (gunaTextBox11.Text == "n") && (gunaTextBox16.Text == "u") &&
                (gunaTextBox15.Text == "p") && (gunaTextBox14.Text == "e") &&
                (gunaTextBox17.Text == "a") && (gunaTextBox13.Text == "b") &&
                (gunaTextBox12.Text == "o")
                ) gunaLabel30.Text = "You are right!";
            else gunaLabel30.Text = "You are not right!";
        }

        private void gunaTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }
    }
}
