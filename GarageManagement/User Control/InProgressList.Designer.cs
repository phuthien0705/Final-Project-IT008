
namespace GarageManagement.User_Control
{
    partial class InProgressList
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
            this.label15 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.backToAllBtn = new System.Windows.Forms.Label();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.inProgressLv = new System.Windows.Forms.ListView();
            this.viewDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 23);
            this.label15.TabIndex = 7;
            this.label15.Text = "Đang sửa |";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // backToAllBtn
            // 
            this.backToAllBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAllBtn.Location = new System.Drawing.Point(121, 32);
            this.backToAllBtn.Name = "backToAllBtn";
            this.backToAllBtn.Size = new System.Drawing.Size(106, 23);
            this.backToAllBtn.TabIndex = 15;
            this.backToAllBtn.Text = "Tất cả";
            this.backToAllBtn.Click += new System.EventHandler(this.backToAllBtn_Click);
            this.backToAllBtn.MouseLeave += new System.EventHandler(this.backToAllBtn_MouseLeave);
            this.backToAllBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backToAllBtn_MouseMove);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.inProgressLv);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(32, 58);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1000, 296);
            this.guna2ContainerControl1.TabIndex = 16;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // inProgressLv
            // 
            this.inProgressLv.AutoArrange = false;
            this.inProgressLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inProgressLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressLv.FullRowSelect = true;
            this.inProgressLv.HideSelection = false;
            this.inProgressLv.Location = new System.Drawing.Point(3, 0);
            this.inProgressLv.Name = "inProgressLv";
            this.inProgressLv.Size = new System.Drawing.Size(994, 293);
            this.inProgressLv.TabIndex = 6;
            this.inProgressLv.UseCompatibleStateImageBehavior = false;
            this.inProgressLv.View = System.Windows.Forms.View.Details;
            // 
            // viewDetail
            // 
            this.viewDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetail.Location = new System.Drawing.Point(901, 33);
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.Size = new System.Drawing.Size(128, 20);
            this.viewDetail.TabIndex = 22;
            this.viewDetail.Text = "Xem chi tiết xe";
            this.viewDetail.Click += new System.EventHandler(this.viewDetail_Click);
            this.viewDetail.MouseLeave += new System.EventHandler(this.viewDetail_MouseLeave);
            this.viewDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewDetail_MouseMove);
            // 
            // InProgressList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.viewDetail);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.backToAllBtn);
            this.Controls.Add(this.label15);
            this.Name = "InProgressList";
            this.Size = new System.Drawing.Size(1069, 387);
            this.Click += new System.EventHandler(this.viewDetail_Click);
            this.MouseLeave += new System.EventHandler(this.viewDetail_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewDetail_MouseMove);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label backToAllBtn;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.ListView inProgressLv;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewDetail;
    }
}
