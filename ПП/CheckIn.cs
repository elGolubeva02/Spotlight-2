using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПП
{

    public partial class CheckIn : Form
    {
        public static int KodY;
        Query controller;
        public CheckIn()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {

        }
        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            controller.Registracia(gunaTextBox1.Text, gunaTextBox2.Text);
            KodY = Convert.ToInt32(controller.Autorise2(gunaTextBox1.Text, gunaTextBox2.Text));
            Debug.WriteLine(KodY);
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
