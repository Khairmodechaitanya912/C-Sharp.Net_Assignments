using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class MDI_Employee_Details : Form
    {
        private int childFormNumber = 0;

        public MDI_Employee_Details()
        {
            InitializeComponent();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.MdiParent = this;

            ANE.WindowState = FormWindowState.Maximized;

            ANE.Show();

        }
    }
}
