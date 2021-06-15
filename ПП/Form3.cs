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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox5.Text == "b") && (gunaTextBox4.Text == "5") &&
                (gunaTextBox3.Text == "a") && (gunaTextBox6.Text == "3") &&
                (gunaTextBox8.Text == "e") && (gunaTextBox2.Text == "2") &&
                (gunaTextBox7.Text == "d") && (gunaTextBox1.Text == "1") &&
                (gunaTextBox12.Text == "c") && (gunaTextBox10.Text == "4"))
            { gunaLabel7.Text = "You are right!"; gunaLabel23.Text = "The eng of Module1"; }
            else gunaLabel7.Text = "You are not right!";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
