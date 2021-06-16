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
    public partial class Form4_2 : Form
    {
        public Form4_2()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            bool z12, z22;
            if ((gunaTextBox5.Text == "1") && (gunaTextBox3.Text == "2") &&
               (gunaTextBox4.Text == "3") && (gunaTextBox7.Text == "4") &&
               (gunaTextBox6.Text == "5") && (gunaTextBox12.Text == "6") &&
               (gunaTextBox11.Text == "7") && (gunaTextBox10.Text == "8") &&
               (gunaTextBox9.Text == "9") && (gunaTextBox8.Text == "10")
               ) z12 = true;
            else z12 = false;
            if ((gunaTextBox1.Text == "Ice cream") && (gunaTextBox2.Text == "Pizza")) z22 = true;
            else z22 = false;
            Form5_2 f5_2 = new Form5_2();
            this.Hide();
            f5_2.Show();
        }
    }
}
