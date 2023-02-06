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

        public RepairForm()
        {
            InitializeComponent();
            LoadAvailableKitList();
            LoadCarCombobox();
            CreateTableForChoosenKit();
        }

        void CreateTableForChoosenKit()
        {
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
            carList = XE_DAL.Instance.LoadCarList();
            for (int i = 0; i < carList.Rows.Count; i++)
            {
                string car = carList.Rows[i]["BienSo"].ToString() + " | " + carList.Rows[i]["TenHieuXe"].ToString();
                carCbb.Items.Add(car);
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
                        MessageBox.Show("Phụ tùng nãy đã được chọn !!");
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
    }
}
