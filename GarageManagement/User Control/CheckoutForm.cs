using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GarageManagement.User_Control
{
    public partial class CheckoutForm : UserControl
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            loadCartComboBox();
        }

        private void loadCartComboBox() {
            DataTable listCar = XE_DAL.Instance.LoadCarListOnStatus(2);
            for (int i = 0; i < listCar.Rows.Count; i++) {
                carComboBox.Items.Add(listCar.Rows[i]["BienSo"].ToString() + " | " + listCar.Rows[i]["TenHieuXe"].ToString());
            }
            
        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (string)carComboBox.SelectedItem;
            string[] subValue = value.Split(' ');

            test.Text = subValue[0];
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void receiptInfo1_Load(object sender, EventArgs e)
        {

        }

        private void policyCb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

       

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }

        private void confirmCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmCheckbox.Checked == true)
            {
                submitBtn.Enabled = true;
            }
            else {
                submitBtn.Enabled = false;
            }
        }
    }
}
