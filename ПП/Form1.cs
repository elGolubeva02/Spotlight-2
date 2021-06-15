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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked)
            {
                Form10 f10 = new Form10();
                this.Hide();
                f10.Show();
            }
        }
    }
}
