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
        public Form3_2()
        {
            InitializeComponent();
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
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
