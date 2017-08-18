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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if(checkBox1.Checked==false)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;

            }
        }
    }
}
