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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form4_2 f4_2 = new Form4_2();
            this.Hide();
            f4_2.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form2_2 f2_2 = new Form2_2();
            this.Hide();
            f2_2.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form6_2 f6_2 = new Form6_2();
            this.Hide();
            f6_2.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Form8_2 f8_2 = new Form8_2();
            this.Hide();
            f8_2.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form10_2 f10_2 = new Form10_2();
            this.Hide();
            f10_2.Show();
        }
    }
}
