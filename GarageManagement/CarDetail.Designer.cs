
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
            this.carImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plateNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.statusCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.orderedDateTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.problemLv = new System.Windows.Forms.ListView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.kitOrderedLv = new System.Windows.Forms.ListView();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.brandCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.viewCustomerDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noImgLb = new System.Windows.Forms.Label();
            this.purchasedLb = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).BeginInit();
            this.SuspendLayout();
            // 
            // carImg
            // 
            this.carImg.ImageRotate = 0F;
            this.carImg.Location = new System.Drawing.Point(594, 42);
            this.carImg.Name = "carImg";
            this.carImg.Size = new System.Drawing.Size(150, 150);
            this.carImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImg.TabIndex = 0;
            this.carImg.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "THÔNG TIN XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hãng xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Biển số";
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
            this.plateNumberTb.Location = new System.Drawing.Point(389, 64);
            this.plateNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.plateNumberTb.Name = "plateNumberTb";
            this.plateNumberTb.PasswordChar = '\0';
            this.plateNumberTb.PlaceholderText = "Type for plate number";
            this.plateNumberTb.SelectedText = "";
            this.plateNumberTb.Size = new System.Drawing.Size(154, 31);
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
            this.deleteBtn.Location = new System.Drawing.Point(542, 478);
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
            this.label5.Location = new System.Drawing.Point(172, 112);
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
            this.statusCb.Enabled = false;
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
            this.statusCb.Location = new System.Drawing.Point(176, 134);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(141, 31);
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
            this.updateBtn.Location = new System.Drawing.Point(658, 478);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 30);
            this.updateBtn.TabIndex = 59;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Location = new System.Drawing.Point(639, 212);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(71, 23);
            this.chooseImgBtn.TabIndex = 63;
            this.chooseImgBtn.Text = "Tải ảnh lên";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 19);
            this.label9.TabIndex = 66;
            this.label9.Text = "Dịch vụ đã chọn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "Phụ tùng đã chọn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 112);
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
            this.orderedDateTb.Location = new System.Drawing.Point(331, 134);
            this.orderedDateTb.Margin = new System.Windows.Forms.Padding(4);
            this.orderedDateTb.Name = "orderedDateTb";
            this.orderedDateTb.PasswordChar = '\0';
            this.orderedDateTb.PlaceholderText = "Type for customer phone number";
            this.orderedDateTb.SelectedText = "";
            this.orderedDateTb.Size = new System.Drawing.Size(212, 31);
            this.orderedDateTb.TabIndex = 70;
            this.orderedDateTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // problemLv
            // 
            this.problemLv.AutoArrange = false;
            this.problemLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLv.FullRowSelect = true;
            this.problemLv.HideSelection = false;
            this.problemLv.Location = new System.Drawing.Point(161, 212);
            this.problemLv.Name = "problemLv";
            this.problemLv.Size = new System.Drawing.Size(381, 101);
            this.problemLv.TabIndex = 72;
            this.problemLv.UseCompatibleStateImageBehavior = false;
            this.problemLv.View = System.Windows.Forms.View.Details;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.problemLv;
            // 
            // kitOrderedLv
            // 
            this.kitOrderedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitOrderedLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitOrderedLv.FullRowSelect = true;
            this.kitOrderedLv.HideSelection = false;
            this.kitOrderedLv.Location = new System.Drawing.Point(161, 356);
            this.kitOrderedLv.Name = "kitOrderedLv";
            this.kitOrderedLv.Size = new System.Drawing.Size(381, 105);
            this.kitOrderedLv.TabIndex = 73;
            this.kitOrderedLv.UseCompatibleStateImageBehavior = false;
            this.kitOrderedLv.View = System.Windows.Forms.View.Details;
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
            this.brandCb.Location = new System.Drawing.Point(39, 133);
            this.brandCb.Name = "brandCb";
            this.brandCb.Size = new System.Drawing.Size(124, 31);
            this.brandCb.TabIndex = 74;
            // 
            // viewCustomerDetail
            // 
            this.viewCustomerDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewCustomerDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerDetail.ForeColor = System.Drawing.Color.DarkOrange;
            this.viewCustomerDetail.Location = new System.Drawing.Point(595, 252);
            this.viewCustomerDetail.Name = "viewCustomerDetail";
            this.viewCustomerDetail.Size = new System.Drawing.Size(145, 18);
            this.viewCustomerDetail.TabIndex = 75;
            this.viewCustomerDetail.Text = "Xem thông tin chủ xe";
            this.viewCustomerDetail.Click += new System.EventHandler(this.viewCustomerDetail_Click);
            this.viewCustomerDetail.MouseLeave += new System.EventHandler(this.viewCustomerDetail_MouseLeave);
            this.viewCustomerDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewCustomerDetail_MouseMove);
            // 
            // customerCb
            // 
            this.customerCb.BackColor = System.Drawing.Color.Transparent;
            this.customerCb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.customerCb.BorderRadius = 15;
            this.customerCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customerCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerCb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.customerCb.ItemHeight = 25;
            this.customerCb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCb.Location = new System.Drawing.Point(39, 64);
            this.customerCb.Name = "customerCb";
            this.customerCb.Size = new System.Drawing.Size(329, 31);
            this.customerCb.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Chủ xe";
            // 
            // noImgLb
            // 
            this.noImgLb.AutoSize = true;
            this.noImgLb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noImgLb.Location = new System.Drawing.Point(636, 112);
            this.noImgLb.Name = "noImgLb";
            this.noImgLb.Size = new System.Drawing.Size(68, 13);
            this.noImgLb.TabIndex = 78;
            this.noImgLb.Text = "Chưa có ảnh";
            // 
            // purchasedLb
            // 
            this.purchasedLb.AutoSize = true;
            this.purchasedLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLb.Location = new System.Drawing.Point(265, 478);
            this.purchasedLb.Name = "purchasedLb";
            this.purchasedLb.Size = new System.Drawing.Size(118, 18);
            this.purchasedLb.TabIndex = 79;
            this.purchasedLb.Text = "Đã thanh toán:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(389, 475);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(153, 36);
            this.totalCostLabel.TabIndex = 80;
            this.totalCostLabel.Text = "500.000 VND";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CarDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.purchasedLb);
            this.Controls.Add(this.noImgLb);
            this.Controls.Add(this.customerCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewCustomerDetail);
            this.Controls.Add(this.brandCb);
            this.Controls.Add(this.kitOrderedLv);
            this.Controls.Add(this.problemLv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.orderedDateTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox plateNumberTb;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox statusCb;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox orderedDateTb;
        private System.Windows.Forms.ListView problemLv;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ListView kitOrderedLv;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI2.WinForms.Guna2ComboBox brandCb;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewCustomerDetail;
        private Guna.UI2.WinForms.Guna2ComboBox customerCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noImgLb;
        private System.Windows.Forms.Label purchasedLb;
        private System.Windows.Forms.Label totalCostLabel;
    }
}