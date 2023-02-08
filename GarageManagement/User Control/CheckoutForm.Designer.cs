
namespace GarageManagement.User_Control
{
    partial class CheckoutForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Indicator",
            "200",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Insulation film",
            "450",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Disk brake",
            "150",
            "1"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Flat tires",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Broken windows",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Punctured tires",
            "10"}, -1);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.orderDetailListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quanity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.paymentMethodComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRepairCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCostOfSquarePartLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.addBillPn = new Guna.UI2.WinForms.Guna2Panel();
            this.confirmCheckbox = new System.Windows.Forms.CheckBox();
            this.customerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.receivedDayLabel = new System.Windows.Forms.Label();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carPlateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.carComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.problemPn = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.ProblemListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2ContainerControl1.SuspendLayout();
            this.totalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addBillPn.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.problemPn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.guna2ContainerControl1;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.orderDetailListView);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(24, 406);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(691, 184);
            this.guna2ContainerControl1.TabIndex = 2;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // orderDetailListView
            // 
            this.orderDetailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kitName,
            this.price,
            this.quanity});
            this.orderDetailListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailListView.FullRowSelect = true;
            this.orderDetailListView.HideSelection = false;
            this.orderDetailListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.orderDetailListView.Location = new System.Drawing.Point(12, 9);
            this.orderDetailListView.Name = "orderDetailListView";
            this.orderDetailListView.Size = new System.Drawing.Size(661, 128);
            this.orderDetailListView.TabIndex = 2;
            this.orderDetailListView.UseCompatibleStateImageBehavior = false;
            this.orderDetailListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 49;
            // 
            // kitName
            // 
            this.kitName.Text = "Tên phụ tùng";
            this.kitName.Width = 321;
            // 
            // price
            // 
            this.price.Text = "Giá (VND)";
            this.price.Width = 154;
            // 
            // quanity
            // 
            this.quanity.Text = "Số lượng";
            this.quanity.Width = 132;
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPanel.BorderRadius = 15;
            this.totalPanel.Controls.Add(this.pictureBox1);
            this.totalPanel.Controls.Add(this.submitBtn);
            this.totalPanel.Controls.Add(this.paymentMethodComboBox);
            this.totalPanel.Controls.Add(this.label12);
            this.totalPanel.Controls.Add(this.gunaLinePanel1);
            this.totalPanel.Controls.Add(this.totalCostLabel);
            this.totalPanel.Controls.Add(this.taxLabel);
            this.totalPanel.Controls.Add(this.label5);
            this.totalPanel.Controls.Add(this.totalRepairCostLabel);
            this.totalPanel.Controls.Add(this.label4);
            this.totalPanel.Controls.Add(this.label3);
            this.totalPanel.Controls.Add(this.totalCostOfSquarePartLabel);
            this.totalPanel.Controls.Add(this.label2);
            this.totalPanel.Location = new System.Drawing.Point(743, 19);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(292, 571);
            this.totalPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BorderRadius = 15;
            this.submitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitBtn.Enabled = false;
            this.submitBtn.FillColor = System.Drawing.Color.Orchid;
            this.submitBtn.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(24, 494);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(239, 30);
            this.submitBtn.TabIndex = 36;
            this.submitBtn.Text = "Thanh toán";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.BackColor = System.Drawing.Color.Transparent;
            this.paymentMethodComboBox.BorderColor = System.Drawing.Color.DarkOrchid;
            this.paymentMethodComboBox.BorderRadius = 15;
            this.paymentMethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.paymentMethodComboBox.ItemHeight = 20;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Tiền mặt",
            "PayPal",
            "Apple Pay",
            "Google Pay",
            "Visa"});
            this.paymentMethodComboBox.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.Location = new System.Drawing.Point(24, 427);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(239, 26);
            this.paymentMethodComboBox.TabIndex = 35;
            this.paymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "Phương thước thanh toán:";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkOrchid;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(24, 339);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(240, 1);
            this.gunaLinePanel1.TabIndex = 29;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(122, 346);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(145, 36);
            this.totalCostLabel.TabIndex = 28;
            this.totalCostLabel.Text = "$1720";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(158, 304);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(109, 23);
            this.taxLabel.TabIndex = 27;
            this.taxLabel.Text = "10.00%";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tổng tiền:";
            // 
            // totalRepairCostLabel
            // 
            this.totalRepairCostLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRepairCostLabel.Location = new System.Drawing.Point(131, 262);
            this.totalRepairCostLabel.Name = "totalRepairCostLabel";
            this.totalRepairCostLabel.Size = new System.Drawing.Size(136, 23);
            this.totalRepairCostLabel.TabIndex = 24;
            this.totalRepairCostLabel.Text = "$200";
            this.totalRepairCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Thuế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phí sửa chữa:";
            // 
            // totalCostOfSquarePartLabel
            // 
            this.totalCostOfSquarePartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOfSquarePartLabel.Location = new System.Drawing.Point(127, 222);
            this.totalCostOfSquarePartLabel.Name = "totalCostOfSquarePartLabel";
            this.totalCostOfSquarePartLabel.Size = new System.Drawing.Size(140, 21);
            this.totalCostOfSquarePartLabel.TabIndex = 22;
            this.totalCostOfSquarePartLabel.Text = "$1500";
            this.totalCostOfSquarePartLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Phí phụ tùng:";
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 15;
            this.gunaElipse3.TargetControl = this.totalPanel;
            // 
            // addBillPn
            // 
            this.addBillPn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBillPn.BorderRadius = 15;
            this.addBillPn.Controls.Add(this.confirmCheckbox);
            this.addBillPn.Controls.Add(this.customerPanel);
            this.addBillPn.Controls.Add(this.carComboBox);
            this.addBillPn.Controls.Add(this.label8);
            this.addBillPn.Location = new System.Drawing.Point(24, 19);
            this.addBillPn.Name = "addBillPn";
            this.addBillPn.Size = new System.Drawing.Size(691, 202);
            this.addBillPn.TabIndex = 3;
            // 
            // confirmCheckbox
            // 
            this.confirmCheckbox.AutoSize = true;
            this.confirmCheckbox.Location = new System.Drawing.Point(29, 86);
            this.confirmCheckbox.Name = "confirmCheckbox";
            this.confirmCheckbox.Size = new System.Drawing.Size(245, 38);
            this.confirmCheckbox.TabIndex = 22;
            this.confirmCheckbox.Text = "Khách hàng chấp nhận mọi chính \r\nsách của doanh nghiệp";
            this.confirmCheckbox.UseVisualStyleBackColor = true;
            this.confirmCheckbox.CheckedChanged += new System.EventHandler(this.confirmCheckbox_CheckedChanged);
            // 
            // customerPanel
            // 
            this.customerPanel.BorderColor = System.Drawing.Color.DarkOrchid;
            this.customerPanel.BorderRadius = 15;
            this.customerPanel.BorderThickness = 1;
            this.customerPanel.Controls.Add(this.receivedDayLabel);
            this.customerPanel.Controls.Add(this.carBrandLabel);
            this.customerPanel.Controls.Add(this.carPlateLabel);
            this.customerPanel.Controls.Add(this.addressLabel);
            this.customerPanel.Controls.Add(this.label10);
            this.customerPanel.Controls.Add(this.label15);
            this.customerPanel.Controls.Add(this.label17);
            this.customerPanel.Controls.Add(this.label18);
            this.customerPanel.Controls.Add(this.customerLabel);
            this.customerPanel.Controls.Add(this.label20);
            this.customerPanel.Location = new System.Drawing.Point(312, 12);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(361, 172);
            this.customerPanel.TabIndex = 21;
            this.customerPanel.Visible = false;
            // 
            // receivedDayLabel
            // 
            this.receivedDayLabel.AutoSize = true;
            this.receivedDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDayLabel.Location = new System.Drawing.Point(129, 136);
            this.receivedDayLabel.Name = "receivedDayLabel";
            this.receivedDayLabel.Size = new System.Drawing.Size(160, 20);
            this.receivedDayLabel.TabIndex = 22;
            this.receivedDayLabel.Text = "2022/03/31 11:02:15";
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrandLabel.Location = new System.Drawing.Point(129, 105);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(128, 20);
            this.carBrandLabel.TabIndex = 22;
            this.carBrandLabel.Text = "Mercedes-Benz";
            // 
            // carPlateLabel
            // 
            this.carPlateLabel.AutoSize = true;
            this.carPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPlateLabel.Location = new System.Drawing.Point(129, 74);
            this.carPlateLabel.Name = "carPlateLabel";
            this.carPlateLabel.Size = new System.Drawing.Size(93, 20);
            this.carPlateLabel.TabIndex = 22;
            this.carPlateLabel.Text = "51A-256.21";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(129, 43);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(161, 20);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "25 Ballaire, Houston";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hiệu xe:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Biển số xe:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Ngày nhận:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 20);
            this.label18.TabIndex = 21;
            this.label18.Text = "Địa chỉ:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(129, 12);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(117, 20);
            this.customerLabel.TabIndex = 21;
            this.customerLabel.Text = "Callum Wilson";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Khách hàng:";
            // 
            // carComboBox
            // 
            this.carComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carComboBox.BorderColor = System.Drawing.Color.DarkOrchid;
            this.carComboBox.BorderRadius = 15;
            this.carComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carComboBox.ItemHeight = 25;
            this.carComboBox.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carComboBox.Location = new System.Drawing.Point(29, 44);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(271, 31);
            this.carComboBox.TabIndex = 20;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Chọn xe thanh toán";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.addBillPn;
            // 
            // problemPn
            // 
            this.problemPn.BorderRadius = 15;
            this.problemPn.Controls.Add(this.ProblemListView);
            this.problemPn.Location = new System.Drawing.Point(24, 240);
            this.problemPn.Name = "problemPn";
            this.problemPn.Size = new System.Drawing.Size(691, 143);
            this.problemPn.TabIndex = 4;
            this.problemPn.Text = "guna2ContainerControl2";
            // 
            // ProblemListView
            // 
            this.ProblemListView.AutoArrange = false;
            this.ProblemListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.problemName,
            this.fee});
            this.ProblemListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemListView.FullRowSelect = true;
            this.ProblemListView.HideSelection = false;
            this.ProblemListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.ProblemListView.Location = new System.Drawing.Point(12, 8);
            this.ProblemListView.Name = "ProblemListView";
            this.ProblemListView.Size = new System.Drawing.Size(661, 114);
            this.ProblemListView.TabIndex = 7;
            this.ProblemListView.UseCompatibleStateImageBehavior = false;
            this.ProblemListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // problemName
            // 
            this.problemName.Text = "Tên dịch vụ";
            this.problemName.Width = 322;
            // 
            // fee
            // 
            this.fee.Text = "Chi phí (VND)";
            this.fee.Width = 143;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 15;
            this.gunaElipse4.TargetControl = this.problemPn;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CheckoutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.problemPn);
            this.Controls.Add(this.addBillPn);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.totalPanel);
            this.Name = "CheckoutForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CheckoutForm_VisibleChanged);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addBillPn.ResumeLayout(false);
            this.addBillPn.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.problemPn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI2.WinForms.Guna2Panel totalPanel;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalRepairCostLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCostOfSquarePartLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI2.WinForms.Guna2ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GradientButton submitBtn;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.ListView orderDetailListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kitName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quanity;
        private Guna.UI2.WinForms.Guna2Panel addBillPn;
        private Guna.UI2.WinForms.Guna2ContainerControl problemPn;
        private System.Windows.Forms.ListView ProblemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader problemName;
        private System.Windows.Forms.ColumnHeader fee;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox carComboBox;
        private Guna.UI2.WinForms.Guna2Panel customerPanel;
        private System.Windows.Forms.Label receivedDayLabel;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.Label carPlateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.CheckBox confirmCheckbox;
    }
}
