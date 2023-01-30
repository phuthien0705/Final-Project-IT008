
namespace GarageManagement.User_Control
{
    partial class CompletedList
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
            this.backToAllBtn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.completedLv = new System.Windows.Forms.ListView();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.viewDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToAllBtn
            // 
            this.backToAllBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAllBtn.Location = new System.Drawing.Point(168, 23);
            this.backToAllBtn.Name = "backToAllBtn";
            this.backToAllBtn.Size = new System.Drawing.Size(106, 23);
            this.backToAllBtn.TabIndex = 19;
            this.backToAllBtn.Text = "Quay lại";
            this.backToAllBtn.Click += new System.EventHandler(this.backToAllBtn_Click);
            this.backToAllBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backToAllBtn_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Đã hoàn thành |";
            // 
            // completedLv
            // 
            this.completedLv.AutoArrange = false;
            this.completedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.completedLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedLv.FullRowSelect = true;
            this.completedLv.HideSelection = false;
            this.completedLv.Location = new System.Drawing.Point(3, 3);
            this.completedLv.Name = "completedLv";
            this.completedLv.Size = new System.Drawing.Size(994, 290);
            this.completedLv.TabIndex = 6;
            this.completedLv.UseCompatibleStateImageBehavior = false;
            this.completedLv.View = System.Windows.Forms.View.Details;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.completedLv);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(32, 58);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1000, 296);
            this.guna2ContainerControl1.TabIndex = 20;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // viewDetail
            // 
            this.viewDetail.BackColor = System.Drawing.Color.Transparent;
            this.viewDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetail.Location = new System.Drawing.Point(901, 26);
            this.viewDetail.Name = "viewDetail";
            this.viewDetail.Size = new System.Drawing.Size(128, 20);
            this.viewDetail.TabIndex = 21;
            this.viewDetail.Text = "Xem chi tiết xe";
            this.viewDetail.Click += new System.EventHandler(this.viewDetail_Click);
            this.viewDetail.MouseLeave += new System.EventHandler(this.viewDetail_MouseLeave);
            this.viewDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewDetail_MouseMove);
            // 
            // CompletedList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.viewDetail);
            this.Controls.Add(this.backToAllBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "CompletedList";
            this.Size = new System.Drawing.Size(1069, 387);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backToAllBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView completedLv;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewDetail;
    }
}
