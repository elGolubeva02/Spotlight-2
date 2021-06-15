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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "Yes, I can") && (gunaTextBox2.Text == "No, I can't") &&
                ((gunaTextBox3.Text == "Yes, I can") || (gunaTextBox3.Text == "No, I can't")) &&
                (gunaTextBox4.Text == "Yes, I can") )
            gunaLabel11.Text = "You are right!"; 
            else gunaLabel11.Text = "You are not right!";
        }

        private void gunaLabel31_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox5.Text == "yes") && (gunaTextBox5.Text == "yes")
                &&
                (gunaTextBox5.Text == "yes"))
            { gunaLabel30.Text = "You are right!"; gunaLabel7.Text = "The eng of Module3"; }
            else gunaLabel30.Text = "You are not right!";
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
