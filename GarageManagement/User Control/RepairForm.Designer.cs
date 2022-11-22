
namespace GarageManagement.User_Control
{
    partial class RepairForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Exhaust"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "DanX"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "10cm X 10cm", System.Drawing.SystemColors.HotTrack, System.Drawing.SystemColors.Window, new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Gold"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1200")}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Tire",
            "Pirelli",
            "17\"",
            "Carbon Black",
            "200"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Exhaust"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "DanX"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "10cm X 10cm", System.Drawing.SystemColors.HotTrack, System.Drawing.SystemColors.Window, new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Gold"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1200")}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Tire",
            "Pirelli",
            "17\"",
            "Carbon Black",
            "200"}, -1);
            this.label15 = new System.Windows.Forms.Label();
            this.kitAvailableLv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kit_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.kitChoosenLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carCbb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 37);
            this.label15.TabIndex = 11;
            this.label15.Text = "Repair";
            // 
            // kitAvailableLv
            // 
            this.kitAvailableLv.AutoArrange = false;
            this.kitAvailableLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitAvailableLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kit_name,
            this.brand,
            this.type,
            this.color,
            this.price});
            this.kitAvailableLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitAvailableLv.FullRowSelect = true;
            this.kitAvailableLv.HideSelection = false;
            this.kitAvailableLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.kitAvailableLv.Location = new System.Drawing.Point(29, 112);
            this.kitAvailableLv.Name = "kitAvailableLv";
            this.kitAvailableLv.Size = new System.Drawing.Size(1000, 215);
            this.kitAvailableLv.TabIndex = 12;
            this.kitAvailableLv.UseCompatibleStateImageBehavior = false;
            this.kitAvailableLv.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // kit_name
            // 
            this.kit_name.Text = "Name";
            this.kit_name.Width = 150;
            // 
            // brand
            // 
            this.brand.Text = "Brand";
            this.brand.Width = 150;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 192;
            // 
            // color
            // 
            this.color.Text = "Color";
            this.color.Width = 170;
            // 
            // price
            // 
            this.price.Text = "Price($)";
            this.price.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(791, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose the quanity:";
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
            this.guna2TextBox3.Enabled = false;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox3.Location = new System.Drawing.Point(944, 346);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox3.MaxLength = 50;
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Number";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(85, 25);
            this.guna2TextBox3.TabIndex = 14;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.kitAvailableLv;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.kitChoosenLv;
            // 
            // kitChoosenLv
            // 
            this.kitChoosenLv.AutoArrange = false;
            this.kitChoosenLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitChoosenLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.kitChoosenLv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitChoosenLv.FullRowSelect = true;
            this.kitChoosenLv.HideSelection = false;
            this.kitChoosenLv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.kitChoosenLv.Location = new System.Drawing.Point(29, 385);
            this.kitChoosenLv.Name = "kitChoosenLv";
            this.kitChoosenLv.Size = new System.Drawing.Size(1000, 215);
            this.kitChoosenLv.TabIndex = 12;
            this.kitChoosenLv.UseCompatibleStateImageBehavior = false;
            this.kitChoosenLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 192;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Color";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price($)";
            this.columnHeader6.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kits available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kits choosen for car";
            // 
            // carCbb
            // 
            this.carCbb.BackColor = System.Drawing.Color.Transparent;
            this.carCbb.BorderColor = System.Drawing.Color.DarkOrange;
            this.carCbb.BorderRadius = 15;
            this.carCbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carCbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carCbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carCbb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carCbb.ItemHeight = 30;
            this.carCbb.Items.AddRange(new object[] {
            "99A-561.29 | Kia Morning",
            "75A-023.41 | Roll-royce",
            "44A-586.12 | Mercedes-Benz"});
            this.carCbb.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCbb.Location = new System.Drawing.Point(749, 62);
            this.carCbb.Name = "carCbb";
            this.carCbb.Size = new System.Drawing.Size(280, 36);
            this.carCbb.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose the car:";
            // 
            // RepairForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carCbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.kitChoosenLv);
            this.Controls.Add(this.kitAvailableLv);
            this.Controls.Add(this.label15);
            this.Name = "RepairForm";
            this.Size = new System.Drawing.Size(1069, 622);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView kitAvailableLv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kit_name;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox carCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.ListView kitChoosenLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
