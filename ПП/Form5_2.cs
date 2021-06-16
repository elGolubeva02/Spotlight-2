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
    public partial class Form5_2 : Form
    {
        public Form5_2()
        {
            InitializeComponent();
        }

        private void Form5_2_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool z32;
            if ((gunaMediumCheckBox3.Checked == false) && (gunaMediumCheckBox4.Checked == true)
                &&
                (gunaMediumCheckBox5.Checked == false) && (gunaMediumCheckBox6.Checked == false))
                z32 = true;
            else z32 = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
