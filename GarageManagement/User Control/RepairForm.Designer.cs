
namespace GarageManagement.User_Control
{
    partial class RepairForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Exhaust",
            "1200",
            "20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Tire",
            "200",
            "50"}, -1);
            this.label15 = new System.Windows.Forms.Label();
            this.kitAvailableLv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kit_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.kitChosenLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carCbb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.removeBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.problemLv = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.chooseBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 28);
            this.label15.TabIndex = 11;
            this.label15.Text = "Sửa chữa";
            // 
            // kitAvailableLv
            // 
            this.kitAvailableLv.AutoArrange = false;
            this.kitAvailableLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitAvailableLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kit_name,
            this.price,
            this.available});
            this.kitAvailableLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitAvailableLv.FullRowSelect = true;
            this.kitAvailableLv.HideSelection = false;
            this.kitAvailableLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.kitAvailableLv.Location = new System.Drawing.Point(29, 112);
            this.kitAvailableLv.Name = "kitAvailableLv";
            this.kitAvailableLv.Size = new System.Drawing.Size(593, 180);
            this.kitAvailableLv.TabIndex = 12;
            this.kitAvailableLv.UseCompatibleStateImageBehavior = false;
            this.kitAvailableLv.View = System.Windows.Forms.View.Details;
            this.kitAvailableLv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.kitAvailableLv_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "STT";
            this.id.Width = 50;
            // 
            // kit_name
            // 
            this.kit_name.Text = "Tên phụ tùng";
            this.kit_name.Width = 230;
            // 
            // price
            // 
            this.price.Text = "Giá (VND)";
            this.price.Width = 150;
            // 
            // available
            // 
            this.available.Text = "Số lượng sẵn có";
            this.available.Width = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chọn số lượng:";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtbxQuantity.BorderRadius = 13;
            this.txtbxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxQuantity.DefaultText = "";
            this.txtbxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxQuantity.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbxQuantity.Location = new System.Drawing.Point(537, 338);
            this.txtbxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxQuantity.MaxLength = 50;
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.PasswordChar = '\0';
            this.txtbxQuantity.PlaceholderText = "Number";
            this.txtbxQuantity.SelectedText = "";
            this.txtbxQuantity.Size = new System.Drawing.Size(85, 25);
            this.txtbxQuantity.TabIndex = 14;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.kitAvailableLv;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.kitChosenLv;
            // 
            // kitChosenLv
            // 
            this.kitChosenLv.AutoArrange = false;
            this.kitChosenLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitChosenLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.kitChosenLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitChosenLv.FullRowSelect = true;
            this.kitChosenLv.HideSelection = false;
            this.kitChosenLv.Location = new System.Drawing.Point(28, 374);
            this.kitChosenLv.Name = "kitChosenLv";
            this.kitChosenLv.Size = new System.Drawing.Size(593, 180);
            this.kitChosenLv.TabIndex = 41;
            this.kitChosenLv.UseCompatibleStateImageBehavior = false;
            this.kitChosenLv.View = System.Windows.Forms.View.Details;
            this.kitChosenLv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.kitChosenLv_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phụ tùng";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá (VND)";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phụ tùng hiện có trong kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phụ tùng đã chọn";
            // 
            // carCbb
            // 
            this.carCbb.BackColor = System.Drawing.Color.Transparent;
            this.carCbb.BorderColor = System.Drawing.Color.IndianRed;
            this.carCbb.BorderRadius = 15;
            this.carCbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carCbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carCbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carCbb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.carCbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carCbb.ItemHeight = 25;
            this.carCbb.Items.AddRange(new object[] {
            "99A-561.29 | Kia Morning",
            "75A-023.41 | Roll-royce",
            "44A-586.12 | Mercedes-Benz"});
            this.carCbb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCbb.Location = new System.Drawing.Point(665, 112);
            this.carCbb.Name = "carCbb";
            this.carCbb.Size = new System.Drawing.Size(280, 31);
            this.carCbb.TabIndex = 19;
            this.carCbb.SelectedIndexChanged += new System.EventHandler(this.carCbb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose the car:";
            // 
            // updateBtn
            // 
            this.updateBtn.BorderRadius = 13;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.DarkBlue;
            this.updateBtn.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(511, 570);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 25);
            this.updateBtn.TabIndex = 37;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fix fee:";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 13;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.DarkKhaki;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Gold;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(921, 303);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(113, 25);
            this.guna2GradientButton2.TabIndex = 40;
            this.guna2GradientButton2.Text = "Confirm";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BorderRadius = 13;
            this.removeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeBtn.FillColor = System.Drawing.Color.Crimson;
            this.removeBtn.FillColor2 = System.Drawing.Color.DeepPink;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(414, 570);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(91, 25);
            this.removeBtn.TabIndex = 42;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // problemLv
            // 
            this.problemLv.AutoArrange = false;
            this.problemLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.problemName,
            this.fee});
            this.problemLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLv.FullRowSelect = true;
            this.problemLv.HideSelection = false;
            this.problemLv.Location = new System.Drawing.Point(665, 190);
            this.problemLv.Name = "problemLv";
            this.problemLv.Size = new System.Drawing.Size(369, 102);
            this.problemLv.TabIndex = 43;
            this.problemLv.UseCompatibleStateImageBehavior = false;
            this.problemLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // problemName
            // 
            this.problemName.Text = "Problem";
            this.problemName.Width = 206;
            // 
            // fee
            // 
            this.fee.Text = "Fee($)";
            this.fee.Width = 113;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 15;
            this.gunaElipse3.TargetControl = this.problemLv;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(28, 303);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(596, 10);
            this.gunaLinePanel1.TabIndex = 44;
            // 
            // chooseBtn
            // 
            this.chooseBtn.BorderRadius = 13;
            this.chooseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chooseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chooseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chooseBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chooseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chooseBtn.FillColor = System.Drawing.Color.DarkBlue;
            this.chooseBtn.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.chooseBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseBtn.ForeColor = System.Drawing.Color.White;
            this.chooseBtn.Location = new System.Drawing.Point(534, 77);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(87, 25);
            this.chooseBtn.TabIndex = 45;
            this.chooseBtn.Text = "Chọn";
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // RepairForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.problemLv);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.kitChosenLv);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carCbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxQuantity);
            this.Controls.Add(this.kitAvailableLv);
            this.Controls.Add(this.label15);
            this.Name = "RepairForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.Load += new System.EventHandler(this.RepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView kitAvailableLv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kit_name;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtbxQuantity;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox carCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader available;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.ListView kitChosenLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2GradientButton removeBtn;
        private System.Windows.Forms.ListView problemLv;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader problemName;
        private System.Windows.Forms.ColumnHeader fee;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI2.WinForms.Guna2GradientButton chooseBtn;
    }
}
