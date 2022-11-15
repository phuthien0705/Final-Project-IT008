using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarageManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            carForm1.Visible = true;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            carForm1.Visible = false;
        }
    }
}
