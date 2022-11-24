
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
            "Xider",
            "100W",
            "White",
            "200",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Insulation film",
            "Llumar",
            "X15",
            "",
            "450",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Disk brake",
            "Michelin",
            "5kg",
            "Red",
            "150",
            "1"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.addBillPn = new Guna.UI2.WinForms.Guna2Panel();
            this.receiptInfo1 = new GarageManagement.User_Control.ReceiptInfo();
            this.orderDetailLv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quanity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.totalPn = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.addBillPn.SuspendLayout();
            this.totalPn.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBillPn
            // 
            this.addBillPn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBillPn.BorderRadius = 15;
            this.addBillPn.Controls.Add(this.receiptInfo1);
            this.addBillPn.Location = new System.Drawing.Point(617, 43);
            this.addBillPn.Name = "addBillPn";
            this.addBillPn.Size = new System.Drawing.Size(391, 539);
            this.addBillPn.TabIndex = 0;
            // 
            // receiptInfo1
            // 
            this.receiptInfo1.BackColor = System.Drawing.Color.White;
            this.receiptInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptInfo1.Location = new System.Drawing.Point(0, 0);
            this.receiptInfo1.Name = "receiptInfo1";
            this.receiptInfo1.Size = new System.Drawing.Size(391, 539);
            this.receiptInfo1.TabIndex = 0;
            // 
            // orderDetailLv
            // 
            this.orderDetailLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDetailLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kitName,
            this.brand,
            this.type,
            this.color,
            this.price,
            this.quanity});
            this.orderDetailLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailLv.FullRowSelect = true;
            this.orderDetailLv.HideSelection = false;
            this.orderDetailLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.orderDetailLv.Location = new System.Drawing.Point(51, 43);
            this.orderDetailLv.Name = "orderDetailLv";
            this.orderDetailLv.Size = new System.Drawing.Size(519, 307);
            this.orderDetailLv.TabIndex = 1;
            this.orderDetailLv.UseCompatibleStateImageBehavior = false;
            this.orderDetailLv.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 49;
            // 
            // kitName
            // 
            this.kitName.Text = "Kit name";
            this.kitName.Width = 110;
            // 
            // brand
            // 
            this.brand.Text = "Brand";
            this.brand.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 100;
            // 
            // color
            // 
            this.color.Text = "Color";
            this.color.Width = 70;
            // 
            // price
            // 
            this.price.Text = "Price($)";
            this.price.Width = 100;
            // 
            // quanity
            // 
            this.quanity.Text = "Quanity";
            this.quanity.Width = 100;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.orderDetailLv;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.addBillPn;
            // 
            // totalPn
            // 
            this.totalPn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPn.BorderRadius = 15;
            this.totalPn.Controls.Add(this.guna2GradientButton1);
            this.totalPn.Controls.Add(this.guna2ComboBox1);
            this.totalPn.Controls.Add(this.label12);
            this.totalPn.Controls.Add(this.guna2ComboBox2);
            this.totalPn.Controls.Add(this.label10);
            this.totalPn.Controls.Add(this.label8);
            this.totalPn.Controls.Add(this.label9);
            this.totalPn.Controls.Add(this.gunaLinePanel1);
            this.totalPn.Controls.Add(this.label6);
            this.totalPn.Controls.Add(this.label7);
            this.totalPn.Controls.Add(this.label5);
            this.totalPn.Controls.Add(this.label1);
            this.totalPn.Controls.Add(this.label4);
            this.totalPn.Controls.Add(this.label3);
            this.totalPn.Controls.Add(this.label11);
            this.totalPn.Controls.Add(this.label2);
            this.totalPn.Location = new System.Drawing.Point(51, 378);
            this.totalPn.Name = "totalPn";
            this.totalPn.Size = new System.Drawing.Size(519, 204);
            this.totalPn.TabIndex = 1;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkOrange;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(262, 140);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(240, 1);
            this.gunaLinePanel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 36);
            this.label6.TabIndex = 28;
            this.label6.Text = "$1720";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "10.00%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "TOTAL:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "$200";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "TAX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "FIX FEE:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(392, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "$1500";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "TOTAL KITS:";
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 15;
            this.gunaElipse3.TargetControl = this.totalPn;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "$15";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "DELIVERY FEE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Delivery: ";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ComboBox2.BorderRadius = 15;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 20;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "None",
            "To your address"});
            this.guna2ComboBox2.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox2.Location = new System.Drawing.Point(17, 40);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(218, 26);
            this.guna2ComboBox2.TabIndex = 33;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 20;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "On cash",
            "PayPal",
            "Apple Pay",
            "Google Pay",
            "Visa"});
            this.guna2ComboBox1.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.Location = new System.Drawing.Point(17, 101);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(218, 26);
            this.guna2ComboBox1.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Purchase method:";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(17, 148);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(218, 30);
            this.guna2GradientButton1.TabIndex = 36;
            this.guna2GradientButton1.Text = "Checkout";
            // 
            // CheckoutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.totalPn);
            this.Controls.Add(this.orderDetailLv);
            this.Controls.Add(this.addBillPn);
            this.Name = "CheckoutForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.addBillPn.ResumeLayout(false);
            this.totalPn.ResumeLayout(false);
            this.totalPn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel addBillPn;
        private System.Windows.Forms.ListView orderDetailLv;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI2.WinForms.Guna2Panel totalPn;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private ReceiptInfo receiptInfo1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kitName;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quanity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}
