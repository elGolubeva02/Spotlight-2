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
    public partial class Form10_2 : Form
    {
        Query controller;
        public static bool z15, z25;
        public Form10_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "hot") && (gunaTextBox2.Text == "windy") && (gunaTextBox3.Text == "cold")) z15 = true;
            else z15 = false;
            if ((gunaTextBox16.Text == "i") && (gunaTextBox15.Text == "n") && (gunaTextBox14.Text == "r") &&
                (gunaTextBox7.Text == "u") && (gunaTextBox9.Text == "e") && (gunaTextBox8.Text == "r") &&
                (gunaTextBox11.Text == "p") && (gunaTextBox10.Text == "r"))
                z25 = true;
            else z25 = false;
            Form11_2 f11_2 = new Form11_2();
            this.Hide();
            f11_2.Show();
        }
    }
}
