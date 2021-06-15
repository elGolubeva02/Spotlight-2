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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            gunaMediumCheckBox2.Checked = true;
            gunaMediumCheckBox2.Enabled = false;
            gunaMediumCheckBox1.Checked = false;
            gunaMediumCheckBox1.Enabled = false;
        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((gunaMediumCheckBox3.Checked == true) && (gunaMediumCheckBox4.Checked == true)
               &&
               (gunaMediumCheckBox5.Checked ==true) && (gunaMediumCheckBox6.Checked == false)
               &&
               (gunaMediumCheckBox8.Checked == false) && (gunaMediumCheckBox7.Checked == false))
             gunaLabel7.Text = "You are right!" ;
            else gunaLabel7.Text = "You are not right!";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }
    }
}
