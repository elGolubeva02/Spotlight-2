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
        Query controller;
        public static int Count, Count2, Count3, Count4, Count5;
        public Form12()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            Count = Convert.ToInt32(controller.Color1(CheckIn.KodY));
            if (Count !=0) gunaButton1.BaseColor = Color.FromArgb(216, 216, 216);

            Count2 = Convert.ToInt32(controller.Color2(CheckIn.KodY));
            if (Count2 != 0) gunaButton2.BaseColor = Color.FromArgb(216, 216, 216);

            Count3 = Convert.ToInt32(controller.Color3(CheckIn.KodY));
            if (Count3 != 0) gunaButton3.BaseColor = Color.FromArgb(216, 216, 216);

            Count4 = Convert.ToInt32(controller.Color4(CheckIn.KodY));
            if (Count4 != 0) gunaButton4.BaseColor = Color.FromArgb(216, 216, 216);

            Count5 = Convert.ToInt32(controller.Color5(CheckIn.KodY));
            if (Count5 != 0) gunaButton5.BaseColor = Color.FromArgb(216, 216, 216);
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
