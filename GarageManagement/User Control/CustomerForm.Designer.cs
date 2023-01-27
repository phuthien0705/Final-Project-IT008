
namespace GarageManagement.User_Control
{
    partial class CustomerForm
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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Flat tires",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Broken windows",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Punctured tires",
            "10"}, -1);
            this.fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fee
            // 
            this.fee.Text = "Fee($)";
            this.fee.Width = 143;
            // 
            // problemName
            // 
            this.problemName.Text = "Problem";
            this.problemName.Width = 213;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.problemName,
            this.fee});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(3, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(598, 335);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.listView1);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(410, 127);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(604, 362);
            this.guna2ContainerControl1.TabIndex = 64;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Số điện thoại";
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2TextBox6.BorderRadius = 15;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox6.Location = new System.Drawing.Point(50, 400);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "Type for customer phone number";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(295, 31);
            this.guna2TextBox6.TabIndex = 60;
            this.guna2TextBox6.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Địa chỉ";
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2TextBox5.BorderRadius = 15;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox5.Location = new System.Drawing.Point(50, 309);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "Type for customer address";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(295, 31);
            this.guna2TextBox5.TabIndex = 58;
            this.guna2TextBox5.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(-91, 544);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(204, 206);
            this.guna2GradientCircleButton2.TabIndex = 57;
            // 
            // guna2GradientCircleButton3
            // 
            this.guna2GradientCircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton3.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2GradientCircleButton3.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2GradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(981, 544);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(148, 148);
            this.guna2GradientCircleButton3.TabIndex = 56;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(1011, -73);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2GradientCircleButton1.TabIndex = 55;
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
            this.guna2GradientButton1.Location = new System.Drawing.Point(96, 459);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(203, 30);
            this.guna2GradientButton1.TabIndex = 54;
            this.guna2GradientButton1.Text = "Thêm khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Danh sách khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Họ và tên";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2TextBox3.BorderRadius = 15;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox3.Location = new System.Drawing.Point(50, 127);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Type for customer name";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(295, 31);
            this.guna2TextBox3.TabIndex = 48;
            this.guna2TextBox3.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(311, 36);
            this.label15.TabIndex = 47;
            this.label15.Text = "Thêm khách hàng";
            this.label15.Click += new System.EventHandler(this.label15_Click);
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
            this.guna2ComboBox2.ItemHeight = 25;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.guna2ComboBox2.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox2.Location = new System.Drawing.Point(50, 218);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(295, 31);
            this.guna2ComboBox2.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Giới tính";
            // 
            // CustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.label15);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader fee;
        private System.Windows.Forms.ColumnHeader problemName;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label1;
    }
}
