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
    public partial class Form11_2 : Form
    {
        public Form11_2()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           bool z35;
            if ((gunaTextBox1.Text == "8") && (gunaTextBox2.Text == "1") &&
               (gunaTextBox6.Text == "3") && (gunaTextBox4.Text == "5") &&
               (gunaTextBox3.Text == "7") && (gunaTextBox9.Text == "4") &&
               (gunaTextBox8.Text == "6") && (gunaTextBox7.Text == "2"))
                z35 = true;
            else z35 = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
