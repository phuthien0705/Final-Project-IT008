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
        private DataTable listCar;
        private DataRow currentCar;
        private DataRow repairCard;
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
            this.listCar = listCar;
            for (int i = 0; i < listCar.Rows.Count; i++) {
                carComboBox.Items.Add(listCar.Rows[i]["BienSo"].ToString() + " | " + listCar.Rows[i]["TenHieuXe"].ToString());
            }

        }
        private void checkCheckoutCondition() {
            if (confirmCheckbox.Checked == true && carComboBox.Text != "")
            {
                submitBtn.Enabled = true;
            }
            else
            {
                submitBtn.Enabled = false;
            }
        }
        private void checkCustomberPanelCondition() {
            if (this.currentCar != null && customerPanel.Visible == false) {
                customerPanel.Visible = true;
            }
        }
        private void clearAllItemsInProblemListView() {
            ProblemListView.Items.Clear();
        }
        private void loadDataToProblemListView() { 
            
        }
        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (string)carComboBox.SelectedItem;
            int index = carComboBox.SelectedIndex;
            string[] subValue = value.Split(' ');
            this.currentCar = this.listCar.Rows[index];

            checkCheckoutCondition();
            checkCustomberPanelCondition();

            DataTable customerInfo = KHACHHANG_DAL.Instance.GetCustomerById(this.listCar.Rows[index]["MaKH"].ToString());
            if (customerInfo.Rows.Count == 0) {
                MessageBox.Show("Không tìm thấy khách hàng");
                return;
            }
            customerLabel.Text = customerInfo.Rows[0]["TenKH"].ToString();
            addressLabel.Text = customerInfo.Rows[0]["DiaChi"].ToString();
            carPlateLabel.Text = this.listCar.Rows[index]["BienSo"].ToString();
            carBrandLabel.Text = this.listCar.Rows[index]["TenHieuXe"].ToString();
            receivedDayLabel.Text = this.listCar.Rows[index]["NgayTiepNhan"].ToString();

            // get repair card
            DataTable repairCards = PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCarNotInPHIEUTHUTIEN(int.Parse(this.currentCar["MaXe"].ToString()));
            if (repairCards.Rows.Count == 0) {
                MessageBox.Show("Không tìm thấy khách hàng");
                return;
            }
            this.repairCard = repairCards.Rows[0];
            // get list problem

            DataTable problems = CHITIETTIENCONG_DAL.Instance.LoadProblemDetail(int.Parse(repairCards.Rows[0]["MaPhieuSuaChua"].ToString()));
            foreach(DataRow row in problems.Rows) {
                ListViewItem lvItem = new ListViewItem(row["MaPhieuSuaChua"].ToString());
                lvItem.SubItems.Add(row["TenTienCong"].ToString());
                lvItem.SubItems.Add(row["ChiPhi"].ToString());
                ProblemListView.Items.Add(lvItem);
            }
        }

        private void confirmCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            checkCheckoutCondition();
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

        
    }
}
