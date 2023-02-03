
namespace GarageManagement.User_Control
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label15 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.viewCompleted = new System.Windows.Forms.Label();
            this.completedQuantityLb = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.viewInProgress = new System.Windows.Forms.Label();
            this.inProgressQuantityLb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.viewOrdered = new System.Windows.Forms.Label();
            this.orderedQuantityLb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.revenueLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allList1 = new GarageManagement.User_Control.AllList();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gunaGradient2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gunaGradient2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 36);
            this.label15.TabIndex = 9;
            this.label15.Text = "Trang chủ";
            // 
            // gunaGradient2Panel4
            // 
            this.gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel4.Controls.Add(this.pictureBox6);
            this.gunaGradient2Panel4.Controls.Add(this.viewCompleted);
            this.gunaGradient2Panel4.Controls.Add(this.completedQuantityLb);
            this.gunaGradient2Panel4.Controls.Add(this.label17);
            this.gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.DeepPink;
            this.gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.Crimson;
            this.gunaGradient2Panel4.Location = new System.Drawing.Point(800, 69);
            this.gunaGradient2Panel4.Name = "gunaGradient2Panel4";
            this.gunaGradient2Panel4.Radius = 20;
            this.gunaGradient2Panel4.Size = new System.Drawing.Size(225, 143);
            this.gunaGradient2Panel4.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(161, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // viewCompleted
            // 
            this.viewCompleted.AutoSize = true;
            this.viewCompleted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompleted.ForeColor = System.Drawing.SystemColors.Window;
            this.viewCompleted.Location = new System.Drawing.Point(17, 106);
            this.viewCompleted.Name = "viewCompleted";
            this.viewCompleted.Size = new System.Drawing.Size(120, 23);
            this.viewCompleted.TabIndex = 2;
            this.viewCompleted.Text = "Xem chi tiết";
            this.viewCompleted.Click += new System.EventHandler(this.viewCompleted_Click);
            this.viewCompleted.MouseLeave += new System.EventHandler(this.viewCompleted_MouseLeave);
            this.viewCompleted.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewCompleted_MouseMove);
            // 
            // completedQuantityLb
            // 
            this.completedQuantityLb.AutoSize = true;
            this.completedQuantityLb.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedQuantityLb.ForeColor = System.Drawing.Color.White;
            this.completedQuantityLb.Location = new System.Drawing.Point(11, 47);
            this.completedQuantityLb.Name = "completedQuantityLb";
            this.completedQuantityLb.Size = new System.Drawing.Size(81, 59);
            this.completedQuantityLb.TabIndex = 1;
            this.completedQuantityLb.Text = "30";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "Đã hoàn thành";
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.pictureBox5);
            this.gunaGradient2Panel3.Controls.Add(this.viewInProgress);
            this.gunaGradient2Panel3.Controls.Add(this.inProgressQuantityLb);
            this.gunaGradient2Panel3.Controls.Add(this.label13);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.LimeGreen;
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.Gold;
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(543, 69);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Radius = 20;
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(225, 143);
            this.gunaGradient2Panel3.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(120, -24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 127);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // viewInProgress
            // 
            this.viewInProgress.AutoSize = true;
            this.viewInProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInProgress.ForeColor = System.Drawing.SystemColors.Window;
            this.viewInProgress.Location = new System.Drawing.Point(17, 106);
            this.viewInProgress.Name = "viewInProgress";
            this.viewInProgress.Size = new System.Drawing.Size(120, 23);
            this.viewInProgress.TabIndex = 2;
            this.viewInProgress.Text = "Xem chi tiết";
            this.viewInProgress.Click += new System.EventHandler(this.viewInProgress_Click);
            this.viewInProgress.MouseLeave += new System.EventHandler(this.viewInProgress_MouseLeave);
            this.viewInProgress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewInProgress_MouseMove);
            // 
            // inProgressQuantityLb
            // 
            this.inProgressQuantityLb.AutoSize = true;
            this.inProgressQuantityLb.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressQuantityLb.ForeColor = System.Drawing.Color.White;
            this.inProgressQuantityLb.Location = new System.Drawing.Point(7, 47);
            this.inProgressQuantityLb.Name = "inProgressQuantityLb";
            this.inProgressQuantityLb.Size = new System.Drawing.Size(81, 59);
            this.inProgressQuantityLb.TabIndex = 1;
            this.inProgressQuantityLb.Text = "15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Đang sửa";
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.pictureBox4);
            this.gunaGradient2Panel2.Controls.Add(this.viewOrdered);
            this.gunaGradient2Panel2.Controls.Add(this.orderedQuantityLb);
            this.gunaGradient2Panel2.Controls.Add(this.label10);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.DarkViolet;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(286, 69);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 20;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(225, 143);
            this.gunaGradient2Panel2.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(149, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // viewOrdered
            // 
            this.viewOrdered.AutoSize = true;
            this.viewOrdered.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdered.ForeColor = System.Drawing.SystemColors.Window;
            this.viewOrdered.Location = new System.Drawing.Point(17, 106);
            this.viewOrdered.Name = "viewOrdered";
            this.viewOrdered.Size = new System.Drawing.Size(120, 23);
            this.viewOrdered.TabIndex = 2;
            this.viewOrdered.Text = "Xem chi tiết";
            this.viewOrdered.Click += new System.EventHandler(this.viewOrdered_Click);
            this.viewOrdered.MouseLeave += new System.EventHandler(this.viewOrdered_MouseLeave);
            this.viewOrdered.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewOrdered_MouseMove);
            // 
            // orderedQuantityLb
            // 
            this.orderedQuantityLb.AutoSize = true;
            this.orderedQuantityLb.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedQuantityLb.ForeColor = System.Drawing.Color.White;
            this.orderedQuantityLb.Location = new System.Drawing.Point(7, 47);
            this.orderedQuantityLb.Name = "orderedQuantityLb";
            this.orderedQuantityLb.Size = new System.Drawing.Size(81, 59);
            this.orderedQuantityLb.TabIndex = 1;
            this.orderedQuantityLb.Text = "30";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đã tiếp nhận";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox3);
            this.gunaGradient2Panel1.Controls.Add(this.revenueLb);
            this.gunaGradient2Panel1.Controls.Add(this.label6);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.OrangeRed;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.DarkOrange;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(29, 69);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 20;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(225, 143);
            this.gunaGradient2Panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(151, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // revenueLb
            // 
            this.revenueLb.AutoSize = true;
            this.revenueLb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLb.ForeColor = System.Drawing.Color.White;
            this.revenueLb.Location = new System.Drawing.Point(10, 80);
            this.revenueLb.Name = "revenueLb";
            this.revenueLb.Size = new System.Drawing.Size(208, 40);
            this.revenueLb.TabIndex = 1;
            this.revenueLb.Text = "300.000.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allList1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 387);
            this.panel1.TabIndex = 10;
            // 
            // allList1
            // 
            this.allList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allList1.Location = new System.Drawing.Point(0, 0);
            this.allList1.Name = "allList1";
            this.allList1.Size = new System.Drawing.Size(1069, 387);
            this.allList1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "(đơn vị VND)";
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gunaGradient2Panel4);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1069, 622);
            this.gunaGradient2Panel4.ResumeLayout(false);
            this.gunaGradient2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.gunaGradient2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label viewCompleted;
        private System.Windows.Forms.Label completedQuantityLb;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label viewInProgress;
        private System.Windows.Forms.Label inProgressQuantityLb;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label viewOrdered;
        private System.Windows.Forms.Label orderedQuantityLb;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label revenueLb;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel1;
        private AllList allList1;
        private System.Windows.Forms.Label label1;
    }
}
