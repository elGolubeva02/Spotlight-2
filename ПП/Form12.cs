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
        public static int zItog;
        public Form12()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            //zItog = Convert.ToInt32(controller.Color1(CheckIn.KodY));
            //if (zItog == 0) gunaButton1.BaseColor = Color.FromArgb(240, 60, 69);
            //if (zItog == 1) gunaButton1.BaseColor = Color.FromArgb(255, 141, 66);
            //if (zItog == 2) gunaButton1.BaseColor = Color.FromArgb(255, 242, 0);
            //if (zItog == 3) gunaButton1.BaseColor = Color.FromArgb(194, 235, 73);

            if (Form5_2.kol2 == 0) gunaButton2.BaseColor = Color.FromArgb(240, 60, 69);
            if (Form5_2.kol2 == 1) gunaButton2.BaseColor = Color.FromArgb(255, 141, 66);
            if (Form5_2.kol2 == 2) gunaButton2.BaseColor = Color.FromArgb(255, 242, 0);
            if (Form5_2.kol2 == 3) gunaButton2.BaseColor = Color.FromArgb(194, 235, 73);

            if (Form3_2.kol == 0) gunaButton1.BaseColor = Color.FromArgb(240, 60, 69);
            if (Form3_2.kol == 1) gunaButton1.BaseColor = Color.FromArgb(255, 141, 66);
            if (Form3_2.kol == 2) gunaButton1.BaseColor = Color.FromArgb(255, 242, 0);
            if (Form3_2.kol == 3) gunaButton1.BaseColor = Color.FromArgb(194, 235, 73);

            if (Form7_2.kol3 == 0) gunaButton3.BaseColor = Color.FromArgb(240, 60, 69);
            if (Form7_2.kol3 == 1) gunaButton3.BaseColor = Color.FromArgb(255, 141, 66);
            if (Form7_2.kol3== 2) gunaButton3.BaseColor = Color.FromArgb(255, 242, 0);
            if (Form7_2.kol3 == 3) gunaButton3.BaseColor = Color.FromArgb(194, 235, 73);

            if (Form9_2.kol4 == 0) gunaButton4.BaseColor = Color.FromArgb(240, 60, 69);
            if (Form9_2.kol4 == 1) gunaButton4.BaseColor = Color.FromArgb(255, 141, 66);
            if (Form9_2.kol4 == 2) gunaButton4.BaseColor = Color.FromArgb(255, 242, 0);
            if (Form9_2.kol4 == 3) gunaButton4.BaseColor = Color.FromArgb(194, 235, 73);

            if (Form11_2.kol5 == 0) gunaButton5.BaseColor = Color.FromArgb(240, 60, 69);
            if (Form11_2.kol5 == 1) gunaButton5.BaseColor = Color.FromArgb(255, 141, 66);
            if (Form11_2.kol5 == 2) gunaButton5.BaseColor = Color.FromArgb(255, 242, 0);
            if (Form11_2.kol5 == 3) gunaButton5.BaseColor = Color.FromArgb(194, 235, 73);
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
