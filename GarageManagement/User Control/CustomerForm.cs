using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagement.User_Control
{
    public partial class CustomerForm : UserControl
    {
        DataTable dtCustomer;
        int index;
        public CustomerForm()
        {
            InitializeComponent();
        }

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKH");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("DienThoai");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("Gioitinh");
            dt.Columns.Add("NgayDangKy");
            return dt;
        }

        static void BindingData(DataTable data, ListView listview)
        {
            listview.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listview.Items.Add(item);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            genderCb.SelectedIndex = 0;

            dtCustomer = KHACHHANG_DAL.Instance.LoadCustomerList();
            BindingData(dtCustomer, customerLv);
            customerLv.Refresh();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String name = txtbxName.Text.Trim();
            String gender = genderCb.SelectedItem.ToString();
            String address = txtbxAdrdess.Text.Trim();
            String phone = txtbxPhone.Text.Trim();

            KHACHHANG_DAL.Instance.InsertCustomer(name, phone, address, gender);
        }
    }
}
