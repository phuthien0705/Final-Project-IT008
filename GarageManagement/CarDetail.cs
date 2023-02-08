using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GarageManagement
{
    public partial class CarDetail : Form
    {
        string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\car_image\";

        public OpenFileDialog opFile = new OpenFileDialog();

        bool imageExist = false;

        private DataTable data;

        private DataTable allCustomer;

        private int MaXe;

        public CarDetail(int MaXe)
        {
            this.MaXe = MaXe;
            InitializeComponent();
            LoadCarDeTail();
            LoadProblemList();
            LoadKitChoosen();
            imageExist = CheckImageExist();
            LoadCarImage();
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";                                                                                   // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    carImg.Image = new Bitmap(opFile.OpenFile());
                    noImgLb.Visible = false;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        void LoadCarImage()
        {
            string iName = "image" + MaXe + ".jpg";
            if (imageExist)
            {
                noImgLb.Visible = false;
                using (FileStream fs = new FileStream(appPath + iName, FileMode.Open))
                {
                    Image image = Image.FromStream(fs);
                    carImg.Image = image;
                    fs.Close();
                }
            }
            else
            {
                noImgLb.Visible = true;
            }
        }

        bool CheckImageExist()
        {
            string iName = "image" + MaXe + ".jpg";
            return File.Exists(appPath + iName);
        }

        void SaveCarImage()
        {
            try
            {
                if (Directory.Exists(appPath) == false)
                {                                                                                    
                    Directory.CreateDirectory(appPath);        
                }
                string iName = "image" + MaXe + ".jpg";
                string filepath = opFile.FileName;

                if (imageExist)
                {
                    File.Delete(appPath + iName);
                }
                File.Copy(filepath, appPath + iName);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Cannot save image !! \n " + exp.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int MaKH = GetTableIndexFromComboboxIndex(customerCb, allCustomer, "MaKH");
            string BienSo = plateNumberTb.Text;
            int MaHX = brandCb.SelectedIndex + 1;
            int TrangThai = statusCb.SelectedIndex + 1;
            int MaPhieuSuaChua = (int)(PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(MaXe)).Rows[0]["MaPhieuSuaChua"];
            if (XE_DAL.Instance.UpdateCar(this.MaXe, BienSo, MaKH, MaHX, TrangThai) && PHIEUSUACHUA_DAL.Instance.UpdateCustomer(MaPhieuSuaChua, MaKH)) 
            {
                SaveCarImage();
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

            customerCb.SelectedIndex = GetComboboxIndexFromTableIndex(allCustomer, MaKH, "MaKH");
            plateNumberTb.Text = BienSo;
            brandCb.SelectedIndex = MaHX - 1;
            statusCb.SelectedIndex = Int32.Parse(TrangThai) - 1;
            orderedDateTb.Text = NgayTiepNhan;
        }

        void LoadProblemList()
        {
            problemLv.Clear();
            int MaPhieuSuaChua = (int)PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(MaXe).Rows[0]["MaPhieuSuaChua"];
            DataTable problemList = CHITIETTIENCONG_DAL.Instance.LoadProblemDetail(MaPhieuSuaChua);
            problemLv.Columns.Add("STT", 50);
            problemLv.Columns.Add("Tên dịch vụ", 180);
            problemLv.Columns.Add("Chi phí (VND)", 120);
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

        void LoadAllBrand()
        {
            brandCb.Items.Clear();
            DataTable allBrand = HIEUXE_DAL.Instance.LoadBrandList();
            for (int i = 0; i < allBrand.Rows.Count; i++)
            {
                brandCb.Items.Add(allBrand.Rows[i]["TenHieuXe"].ToString());
            }
        }

        void LoadAllCustomer()
        {
            customerCb.Items.Clear();
            allCustomer = KHACHHANG_DAL.Instance.LoadCustomerList();
            for (int i = 0; i < allCustomer.Rows.Count; i++)
            {
                string TenKH = allCustomer.Rows[i]["TenKH"].ToString();
                string DienThoai = allCustomer.Rows[i]["DienThoai"].ToString();
                customerCb.Items.Add(TenKH + " | " + DienThoai);
            }
        }

        void LoadKitChoosen()
        {
            kitOrderedLv.Clear();
            int MaPhieuSuaChua = (int)PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(MaXe).Rows[0]["MaPhieuSuaChua"];
            DataTable kitList = CHITIETPHIEUSUACHUA_DAL.Instance.GetKitListOfCar(MaPhieuSuaChua);
            kitOrderedLv.Columns.Add("STT", 40);
            kitOrderedLv.Columns.Add("Tên phụ tùng", 150);
            kitOrderedLv.Columns.Add("Giá (VND)", 100);
            kitOrderedLv.Columns.Add("Số lượng", 70);
            for (int i = 0; i < kitList.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                kitOrderedLv.Items.Add(item);

                // add kitName to carLv
                string kitName = kitList.Rows[i]["TenVatTuPhuTung"].ToString();
                ListViewItem.ListViewSubItem kitNameItem = new ListViewItem.ListViewSubItem(item, kitName);
                item.SubItems.Add(kitNameItem);

                // add price to carLv
                string price = kitList.Rows[i]["DonGia"].ToString();
                ListViewItem.ListViewSubItem priceItem = new ListViewItem.ListViewSubItem(item, price);
                item.SubItems.Add(priceItem);

                // add quantity to carLv
                string quantity = kitList.Rows[i]["SoLuongPhuTung"].ToString();
                ListViewItem.ListViewSubItem quantityItem = new ListViewItem.ListViewSubItem(item, quantity);
                item.SubItems.Add(quantityItem);
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
            CustomerDetail cd = (CustomerDetail)sender;
            if (!cd.deleted)
            {
                LoadCarDeTail();
            }
            else
            {
                this.Close();
            }
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

        int GetComboboxIndexFromTableIndex(DataTable dataTable, int tableIndex, string fieldName)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if ((int)dataTable.Rows[i][fieldName] == tableIndex) return i;
            }
            return 0;
        }

        int GetTableIndexFromComboboxIndex(ComboBox comboBox, DataTable dataTable, string fieldName)
        {
            return (int) dataTable.Rows[comboBox.SelectedIndex][fieldName];
        }
    }
}
