
namespace GarageManagement
{
    partial class CarDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetail));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Flat tires",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Broken windows",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Punctured tires",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Indicator",
            "200",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Insulation film",
            "450",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Disk brake",
            "150",
            "1"}, -1);
            this.carImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.plateNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.statusCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.genderCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.orderedDateTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.problemLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.kitOrderedLv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quanity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.brandCb = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).BeginInit();
            this.SuspendLayout();
            // 
            // carImg
            // 
            this.carImg.Image = ((System.Drawing.Image)(resources.GetObject("carImg.Image")));
            this.carImg.ImageRotate = 0F;
            this.carImg.Location = new System.Drawing.Point(23, 65);
            this.carImg.Name = "carImg";
            this.carImg.Size = new System.Drawing.Size(100, 100);
            this.carImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImg.TabIndex = 0;
            this.carImg.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(697, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Địa chỉ";
            // 
            // addressTb
            // 
            this.addressTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.addressTb.BorderRadius = 15;
            this.addressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTb.DefaultText = "";
            this.addressTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.addressTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.addressTb.Location = new System.Drawing.Point(508, 212);
            this.addressTb.Margin = new System.Windows.Forms.Padding(4);
            this.addressTb.Name = "addressTb";
            this.addressTb.PasswordChar = '\0';
            this.addressTb.PlaceholderText = "Type for customer phone number";
            this.addressTb.SelectedText = "";
            this.addressTb.Size = new System.Drawing.Size(295, 31);
            this.addressTb.TabIndex = 54;
            this.addressTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Giới tính";
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.phoneNumberTb.BorderRadius = 15;
            this.phoneNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTb.DefaultText = "";
            this.phoneNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.phoneNumberTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.phoneNumberTb.Location = new System.Drawing.Point(626, 134);
            this.phoneNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.PasswordChar = '\0';
            this.phoneNumberTb.PlaceholderText = "Type for customer address";
            this.phoneNumberTb.SelectedText = "";
            this.phoneNumberTb.Size = new System.Drawing.Size(177, 31);
            this.phoneNumberTb.TabIndex = 52;
            this.phoneNumberTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hãng xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Biển số";
            // 
            // nameTb
            // 
            this.nameTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.nameTb.BorderRadius = 15;
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.DefaultText = "";
            this.nameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.nameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.nameTb.Location = new System.Drawing.Point(508, 56);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4);
            this.nameTb.Name = "nameTb";
            this.nameTb.PasswordChar = '\0';
            this.nameTb.PlaceholderText = "Type for customer name";
            this.nameTb.SelectedText = "";
            this.nameTb.Size = new System.Drawing.Size(295, 31);
            this.nameTb.TabIndex = 47;
            this.nameTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // plateNumberTb
            // 
            this.plateNumberTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.plateNumberTb.BorderRadius = 15;
            this.plateNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plateNumberTb.DefaultText = "";
            this.plateNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.plateNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.plateNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plateNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plateNumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plateNumberTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.plateNumberTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plateNumberTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.plateNumberTb.Location = new System.Drawing.Point(158, 56);
            this.plateNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.plateNumberTb.Name = "plateNumberTb";
            this.plateNumberTb.PasswordChar = '\0';
            this.plateNumberTb.PlaceholderText = "Type for plate number";
            this.plateNumberTb.SelectedText = "";
            this.plateNumberTb.Size = new System.Drawing.Size(295, 31);
            this.plateNumberTb.TabIndex = 48;
            this.plateNumberTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderColor = System.Drawing.Color.Blue;
            this.deleteBtn.BorderRadius = 15;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.HotPink;
            this.deleteBtn.FillColor2 = System.Drawing.Color.IndianRed;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(577, 572);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 30);
            this.deleteBtn.TabIndex = 59;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tình trạng";
            // 
            // statusCb
            // 
            this.statusCb.BackColor = System.Drawing.Color.Transparent;
            this.statusCb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.statusCb.BorderRadius = 15;
            this.statusCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusCb.ItemHeight = 25;
            this.statusCb.Items.AddRange(new object[] {
            "Đã tiếp nhận",
            "Đang sửa",
            "Đã hoàn thành"});
            this.statusCb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.Location = new System.Drawing.Point(306, 134);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(147, 31);
            this.statusCb.TabIndex = 62;
            // 
            // updateBtn
            // 
            this.updateBtn.BorderColor = System.Drawing.Color.Blue;
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.FillColor2 = System.Drawing.SystemColors.Highlight;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(693, 572);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 30);
            this.updateBtn.TabIndex = 59;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Location = new System.Drawing.Point(40, 171);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(71, 23);
            this.chooseImgBtn.TabIndex = 63;
            this.chooseImgBtn.Text = "Upload";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Vấn đề của xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Phụ tùng đã chọn";
            // 
            // genderCb
            // 
            this.genderCb.BackColor = System.Drawing.Color.Transparent;
            this.genderCb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.genderCb.BorderRadius = 15;
            this.genderCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderCb.ItemHeight = 25;
            this.genderCb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genderCb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCb.Location = new System.Drawing.Point(508, 134);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(97, 31);
            this.genderCb.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(622, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "Số điện thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Thời gian tiếp nhận";
            // 
            // orderedDateTb
            // 
            this.orderedDateTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.orderedDateTb.BorderRadius = 15;
            this.orderedDateTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderedDateTb.DefaultText = "";
            this.orderedDateTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.orderedDateTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.orderedDateTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderedDateTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderedDateTb.Enabled = false;
            this.orderedDateTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderedDateTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedDateTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.orderedDateTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderedDateTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.orderedDateTb.Location = new System.Drawing.Point(158, 212);
            this.orderedDateTb.Margin = new System.Windows.Forms.Padding(4);
            this.orderedDateTb.Name = "orderedDateTb";
            this.orderedDateTb.PasswordChar = '\0';
            this.orderedDateTb.PlaceholderText = "Type for customer phone number";
            this.orderedDateTb.SelectedText = "";
            this.orderedDateTb.Size = new System.Drawing.Size(295, 31);
            this.orderedDateTb.TabIndex = 70;
            this.orderedDateTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // problemLv
            // 
            this.problemLv.AutoArrange = false;
            this.problemLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.problemName,
            this.fee});
            this.problemLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLv.FullRowSelect = true;
            this.problemLv.HideSelection = false;
            this.problemLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.problemLv.Location = new System.Drawing.Point(209, 283);
            this.problemLv.Name = "problemLv";
            this.problemLv.Size = new System.Drawing.Size(594, 101);
            this.problemLv.TabIndex = 72;
            this.problemLv.UseCompatibleStateImageBehavior = false;
            this.problemLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // problemName
            // 
            this.problemName.Text = "Problem";
            this.problemName.Width = 322;
            // 
            // fee
            // 
            this.fee.Text = "Fee($)";
            this.fee.Width = 143;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.problemLv;
            // 
            // kitOrderedLv
            // 
            this.kitOrderedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitOrderedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kitName,
            this.price,
            this.quanity});
            this.kitOrderedLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitOrderedLv.FullRowSelect = true;
            this.kitOrderedLv.HideSelection = false;
            this.kitOrderedLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.kitOrderedLv.Location = new System.Drawing.Point(209, 427);
            this.kitOrderedLv.Name = "kitOrderedLv";
            this.kitOrderedLv.Size = new System.Drawing.Size(594, 105);
            this.kitOrderedLv.TabIndex = 73;
            this.kitOrderedLv.UseCompatibleStateImageBehavior = false;
            this.kitOrderedLv.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 49;
            // 
            // kitName
            // 
            this.kitName.Text = "Kit name";
            this.kitName.Width = 241;
            // 
            // price
            // 
            this.price.Text = "Price($)";
            this.price.Width = 154;
            // 
            // quanity
            // 
            this.quanity.Text = "Quanity";
            this.quanity.Width = 132;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.kitOrderedLv;
            // 
            // brandCb
            // 
            this.brandCb.BackColor = System.Drawing.Color.Transparent;
            this.brandCb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.brandCb.BorderRadius = 15;
            this.brandCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.brandCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandCb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.brandCb.ItemHeight = 25;
            this.brandCb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCb.Location = new System.Drawing.Point(158, 133);
            this.brandCb.Name = "brandCb";
            this.brandCb.Size = new System.Drawing.Size(123, 31);
            this.brandCb.TabIndex = 74;
            // 
            // CarDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 625);
            this.Controls.Add(this.brandCb);
            this.Controls.Add(this.kitOrderedLv);
            this.Controls.Add(this.problemLv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.orderedDateTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumberTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.plateNumberTb);
            this.Controls.Add(this.carImg);
            this.Name = "CarDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Detail";
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox carImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox addressTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nameTb;
        private Guna.UI2.WinForms.Guna2TextBox plateNumberTb;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox statusCb;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox genderCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox orderedDateTb;
        private System.Windows.Forms.ListView problemLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader problemName;
        private System.Windows.Forms.ColumnHeader fee;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ListView kitOrderedLv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kitName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quanity;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI2.WinForms.Guna2ComboBox brandCb;
    }
}