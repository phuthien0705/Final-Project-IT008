
namespace GarageManagement
{
    partial class CustomerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetail));
            this.label11 = new System.Windows.Forms.Label();
            this.genderCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.carImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label12 = new System.Windows.Forms.Label();
            this.createdTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 78;
            this.label11.Text = "Số điện thoại";
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
            this.genderCb.Location = new System.Drawing.Point(27, 149);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(97, 31);
            this.genderCb.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 23);
            this.label8.TabIndex = 76;
            this.label8.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 75;
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
            this.addressTb.Location = new System.Drawing.Point(27, 226);
            this.addressTb.Margin = new System.Windows.Forms.Padding(4);
            this.addressTb.Name = "addressTb";
            this.addressTb.PasswordChar = '\0';
            this.addressTb.PlaceholderText = "Type for customer phone number";
            this.addressTb.SelectedText = "";
            this.addressTb.Size = new System.Drawing.Size(295, 31);
            this.addressTb.TabIndex = 74;
            this.addressTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 73;
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
            this.phoneNumberTb.Location = new System.Drawing.Point(145, 150);
            this.phoneNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.PasswordChar = '\0';
            this.phoneNumberTb.PlaceholderText = "Type for customer address";
            this.phoneNumberTb.SelectedText = "";
            this.phoneNumberTb.Size = new System.Drawing.Size(177, 31);
            this.phoneNumberTb.TabIndex = 72;
            this.phoneNumberTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "Họ và tên";
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
            this.nameTb.Location = new System.Drawing.Point(27, 72);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4);
            this.nameTb.Name = "nameTb";
            this.nameTb.PasswordChar = '\0';
            this.nameTb.PlaceholderText = "Type for customer name";
            this.nameTb.SelectedText = "";
            this.nameTb.Size = new System.Drawing.Size(295, 31);
            this.nameTb.TabIndex = 70;
            this.nameTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Location = new System.Drawing.Point(451, 252);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(71, 23);
            this.chooseImgBtn.TabIndex = 80;
            this.chooseImgBtn.Text = "Tải ảnh lên";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            // 
            // carImg
            // 
            this.carImg.Image = ((System.Drawing.Image)(resources.GetObject("carImg.Image")));
            this.carImg.ImageRotate = 0F;
            this.carImg.Location = new System.Drawing.Point(406, 72);
            this.carImg.Name = "carImg";
            this.carImg.Size = new System.Drawing.Size(160, 160);
            this.carImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImg.TabIndex = 79;
            this.carImg.TabStop = false;
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
            this.updateBtn.Location = new System.Drawing.Point(489, 303);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 30);
            this.updateBtn.TabIndex = 81;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(373, 303);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 30);
            this.deleteBtn.TabIndex = 82;
            this.deleteBtn.Text = "Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 84;
            this.label12.Text = "Thời gian đăng ký";
            // 
            // createdTb
            // 
            this.createdTb.BorderColor = System.Drawing.SystemColors.Desktop;
            this.createdTb.BorderRadius = 15;
            this.createdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createdTb.DefaultText = "";
            this.createdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createdTb.Enabled = false;
            this.createdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createdTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.createdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createdTb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.createdTb.Location = new System.Drawing.Point(27, 303);
            this.createdTb.Margin = new System.Windows.Forms.Padding(4);
            this.createdTb.Name = "createdTb";
            this.createdTb.PasswordChar = '\0';
            this.createdTb.PlaceholderText = "Type for customer phone number";
            this.createdTb.SelectedText = "";
            this.createdTb.Size = new System.Drawing.Size(295, 31);
            this.createdTb.TabIndex = 83;
            this.createdTb.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // CustomerDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.createdTb);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.carImg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumberTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTb);
            this.Name = "CustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDetail";
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox genderCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox addressTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox nameTb;
        private System.Windows.Forms.Button chooseImgBtn;
        private Guna.UI2.WinForms.Guna2PictureBox carImg;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox createdTb;
    }
}