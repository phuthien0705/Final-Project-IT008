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
    public partial class InProgressList : UserControl
    {
        public DataTable inProgressList;

        Dashboard db = new Dashboard();

        public InProgressList(Dashboard db)
        {
            this.db = db;
            InitializeComponent();
            LoadInProgressCar();
        }

        private void backToAllBtn_MouseMove(object sender, MouseEventArgs e)
        {
            backToAllBtn.Font = new Font(backToAllBtn.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void backToAllBtn_Click(object sender, EventArgs e)
        {
            db.panel1.Controls.Clear();
            AllList allList = new AllList();
            db.panel1.Controls.Add(allList);
            allList.Dock = DockStyle.Fill;
        }

        private void backToAllBtn_MouseLeave(object sender, EventArgs e)
        {
            backToAllBtn.Font = new Font(backToAllBtn.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        void LoadInProgressCar()
        {
            inProgressList = XE_DAL.Instance.LoadCarListOnStatus(2);
            inProgressLv.Columns.Add("STT", 50);
            inProgressLv.Columns.Add("Biển số", 120);
            inProgressLv.Columns.Add("Hãng xe", 100);
            inProgressLv.Columns.Add("Tên chủ xe", 150);
            inProgressLv.Columns.Add("Số điện thoại", 120);
            inProgressLv.Columns.Add("Tình trạng", 120);
            inProgressLv.Columns.Add("Ngày tiếp nhận", 200);
            for (int i = 0; i < inProgressList.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                inProgressLv.Items.Add(item);

                // add PlateNumber to carLv
                string plateNumber = inProgressList.Rows[i]["BienSo"].ToString();
                ListViewItem.ListViewSubItem plateNumberItem = new ListViewItem.ListViewSubItem(item, plateNumber);
                item.SubItems.Add(plateNumberItem);

                // add Brand to carLv
                string brand = inProgressList.Rows[i]["TenHieuXe"].ToString();
                ListViewItem.ListViewSubItem brandItem = new ListViewItem.ListViewSubItem(item, brand);
                item.SubItems.Add(brandItem);

                // add customer to carLv
                string customer = inProgressList.Rows[i]["TenKH"].ToString();
                ListViewItem.ListViewSubItem customerItem = new ListViewItem.ListViewSubItem(item, customer);
                item.SubItems.Add(customerItem);

                // add phoneNumber to carLv
                string phoneNumber = inProgressList.Rows[i]["DienThoai"].ToString();
                ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                item.SubItems.Add(phoneNumberItem);

                // add Status to carLv
                string status = "";
                string statusValue = inProgressList.Rows[i]["TrangThai"].ToString();
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
                string orderDatetime = inProgressList.Rows[i]["NgayTiepNhan"].ToString();
                ListViewItem.ListViewSubItem orderDatetimeItem = new ListViewItem.ListViewSubItem(item, orderDatetime);
                item.SubItems.Add(orderDatetimeItem);
            }
        }

        private void viewDetail_Click(object sender, EventArgs e)
        {
            CarDetail carDetail = new CarDetail();
            carDetail.Show();
        }

        private void viewDetail_MouseLeave(object sender, EventArgs e)
        {
            viewDetail.Font = new Font(viewDetail.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void viewDetail_MouseMove(object sender, MouseEventArgs e)
        {
            viewDetail.Font = new Font(viewDetail.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

    }
}
