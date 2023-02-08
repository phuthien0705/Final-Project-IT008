
namespace GarageManagement.User_Control
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.label15 = new System.Windows.Forms.Label();
            this.plateNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.customerLv = new System.Windows.Forms.ListView();
            this.brandCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.problemLv = new System.Windows.Forms.ListView();
            this.searchCustomerTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 29);
            this.label15.TabIndex = 10;
            this.label15.Text = "Thêm xe mới";
            // 
            // plateNumberTb
            // 
            this.plateNumberTb.BorderColor = System.Drawing.Color.DarkOrange;
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
            this.plateNumberTb.Location = new System.Drawing.Point(64, 118);
            this.plateNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.plateNumberTb.Name = "plateNumberTb";
            this.plateNumberTb.PasswordChar = '\0';
            this.plateNumberTb.PlaceholderText = "Type for plate number";
            this.plateNumberTb.SelectedText = "";
            this.plateNumberTb.Size = new System.Drawing.Size(353, 31);
            this.plateNumberTb.TabIndex = 12;
            this.plateNumberTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập biển số xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn hãng xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Chọn khách hàng";
            // 
            // addCarBtn
            // 
            this.addCarBtn.BorderRadius = 15;
            this.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCarBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.addCarBtn.FillColor2 = System.Drawing.Color.DarkOrange;
            this.addCarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.addCarBtn.ForeColor = System.Drawing.Color.White;
            this.addCarBtn.Location = new System.Drawing.Point(845, 535);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(132, 30);
            this.addCarBtn.TabIndex = 17;
            this.addCarBtn.Text = "Thêm xe";
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
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
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(1002, -82);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2GradientCircleButton1.TabIndex = 19;
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
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(992, 557);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(148, 148);
            this.guna2GradientCircleButton3.TabIndex = 19;
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
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(-100, 535);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(204, 206);
            this.guna2GradientCircleButton2.TabIndex = 19;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.customerLv);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(478, 118);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(499, 399);
            this.guna2ContainerControl1.TabIndex = 26;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // customerLv
            // 
            this.customerLv.AutoArrange = false;
            this.customerLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLv.FullRowSelect = true;
            this.customerLv.HideSelection = false;
            this.customerLv.Location = new System.Drawing.Point(5, 8);
            this.customerLv.MultiSelect = false;
            this.customerLv.Name = "customerLv";
            this.customerLv.Size = new System.Drawing.Size(490, 382);
            this.customerLv.TabIndex = 6;
            this.customerLv.UseCompatibleStateImageBehavior = false;
            this.customerLv.View = System.Windows.Forms.View.Details;
            // 
            // brandCb
            // 
            this.brandCb.BackColor = System.Drawing.Color.Transparent;
            this.brandCb.BorderColor = System.Drawing.Color.DarkOrange;
            this.brandCb.BorderRadius = 15;
            this.brandCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.brandCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandCb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.brandCb.ItemHeight = 25;
            this.brandCb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCb.Location = new System.Drawing.Point(64, 191);
            this.brandCb.Name = "brandCb";
            this.brandCb.Size = new System.Drawing.Size(353, 31);
            this.brandCb.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Chọn dịch vụ";
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ContainerControl2.BorderRadius = 15;
            this.guna2ContainerControl2.BorderThickness = 1;
            this.guna2ContainerControl2.Controls.Add(this.problemLv);
            this.guna2ContainerControl2.Location = new System.Drawing.Point(64, 280);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(353, 237);
            this.guna2ContainerControl2.TabIndex = 27;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // problemLv
            // 
            this.problemLv.AutoArrange = false;
            this.problemLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLv.FullRowSelect = true;
            this.problemLv.HideSelection = false;
            this.problemLv.Location = new System.Drawing.Point(3, 8);
            this.problemLv.Name = "problemLv";
            this.problemLv.Size = new System.Drawing.Size(347, 220);
            this.problemLv.TabIndex = 7;
            this.problemLv.UseCompatibleStateImageBehavior = false;
            this.problemLv.View = System.Windows.Forms.View.Details;
            // 
            // searchCustomerTb
            // 
            this.searchCustomerTb.BorderColor = System.Drawing.Color.DarkOrange;
            this.searchCustomerTb.BorderRadius = 15;
            this.searchCustomerTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCustomerTb.DefaultText = "";
            this.searchCustomerTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchCustomerTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchCustomerTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchCustomerTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchCustomerTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchCustomerTb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchCustomerTb.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchCustomerTb.IconLeft")));
            this.searchCustomerTb.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.searchCustomerTb.IconLeftSize = new System.Drawing.Size(15, 15);
            this.searchCustomerTb.Location = new System.Drawing.Point(781, 87);
            this.searchCustomerTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomerTb.Name = "searchCustomerTb";
            this.searchCustomerTb.PasswordChar = '\0';
            this.searchCustomerTb.PlaceholderText = "Tìm kiếm khách hàng";
            this.searchCustomerTb.SelectedText = "";
            this.searchCustomerTb.Size = new System.Drawing.Size(193, 25);
            this.searchCustomerTb.TabIndex = 48;
            this.searchCustomerTb.TextOffset = new System.Drawing.Point(5, 0);
            this.searchCustomerTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchCustomerTb_KeyPress);
            // 
            // CarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.searchCustomerTb);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brandCb);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plateNumberTb);
            this.Controls.Add(this.label15);
            this.Name = "CarForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CarForm_VisibleChanged);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox plateNumberTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton addCarBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.ListView customerLv;
        private Guna.UI2.WinForms.Guna2ComboBox brandCb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2TextBox searchCustomerTb;
        private System.Windows.Forms.ListView problemLv;
    }
}
