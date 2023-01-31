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

            string BienSo = data.Rows[0]["BienSo"].ToString();
            string TenHieuXe = data.Rows[0]["TenHieuXe"].ToString();
            string TrangThai = data.Rows[0]["TrangThai"].ToString();
            string TenKH = data.Rows[0]["TenKH"].ToString();
            string GioiTinh = data.Rows[0]["GioiTinh"].ToString();
            string DienThoai = data.Rows[0]["DienThoai"].ToString();
            string DiaChi = data.Rows[0]["DiaChi"].ToString();
            string NgayTiepNhan = data.Rows[0]["NgayTiepNhan"].ToString();

            this.Text = BienSo + " | " + TenHieuXe;
            plateNumberTb.Text = BienSo;
            brandTb.Text = TenHieuXe;
            statusCb.SelectedIndex = Int32.Parse(TrangThai) - 1;
            orderedDateTb.Text = NgayTiepNhan;
            nameTb.Text = TenKH;
            genderCb.SelectedIndex = GioiTinh == "Nam" ? 0 : 1;
            phoneNumberTb.Text = DienThoai;
            addressTb.Text = DiaChi;
        }
    }
}
