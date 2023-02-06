using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagement.User_Control
{
    public partial class CustomerForm : UserControl
    {
        DataTable dtCustomer;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomerList();
            genderCb.SelectedIndex = 0;
        }

        void LoadCustomerList()
        {
            customerLv.Clear();
            dtCustomer = KHACHHANG_DAL.Instance.LoadCustomerList();
            customerLv.Columns.Add("STT", 50);
            customerLv.Columns.Add("Họ và tên", 180);
            customerLv.Columns.Add("Giới tính", 100);
            customerLv.Columns.Add("Số điện thoại", 150);
            customerLv.Columns.Add("Địa chỉ", 300);
            customerLv.Columns.Add("Ngày đăng ký", 200);
            for (int i = 0; i < dtCustomer.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                customerLv.Items.Add(item);

                // add customerName to carLv
                string customerName = dtCustomer.Rows[i]["TenKH"].ToString();
                ListViewItem.ListViewSubItem customerNameItem = new ListViewItem.ListViewSubItem(item, customerName);
                item.SubItems.Add(customerNameItem);

                // add gender to carLv
                string gender = dtCustomer.Rows[i]["GioiTinh"].ToString();
                ListViewItem.ListViewSubItem genderItem = new ListViewItem.ListViewSubItem(item, gender);
                item.SubItems.Add(genderItem);

                // add phoneNumber to carLv
                string phoneNumber = dtCustomer.Rows[i]["DienThoai"].ToString();
                ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                item.SubItems.Add(phoneNumberItem);

                // add address to carLv
                string address = dtCustomer.Rows[i]["DiaChi"].ToString();
                ListViewItem.ListViewSubItem addressItem = new ListViewItem.ListViewSubItem(item, address);
                item.SubItems.Add(addressItem);

                // add registerTime to carLv
                string registerTime = dtCustomer.Rows[i]["ThoiGianDangKy"].ToString();
                ListViewItem.ListViewSubItem registerTimeItem = new ListViewItem.ListViewSubItem(item, registerTime);
                item.SubItems.Add(registerTimeItem);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            String name = txtbxName.Text.Trim();
            String gender = genderCb.SelectedItem.ToString();
            String address = txtbxAdrdess.Text.Trim();
            String phone = txtbxPhone.Text.Trim();

            if (KHACHHANG_DAL.Instance.InsertCustomer(name, phone, address, gender))
            {
                MessageBox.Show("Thêm khách hàng " + name + " | " + phone + " thành công!!");
                LoadCustomerList();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng " + name + " | " + phone + " thất bại!!");
            }
        }

        private void viewCustomerDetail_Click(object sender, EventArgs e)
        {
            if (customerLv.SelectedItems.Count > 0)
            {
                int MaKH = (int) dtCustomer.Rows[customerLv.SelectedItems[0].Index]["MaKH"];
                CustomerDetail customerDetail = new CustomerDetail(MaKH);
                customerDetail.Show();
                customerDetail.FormClosed += CustomerDetail_FormClosed;
            } else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xem thông tin !!");
            }
        }

        private void CustomerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomerList();
        }

        private void viewCustomerDetail_MouseMove(object sender, MouseEventArgs e)
        {
            viewCustomerDetail.Font = new Font(viewCustomerDetail.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void viewCustomerDetail_MouseLeave(object sender, EventArgs e)
        {
            viewCustomerDetail.Font = new Font(viewCustomerDetail.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }
    }
}
