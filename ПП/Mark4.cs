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
    public partial class Mark4 : Form
    {
        public Mark4()
        {
            InitializeComponent();
            if (Form9_2.kol4 == 3)
            {
                gunaPictureBox1.Visible = true;
                gunaPictureBox2.Visible = false;
                gunaPictureBox3.Visible = false;
                gunaLabel1.Text = "Escellent";
            }
            else if (Form9_2.kol4 == 2)
            {
                gunaPictureBox1.Visible = false;
                gunaPictureBox2.Visible = false;
                gunaPictureBox3.Visible = true;
                gunaLabel1.Text = "Very Good";
            }
            else if (Form9_2.kol4 == 1 || Form9_2.kol4 == 0)
            {
                gunaPictureBox1.Visible = false;
                gunaPictureBox2.Visible = true;
                gunaPictureBox3.Visible = false;
                gunaLabel1.Text = "Good";
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }
    }
}
