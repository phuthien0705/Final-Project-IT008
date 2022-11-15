using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarageManagement.User_Control
{
    public partial class InProgressList : UserControl
    {
        Dashboard db = new Dashboard();

        public InProgressList()
        {
            InitializeComponent();
        }

        public InProgressList(Dashboard db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void backToAllBtn_MouseMove(object sender, MouseEventArgs e)
        {
            backToAllBtn.Font = new Font(backToAllBtn.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void backToAllBtn_Click(object sender, EventArgs e)
        {
            db.panel1.Controls.Clear();
            AllList allList = new AllList();
            db.panel1.Controls.Add(allList);
            allList.Dock = DockStyle.Fill;
        }

        private void backToAllBtn_MouseLeave(object sender, EventArgs e)
        {
            backToAllBtn.Font = new Font(backToAllBtn.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }
    }
}
