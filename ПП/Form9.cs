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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            gunaMediumCheckBox2.Checked = true;
            gunaMediumCheckBox2.Enabled = false;
            gunaMediumCheckBox1.Checked = false;
            gunaMediumCheckBox1.Enabled = false;
        }

        private void gunaMediumCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((gunaMediumCheckBox5.Checked == true) && (gunaMediumCheckBox6.Checked == false) &&
                (gunaMediumCheckBox9.Checked == true) && (gunaMediumCheckBox10.Checked == false) &&
                (gunaMediumCheckBox4.Checked == true) && (gunaMediumCheckBox3.Checked == false) 
                )
            { gunaLabel11.Text = "You are right!"; gunaLabel18.Text = "The eng of Module4"; }
            else gunaLabel11.Text = "You are not right!";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
