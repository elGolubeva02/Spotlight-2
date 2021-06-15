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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            gunaMediumCheckBox1.Checked = true;
            gunaMediumCheckBox1.Enabled = false;
            gunaMediumCheckBox2.Checked = false;
            gunaMediumCheckBox2.Enabled = false;
        }

        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaMediumCheckBox3.Checked == false ) && (gunaMediumCheckBox4.Checked == true)
                &&
                (gunaMediumCheckBox5.Checked == false) && (gunaMediumCheckBox6.Checked == false))
            { gunaLabel7.Text = "You are right!"; gunaLabel15.Text = "The eng of Module2"; }
            else gunaLabel7.Text = "You are not right!";
        }
    }
}
