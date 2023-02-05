
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
            this.customerLv = new System.Windows.Forms.ListView();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxAdrdess = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.insertBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.genderCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCustomerDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerLv
            // 
            this.customerLv.AutoArrange = false;
            this.customerLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLv.FullRowSelect = true;
            this.customerLv.HideSelection = false;
            this.customerLv.Location = new System.Drawing.Point(3, 10);
            this.customerLv.Name = "customerLv";
            this.customerLv.Size = new System.Drawing.Size(598, 335);
            this.customerLv.TabIndex = 6;
            this.customerLv.UseCompatibleStateImageBehavior = false;
            this.customerLv.View = System.Windows.Forms.View.Details;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.BorderThickness = 1;
            this.guna2ContainerControl1.Controls.Add(this.customerLv);
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
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Số điện thoại";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.txtbxPhone.BorderRadius = 15;
            this.txtbxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPhone.DefaultText = "";
            this.txtbxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPhone.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbxPhone.Location = new System.Drawing.Point(50, 400);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.PasswordChar = '\0';
            this.txtbxPhone.PlaceholderText = "Type for customer phone number";
            this.txtbxPhone.SelectedText = "";
            this.txtbxPhone.Size = new System.Drawing.Size(295, 31);
            this.txtbxPhone.TabIndex = 60;
            this.txtbxPhone.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Địa chỉ";
            // 
            // txtbxAdrdess
            // 
            this.txtbxAdrdess.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.txtbxAdrdess.BorderRadius = 15;
            this.txtbxAdrdess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxAdrdess.DefaultText = "";
            this.txtbxAdrdess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxAdrdess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxAdrdess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxAdrdess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxAdrdess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxAdrdess.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAdrdess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbxAdrdess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxAdrdess.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbxAdrdess.Location = new System.Drawing.Point(50, 309);
            this.txtbxAdrdess.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxAdrdess.Name = "txtbxAdrdess";
            this.txtbxAdrdess.PasswordChar = '\0';
            this.txtbxAdrdess.PlaceholderText = "Type for customer address";
            this.txtbxAdrdess.SelectedText = "";
            this.txtbxAdrdess.Size = new System.Drawing.Size(295, 31);
            this.txtbxAdrdess.TabIndex = 58;
            this.txtbxAdrdess.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.RoyalBlue;
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
            this.guna2GradientCircleButton3.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientCircleButton3.FillColor2 = System.Drawing.Color.RoyalBlue;
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
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(1011, -73);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2GradientCircleButton1.TabIndex = 55;
            // 
            // insertBtn
            // 
            this.insertBtn.BorderRadius = 15;
            this.insertBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertBtn.FillColor = System.Drawing.Color.MediumTurquoise;
            this.insertBtn.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.insertBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(96, 459);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(203, 30);
            this.insertBtn.TabIndex = 54;
            this.insertBtn.Text = "Thêm khách hàng";
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Danh sách khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Họ và tên";
            // 
            // txtbxName
            // 
            this.txtbxName.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.txtbxName.BorderRadius = 15;
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.DefaultText = "";
            this.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbxName.Location = new System.Drawing.Point(50, 127);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderText = "Type for customer name";
            this.txtbxName.SelectedText = "";
            this.txtbxName.Size = new System.Drawing.Size(295, 31);
            this.txtbxName.TabIndex = 48;
            this.txtbxName.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 29);
            this.label15.TabIndex = 47;
            this.label15.Text = "Thêm khách hàng";
            // 
            // genderCb
            // 
            this.genderCb.BackColor = System.Drawing.Color.Transparent;
            this.genderCb.BorderColor = System.Drawing.Color.MediumTurquoise;
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
            this.genderCb.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.genderCb.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.genderCb.Location = new System.Drawing.Point(50, 218);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(295, 31);
            this.genderCb.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Giới tính";
            // 
            // viewCustomerDetail
            // 
            this.viewCustomerDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewCustomerDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerDetail.Location = new System.Drawing.Point(837, 100);
            this.viewCustomerDetail.Name = "viewCustomerDetail";
            this.viewCustomerDetail.Size = new System.Drawing.Size(177, 18);
            this.viewCustomerDetail.TabIndex = 76;
            this.viewCustomerDetail.Text = "Xem thông tin khách hàng";
            this.viewCustomerDetail.Click += new System.EventHandler(this.viewCustomerDetail_Click);
            this.viewCustomerDetail.MouseLeave += new System.EventHandler(this.viewCustomerDetail_MouseLeave);
            this.viewCustomerDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewCustomerDetail_MouseMove);
            // 
            // CustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.viewCustomerDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxAdrdess);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label15);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView customerLv;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPhone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtbxAdrdess;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientButton insertBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox genderCb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewCustomerDetail;
    }
}
