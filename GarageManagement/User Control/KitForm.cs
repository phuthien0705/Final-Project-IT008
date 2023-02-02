using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarageManagement.User_Control
{
    public partial class KitForm : UserControl
    {
        public KitForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkInput2())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                int price = int.Parse(txtPrice2.Text);
                int quantity = int.Parse(txtQuantity2.Text);
                int id = (int)cboKitName.SelectedValue;
                KHO_DAL.Instance.updateAccessory(id, quantity, price);
                MessageBox.Show("Cập nhật thông tin thành công!");
                resetText2();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi. \n[{ex}]");
                throw;
            }
        }
        void resetText1()
        {
            txtKitName.ResetText();
            txtPrice1.ResetText();
            txtQuantity1.ResetText();
        }
        void resetText2()
        {
            txtPrice2.ResetText();
            txtQuantity2.ResetText();
        }
        bool checkInput1()
        {
            if (txtKitName.Text.Trim().Equals("")) return false;
            if (txtPrice1.Text.Trim().Equals("")) return false;
            if (txtQuantity1.Text.Trim().Equals("")) return false;
            return true;
        }
        bool checkInput2()
        {
            if (txtPrice2.Text.Trim().Equals("")) return false;
            if (txtQuantity2.Text.Trim().Equals("")) return false;
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput1())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                string kitName = txtKitName.Text;
                int price = int.Parse(txtPrice1.Text);
                int quantity = int.Parse(txtQuantity1.Text);
                KHO_DAL.Instance.addAccessory(kitName, quantity, price );
                MessageBox.Show("Thêm phụ tùng thành công!");
                resetText1();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi! {ex}");
            }
        }
        void loadKitName()
        {
            try
            {
                DataTable dataKit = KHO_DAL.Instance.getAccessoriesInStock();
                cboKitName.DataSource = dataKit;
                cboKitName.DisplayMember = "TenVatTuPhuTung";
                cboKitName.ValueMember = "MaPhuTung";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đổ dữ liệu kit lên combobox kit name");
                throw;
            }
        }

        private void txtKitName_Leave(object sender, EventArgs e)
        {
            try
            {
                string kitName = txtKitName.Text;
                if (KHO_DAL.Instance.checkDuplicateKitName(kitName))
                {
                    MessageBox.Show("Tên phụ tùng này đã có trong cửa hàng");
                    txtKitName.ResetText();
                    txtKitName.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtPrice1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice1.Text.Trim().Equals(""))
                {
                    return;
                }
                int price = int.Parse(txtPrice1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập!");
                txtPrice1.Focus();
            }
        }

        private void txtQuantity1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity1.Text.Trim().Equals(""))
                {
                    return;
                }
                int price = int.Parse(txtQuantity1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập!");
                txtQuantity1.Focus();
            }
        }

        private void txtPrice2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice2.Text.Trim().Equals(""))
                {
                    return;
                }
                int price = int.Parse(txtPrice2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập price!");
                txtPrice2.Focus();
            }
        }

        private void txtQuantity2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity2.Text.Trim().Equals(""))
                {
                    return;
                }
                int price = int.Parse(txtQuantity2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập quantity!");
                txtQuantity2.Focus();
            }
        }

        private void KitForm_Load(object sender, EventArgs e)
        {
            loadKitName();
            resetText2();
        }

        private void cboKitName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboKitName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = KHO_DAL.Instance.getAccessoryByKitName(cboKitName.Text);
                if (data != null)
                {
                    txtPrice2.Text = data.Rows[0]["DonGia"].ToString();
                    txtQuantity2.Text = data.Rows[0]["SoLuong"].ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
