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
    public partial class AllList : UserControl
    {
        public DataTable carList;
        public AllList()
        {
            InitializeComponent();
            LoadCarListView();
        }

        void LoadCarListView()
        {
            carList = XE_DAL.Instance.LoadCarList();
            carLv.Columns.Add("STT", 50);
            carLv.Columns.Add("Biển số", 150);
            carLv.Columns.Add("Hãng xe", 150);
            carLv.Columns.Add("Tình trạng", 150);
            carLv.Columns.Add("Ngày tiếp nhận", 200);
            for (int i = 0; i < carList.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                carLv.Items.Add(item);

                // add PlateNumber to carLv
                string plateNumber = carList.Rows[i]["BienSo"].ToString();
                ListViewItem.ListViewSubItem plateNumberItem = new ListViewItem.ListViewSubItem(item, plateNumber);
                item.SubItems.Add(plateNumberItem);

                // add Brand to carLv
                string brand = carList.Rows[i]["TenHieuXe"].ToString();
                ListViewItem.ListViewSubItem brandItem = new ListViewItem.ListViewSubItem(item, brand);
                item.SubItems.Add(brandItem);

                // add Status to carLv
                string status = "";
                string statusValue = carList.Rows[i]["TrangThai"].ToString();
                switch (statusValue)
                {
                    case "1":
                        status = "Đã tiếp nhận";
                        break;
                    case "2":
                        status = "Đang sửa";
                        break;
                    case "3":
                        status = "Đã hoàn thành";
                        break;
                    default:
                        status = "Đã hủy";
                        break;
                }
                ListViewItem.ListViewSubItem statusItem = new ListViewItem.ListViewSubItem(item, status);
                item.SubItems.Add(statusItem);

                // add orderDatetime to carLv
                string orderDatetime = carList.Rows[i]["NgayTiepNhan"].ToString();
                ListViewItem.ListViewSubItem orderDatetimeItem = new ListViewItem.ListViewSubItem(item, orderDatetime);
                item.SubItems.Add(orderDatetimeItem);
            }
        }
    }
}
