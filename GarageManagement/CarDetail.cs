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
    public partial class CarDetail : Form
    {
        private DataTable data;

        private int MaXe;

        public CarDetail(int MaXe)
        {
            this.MaXe = MaXe;
            InitializeComponent();
            LoadCarDeTail();
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
            int MaKH = customerCb.SelectedIndex + 1;
            string BienSo = plateNumberTb.Text;
            int MaHX = brandCb.SelectedIndex + 1;
            int TrangThai = statusCb.SelectedIndex + 1;
            if (XE_DAL.Instance.UpdateCar(this.MaXe, BienSo, MaKH, MaHX, TrangThai)) 
            {
                MessageBox.Show("Cập nhật thành công !!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !! Vui lòng thử lại.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn sẽ xóa xe này ?", "delete car", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (XE_DAL.Instance.SoftDeleteCar(this.MaXe))
                {
                    MessageBox.Show("Xóa xe thành công !!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa xe thất bại !! Thử lại");
                }
            }
        }

        void LoadCarDeTail()
        {
            data = XE_DAL.Instance.GetCarDetail(this.MaXe);
            LoadAllBrand();
            LoadAllCustomer();

            string BienSo = data.Rows[0]["BienSo"].ToString();
            int MaHX = Int32.Parse(data.Rows[0]["MaHX"].ToString());
            int MaKH = Int32.Parse(data.Rows[0]["MaKH"].ToString());
            string TenHieuXe = data.Rows[0]["TenHieuXe"].ToString();
            string TrangThai = data.Rows[0]["TrangThai"].ToString();
            string NgayTiepNhan = data.Rows[0]["NgayTiepNhan"].ToString();

            this.Text = BienSo + " | " + TenHieuXe;

            customerCb.SelectedIndex = MaKH - 1;
            plateNumberTb.Text = BienSo;
            brandCb.SelectedIndex = MaHX - 1;
            statusCb.SelectedIndex = Int32.Parse(TrangThai) - 1;
            orderedDateTb.Text = NgayTiepNhan;
        }

        void LoadAllBrand()
        {
            DataTable allBrand = HIEUXE_DAL.Instance.LoadBrandList();
            for (int i = 0; i < allBrand.Rows.Count; i++)
            {
                brandCb.Items.Add(allBrand.Rows[i]["TenHieuXe"].ToString());
            }
        }

        void LoadAllCustomer()
        {
            DataTable allCustomer = KHACHHANG_DAL.Instance.LoadCustomerList();
            for (int i = 0; i < allCustomer.Rows.Count; i++)
            {
                string TenKH = allCustomer.Rows[i]["TenKH"].ToString();
                string DienThoai = allCustomer.Rows[i]["DienThoai"].ToString();
                customerCb.Items.Add(TenKH + " | " + DienThoai);
            }
        }

        private void viewCustomerDetail_Click(object sender, EventArgs e)
        {
            int MaKH = XE_DAL.Instance.GetCustomerFromCar(MaXe);
            CustomerDetail customerDetail = new CustomerDetail(MaKH);
            customerDetail.Show();
            customerDetail.FormClosed += CustomerDetail_FormClosed;
        }

        private void CustomerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đóng form");
        }

        private void viewCustomerDetail_MouseLeave(object sender, EventArgs e)
        {
            viewCustomerDetail.Font = new Font(viewCustomerDetail.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void viewCustomerDetail_MouseMove(object sender, MouseEventArgs e)
        {
            viewCustomerDetail.Font = new Font(viewCustomerDetail.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }
    }
}
