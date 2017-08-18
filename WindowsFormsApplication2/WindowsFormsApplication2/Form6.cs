using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                lampoff.Visible = true;
                lampon.Visible = false;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                lampon.Visible = true;
                lampoff.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                lampon.Visible = true;
                lampoff.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                lampon.Visible = true;
                lampoff.Visible = false;


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                lampoff.Visible = true;
                lampon.Visible = false;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                lampon.Visible = true;
                lampoff.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                lampon.Visible = true;
                lampoff.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                lampon.Visible = true;
                lampoff.Visible = false;


            }
        }
    }
}
