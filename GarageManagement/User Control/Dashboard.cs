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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void viewOrdered_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OrderList orderList = new OrderList(this);
            panel1.Controls.Add(orderList);
            orderList.Dock = DockStyle.Fill;
        }

        private void viewOrdered_MouseMove(object sender, MouseEventArgs e)
        {
            viewOrdered.Font = new Font(viewOrdered.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void viewOrdered_MouseLeave(object sender, EventArgs e)
        {
            viewOrdered.Font = new Font(viewOrdered.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void viewInProgress_MouseLeave(object sender, EventArgs e)
        {
            viewInProgress.Font = new Font(viewInProgress.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void viewInProgress_MouseMove(object sender, MouseEventArgs e)
        {
            viewInProgress.Font = new Font(viewInProgress.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void viewInProgress_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InProgressList inProgressList = new InProgressList(this);
            panel1.Controls.Add(inProgressList);
            inProgressList.Dock = DockStyle.Fill;
        }
    }
}
