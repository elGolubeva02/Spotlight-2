﻿using System;
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
    public partial class Form8_2 : Form
    {
        Query controller;
        public static bool z14, z24;
        public Form8_2()
        {
            InitializeComponent();
            controller = new Query(DB.ConnStr);
            gunaTextBox3.Text = "e";
            gunaTextBox3.Enabled = false;
            gunaTextBox4.Text = "d";
            gunaTextBox4.Enabled = false;
            gunaTextBox7.Text = "e";
            gunaTextBox7.Enabled = false;
            gunaTextBox9.Text = "r";
            gunaTextBox9.Enabled = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "on") && (gunaTextBox2.Text == "under")
             ) z14 = true;
            else z14 = false;
            if ((gunaTextBox6.Text == "a") && (gunaTextBox5.Text == "l") &&
               (gunaTextBox8.Text == "e") && (gunaTextBox10.Text == "r") &&
               (gunaTextBox11.Text == "n") && (gunaTextBox16.Text == "u") &&
               (gunaTextBox15.Text == "p") && (gunaTextBox14.Text == "e") &&
               (gunaTextBox17.Text == "a") && (gunaTextBox13.Text == "b") &&
               (gunaTextBox12.Text == "o")
               ) z24 = true;
            else z24 = false;
            Form9_2 f9_2 = new Form9_2();
            this.Hide();
            f9_2.Show();
        }
    }
}
