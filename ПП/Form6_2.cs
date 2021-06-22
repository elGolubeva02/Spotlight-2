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
    public partial class Form6_2 : Form
    {
        public static bool z13;
        Query controller;
        public Form6_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            gunaMediumCheckBox2.Checked = true;
            gunaMediumCheckBox2.Enabled = false;
            gunaMediumCheckBox1.Checked = false;
            gunaMediumCheckBox1.Enabled = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if ((gunaMediumCheckBox3.Checked == true) && (gunaMediumCheckBox4.Checked == true)
               &&
               (gunaMediumCheckBox5.Checked == true) && (gunaMediumCheckBox6.Checked == false)
               &&
               (gunaMediumCheckBox8.Checked == false) && (gunaMediumCheckBox7.Checked == false))
                z13 = true;
            else z13 = false;
            Form7_2 f7_2 = new Form7_2();
            this.Hide();
            f7_2.Show();
        }
    }
}
