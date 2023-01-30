
namespace GarageManagement.User_Control
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.carLv = new System.Windows.Forms.ListView();
            this.searchKeyword = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.viewDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.backToAllBtn = new System.Windows.Forms.Label();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carLv
            // 
            this.carLv.AutoArrange = false;
            this.carLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLv.FullRowSelect = true;
            this.carLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.carLv.HideSelection = false;
            this.carLv.Location = new System.Drawing.Point(3, 3);
            this.carLv.Name = "carLv";
            this.carLv.Size = new System.Drawing.Size(994, 283);
            this.carLv.TabIndex = 10;
            this.carLv.UseCompatibleStateImageBehavior = false;
            this.carLv.View = System.Windows.Forms.View.Details;
            // 
            // searchKeyword
            // 
            this.searchKeyword.AutoSize = true;
            this.searchKeyword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeyword.Location = new System.Drawing.Point(32, 39);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(211, 23);
            this.searchKeyword.TabIndex = 23;
            this.searchKeyword.Text = "Kết quả tìm kiếm cho";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.carLv;
            // 
            // viewDetail
            // 
            this.viewDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetail.Location = new System.Drawing.Point(642, 35);
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.Size = new System.Drawing.Size(128, 20);
            this.viewDetail.TabIndex = 26;
            this.viewDetail.Text = "Xem chi tiết xe";
            // 
            // searchTb
            // 
            this.searchTb.BorderColor = System.Drawing.Color.DarkOrange;
            this.searchTb.BorderRadius = 15;
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.DefaultText = "";
            this.searchTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTb.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTb.IconLeft")));
            this.searchTb.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.searchTb.IconLeftSize = new System.Drawing.Size(15, 15);
            this.searchTb.Location = new System.Drawing.Point(751, 27);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "Search for all";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(285, 35);
            this.searchTb.TabIndex = 24;
            this.searchTb.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.carLv);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(36, 74);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1000, 286);
            this.guna2ContainerControl1.TabIndex = 25;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // backToAllBtn
            // 
            this.backToAllBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAllBtn.Location = new System.Drawing.Point(249, 41);
            this.backToAllBtn.Name = "backToAllBtn";
            this.backToAllBtn.Size = new System.Drawing.Size(106, 23);
            this.backToAllBtn.TabIndex = 27;
            this.backToAllBtn.Text = "Quay lại";
            this.backToAllBtn.Click += new System.EventHandler(this.backToAllBtn_Click);
            this.backToAllBtn.MouseLeave += new System.EventHandler(this.backToAllBtn_MouseLeave);
            this.backToAllBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backToAllBtn_MouseMove);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backToAllBtn);
            this.Controls.Add(this.searchKeyword);
            this.Controls.Add(this.viewDetail);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(1069, 387);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carLv;
        private System.Windows.Forms.Label searchKeyword;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewDetail;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label backToAllBtn;
    }
}
