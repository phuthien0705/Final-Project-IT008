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
        DataTable availableKitData_main;
        DataTable availableKitData;
        DataTable chosenKitData;
        List<int> index = new List<int>();
        int new_index;
        int quantity_index;
        int idcar;
        int idRepairdCard;

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            return dt;
        }

        public RepairForm()
        {
            InitializeComponent();
        }

        private void loadCartComboBox()
        {
            DataTable listCar = XE_DAL.Instance.LoadCarListOnStatus(1);
            for (int i = 0; i < listCar.Rows.Count; i++)
            {
                carCbb.Items.Add(listCar.Rows[i]["MaXe"].ToString() + " | " + listCar.Rows[i]["BienSo"].ToString() + " | " + listCar.Rows[i]["TenHieuXe"].ToString());
            }

        }

        private void RepairForm_Load(object sender, EventArgs e)
        {
            loadCartComboBox();
            availableKitData = KHO_DAL.Instance.getAccessoriesInStock();
            availableKitData_main = KHO_DAL.Instance.getAccessoriesInStock();
            chosenKitData = createTable();
            loadData(availableKitData, kitAvailableLv);
            loadData(chosenKitData,kitChosenLv);
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
        public void loadData(DataTable data, ListView listview)
        {
            BindingData(data, listview);
            listview.Refresh();
        }


        private void carCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (string)carCbb.SelectedItem;
            //MessageBox.Show(value.Split(' ')[0]);
            string idcar_string = value.Split(' ')[0];
            idcar = Int32.Parse(idcar_string);
            //MessageBox.Show(subValue[0], "Thông báo");
            DataTable RepairCardTable = PHIEUSUACHUA_DAL.Instance.GetRepairCardFromCar(idcar);
            string idRepairdCard_string = RepairCardTable.Rows[0]["MaPhieuSuaChua"].ToString();
            idRepairdCard = Convert.ToInt32(idRepairdCard_string);
            //MessageBox.Show(idRepairdCard);
            DataTable ProblemTable = CHITIETTIENCONG_DAL.Instance.LoadProblemDetail(idRepairdCard);
            BindingData(ProblemTable, problemLv);
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            DataTable tempTable = createTable();
            foreach (var item in index)
            {
                bool flag_new = true;
                String id = kitAvailableLv.Items[item].SubItems[0].Text;

                foreach (DataRow dr in chosenKitData.Rows)
                {
                    if (dr["Id"].ToString() == id)
                    {
                        dr["Quantity"] = Convert.ToInt32(dr["Quantity"]) + 1;
                        flag_new = false;
                        break;
                    }
                }
                foreach (DataRow dr in availableKitData.Rows)
                {
                    if (dr["MaPhuTung"].ToString() == id)
                    {
                        if (Convert.ToInt32(dr["SoLuong"]) <= 0)
                        {
                            MessageBox.Show("Không đủ phụ tùng sửa chữa");
                            break;
                        }  
                        dr["SoLuong"] = Convert.ToInt32(dr["SoLuong"]) - 1;
                        break;
                    }
                }
                
                if (flag_new)
                {
                    String name = kitAvailableLv.Items[item].SubItems[1].Text;
                    String price = kitAvailableLv.Items[item].SubItems[2].Text;
                    object[] row = { id, name, price, 1 };
                    chosenKitData.Rows.Add(row);
                }
            }
            chosenKitData.DefaultView.Sort = "Id ASC";
            chosenKitData = chosenKitData.DefaultView.ToTable();
            loadData(chosenKitData, kitChosenLv);
            loadData(availableKitData, kitAvailableLv);
            index = new List<int>();
        }
        private void kitAvailableLv_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (kitAvailableLv.SelectedItems.Count > 0)
            {
                new_index = kitAvailableLv.Items.IndexOf(kitAvailableLv.SelectedItems[0]);
                int result = index.FirstOrDefault(x => x == new_index);
                if (result != 0)
                {
                    index.RemoveAll(p => p == new_index);
                    kitAvailableLv.Items[new_index].BackColor = Color.White;
                }
                else
                {
                    index.Add(new_index);
                    kitAvailableLv.Items[new_index].BackColor = SystemColors.Highlight;
                }

                //MessageBox.Show(index);
            }
            //Console.WriteLine(string.Join(" ", index));
        }

       
        private void kitChosenLv_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (kitChosenLv.SelectedItems.Count > 0)
            {
                quantity_index = kitChosenLv.Items.IndexOf(kitChosenLv.SelectedItems[0]);
                //MessageBox.Show(quantity_index.ToString());
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String quantity = txtbxQuantity.Text.Trim();
            String id = kitChosenLv.Items[quantity_index].SubItems[0].Text;
            foreach (DataRow dr in chosenKitData.Rows)
            {
                if (dr["Id"].ToString() == id)
                {
                    dr["Quantity"] = Convert.ToInt32(dr["Quantity"]) + Convert.ToInt32(quantity);
                    break;
                }
            }
            foreach (DataRow dr in availableKitData.Rows)
            {
                if (dr["MaPhuTung"].ToString() == id)
                {
                    if (Convert.ToInt32(dr["SoLuong"]) < Convert.ToInt32(quantity))
                    {
                        MessageBox.Show("Không đủ phụ tùng");
                        break;
                    }
                    dr["SoLuong"] = Convert.ToInt32(dr["SoLuong"]) - Convert.ToInt32(quantity);
                    break;
                }
            }
            loadData(chosenKitData, kitChosenLv);
            loadData(availableKitData, kitAvailableLv);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            String id = kitChosenLv.Items[quantity_index].SubItems[0].Text;
            foreach (DataRow dr in chosenKitData.Rows)
            {
                if (dr["Id"].ToString() == id)
                {
                    dr.Delete();
                    break;
                }
            }
            loadData(chosenKitData, kitChosenLv);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in chosenKitData.Rows)
            {

                CHITIETPHIEUSUACHUA_DAL.Instance.InsertKit(idRepairdCard, Convert.ToInt32(dr["Id"]), Convert.ToInt32(dr["Quantity"]));
                foreach (DataRow dr2 in availableKitData_main.Rows)
                {
                    if (dr2["MaPhuTung"].ToString() == dr["Id"].ToString())
                    {
                        KHO_DAL.Instance.updateAccessory(Convert.ToInt32(dr2["MaPhuTung"]),  Convert.ToInt32(dr2["SoLuong"]) - Convert.ToInt32(dr["Quantity"]), Convert.ToInt32(dr2["DonGia"]));

                    }
                }    
            }
            
        }
    }
}
