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
    public partial class Mark2 : Form
    {
        public Mark2()
        {
            InitializeComponent();
            if (Form5_2.kol2 == 3)
            {
                gunaPictureBox1.Visible = true;
                gunaPictureBox2.Visible = false;
                gunaPictureBox3.Visible = false;
                gunaLabel1.Text = "Escellent";
            }
            else if (Form5_2.kol2 == 2)
            {
                gunaPictureBox1.Visible = false;
                gunaPictureBox2.Visible = false;
                gunaPictureBox3.Visible = true;
                gunaLabel1.Text = "Very Good";
            }
            else if (Form5_2.kol2 == 1 || Form5_2.kol2 == 0)
            {
                gunaPictureBox1.Visible = false;
                gunaPictureBox2.Visible = true;
                gunaPictureBox3.Visible = false;
                gunaLabel1.Text = "Good";
            }
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }
    }
}
