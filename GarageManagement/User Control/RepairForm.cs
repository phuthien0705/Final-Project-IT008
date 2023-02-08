using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GarageManagement.User_Control
{
    public partial class RepairForm : UserControl
    {
        DataTable availableKitData;
        DataTable chosenKitData = new DataTable();
        DataTable carList;
        DataTable problemList;

        public RepairForm()
        {
            InitializeComponent();
            Reload();
        }

        void Reload()
        {
            LoadAvailableKitList();
            LoadCarCombobox();
            CreateTableForChoosenKit();
        }

        void CreateTableForChoosenKit()
        {
            chosenKitData.Columns.Clear();
            chosenKitData.Columns.Add("MaPhuTung", typeof(int));
            chosenKitData.Columns.Add("TenVatTuPhuTung", typeof(string));
            chosenKitData.Columns.Add("SoLuong", typeof(int));
            chosenKitData.Columns.Add("DonGia", typeof(int));
        }

        void LoadAvailableKitList()
        {
            kitAvailableLv.Clear();
            availableKitData = KHO_DAL.Instance.getAccessoriesInStock();
            kitAvailableLv.Columns.Add("STT", 50);
            kitAvailableLv.Columns.Add("Tên phụ tùng", 200);
            kitAvailableLv.Columns.Add("Giá (VND)", 150);
            kitAvailableLv.Columns.Add("Số lượng có sẵn", 170);
            for (int i = 0; i < availableKitData.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                kitAvailableLv.Items.Add(item);

                // add kitName to carLv
                string kitName = availableKitData.Rows[i]["TenVatTuPhuTung"].ToString();
                ListViewItem.ListViewSubItem kitNameItem = new ListViewItem.ListViewSubItem(item, kitName);
                item.SubItems.Add(kitNameItem);

                // add price to carLv
                string price = availableKitData.Rows[i]["DonGia"].ToString();
                ListViewItem.ListViewSubItem priceItem = new ListViewItem.ListViewSubItem(item, price);
                item.SubItems.Add(priceItem);

                // add quantity to carLv
                string quantity = availableKitData.Rows[i]["SoLuong"].ToString();
                ListViewItem.ListViewSubItem quantityItem = new ListViewItem.ListViewSubItem(item, quantity);
                item.SubItems.Add(quantityItem);
            }
        }

        void LoadChoosenKitList()
        {
            kitChosenLv.Clear();
            kitChosenLv.Columns.Add("STT", 50);
            kitChosenLv.Columns.Add("Tên phụ tùng", 200);
            kitChosenLv.Columns.Add("Giá (VND)", 150);
            kitChosenLv.Columns.Add("Số lượng", 170);
            for (int i = 0; i < chosenKitData.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                kitChosenLv.Items.Add(item);

                // add kitName to carLv
                string kitName = chosenKitData.Rows[i]["TenVatTuPhuTung"].ToString();
                ListViewItem.ListViewSubItem kitNameItem = new ListViewItem.ListViewSubItem(item, kitName);
                item.SubItems.Add(kitNameItem);

                // add price to carLv
                string price = chosenKitData.Rows[i]["DonGia"].ToString();
                ListViewItem.ListViewSubItem priceItem = new ListViewItem.ListViewSubItem(item, price);
                item.SubItems.Add(priceItem);

                // add quantity to carLv
                string quantity = chosenKitData.Rows[i]["SoLuong"].ToString();
                ListViewItem.ListViewSubItem quantityItem = new ListViewItem.ListViewSubItem(item, quantity);
                item.SubItems.Add(quantityItem);
            }
        }
       
        void LoadCarCombobox()
        {
            carCbb.Items.Clear();
            carList = XE_DAL.Instance.LoadCarListOnStatus(1);
            for (int i = 0; i < carList.Rows.Count; i++)
            {
                string car = carList.Rows[i]["BienSo"].ToString() + " | " + carList.Rows[i]["TenHieuXe"].ToString();
                carCbb.Items.Add(car);
            }
            if (carCbb.Items.Count > 0) carCbb.SelectedIndex = 0;
        }

        void LoadProblemList(int MaXe)
        {
            problemLv.Clear();
            int MaPhieuSuaChua = (int)PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(MaXe).Rows[0]["MaPhieuSuaChua"];
            problemList = CHITIETTIENCONG_DAL.Instance.LoadProblemDetail(MaPhieuSuaChua);
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

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            if (kitAvailableLv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in kitAvailableLv.SelectedItems)
                {
                    int MaPhuTung = (int)availableKitData.Rows[item.Index]["MaPhuTung"];
                    if (!CheckExistKitInChoosenList(MaPhuTung))
                    {
                        chosenKitData.Rows.Add(MaPhuTung, item.SubItems[1].Text, 1, Int32.Parse(item.SubItems[2].Text));
                    }
                    else
                    {
                        MessageBox.Show("Phụ tùng "+ item.SubItems[1].Text + " đã được chọn !!");
                    }
                }
                LoadChoosenKitList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phụ tùng !!");
            }
        }

        public bool CheckExistKitInChoosenList(int MaPhuTung)
        {
            foreach (DataRow row in chosenKitData.Rows)
            {
                if ((int)row["MaPhuTung"] == MaPhuTung) return true;
            }
            return false;
        }

        private void carCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaXe = (int) carList.Rows[carCbb.SelectedIndex]["MaXe"];
            LoadProblemList(MaXe);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (kitChosenLv.SelectedItems.Count == 1)
            {
                chosenKitData.Rows.RemoveAt(kitChosenLv.SelectedItems[0].Index);
                LoadChoosenKitList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phụ tùng để loại bỏ !!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {   
            if (kitChosenLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng để cập nhật số lượng !!");
            }
            else
            {
                int isNumeric;
                if (txtbxQuantity.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng phụ tùng muốn cập nhật !!");
                }
                else if (!Int32.TryParse(txtbxQuantity.Text, out isNumeric))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số !!");
                }
                else 
                {
                    int MaPhuTung = (int) chosenKitData.Rows[kitChosenLv.SelectedItems[0].Index]["MaPhuTung"];
                    int quantityAvailable = (int) (KHO_DAL.Instance.getKitDetailOnKitIndex(MaPhuTung)).Rows[0]["SoLuong"];
                    if (Int32.Parse(txtbxQuantity.Text) > quantityAvailable)
                    {
                        MessageBox.Show("Không thể chọn số lượng vượt quá số lượng phụ tùng có sẵn trong kho !!");
                    }
                    else
                    {
                        int quantity = Int32.Parse(txtbxQuantity.Text);
                        chosenKitData.Rows[kitChosenLv.SelectedItems[0].Index]["SoLuong"] = quantity;
                        LoadChoosenKitList();
                    }
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int MaXe = (int)carList.Rows[carCbb.SelectedIndex]["MaXe"];
            int MaPhieuSuaChua = (int)PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(MaXe).Rows[0]["MaPhieuSuaChua"];
            foreach (DataRow row in chosenKitData.Rows)
            {
                int MaPhuTung = (int) row["MaPhuTung"];
                int SoLuong = (int)(KHO_DAL.Instance.getKitDetailOnKitIndex(MaPhuTung)).Rows[0]["SoLuong"];
                int SoLuongPhuTung = (int)row["SoLuong"];
                CHITIETPHIEUSUACHUA_DAL.Instance.InsertKit(MaPhieuSuaChua, MaPhuTung, SoLuongPhuTung);
                int TienPhuTung = CHITIETPHIEUSUACHUA_DAL.Instance.GetTotalPrice(MaPhieuSuaChua);
                PHIEUSUACHUA_DAL.Instance.UpdateTotalKitPrice(MaPhieuSuaChua, TienPhuTung);
                KHO_DAL.Instance.UpdateKitAvailableQuantityAfterChoosing(MaPhuTung, SoLuong - SoLuongPhuTung);
            }
            XE_DAL.Instance.UpdateCarStatus(MaXe, 2);
            MessageBox.Show("Đã thêm phụ tùng cho xe !!");
        }

        private void RepairForm_VisibleChanged(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
