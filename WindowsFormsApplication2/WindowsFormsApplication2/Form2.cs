﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;

            }
        }
    }
}
