
namespace GarageManagement.User_Control
{
    partial class AllList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllList));
            this.carLv = new System.Windows.Forms.ListView();
            this.title = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.searchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.viewDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carLv
            // 
            this.carLv.AutoArrange = false;
            this.carLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLv.FullRowSelect = true;
            this.carLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.carLv.HideSelection = false;
            this.carLv.Location = new System.Drawing.Point(0, 0);
            this.carLv.MultiSelect = false;
            this.carLv.Name = "carLv";
            this.carLv.Size = new System.Drawing.Size(1000, 286);
            this.carLv.TabIndex = 10;
            this.carLv.UseCompatibleStateImageBehavior = false;
            this.carLv.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(28, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(63, 23);
            this.title.TabIndex = 9;
            this.title.Text = "Tất cả";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.carLv;
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
            this.searchTb.Location = new System.Drawing.Point(747, 11);
            this.searchTb.Name = "searchTb";
            this.searchTb.PasswordChar = '\0';
            this.searchTb.PlaceholderText = "Gõ từ khóa cần tìm";
            this.searchTb.SelectedText = "";
            this.searchTb.Size = new System.Drawing.Size(285, 35);
            this.searchTb.TabIndex = 11;
            this.searchTb.TextOffset = new System.Drawing.Point(5, 0);
            this.searchTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTb_KeyPress);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.carLv);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(32, 58);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1000, 286);
            this.guna2ContainerControl1.TabIndex = 12;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // viewDetail
            // 
            this.viewDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetail.Location = new System.Drawing.Point(638, 19);
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.Size = new System.Drawing.Size(128, 20);
            this.viewDetail.TabIndex = 22;
            this.viewDetail.Text = "Xem chi tiết xe";
            this.viewDetail.Click += new System.EventHandler(this.viewDetail_Click);
            this.viewDetail.MouseLeave += new System.EventHandler(this.viewDetail_MouseLeave);
            this.viewDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewDetail_MouseMove);
            // 
            // AllList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.viewDetail);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.title);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "AllList";
            this.Size = new System.Drawing.Size(1069, 387);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carLv;
        private System.Windows.Forms.Label title;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2TextBox searchTb;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewDetail;
    }
}
