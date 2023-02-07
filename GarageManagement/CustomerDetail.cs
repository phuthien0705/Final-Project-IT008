using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GarageManagement
{
    public partial class CustomerDetail : Form
    {
        private int MaKH;
        public bool deleted = false;

        public CustomerDetail(int MaKH)
        {
            this.MaKH = MaKH;
            InitializeComponent();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            DataTable customerDetail = KHACHHANG_DAL.Instance.GetCustomerDetail(MaKH);

            string TenKH = customerDetail.Rows[0]["TenKH"].ToString();
            string GioiTinh = customerDetail.Rows[0]["GioiTinh"].ToString();
            string DienThoai = customerDetail.Rows[0]["DienThoai"].ToString();
            string DiaChi = customerDetail.Rows[0]["DiaChi"].ToString();
            string ThoiGianDangKy = customerDetail.Rows[0]["ThoiGianDangKy"].ToString();

            this.Text = TenKH + " | " + DienThoai;

            nameTb.Text = TenKH;
            genderCb.SelectedIndex = GioiTinh == "Nam" ? 0 : 1;
            phoneNumberTb.Text = DienThoai;
            addressTb.Text = DiaChi;
            createdTb.Text = ThoiGianDangKy;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string TenKH = nameTb.Text;
            string GioiTinh = genderCb.SelectedIndex == 0 ? "Nam" : "Nữ";
            string DienThoai = phoneNumberTb.Text;
            string DiaChi = addressTb.Text;
            
            if (KHACHHANG_DAL.Instance.UpdateCustomer(MaKH, TenKH, DienThoai, GioiTinh, DiaChi))
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại");
            }
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn sẽ xóa khách hàng này ?", "delete customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (XE_DAL.Instance.SoftDeleteAllCarOfCustomer(this.MaKH) && KHACHHANG_DAL.Instance.SoftDeleteCustomer(this.MaKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!!");
                    deleted = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại !! Thử lại");
                }
            }
        }
    }
}
