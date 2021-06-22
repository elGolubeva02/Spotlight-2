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
    public partial class Form2_2 : Form
    {
        Query controller;
        public static bool z11, z21;
        public Form2_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "kitchen") && (gunaTextBox2.Text == "bedroom")) z11 = true;
            else z11 = false;
            if ((gunaTextBox3.Text == "c") && (gunaTextBox4.Text == "b") && (gunaTextBox5.Text == "d") && (gunaTextBox6.Text == "a")) z21 = true;
            else z21 = false;
            Form3_2 f3_2 = new Form3_2();
            this.Hide();
            f3_2.Show();
        }
    }
}
