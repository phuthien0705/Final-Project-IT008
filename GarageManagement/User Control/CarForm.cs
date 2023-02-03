using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace GarageManagement.User_Control
{
    public partial class CarForm : UserControl
    {
        public DataTable customerList;

        public DataTable problemList;

        public DataTable brandList;

        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            DataTable allBrand = HIEUXE_DAL.Instance.LoadBrandList();
            for (int i = 0; i < allBrand.Rows.Count; i++)
            {
                brandCb.Items.Add(allBrand.Rows[i]["TenHieuXe"].ToString());
            }
            brandCb.SelectedIndex = 0;
            LoadCutomerList();
            LoadProblemList();
            LoadBrandList();
        }

        void LoadCutomerList()
        {
            customerList = KHACHHANG_DAL.Instance.LoadCustomerList();
            customerLv.Columns.Add("STT", 50);
            customerLv.Columns.Add("Họ và tên", 225);
            customerLv.Columns.Add("Số điện thoại", 215);
            for (int i = 0; i < customerList.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                customerLv.Items.Add(item);

                // add customerName to carLv
                string customerName = customerList.Rows[i]["TenKH"].ToString();
                ListViewItem.ListViewSubItem customerNameItem = new ListViewItem.ListViewSubItem(item, customerName);
                item.SubItems.Add(customerNameItem);

                // add phoneNumber to carLv
                string phoneNumber = customerList.Rows[i]["DienThoai"].ToString();
                ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                item.SubItems.Add(phoneNumberItem);
            }
        }

        void LoadProblemList()
        {
            problemList = TIENCONG_DAL.Instance.LoadProblemList();
            problemLv.Columns.Add("STT", 70);
            problemLv.Columns.Add("Loại dịch vụ", 180);
            problemLv.Columns.Add("Chi phí", 90);
            for (int i = 0; i < problemList.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                problemLv.Items.Add(item);

                // add problemName to carLv
                string problemName = problemList.Rows[i]["TenTienCong"].ToString();
                ListViewItem.ListViewSubItem problemNameItem = new ListViewItem.ListViewSubItem(item, problemName);
                item.SubItems.Add(problemNameItem);

                // add fee to carLv
                string fee = problemList.Rows[i]["ChiPhi"].ToString();
                ListViewItem.ListViewSubItem feeItem = new ListViewItem.ListViewSubItem(item, fee);
                item.SubItems.Add(feeItem);
            }
        }

        void LoadBrandList()
        {
            brandCb.Items.Clear();
            brandList = HIEUXE_DAL.Instance.LoadBrandList();
            for (int i = 0; i < brandList.Rows.Count; i++)
            {
                brandCb.Items.Add(brandList.Rows[i]["TenHieuXe"].ToString());
            }
            brandCb.SelectedIndex = 0;
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            string BienSo = plateNumberTb.Text;
            int MaHX = brandCb.SelectedIndex + 1;
            if (BienSo != "")
            {
                if (customerLv.SelectedItems.Count > 0)
                {
                    int MaKH = Int32.Parse(customerLv.SelectedItems[0].Text);

                    if (XE_DAL.Instance.InsertCar(BienSo, MaHX, MaKH))
                    {
                        MessageBox.Show("Thêm xe " + BienSo + " | " + brandCb.SelectedItem + " thành công!!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm xe " + BienSo + " | " + brandCb.SelectedItem + " thất bại!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chủ xe !!");
                }
            } else
            {
                MessageBox.Show("Vui lòng điền biển số xe !!");
            }
        }

        private void searchCustomerTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                customerLv.Items.Clear();

                string keyword = searchCustomerTb.Text;
                DataTable result = KHACHHANG_DAL.Instance.SearchForCustomer(keyword);

                for (int i = 0; i < result.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(i + 1 + "");
                    customerLv.Items.Add(item);

                    // add customerName to carLv
                    string customerName = result.Rows[i]["TenKH"].ToString();
                    ListViewItem.ListViewSubItem customerNameItem = new ListViewItem.ListViewSubItem(item, customerName);
                    item.SubItems.Add(customerNameItem);

                    // add phoneNumber to carLv
                    string phoneNumber = result.Rows[i]["DienThoai"].ToString();
                    ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                    item.SubItems.Add(phoneNumberItem);
                }
            }
        }
    }
}
