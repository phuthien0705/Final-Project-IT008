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

        public CarDetail carDetail;

        public AllList()
        {
            InitializeComponent();
            LoadCarListView();
        }

        void LoadCarListView()
        {
            carList = XE_DAL.Instance.LoadCarList();
            carLv.Columns.Add("STT", 50);
            carLv.Columns.Add("Biển số", 120);
            carLv.Columns.Add("Hãng xe", 100);
            carLv.Columns.Add("Tên chủ xe", 150);
            carLv.Columns.Add("Số điện thoại", 120);
            carLv.Columns.Add("Tình trạng", 120);
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

                // add customer to carLv
                string customer = carList.Rows[i]["TenKH"].ToString();
                ListViewItem.ListViewSubItem customerItem = new ListViewItem.ListViewSubItem(item, customer);
                item.SubItems.Add(customerItem);

                // add phoneNumber to carLv
                string phoneNumber = carList.Rows[i]["DienThoai"].ToString();
                ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                item.SubItems.Add(phoneNumberItem);

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

        private void viewDetail_Click(object sender, EventArgs e)
        {
            if (carLv.SelectedItems.Count > 0)
            {
                ListViewItem carItem = carLv.SelectedItems[0];
                int MaXe = Int32.Parse(carList.Rows[carItem.Index]["MaXe"].ToString());
                carDetail = new CarDetail(MaXe);
                carDetail.Show();
                carDetail.FormClosed += CarDetail_FormClosed;
            }
            else
            {
                MessageBox.Show("Cần chọn xe để xem chi tiết !!");
            }
        }

        private void CarDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            carLv.Clear();
            LoadCarListView();
            
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

        private void searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                carLv.Clear();

                string keywords = searchTb.Text;
                title.Text = searchTb.Text != "" ? String.Format(@"Kết quả cho từ khóa '{0}'",keywords) : "Tất cả";
                carList = XE_DAL.Instance.SearchForCar(keywords);

                carLv.Columns.Add("STT", 50);
                carLv.Columns.Add("Biển số", 120);
                carLv.Columns.Add("Hãng xe", 100);
                carLv.Columns.Add("Tên chủ xe", 150);
                carLv.Columns.Add("Số điện thoại", 120);
                carLv.Columns.Add("Tình trạng", 120);
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

                    // add customer to carLv
                    string customer = carList.Rows[i]["TenKH"].ToString();
                    ListViewItem.ListViewSubItem customerItem = new ListViewItem.ListViewSubItem(item, customer);
                    item.SubItems.Add(customerItem);

                    // add phoneNumber to carLv
                    string phoneNumber = carList.Rows[i]["DienThoai"].ToString();
                    ListViewItem.ListViewSubItem phoneNumberItem = new ListViewItem.ListViewSubItem(item, phoneNumber);
                    item.SubItems.Add(phoneNumberItem);

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
}
