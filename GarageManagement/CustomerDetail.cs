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

        public CustomerDetail(int MaKH)
        {
            this.MaKH = MaKH;
            InitializeComponent();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            DataTable customerDetail = XE_DAL.Instance.GetCustomerDetail(MaKH);

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
    }
}
