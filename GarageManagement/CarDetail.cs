using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagement
{
    public partial class CarDetail : Form
    {
        public CarDetail()
        {
            InitializeComponent();
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    carImg.ImageLocation = imageLocation;
                }
            } catch (Exception)
            {
                MessageBox.Show("Cann't upload image now !","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete this car ?", "delete car", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
