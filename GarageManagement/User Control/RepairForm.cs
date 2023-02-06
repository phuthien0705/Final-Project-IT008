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
        DataTable chosenKitData;
        DataTable carList;

        public RepairForm()
        {
            InitializeComponent();
            LoadKitList();
            LoadCarCombobox();
        }

        void LoadKitList()
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
       
        void LoadCarCombobox()
        {
            carList = XE_DAL.Instance.LoadCarList();
            for (int i = 0; i < carList.Rows.Count; i++)
            {
                string car = carList.Rows[i]["BienSo"].ToString() + " | " + carList.Rows[i]["TenHieuXe"].ToString();
                carCbb.Items.Add(car);
            }
        }

    }
}
